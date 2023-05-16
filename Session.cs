using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteView
{
  internal class Session
  {
    public readonly bool authoritative;
    public readonly string username;
    public readonly string firstName;
    public readonly string lastName;
    public readonly int userId;

    public Session(bool authoritative, string username, string firstName, string lastName, int userId)
    {
      this.authoritative = authoritative;
      this.username = username;
      this.firstName = firstName;
      this.lastName = lastName;
      this.userId = userId;
    }
  }
}
