namespace chemical_dam;

partial class PeriodicTable
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.dataGridElements = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SymbolColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtomicNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtomicMassColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NeutronCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProtonCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElectronCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridElements)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridElements
            // 
            this.dataGridElements.AllowUserToAddRows = false;
            this.dataGridElements.AllowUserToDeleteRows = false;
            this.dataGridElements.AllowUserToOrderColumns = true;
            this.dataGridElements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridElements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridElements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridElements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.SymbolColumn,
            this.AtomicNumberColumn,
            this.AtomicMassColumn,
            this.NeutronCountColumn,
            this.ProtonCountColumn,
            this.ElectronCountColumn});
            this.dataGridElements.Location = new System.Drawing.Point(10, 9);
            this.dataGridElements.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridElements.Name = "dataGridElements";
            this.dataGridElements.ReadOnly = true;
            this.dataGridElements.RowHeadersWidth = 51;
            this.dataGridElements.RowTemplate.Height = 29;
            this.dataGridElements.Size = new System.Drawing.Size(858, 445);
            this.dataGridElements.TabIndex = 0;
            this.dataGridElements.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridElements_CellContentClick);
            // 
            // NameColumn
            // 
            this.NameColumn.Frozen = true;
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 64;
            // 
            // SymbolColumn
            // 
            this.SymbolColumn.Frozen = true;
            this.SymbolColumn.HeaderText = "Symbol";
            this.SymbolColumn.MinimumWidth = 6;
            this.SymbolColumn.Name = "SymbolColumn";
            this.SymbolColumn.ReadOnly = true;
            this.SymbolColumn.Width = 72;
            // 
            // AtomicNumberColumn
            // 
            this.AtomicNumberColumn.HeaderText = "Atomic Number";
            this.AtomicNumberColumn.MinimumWidth = 6;
            this.AtomicNumberColumn.Name = "AtomicNumberColumn";
            this.AtomicNumberColumn.ReadOnly = true;
            this.AtomicNumberColumn.Width = 108;
            // 
            // AtomicMassColumn
            // 
            this.AtomicMassColumn.HeaderText = "Atomic Mass";
            this.AtomicMassColumn.MinimumWidth = 6;
            this.AtomicMassColumn.Name = "AtomicMassColumn";
            this.AtomicMassColumn.ReadOnly = true;
            this.AtomicMassColumn.Width = 93;
            // 
            // NeutronCountColumn
            // 
            this.NeutronCountColumn.HeaderText = "Neutron Count";
            this.NeutronCountColumn.MinimumWidth = 6;
            this.NeutronCountColumn.Name = "NeutronCountColumn";
            this.NeutronCountColumn.ReadOnly = true;
            this.NeutronCountColumn.Width = 103;
            // 
            // ProtonCountColumn
            // 
            this.ProtonCountColumn.HeaderText = "Proton Count";
            this.ProtonCountColumn.MinimumWidth = 6;
            this.ProtonCountColumn.Name = "ProtonCountColumn";
            this.ProtonCountColumn.ReadOnly = true;
            this.ProtonCountColumn.Width = 96;
            // 
            // ElectronCountColumn
            // 
            this.ElectronCountColumn.HeaderText = "Electron Count";
            this.ElectronCountColumn.MinimumWidth = 6;
            this.ElectronCountColumn.Name = "ElectronCountColumn";
            this.ElectronCountColumn.ReadOnly = true;
            this.ElectronCountColumn.Width = 102;
            // 
            // PeriodicTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(879, 463);
            this.Controls.Add(this.dataGridElements);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PeriodicTable";
            this.ShowIcon = false;
            this.Text = "Periodic Table";
            this.Load += new System.EventHandler(this.PeriodicTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridElements)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private DataGridView dataGridElements;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn SymbolColumn;
    private DataGridViewTextBoxColumn AtomicNumberColumn;
    private DataGridViewTextBoxColumn AtomicMassColumn;
    private DataGridViewTextBoxColumn NeutronCountColumn;
    private DataGridViewTextBoxColumn ProtonCountColumn;
    private DataGridViewTextBoxColumn ElectronCountColumn;
}
