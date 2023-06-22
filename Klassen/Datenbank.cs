using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resthome_Database.Klassen
{
    public class Datenbank
    {
        public Datenbank()
        {
            SqlConnection con = GetCon();
            SqlCommand cmd = new SqlCommand("", con);

            DataTable database = con.GetSchema("databases");
            bool dbexists = false;
            foreach (DataRow row in database.Rows)
            {
                if (row.Field<String>("database_name").Equals("Resthome"))
                {
                    Console.WriteLine("Database already exists.");
                    con.Close();
                    dbexists = true;
                }

            }
            if (dbexists.Equals(false))
            {
                try
                {
                    cmd.CommandText = "CREATE DATABASE Resthome";

                    cmd.ExecuteNonQuery();

                    cmd.Connection.Close();
                    ExecuteNQuery(@"CREATE TABLE [dbo].[Pensioner](ID INT NOT NULL PRIMARY KEY IDENTITY (1,1), [Firstname] VARCHAR(50) NULL, [LastName] VARCHAR(50) NULL, [Age] INT NOT NULL, [Roomnumber] NVARCHAR(100) NULL, [Carelevel] INT)");
                    ExecuteNQuery(@"CREATE TABLE [dbo].[Personal](ID INT NOT NULL PRIMARY KEY IDENTITY(1,1), [Firstname] VARCHAR(50) NULL, [LastName] NVARCHAR(50) NULL, [Age] INT, IsAdmin VARCHAR(50), Username VARCHAR(50), password VARCHAR(50))");
                    ExecuteNQuery(@"CREATE TABLE [dbo].[Visitor](ID INT NOT NULL PRIMARY KEY IDENTITY(1,1), [Firstname] VARCHAR(50) NULL, [LastName] VARCHAR(50) NULL, [Age] INT NOT NULL, [Day] DATETIME, Username VARCHAR(50), password VARCHAR(50))");

                    ExecuteNQuery(@"INSERT INTO  [dbo].Personal ([Firstname], LastName, Age, IsAdmin, Username, password) 
VALUES ('Admin', 'Admin',0, 'true', 'Admin', 'Admin' )");
                    ExecuteNQuery(@"INSERT INTO  [dbo].Personal ([Firstname], LastName, Age, IsAdmin, Username, password) 
VALUES ('Demo', 'Demo', 0, 'false', 'Demo', 'Demo')");

                    con.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                Console.ReadLine();
            }
        }

        public void ExecuteNQuery(string query, string dbname = "Resthome")
        {
            SqlCommand cmd = new SqlCommand(query, GetCon(dbname));
            try
            { cmd.ExecuteNonQuery(); }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            cmd.Connection.Close();

        }

        public DataTable GetData(string sqlquery)
        {

            SqlConnection con = GetCon("Resthome");

            SqlCommand cmd = new SqlCommand(sqlquery, con);
            SqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            return dataTable;
        }

        private SqlConnection GetCon(string db = "master")
        {

            SqlConnection con = new SqlConnection($"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog={db};Integrated Security=True;");
            con.Open(); return con;

        }
    }
}

