namespace chemical_dam
{
    partial class ChemicalComponents
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CASNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChemicalElementsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElementsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.CASNumberColumn,
            this.ChemicalElementsColumn,
            this.ElementsCount});
            this.dataGridView1.Location = new System.Drawing.Point(10, 9);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(679, 320);
            this.dataGridView1.TabIndex = 0;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 125;
            // 
            // CASNumberColumn
            // 
            this.CASNumberColumn.HeaderText = "CAS Number";
            this.CASNumberColumn.MinimumWidth = 6;
            this.CASNumberColumn.Name = "CASNumberColumn";
            this.CASNumberColumn.ReadOnly = true;
            this.CASNumberColumn.Width = 125;
            // 
            // ChemicalElementsColumn
            // 
            this.ChemicalElementsColumn.HeaderText = "Chemical Elements";
            this.ChemicalElementsColumn.MinimumWidth = 6;
            this.ChemicalElementsColumn.Name = "ChemicalElementsColumn";
            this.ChemicalElementsColumn.ReadOnly = true;
            this.ChemicalElementsColumn.Width = 125;
            // 
            // ElementsCount
            // 
            this.ElementsCount.HeaderText = "Elements Count";
            this.ElementsCount.MinimumWidth = 6;
            this.ElementsCount.Name = "ElementsCount";
            this.ElementsCount.ReadOnly = true;
            this.ElementsCount.Width = 125;
            // 
            // ChemicalComponents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChemicalComponents";
            this.ShowIcon = false;
            this.Text = "Chemical Components";
            this.Load += new System.EventHandler(this.ChemicalComponents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn CASNumberColumn;
        private DataGridViewTextBoxColumn ChemicalElementsColumn;
        private DataGridViewTextBoxColumn ElementsCount;
    }
}