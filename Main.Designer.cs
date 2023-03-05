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
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chemical DAM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 25);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(293, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablaPeriodicaToolStripMenuItem,
            this.compuestosQuimicosToolStripMenuItem,
            this.reaccionesQuimicasToolStripMenuItem});
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importarToolStripMenuItem.Text = "Importar";
            // 
            // tablaPeriodicaToolStripMenuItem
            // 
            this.tablaPeriodicaToolStripMenuItem.Name = "tablaPeriodicaToolStripMenuItem";
            this.tablaPeriodicaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.tablaPeriodicaToolStripMenuItem.Text = "Tabla Periodica";
            this.tablaPeriodicaToolStripMenuItem.Click += new System.EventHandler(this.tablaPeriodicaToolStripMenuItem_Click);
            // 
            // compuestosQuimicosToolStripMenuItem
            // 
            this.compuestosQuimicosToolStripMenuItem.Name = "compuestosQuimicosToolStripMenuItem";
            this.compuestosQuimicosToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.compuestosQuimicosToolStripMenuItem.Text = "Compuestos Quimicos";
            this.compuestosQuimicosToolStripMenuItem.Click += new System.EventHandler(this.compuestosQuimicosToolStripMenuItem_Click);
            // 
            // reaccionesQuimicasToolStripMenuItem
            // 
            this.reaccionesQuimicasToolStripMenuItem.Name = "reaccionesQuimicasToolStripMenuItem";
            this.reaccionesQuimicasToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.reaccionesQuimicasToolStripMenuItem.Text = "Reacciones Quimicas";
            this.reaccionesQuimicasToolStripMenuItem.Click += new System.EventHandler(this.reaccionesQuimicasToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 97);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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