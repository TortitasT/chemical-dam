namespace chemical_dam
{
    partial class ChemicalReactions
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
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnergyRelationshipColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KelvinOptimalTemperatureColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnthalpyKjPerMoleculeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerformancePercentageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.NameColumn,
            this.TypeColumn,
            this.EnergyRelationshipColumn,
            this.KelvinOptimalTemperatureColumn,
            this.EnthalpyKjPerMoleculeColumn,
            this.PerformancePercentageColumn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(797, 314);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            // 
            // TypeColumn
            // 
            this.TypeColumn.HeaderText = "Type";
            this.TypeColumn.Name = "TypeColumn";
            // 
            // EnergyRelationshipColumn
            // 
            this.EnergyRelationshipColumn.HeaderText = "Energy Relationship";
            this.EnergyRelationshipColumn.Name = "EnergyRelationshipColumn";
            // 
            // KelvinOptimalTemperatureColumn
            // 
            this.KelvinOptimalTemperatureColumn.HeaderText = "Kelvin Optimal Temperature";
            this.KelvinOptimalTemperatureColumn.Name = "KelvinOptimalTemperatureColumn";
            // 
            // EnthalpyKjPerMoleculeColumn
            // 
            this.EnthalpyKjPerMoleculeColumn.HeaderText = "Enthalpy Kj Per Molecule";
            this.EnthalpyKjPerMoleculeColumn.Name = "EnthalpyKjPerMoleculeColumn";
            // 
            // PerformancePercentageColumn
            // 
            this.PerformancePercentageColumn.HeaderText = "Performance Percentage";
            this.PerformancePercentageColumn.Name = "PerformancePercentageColumn";
            // 
            // ChemicalReactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 338);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChemicalReactions";
            this.ShowIcon = false;
            this.Text = "Chemical Reactions";
            this.Load += new System.EventHandler(this.ChemicalReactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn TypeColumn;
        private DataGridViewTextBoxColumn EnergyRelationshipColumn;
        private DataGridViewTextBoxColumn KelvinOptimalTemperatureColumn;
        private DataGridViewTextBoxColumn EnthalpyKjPerMoleculeColumn;
        private DataGridViewTextBoxColumn PerformancePercentageColumn;
    }
}