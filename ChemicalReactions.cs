using chemical_dam.Types;

namespace chemical_dam;

public partial class ChemicalReactions : Form
{
    public ChemicalReactions()
    {
        InitializeComponent();
    }

    private void ChemicalReactions_Load(object sender, EventArgs e)
    {
        var openFileDialog = new OpenFileDialog();

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            var content = File.ReadAllText(openFileDialog.FileName);

            Database.LoadChemicalReactions(
                content, () =>
                {
                    dataGridView1.Rows.Add(
                        Database.ChemicalReactions.Length
                    );

                    for (var i = 0; i < Database.ChemicalReactions.Length; i++)
                    {
                        if (Database.ChemicalReactions[i].Equals(default(ChemicalReaction))) continue;

                        dataGridView1.Rows[i].Cells[0].Value = Database.ChemicalReactions[i].Id;
                        dataGridView1.Rows[i].Cells[1].Value = Database.ChemicalReactions[i].Name;
                        dataGridView1.Rows[i].Cells[2].Value = Database.ChemicalReactions[i].Type;
                        dataGridView1.Rows[i].Cells[3].Value = Database.ChemicalReactions[i].EnergyRelationship;
                        dataGridView1.Rows[i].Cells[4].Value = Database.ChemicalReactions[i].KelvinOptimalTemperature;
                        dataGridView1.Rows[i].Cells[5].Value = Database.ChemicalReactions[i].EnthalpyKjPerMolecule;
                        dataGridView1.Rows[i].Cells[6].Value = Database.ChemicalReactions[i].PerformancePercentage;
                    }
                }
            );
        }
    }

    private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (Database.GetLastIndex(Database.PeriodicTable) == -1)
        {
            Alert.show("Please load the periodic table first.");
            return;
        }

        if (Database.GetLastIndex(Database.ChemicalCompounds) == -1)
        {
            Alert.show("Please load chemical compounds first.");
            return;
        }

        var rowData = dataGridView1.Rows[e.RowIndex].Cells;

        var reaction = Database.ChemicalReactions.ToList().Where(x =>
        {
            return x.Id ==
                   int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }).First();


        var chemicalReactionView = new ChemicalReactionView();
        chemicalReactionView.chemicalReaction = reaction;
        chemicalReactionView.Show();
    }
}