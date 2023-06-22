using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resthome_Database
{
    internal static class User
    {
        internal  static string Username { get; set; }
        internal  static string  Password { get; set; }
        internal  static string FirstName { get; set; }
        internal  static string LastName { get; set; }
        internal  static int Id { get; set; }
        internal  static int Age { get; set; }
        internal static bool IsAdmin { get; set; } = false;
        internal enum UserType {Visitor, Employee, none}
        internal static UserType UType { get; set; } = UserType.none;
        internal static bool login (string Username, string Password)
        {
            Klassen.Datenbank datenbank = new Klassen.Datenbank();
            DataTable data = datenbank.GetData($"Select * from Personal where Username = '{Username}' and password = '{Password}'");
            if(data.Rows.Count == 1)
            {
                FirstName = data.Rows[0]["FirstName"].ToString();
                LastName = data.Rows[0]["LastName"].ToString();
                Age = Convert.ToInt32(data.Rows[0]["Age"]);
                User.Username = Username;
                User.Password = Password;
                User.Id = (int)data.Rows[0]["ID"];
                User.UType = UserType.Employee;
                if(data.Rows[0]["IsAdmin"].ToString() == "true")
                {
                    User.IsAdmin = true;
                }
                return true;
            }
            data = datenbank.GetData($"Select * from Visitor where Username = '{Username}' and password = '{Password}'");
            if (data.Rows.Count == 1)
            {
                FirstName = data.Rows[0]["FirstName"].ToString();
                LastName = data.Rows[0]["LastName"].ToString();
                Age = Convert.ToInt32(data.Rows[0]["Age"]);
                User.Username = Username;
                User.Password = Password;
                User.UType = UserType.Visitor;
                User.Id = (int)data.Rows[0]["ID"];
                datenbank.ExecuteNQuery($"Update Visitor set Day = CONVERT(DATETIME, '{DateTime.Now.ToString("yyyy-MM-dd")}', 102) where ID = {User.Id}");
                return true;
            }
            return false;
        }
        internal static bool CreateVisitor(string FirstName, string LastName, string Username, string Password, int Age)
        {

            Klassen.Datenbank datenbank = new Klassen.Datenbank();
            DataTable data = datenbank.GetData($"Select * from Personal where Username = '{Username}'");
            if (data.Rows.Count > 0)
            {
                return false;
            }
                 data = datenbank.GetData($"Select * from Visitor where Username = '{Username}'");
            if (data.Rows.Count == 0)
            {
                datenbank.ExecuteNQuery($"Insert into Visitor ([Firstname], [LastName] , [Age], [Day] , Username , password ) " +
                    $"Values('{FirstName}', '{LastName}', {Age}, CONVERT(DATETIME, '{DateTime.Now.ToString("yyyy-MM-dd")}', 102), '{Username}', '{Password}')");
                login(Username, Password);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
