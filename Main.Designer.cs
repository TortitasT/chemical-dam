namespace chemical_dam;

partial class Main
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
            this.ElementColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridElements)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridElements
            // 
            this.dataGridElements.AllowUserToAddRows = false;
            this.dataGridElements.AllowUserToDeleteRows = false;
            this.dataGridElements.AllowUserToOrderColumns = true;
            this.dataGridElements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridElements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.ElementColumn});
            this.dataGridElements.Location = new System.Drawing.Point(12, 12);
            this.dataGridElements.Name = "dataGridElements";
            this.dataGridElements.ReadOnly = true;
            this.dataGridElements.RowHeadersWidth = 51;
            this.dataGridElements.RowTemplate.Height = 29;
            this.dataGridElements.Size = new System.Drawing.Size(300, 426);
            this.dataGridElements.TabIndex = 0;
            // 
            // NameColumn
            // 
            this.NameColumn.Frozen = true;
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 125;
            // 
            // ElementColumn
            // 
            this.ElementColumn.Frozen = true;
            this.ElementColumn.HeaderText = "Element";
            this.ElementColumn.MinimumWidth = 6;
            this.ElementColumn.Name = "ElementColumn";
            this.ElementColumn.ReadOnly = true;
            this.ElementColumn.Width = 125;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridElements);
            this.Name = "Main";
            this.Text = "Chemical";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridElements)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private DataGridView dataGridElements;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn ElementColumn;
}
