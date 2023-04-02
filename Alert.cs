namespace chemical_dam;

internal static class Alert
{
    public static void show(string message)
    {
        MessageBox.Show(message, "Chemical DAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}