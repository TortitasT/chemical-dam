using System.Drawing.Printing;

namespace chemical_dam
{
    internal class Alert
    {
        public static void show(string message)
        {
            Form form = new Form();
            form.AutoSize = true;

            Label label = new Label();
            label.Text = message;
            label.Size = new Size(300, 200);
            label.Location = new Point(0, 0);

            Button close = new Button();
            close.Text = "Cerrar";
            close.Click += new EventHandler(
                (object sender, EventArgs e) => { form.Close(); }
            );
            close.Location = new Point(3, 200);
            close.Size = new Size(300, 50);

            form.Controls.Add(label);
            form.Controls.Add(close);
            form.Show();
        }
    }
}