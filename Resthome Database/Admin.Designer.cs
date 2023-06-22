namespace Resthome_Database
{
    partial class FormAdmin
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadTable = new System.Windows.Forms.Button();
            this.dgvShowData = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.btnTestVisitor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadTable
            // 
            this.btnLoadTable.Location = new System.Drawing.Point(202, 16);
            this.btnLoadTable.Name = "btnLoadTable";
            this.btnLoadTable.Size = new System.Drawing.Size(149, 36);
            this.btnLoadTable.TabIndex = 0;
            this.btnLoadTable.Text = "Load Table";
            this.btnLoadTable.UseVisualStyleBackColor = true;
            this.btnLoadTable.Click += new System.EventHandler(this.btnLoadTable_Click);
            // 
            // dgvShowData
            // 
            this.dgvShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowData.Location = new System.Drawing.Point(12, 73);
            this.dgvShowData.Name = "dgvShowData";
            this.dgvShowData.Size = new System.Drawing.Size(943, 393);
            this.dgvShowData.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(736, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(167, 45);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbTables
            // 
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Location = new System.Drawing.Point(12, 25);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(175, 21);
            this.cbTables.TabIndex = 3;
            // 
            // btnTestVisitor
            // 
            this.btnTestVisitor.Location = new System.Drawing.Point(21, 481);
            this.btnTestVisitor.Name = "btnTestVisitor";
            this.btnTestVisitor.Size = new System.Drawing.Size(149, 36);
            this.btnTestVisitor.TabIndex = 4;
            this.btnTestVisitor.Text = "Visitor Test";
            this.btnTestVisitor.UseVisualStyleBackColor = true;
            this.btnTestVisitor.Click += new System.EventHandler(this.btnTestVisitor_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 541);
            this.Controls.Add(this.btnTestVisitor);
            this.Controls.Add(this.cbTables);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvShowData);
            this.Controls.Add(this.btnLoadTable);
            this.Name = "FormAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadTable;
        private System.Windows.Forms.DataGridView dgvShowData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.Button btnTestVisitor;
    }
}

