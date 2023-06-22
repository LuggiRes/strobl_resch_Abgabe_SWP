namespace Resthome_Database
{
    partial class VisitorInput
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
            this.btnCreateVisitor = new System.Windows.Forms.Button();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateVisitor
            // 
            this.btnCreateVisitor.Location = new System.Drawing.Point(70, 115);
            this.btnCreateVisitor.Name = "btnCreateVisitor";
            this.btnCreateVisitor.Size = new System.Drawing.Size(100, 23);
            this.btnCreateVisitor.TabIndex = 0;
            this.btnCreateVisitor.Text = "Create Visitor";
            this.btnCreateVisitor.UseVisualStyleBackColor = true;
            this.btnCreateVisitor.Click += new System.EventHandler(this.btnCreateVisitor_Click);
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(70, 6);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(100, 20);
            this.txtFirstname.TabIndex = 1;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(70, 63);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(70, 32);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(70, 89);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(100, 20);
            this.txtDay.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Firstname";
            // 
            // Day
            // 
            this.Day.AutoSize = true;
            this.Day.Location = new System.Drawing.Point(21, 89);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(26, 13);
            this.Day.TabIndex = 8;
            this.Day.Text = "Day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Age";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(12, 35);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(55, 13);
            this.LastName.TabIndex = 10;
            this.LastName.Text = "LastName";
            // 
            // VisitorInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 147);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.btnCreateVisitor);
            this.Name = "VisitorInput";
            this.Text = "VisitorInput";
            this.Load += new System.EventHandler(this.VisitorInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateVisitor;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Day;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox txtAge;
    }
}