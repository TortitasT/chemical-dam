namespace chemical_dam;

public partial class Main : Form
{
    public Main()
    {
        InitializeComponent();
    }

    private void tablaPeriodicaToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var periodicTable = new PeriodicTable();
        periodicTable.Show();
    }

    private void compuestosQuimicosToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var chemicalComponents = new ChemicalComponents();
        chemicalComponents.Show();
    }

    private void reaccionesQuimicasToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var chemicalReactions = new ChemicalReactions();
        chemicalReactions.Show();
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var about = new About();
        about.Show();
    }
}