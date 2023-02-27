namespace chemical_dam;

public partial class PeriodicTable : Form
{
    public PeriodicTable()
    {
        InitializeComponent();
    }

    private void PeriodicTable_Load(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            String content = File.ReadAllText(openFileDialog.FileName);

            Database.LoadPeriodicTable(
                content, () =>
                {
                    dataGridElements.Rows.Add(
                        Database.PeriodicTable.Length
                    );

                    for (int i = 0; i < Database.PeriodicTable.Length; i++)
                    {
                        dataGridElements.Rows[i].Cells[0].Value = Database.PeriodicTable[i].Name;
                        dataGridElements.Rows[i].Cells[1].Value = Database.PeriodicTable[i].Symbol;
                        dataGridElements.Rows[i].Cells[2].Value = Database.PeriodicTable[i].AtomicNumber;
                        dataGridElements.Rows[i].Cells[3].Value = Database.PeriodicTable[i].AtomicMass;
                        dataGridElements.Rows[i].Cells[4].Value = Database.PeriodicTable[i].NeutronCount;
                        dataGridElements.Rows[i].Cells[5].Value = Database.PeriodicTable[i].ProtonCount;
                        dataGridElements.Rows[i].Cells[6].Value = Database.PeriodicTable[i].ElectronCount;
                    }
                }
            );
        }
    }

    private void dataGridElements_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}