namespace Resthome_Database
{
    partial class PersonalForm
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
            this.dgvShowData = new System.Windows.Forms.DataGridView();
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.btnLoadTable = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShowData
            // 
            this.dgvShowData.AllowUserToAddRows = false;
            this.dgvShowData.AllowUserToDeleteRows = false;
            this.dgvShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvShowData.Location = new System.Drawing.Point(12, 56);
            this.dgvShowData.Name = "dgvShowData";
            this.dgvShowData.ReadOnly = true;
            this.dgvShowData.Size = new System.Drawing.Size(1095, 510);
            this.dgvShowData.TabIndex = 2;
            // 
            // cbTables
            // 
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Location = new System.Drawing.Point(27, 12);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(178, 21);
            this.cbTables.TabIndex = 4;
            // 
            // btnLoadTable
            // 
            this.btnLoadTable.Location = new System.Drawing.Point(235, 5);
            this.btnLoadTable.Name = "btnLoadTable";
            this.btnLoadTable.Size = new System.Drawing.Size(105, 33);
            this.btnLoadTable.TabIndex = 5;
            this.btnLoadTable.Text = "Load Table";
            this.btnLoadTable.UseVisualStyleBackColor = true;
            this.btnLoadTable.Click += new System.EventHandler(this.btnLoadTable_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(875, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(220, 33);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Table";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PersonalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 578);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoadTable);
            this.Controls.Add(this.cbTables);
            this.Controls.Add(this.dgvShowData);
            this.Name = "PersonalForm";
            this.Text = "PersonalForm";
            this.Load += new System.EventHandler(this.PersonalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowData;
        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.Button btnLoadTable;
        private System.Windows.Forms.Button btnSave;
    }
}