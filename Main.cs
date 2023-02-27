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
    }
}
