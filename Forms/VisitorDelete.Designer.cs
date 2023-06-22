namespace Resthome_Database
{
    partial class VisitorDelete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadIndex = new System.Windows.Forms.Button();
            this.lFirstName = new System.Windows.Forms.Label();
            this.lLastName = new System.Windows.Forms.Label();
            this.lAge = new System.Windows.Forms.Label();
            this.lDay = new System.Windows.Forms.Label();
            this.lID = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadIndex
            // 
            this.btnLoadIndex.Location = new System.Drawing.Point(56, 128);
            this.btnLoadIndex.Name = "btnLoadIndex";
            this.btnLoadIndex.Size = new System.Drawing.Size(126, 23);
            this.btnLoadIndex.TabIndex = 0;
            this.btnLoadIndex.Text = "Lade letzten Index";
            this.btnLoadIndex.UseVisualStyleBackColor = true;
            this.btnLoadIndex.Click += new System.EventHandler(this.btnLoadIndex_Click);
            // 
            // lFirstName
            // 
            this.lFirstName.AutoSize = true;
            this.lFirstName.Location = new System.Drawing.Point(53, 28);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(49, 13);
            this.lFirstName.TabIndex = 1;
            this.lFirstName.Text = "Vorname";
            // 
            // lLastName
            // 
            this.lLastName.AutoSize = true;
            this.lLastName.Location = new System.Drawing.Point(53, 53);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(59, 13);
            this.lLastName.TabIndex = 2;
            this.lLastName.Text = "Nachname";
            // 
            // lAge
            // 
            this.lAge.AutoSize = true;
            this.lAge.Location = new System.Drawing.Point(51, 79);
            this.lAge.Name = "lAge";
            this.lAge.Size = new System.Drawing.Size(28, 13);
            this.lAge.TabIndex = 3;
            this.lAge.Text = "Alter";
            // 
            // lDay
            // 
            this.lDay.AutoSize = true;
            this.lDay.Location = new System.Drawing.Point(53, 105);
            this.lDay.Name = "lDay";
            this.lDay.Size = new System.Drawing.Size(26, 13);
            this.lDay.TabIndex = 4;
            this.lDay.Text = "Tag";
            // 
            // lID
            // 
            this.lID.AutoSize = true;
            this.lID.Location = new System.Drawing.Point(418, 31);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(18, 13);
            this.lID.TabIndex = 5;
            this.lID.Text = "ID";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(118, 24);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(279, 20);
            this.txtFirstname.TabIndex = 6;
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(118, 102);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(279, 20);
            this.txtDay.TabIndex = 7;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(118, 76);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(279, 20);
            this.txtAge.TabIndex = 8;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(118, 50);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(279, 20);
            this.txtLastName.TabIndex = 9;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(442, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(85, 20);
            this.txtID.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(188, 128);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Lösche Datensatz";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(320, 128);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(126, 23);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Zurück";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // VisitorDelete
            // 
            this.ClientSize = new System.Drawing.Size(542, 164);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.lID);
            this.Controls.Add(this.lDay);
            this.Controls.Add(this.lAge);
            this.Controls.Add(this.lLastName);
            this.Controls.Add(this.lFirstName);
            this.Controls.Add(this.btnLoadIndex);
            this.Name = "VisitorDelete";
            this.Load += new System.EventHandler(this.VisitorEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadIndex;
        private System.Windows.Forms.Label lFirstName;
        private System.Windows.Forms.Label lLastName;
        private System.Windows.Forms.Label lAge;
        private System.Windows.Forms.Label lDay;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
    }
}