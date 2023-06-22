using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Resthome_Database
{
    public partial class FormAdmin : Form
    {
        public static string databasen = "Resthome";
        public static SqlConnection conn = new SqlConnection("server = (localdb)\\MSSQLLocalDB; integrated security = true;");
        public static SqlCommand cmmd = new SqlCommand("", conn);
        DataTable dataTable;

        public FormAdmin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (CheckForDatabase(conn, databasen))
                {
                    cbTables.Items.Add("Pensioner");
                    cbTables.Items.Add("Personal");
                    cbTables.Items.Add("Visitor");
                }
                else
                {
                    CreateDabase(conn, cmmd, databasen);
                    CreateTable(conn, cmmd, databasen);
                }
            }
            catch (Exception) 
            {
                MessageBox.Show("Etwas ist schiefgegangen, nur wissen wir nicht was!");
            }
        }

        private void Connect()
        {

            string connectionString = @"Data Source=MyServerName;Initial Catalog=MyDbName; User ID=Admin; Password=Root";

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            connection.Close();

        }

        public static bool CheckForDatabase(SqlConnection conn, string db)
        {
            //checking if database exists with the select command where we look at the database table, where all db's are in and then just see if it is in there
                SqlCommand comm = new SqlCommand($"SELECT db_id('{db}')", conn);
                conn.Open();    
                return comm.ExecuteScalar() != DBNull.Value;        
        }

        static void CreateDabase(SqlConnection conn, SqlCommand cmmd, string databasen)
        {
            try
            {
                //here we just create the database with the create statement 
                Console.WriteLine("Database does not exist");
                conn.Close();
                conn.Open();
                cmmd.CommandText = "CREATE DATABASE " + databasen;
                cmmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Etwas ist schiefgegangen, nur wissen wir nicht was!");
            }
        }
        static void CreateTable(SqlConnection conn, SqlCommand cmmd, string databasen)
        {
            try
            {
                //normal creation commands
                conn.Close();
                conn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Integrated Security = true; Database = " + databasen;
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand("", conn);
                sqlCommand.CommandText = "CREATE TABLE Pensioner([ID] INT NOT NULL PRIMARY KEY IDENTITY, [Firstname] VARCHAR(50) NULL, [LastName] VARCHAR(50) NULL, [Age] INT NOT NULL, [Roomnumber] NVARCHAR(100) NULL, [Carelevel] INT)";
                sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandText = "CREATE TABLE Personal([ID] INT NOT NULL PRIMARY KEY IDENTITY(1,1), [Firstname] VARCHAR(50) NULL, [LastName] NVARCHAR(50) NULL, [Age] INT)";
                sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandText = "CREATE TABLE Visitor([ID] INT NOT NULL PRIMARY KEY IDENTITY(1,1), [Firstname] VARCHAR(50) NULL, [LastName] VARCHAR(50) NULL, [Age] INT NOT NULL, [Day] DATETIME)";
                sqlCommand.ExecuteNonQuery();
                conn.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Etwas ist schiefgegangen, nur wissen wir nicht was!");
            }
        }
        private void btnLoadTable_Click(object sender, EventArgs e)
        {
            try
            {
                //here we just do a usual select command, and then we just create an data table, which has included all of our
                //sources and we'll just add it to the datagridview's datasource, so just to the datagrid.
                string Query;
                string chtable = (string)cbTables.SelectedItem;
                Query = "SELECT * FROM " + chtable;
                cmmd.CommandText = Query;//here we could do it with the index (dr[0]) for example! btn.name.ToString(); instead of ID
                conn.Close();
                conn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Integrated Security = true; Database = " + databasen;
                conn.Open();
                cmmd = new SqlCommand(Query, conn);
                SqlDataReader dataReader = cmmd.ExecuteReader();
                dataTable = new DataTable();
                dataTable.Load(dataReader);
                dgvShowData.DataSource = dataTable;
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Etwas ist schiefgegangen, nur wissen wir nicht was!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //With SqlBulk you can add, edit, delete ... data from your datagridview and it copies the items to your datatable
                string chhtable = (string)cbTables.SelectedItem;
                cmmd.CommandText = "Truncate table " + chhtable;
                conn.Close();
                conn.Open();
                cmmd.ExecuteNonQuery();
                SqlBulkCopy copy = new SqlBulkCopy(conn);
                copy.DestinationTableName = chhtable;
                copy.WriteToServer(dataTable);
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Etwas ist schiefgegangen, nur wissen wir nicht was!");
            }
        }

        private void btnTestVisitor_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false;
                FormVisitor formVisitor = new FormVisitor();
                formVisitor.ShowDialog();
                this.Close();
            }
            catch(Exception) 
            {
                MessageBox.Show("Etwas ist schiefgegangen, nur wissen wir nicht was!");
            }
        }
    }
}

       