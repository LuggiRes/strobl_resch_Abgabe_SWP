namespace Resthome_Database
{
    partial class VisitorEdit
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
            this.LastName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.btnLoadLastIndex = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(70, 37);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(59, 13);
            this.LastName.TabIndex = 19;
            this.LastName.Text = "Nachname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Alter";
            // 
            // Day
            // 
            this.Day.AutoSize = true;
            this.Day.Location = new System.Drawing.Point(82, 89);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(26, 13);
            this.Day.TabIndex = 17;
            this.Day.Text = "Tag";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Vorname";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(131, 89);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(100, 20);
            this.txtDay.TabIndex = 15;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(131, 37);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 14;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(131, 63);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 13;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(131, 11);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(100, 20);
            this.txtFirstname.TabIndex = 12;
            // 
            // btnLoadLastIndex
            // 
            this.btnLoadLastIndex.Location = new System.Drawing.Point(12, 115);
            this.btnLoadLastIndex.Name = "btnLoadLastIndex";
            this.btnLoadLastIndex.Size = new System.Drawing.Size(120, 23);
            this.btnLoadLastIndex.TabIndex = 11;
            this.btnLoadLastIndex.Text = "Lade letzten Index";
            this.btnLoadLastIndex.UseVisualStyleBackColor = true;
            this.btnLoadLastIndex.Click += new System.EventHandler(this.btnLoadLastIndex_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(147, 115);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 23);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Bearbeiten";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(308, 12);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "ID";
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(273, 116);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(135, 22);
            this.btnGoBack.TabIndex = 24;
            this.btnGoBack.Text = "Zurück zur Übersicht";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // VisitorEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 148);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.btnLoadLastIndex);
            this.Name = "VisitorEdit";
            this.Text = "VisitorEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Day;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Button btnLoadLastIndex;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGoBack;
    }
}