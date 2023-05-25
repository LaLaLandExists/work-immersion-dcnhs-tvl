using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NoteView
{
  internal class UnexpectedException : Exception
  {
    public UnexpectedException(string msg) : base(msg) { }
  }

  internal static class Program
  {
    // TODO defer this to Util
    public const int MinimumUsernameLength = 8;
    public const int MaximumUsernameLength = 35;

    public const int MinimumPasswordLength = 8;
    public const int MaximumPasswordLength = 16;

    public static readonly Regex unameRegex = new Regex("^[_a-zA-Z][\\._a-zA-Z0-9]*$");
    public static readonly Regex nameRegex = new Regex("^[a-zA-Z]+( [a-zA-Z]+)*$");

    public static Session session;

    public static string IsValidUname(string uname)
    {
      if (uname.Length < MinimumUsernameLength)
      {
        return "Username is too short";
      }
      if (uname.Length > MaximumUsernameLength)
      {
        return "Username is too long";
      }

      if (!unameRegex.IsMatch(uname))
      {
        return "Invalid username";
      }

      return null;
    }

    public static string IsValidPword(string pword)
    {
      if (pword.Length < MinimumPasswordLength)
      {
        return "Password is too short";
      }
      if (pword.Length > MaximumPasswordLength)
      {
        return "Password is too long";
      }

      return null;
    }

    public static void Assert(bool condition, string msg)
    {
      if (!condition) throw new UnexpectedException(msg);
    }

    public static void AssertUnreachable(string msg = "Code unreachable")
    {
      throw new UnexpectedException(msg);
    }
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      try
      {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        // TODO: Implement correct form flow
        Application.Run(new SetupDB());
        Application.Run(new UserLogin());
      }
      finally
      {
        Session.conn?.Close();
      }
    }
  }
}
