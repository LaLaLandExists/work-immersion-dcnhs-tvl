using MySql.Data.MySqlClient;
using System;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace NoteView
{
  internal class Session
  {
    public const int MinimumUsernameLength = 8;
    public const int MaximumUsernameLength = 35;

    public const int MinimumPasswordLength = 8;
    public const int MaximumPasswordLength = 16;

    public static readonly Regex unameRegex = new Regex("^[_a-zA-Z][\\._a-zA-Z0-9]*$");
    public static readonly Regex nameRegex = new Regex("^[a-zA-Z]+( [a-zA-Z]+)*$");

    public static MySqlConnection conn;
    public readonly bool adminMode;
    public readonly string username;
    public readonly string firstName;
    public readonly string lastName;
    public readonly int userId;

    public const string AdminUType = "ADMIN";
    public const string UserUType = "USER";

    private const string FetchAccountSQL =
      "SELECT * FROM UserInfo WHERE BINARY userName = '{0}';";
    private const string AuthAccountSQL =
      "SELECT * FROM UserInfo WHERE BINARY userName = '{0}' AND BINARY password = '{1}';";
    private const string NewAccountSQL =
      "INSERT INTO UserInfo (userType, firstName, lastName, userName, password) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');";

    public static void AssertConnection()
    {
      if (conn == null) throw new InvalidProgramException("An unexpected error occured. Pls contact the developer");
    }

    internal struct SeekResult
    {
      public readonly int id;
      public readonly bool adminMode;
      public readonly string uname;
      public readonly string pword;
      public readonly string firstName;
      public readonly string lastName;

      public SeekResult(int id, bool adminMode, string uname, string pword, string firstName, string lastName)
      {
        this.id = id;
        this.adminMode = adminMode;
        this.uname = uname;
        this.pword = pword;
        this.firstName = firstName;
        this.lastName = lastName;
      }
    }

    private static SeekResult? SeekAccount(string uname)
    {
      AssertConnection();
      using (MySqlCommand cmd = conn.CreateCommand())
      {
        cmd.CommandText = string.Format(FetchAccountSQL, uname);
        using (MySqlDataReader rd = cmd.ExecuteReader())
        {
          if (!rd.Read()) return null;

          return new SeekResult(
            rd.GetInt32("id"), rd.GetString("userType") == "ADMIN", uname, null, rd.GetString("firstName"), rd.GetString("lastName")
          );
        }
      }
    }

    private static SeekResult? SeekAccount(string uname, string password)
    {
      AssertConnection();
      using (MySqlCommand cmd = conn.CreateCommand())
      {
        cmd.CommandText = string.Format(AuthAccountSQL, uname, password);
        using (MySqlDataReader rd = cmd.ExecuteReader())
        {
          if (!rd.Read()) return null;

          return new SeekResult(
            rd.GetInt32("id"), rd.GetString("userType") == "ADMIN", uname, password, rd.GetString("firstName"), rd.GetString("lastName")
          );
        }
      }
    }

    private static SeekResult AddNewAccount(bool adminMode, string uname, string password, string firstName, string lastName)
    {
      SeekResult? r = SeekAccount(uname);
      if (r != null) throw new InvalidOperationException($"User '{uname}' already exists");

      using (MySqlCommand cmd = conn.CreateCommand())
      {
        cmd.CommandText = string.Format(NewAccountSQL, adminMode ? AdminUType : UserUType, firstName, lastName, uname, password);
        cmd.ExecuteNonQuery();

        cmd.CommandText = string.Format(FetchAccountSQL, uname);
        
        return (SeekResult) SeekAccount(uname);
      }
    }

    private Session(bool authoritative, int id, string username, string firstName, string lastName)
    {
      adminMode = authoritative;
      userId = id;
      this.username = username;
      this.firstName = firstName;
      this.lastName = lastName;
    }

    //FIXME! Defer validity here?
    private static void AssertValidity(string uname, string pword)
    {
      if (uname.Length < MinimumUsernameLength)
      {
        throw new ArgumentException("Username is too short");
      }

      if (uname.Length > MaximumUsernameLength)
      {
        throw new ArgumentException("Username is too long");
      }

      if (pword.Length < MinimumPasswordLength)
      {
        throw new ArgumentException("Password is too short");
      }

      if (pword.Length > MaximumPasswordLength)
      {
        throw new ArgumentException("Password is too long");
      }

      if (!unameRegex.IsMatch(uname))
      {
        throw new ArgumentException("Username has invalid character/s");
      }
    }

    private static void AssertValidity(string uname, string pword, string fname, string lname)
    {
      AssertValidity(uname, pword);

      if (!nameRegex.IsMatch(fname))
      {
        throw new ArgumentException("First name has invalid character/s");
      }

      if (!nameRegex.IsMatch(lname))
      {
        throw new ArgumentException("Last name has invalid character/s");
      }
    }

    // Constructor when adding new account for authentication
    public static Session RegisterAccount(bool isAdmin, string username, string password, string firstName, string lastName)
    {
      AssertValidity(username, password, firstName, lastName);
      SeekResult r = AddNewAccount(isAdmin, username, password, firstName, lastName);
      return new Session(r.adminMode, r.id, r.uname, r.firstName, r.lastName);
    }

    // Constructor when authenticating to an existing account
    public static Session LoginAccount(string username, string password)
    {
      AssertValidity(username, password);
      SeekResult r = SeekAccount(username, password) ?? throw new InvalidOperationException($"Account username or password is invalid");
      return new Session(r.adminMode, r.id, r.uname, r.firstName, r.lastName);
    }
  }
}
