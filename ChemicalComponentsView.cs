using chemical_dam.Types;

namespace chemical_dam;

public partial class ChemicalComponentsView : Form
{
    public ChemicalCompound ChemicalCompound;

    public ChemicalComponentsView()
    {
        InitializeComponent();
    }

    private void ChemicalComponentsView_Load(object sender, EventArgs e)
    {
        label1.Text = ChemicalCompound.CompoundName;
        richTextBox1.Text = ChemicalCompound.ToString();

        formatSubscript(richTextBox1);
    }

    /*
     * Replace <sub></sub> with subscript, TODO: only last <sub> occurrence gets formatted
     */
    private void formatSubscript(RichTextBox richTextBox)
    {
        while (true)
        {
            var text = richTextBox.Text;
            var subStart = text.IndexOf("<sub>");
            var subEnd = text.IndexOf("</sub>");

            if (subStart == -1 || subEnd == -1) return;

            richTextBox.Text =
                string.Concat(richTextBox.Text.AsSpan(0, subStart), richTextBox.Text.AsSpan(subStart + 5));
            richTextBox.Text =
                string.Concat(richTextBox.Text.AsSpan(0, subEnd - 5), richTextBox.Text.AsSpan(subEnd + 1));

            richTextBox.Select(subStart, subEnd - subStart - 5);

            richTextBox.SelectionCharOffset = -5;
            richTextBox.SelectionFont = new Font(richTextBox.Font.FontFamily, 7);
            richTextBox.SelectionLength = 0;
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Close();
    }
}