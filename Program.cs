using System;
using System.Windows.Forms;

namespace NewNamespace
{
    class NewClass
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Create a new form
            Form mainForm = new Form();
            mainForm.Text = "My Application Window";
            mainForm.Width = 400;
            mainForm.Height = 300;

            // Create a button
            Button button = new Button();
            button.Text = "Click Me!";
            button.Dock = DockStyle.Fill;
            button.Click += (sender, e) => MessageBox.Show("Hello, World!");

            // Add the button to the form
            mainForm.Controls.Add(button);

            // Run the application
            Application.Run(mainForm);
        }
    }
}
