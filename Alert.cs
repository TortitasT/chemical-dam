using System.Drawing.Printing;

namespace chemical_dam
{
    internal class Alert
    {
        public static void show(string message)
        {
            MessageBox.Show(message, "Chemical DAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}