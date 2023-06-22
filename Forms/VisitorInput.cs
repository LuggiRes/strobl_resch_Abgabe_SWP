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
    public partial class VisitorInput : Form
    {
        
        public VisitorInput()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            
        }

        private void VisitorInput_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateVisitor_Click(object sender, EventArgs e)
        {
            Klassen.Datenbank db = new Klassen.Datenbank();
            try
            {
                db.ExecuteNQuery("INSERT INTO Visitor (Firstname, LastName, Age, Day) VALUES ( '" + txtFirstname.Text + "', '" + txtLastName.Text + "', " + Int32.Parse(txtAge.Text) + ", '" + txtDay.Text + "');");
                
                this.Visible = false; 
            }
            catch(FormatException) 
            {
                MessageBox.Show("Sie haben das falsche Format eingegeben, geben Sie nächstes Mal das Datums Format so ein: dd.mm.yyyy hh:mm:ss und bei Alter (Age) dürfen sie nur Zahlen eingeben!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Etwas ist schiefgegangen, nur wissen wir nicht was!");
            }
        }
    }
}
