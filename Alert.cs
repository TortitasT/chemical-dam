namespace chemical_dam
{
    internal class Alert
    {
        public static void show(string message)
        {
            Form form = new Form();
            form.Width = 315;
            form.Height = 300;

            Label label = new Label();
            label.Text = message;
            label.Width = 300;
            label.Height = 200;

            Button close = new Button();
            close.Text = "Cerrar";
            close.Click += new EventHandler(
                (object sender, EventArgs e) => { form.Close(); }
            );
            close.AutoSize = true;
            close.Top = 200;
            close.Width = 300;
            close.Height = 50;

            form.Controls.Add(label);
            form.Controls.Add(close);
            form.Show();
        }
    }
}