using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NoteView
{
  internal static class Program
  {
    public const int MinimumUsernameLength = 8;
    public const int MaximumUsernameLength = 35;

    public const int MinimumPasswordLength = 8;
    public const int MaximumPasswordLength = 16;

    public static readonly Regex unameRegex = new Regex("^[_a-zA-Z][_a-zA-Z0-9]*$");

    public static Session session;

    public static bool IsValidUname(string uname)
    {
      return unameRegex.IsMatch(uname);
    }
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      // TODO: skip this step if the user has already logged in to a database
      Application.Run(new SetupDB());
      Application.Run(new UserLogin());
    }
  }
}
