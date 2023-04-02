using chemical_dam.Types;

namespace chemical_dam;

public partial class ChemicalReactionView : Form
{
    public ChemicalReaction chemicalReaction;

    public ChemicalReactionView()
    {
        InitializeComponent();
    }

    private void ChemicalReactionView_Load(object sender, EventArgs e)
    {
        label1.Text = chemicalReaction.Name;
        richTextBox1.Text = chemicalReaction.ToString();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Close();
    }
}