namespace chemical_dam
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void tablaPeriodicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeriodicTable periodicTable = new PeriodicTable();
            periodicTable.Show();
        }

        private void compuestosQuimicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChemicalComponents chemicalComponents = new ChemicalComponents();
            chemicalComponents.Show();
        }

        private void reaccionesQuimicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChemicalReactions chemicalReactions = new ChemicalReactions();
            chemicalReactions.Show();
        }
    }
}
