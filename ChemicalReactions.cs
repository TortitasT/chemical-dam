namespace chemical_dam
{
    public partial class ChemicalReactions : Form
    {
        public ChemicalReactions()
        {
            InitializeComponent();
        }

        private void ChemicalReactions_Load(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String content = File.ReadAllText(openFileDialog.FileName);

                Database.LoadChemicalReactions(
                    content, () =>
                    {
                        dataGridView1.Rows.Add(
                            Database.ChemicalReactions.Length
                        );
                        
                        for (int i = 0; i < Database.ChemicalReactions.Length; i++)
                        {
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
    }
}
