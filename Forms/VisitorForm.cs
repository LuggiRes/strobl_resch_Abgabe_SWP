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
    public partial class FormVisitor : Form
    {
        public static string databasen = "Resthome";
        public static SqlConnection conn = new SqlConnection("server = (localdb)\\MSSQLLocalDB; integrated security = true;");
        public static SqlCommand cmmd = new SqlCommand("", conn);
        DataTable dataTable;

        public FormVisitor()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void Connect()
        {
            string connectionString = @"Data Source=MyServerName;Initial Catalog=MyDbName; User ID=Admin; Password=Root";

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            connection.Close();
        }

        public static bool CheckForDatabase(SqlConnection conn, string db)
        {
                conn.Close();
                SqlCommand comm = new SqlCommand($"SELECT db_id('{db}')", conn);
                conn.Open();
                return comm.ExecuteScalar() != DBNull.Value;
        }

        static void CreateDabase(SqlConnection conn, SqlCommand cmmd, string databasen)
        {
            try
            {
                Console.WriteLine("Database does not exist");
                conn.Close();
                conn.Open();
                cmmd.CommandText = "CREATE DATABASE " + databasen;
                cmmd.ExecuteNonQuery();
                conn.Close();
            }
            catch 
            {
                MessageBox.Show("Something went wrong, please try something else");
            }
        }
        static void CreateTable(SqlConnection conn, SqlCommand cmmd, string databasen)
        {
            try
            {
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
            catch
            { 
                MessageBox.Show("Something went wrong, please try something else"); 
            }
        }

         private void btnLoadTable_Click(object sender, EventArgs e)
         {
            try
            {
                if (cbTables.SelectedItem.Equals("Personal"))
                {
                    string Query;
                    //string chtable = (string)cbTables.SelectedItem;
                    Query = "SELECT * FROM Personal" /*chtable*/;
                    cmmd.CommandText = Query;//here I could do it with the index (dr[0]) for example! btn.name.ToString(); instead of ID
                    conn.Close();
                    conn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Integrated Security = true; Database = " + databasen;
                    conn.Open();
                    cmmd = new SqlCommand(Query, conn);
                    SqlDataReader dataReader = cmmd.ExecuteReader();
                    dataTable = new DataTable();
                    dataTable.Load(dataReader);
                    dgvShowData.DataSource = dataTable;
                    dgvShowData.ReadOnly = true;
                    conn.Close();
                }
                else if (cbTables.SelectedItem.Equals("Pensioner"))
                {
                    string Query;
                    //string chtable = (string)cbTables.SelectedItem;
                    Query = "SELECT * FROM Pensioner" /*chtable*/;
                    cmmd.CommandText = Query;//here I could do it with the index (dr[0]) for example! btn.name.ToString(); instead of ID
                    conn.Close();
                    conn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Integrated Security = true; Database = " + databasen;
                    conn.Open();
                    cmmd = new SqlCommand(Query, conn);
                    SqlDataReader dataReader = cmmd.ExecuteReader();
                    dataTable = new DataTable();
                    dataTable.Load(dataReader);
                    dgvShowData.DataSource = dataTable;
                    dgvShowData.ReadOnly = true;
                    conn.Close();
                }
                else if (cbTables.SelectedItem.Equals("Visitor"))
                {
                    string Query;
                    //string chtable = (string)cbTables.SelectedItem;
                    Query = "SELECT * FROM Visitor" /*chtable*/;
                    cmmd.CommandText = Query;//here I could do it with the index (dr[0]) for example! btn.name.ToString(); instead of ID
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
                else
                {
                    MessageBox.Show("Something went wrong, please try something else");
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong, please try something else");
            }
        } 

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                VisitorInput visitorInput = new VisitorInput();
                visitorInput.ShowDialog();
                btnCreate.Enabled = false;
                btnEdit.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Something went wrong, please try something else");
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            VisitorDelete visitorDelete = new VisitorDelete();
            visitorDelete.ShowDialog();
            btnCreate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            try
            {
                VisitorEdit visitorEdit = new VisitorEdit();
                visitorEdit.ShowDialog();
                btnCreate.Enabled = false;
                btnDelete.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Something went wrong, please try something else");
            }
        }
    }
}