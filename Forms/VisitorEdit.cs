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
    public partial class VisitorEdit : Form
    {
        public static string databasen = "Resthome";
        public static SqlConnection conn = new SqlConnection("server = (localdb)\\MSSQLLocalDB; integrated security = true; database =  " + databasen);
        public static SqlCommand cmmd = new SqlCommand("", conn);

        public VisitorEdit()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
 
        private void btnLoadLastIndex_Click(object sender, EventArgs e)
        {
            try
            {
                //https://stackoverflow.com/questions/39002025/is-there-a-lastindexof-in-sql-server   
                //cmmd.CommandText = "SELECT right(db_name(), charindex('_', reverse(db_name()) + '_') -1) FROM Visitor;"; 
                //cmmd.CommandText = "SELECT LEFT(db_name(), len(db_name()) - charindex('_', reverse(db_name()) + '_')) FROM Visitor";
                conn.Close();
                conn.Open();
                string data = "SELECT * FROM Visitor";
                SqlCommand cm = new SqlCommand(data, conn);
                SqlDataReader dr = cm.ExecuteReader();
                //cmmd.CommandText = "SELECT * FROM Visitor where ID = " + dr[0] + "";
                while (dr.Read()) //you can also use for I guess
                {
                    txtID.Text = dr[0].ToString();
                    txtFirstname.Text = dr[1].ToString();
                    txtLastName.Text = dr[2].ToString();
                    txtAge.Text = dr[3].ToString();
                    txtDay.Text = dr[4].ToString();
                }
                dr.Close();
                conn.Close();
            }
            catch(Exception) 
            {
                MessageBox.Show("Etwas ist schiefgegangen, nur wissen wir nicht was!");
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmmd.CommandText = "UPDATE Visitor SET Firstname = '" + txtFirstname.Text + "', LastName = '" + txtLastName.Text + "', Age = " + Int32.Parse(txtAge.Text) + ", Day = '" + txtDay.Text + "' WHERE ID = " + txtID.Text + ";";
                cmmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Sie haben das falsche Format eingegeben, geben Sie nächstes Mal das Datums Format so ein: dd.mm.yyyy hh:mm:ss und bei Alter (Age) dürfen sie nur Zahlen eingeben!");
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Sie müssen zuerst auf 'Lade letzten Index' klicken, bevor sie etwas bearbeiten können!");
            } 
            catch(System.Exception) 
            {
                MessageBox.Show("Etwas ist schiefgegangen, nur wissen wir nicht was!");
            }
        }

        private void txtDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Close();
                conn.Open();
                cmmd.CommandText = "DELETE FROM Visitor WHERE ID = " + txtID.Text + ";";
                cmmd.ExecuteNonQuery();
                btnEdit.Enabled = false;
                btnLoadLastIndex.Enabled = false;
                conn.Close();
                this.Visible = false;
                FormVisitor formVisitor = new FormVisitor();
                formVisitor.ShowDialog();
                this.Close();
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

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;    
        }
    }
}
