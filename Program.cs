using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NoteView
{
  internal static class Program
  {
    private static MySqlConnection conn;
    public static MySqlConnection Connection { set { conn = value; } }
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
    }
  }
}
