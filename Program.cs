﻿using System;
using System.Collections.Generic;
using System.Linq;
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

    private static MySqlConnection conn;
    public static MySqlConnection Connection { get { return conn; }  set { conn = value; } }
    private static Session session;
    public static Session Session { get { return session; }  set { session = value; } }
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      // TODO: skip this step if the user has already logged in to a database
      Application.Run(new UserLogin());
      Application.Run(new SetupDB());
    }
  }
}
