namespace chemical_dam;

public partial class Main : Form
{
    public Main()
    {
        InitializeComponent();
    }

    private void Main_Load(object sender, EventArgs e)
    {
        Alert.show(Resources.PeriodicTable);

        Alert.show("Holaaa");
    }
}