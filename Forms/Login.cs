using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resthome_Database
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (User.login(txt_username.Text, txt_password.Text)) 
            {
                if(User.UType == User.UserType.Employee)
                {
                    this.Hide();
                    if (User.IsAdmin)
                    {
                        FormAdmin Fa = new FormAdmin();
                        Fa.ShowDialog();
                    }
                    else
                    {
                        PersonalForm pf = new PersonalForm();
                        pf.ShowDialog();
                    }
                    
                    this.Close();
                }
                else
                {
                    this.Hide();
                    FormVisitor Fv = new FormVisitor();
                    Fv.ShowDialog();
                    this.Close();
                }

            }
            else { MessageBox.Show("Login nicht erfolgreich"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (User.CreateVisitor(textBox3.Text, textBox4.Text, textBox2.Text, textBox1.Text, Convert.ToInt32(numericUpDown1.Value)))
            {
                this.Hide();
                FormVisitor Fv = new FormVisitor();
                Fv.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username bereits vergeben.");
            }
        }
    }
    }

