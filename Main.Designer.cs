namespace chemical_dam
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaPeriodicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compuestosQuimicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reaccionesQuimicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chemical DAM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(5, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comienza por abrir el menu.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(335, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablaPeriodicaToolStripMenuItem,
            this.compuestosQuimicosToolStripMenuItem,
            this.reaccionesQuimicasToolStripMenuItem});
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.importarToolStripMenuItem.Text = "Importar";
            // 
            // tablaPeriodicaToolStripMenuItem
            // 
            this.tablaPeriodicaToolStripMenuItem.Name = "tablaPeriodicaToolStripMenuItem";
            this.tablaPeriodicaToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.tablaPeriodicaToolStripMenuItem.Text = "Tabla Periodica";
            this.tablaPeriodicaToolStripMenuItem.Click += new System.EventHandler(this.tablaPeriodicaToolStripMenuItem_Click);
            // 
            // compuestosQuimicosToolStripMenuItem
            // 
            this.compuestosQuimicosToolStripMenuItem.Name = "compuestosQuimicosToolStripMenuItem";
            this.compuestosQuimicosToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.compuestosQuimicosToolStripMenuItem.Text = "Compuestos Quimicos";
            // 
            // reaccionesQuimicasToolStripMenuItem
            // 
            this.reaccionesQuimicasToolStripMenuItem.Name = "reaccionesQuimicasToolStripMenuItem";
            this.reaccionesQuimicasToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.reaccionesQuimicasToolStripMenuItem.Text = "Reacciones Quimicas";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 129);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Chemical DAM";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem importarToolStripMenuItem;
        private ToolStripMenuItem tablaPeriodicaToolStripMenuItem;
        private ToolStripMenuItem compuestosQuimicosToolStripMenuItem;
        private ToolStripMenuItem reaccionesQuimicasToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}