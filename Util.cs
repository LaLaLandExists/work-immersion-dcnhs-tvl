using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NoteView
{
  public class ValidationException : Exception
  {
    public ValidationException(string msg) : base(msg) { }
  }

  internal static class Util
  {
    public static bool HasEmpty(params string[] strs)
    {
      foreach (string str in strs)
      {
        if (str.Trim().Length == 0) return true;
      }
      return false;
    }
    public static void EmphasizeRequiredFields(params Label[] lbls)
    {
      foreach (Label lbl in lbls)
      {
        lbl.Text += "*";
        lbl.ForeColor = Color.Red;
      }
    }

    public static bool DBExists(this MySqlConnection conn, string dbName)
    {
      using (MySqlCommand cmd = conn.CreateCommand())
      {
        cmd.CommandText = $"SELECT DISTINCT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = '{dbName}';";
        using (MySqlDataReader rd = cmd.ExecuteReader())
        {
          return rd.HasRows;
        }
      }
    }

    public struct TableInfo
    {
      public string name, schema;

      public TableInfo(string name, string schema)
      {
        this.name = name;
        this.schema = schema;
      }
    }

    // README! Make sure the SQL schemas are in order
    public static readonly TableInfo[] tableOrder =
    {
      new TableInfo("UserInfo", Properties.Resources.user_info)
    };

  }
}
