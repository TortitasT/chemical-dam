using chemical_dam.Types;

namespace chemical_dam
{
    public partial class ChemicalComponents : Form
    {
        public ChemicalComponents()
        {
            InitializeComponent();
        }

        private void ChemicalComponents_Load(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String content = File.ReadAllText(openFileDialog.FileName);

                Database.LoadChemicalCompounds(
                    content, () =>
                    {
                        dataGridView1.Rows.Add(
                            Database.ChemicalCompounds.Length
                        );

                        int index = 0;
                        
                        Database.ChemicalCompounds.ToList().Where(x => !x.Equals(default(ChemicalCompound))).ToList().ForEach(
                            compound =>
                            {
                                if (compound.Equals(default(ChemicalCompound)))
                                {
                                    return;
                                }
                                
                                String composedBy = string.Join(", ", compound.ComposedBy);

                                // These are ints
                                String elementsCount = string.Join(", ", compound.ElementsCount);

                                dataGridView1.Rows[index].Cells[0].Value = compound.CasNumber;
                                dataGridView1.Rows[index].Cells[1].Value = compound.CompoundName;
                                dataGridView1.Rows[index].Cells[2].Value = composedBy;
                                dataGridView1.Rows[index].Cells[3].Value = elementsCount;
                                
                                index++;
                            });
                    }
                );
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(Database.GetLastIndex(Database.PeriodicTable) == -1)
            {
                Alert.show("Please load the periodic table first.");
                return;
            }
            
            var rowData = dataGridView1.Rows[e.RowIndex].Cells;

            var chemicalCompounds = Database.ChemicalCompounds.ToList().Where(
                compound => compound.CasNumber == rowData[0].Value.ToString()
            );
            
            var form = chemicalCompounds.First().ChemicalForm();
            
            Alert.show(form);
        }
    }
}
