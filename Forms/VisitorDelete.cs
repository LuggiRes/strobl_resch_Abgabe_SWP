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
using System.Linq.Expressions;

namespace Resthome_Database
{
    public partial class VisitorDelete : Form
    {
        public static string databasen = "Resthome";
        public static SqlConnection conn = new SqlConnection("server = (localdb)\\MSSQLLocalDB; integrated security = true; database =  " + databasen);
        public static SqlCommand cmmd = new SqlCommand("", conn);

        public VisitorDelete()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void btnLoadIndex_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Close();
                conn.Open();
                string data = "SELECT * FROM Visitor";
                SqlCommand cm = new SqlCommand(data, conn);
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read()) //you can also use for I guess
                {
                    txtID.Text = dr[0].ToString();
                    txtFirstname.Text = dr[1].ToString();
                    txtLastName.Text = dr[2].ToString();
                    txtDay.Text = dr[3].ToString();
                    txtDay.Text = dr[4].ToString();
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Etwas ist schiefgegangen, nur wissen wir nicht was!");
            }
        }

        private void VisitorEdit_Load(object sender, EventArgs e)
        {
            try
            {
                txtID.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Etwas ist schiefgegangen, nur wissen wir nicht was!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Close();
                conn.Open();
                cmmd.CommandText = "DELETE FROM Visitor WHERE ID = " + txtID.Text + ";";
                cmmd.ExecuteNonQuery();
                conn.Close();
                this.Visible = false;
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Sie müssen zuerst auf 'Lade letzten Index' klicken, bevor sie etwas bearbeiten können!");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Etwas ist schiefgegangen, nur wissen wir nicht was!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Etwas ist schiefgegangen, nur wissen wir nicht was!");
            }
        }
    }
}
