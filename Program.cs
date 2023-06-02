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
    public static Session session;

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
        Application.Run(new FrontDesk());
        // TODO: Implement correct form flow
        // Application.Run(new SetupDB());
        // if (Session.conn == null) return;
        // Application.Run(new UserLogin());
      }
      finally
      {
        Session.conn?.Close();
      }
    }
  }
}
