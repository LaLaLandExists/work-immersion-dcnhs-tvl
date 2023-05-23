using MySql.Data.MySqlClient;
using System;

namespace NoteView
{
  internal class Session
  {
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
      "INSERT INTO UserInfo (userType, addedBy, firstName, lastName, userName, password) VALUES ('{0}', {1}, '{2}', '{3}', '{4}', '{5}');";

    // YASSIFICATION PROCESS PLS DONT TOUCH IT WILL BE HARD TO DEBUG
    private static void AssertConnection()
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

    private SeekResult AddNewAccount(bool adminMode, string uname, string password, string firstName, string lastName)
    {
      SeekResult? r = SeekAccount(uname);
      if (r != null) throw new InvalidOperationException($"User '{uname}' already exists");

      using (MySqlCommand cmd = conn.CreateCommand())
      {
        cmd.CommandText = string.Format(NewAccountSQL, adminMode ? AdminUType : UserUType, this.userId, firstName, lastName, uname, password);
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

    // Constructor when adding new account for authentication
    public Session RegisterAccount(bool IsAdmin, string username, string password, string firstName, string lastName)
    {
      SeekResult r = AddNewAccount(IsAdmin, username, password, firstName, lastName);
      return new Session(r.adminMode, r.id, r.uname, r.firstName, r.lastName);
    }

    // Constructor when authenticating to an existing account
    public static Session LoginAccount(string username, string password)
    {
      SeekResult r = SeekAccount(username, password) ?? throw new InvalidOperationException($"Account username or password is invalid");
      return new Session(r.adminMode, r.id, r.uname, r.firstName, r.lastName);
    }
  }
}
