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

            // Create the button
            Button button = new Button();
            button.Text = "FLASH WARNING!";
            button.Width = 700;
            button.Height = 450;

            // Center the button
            button.Location = new Point((mainForm.Width - button.Width) / 2, (mainForm.Height - button.Height) / 2 - 50);

            // Create the label
            Label sayac = new Label();
            sayac.Location = new Point((mainForm.Width - sayac.Width) / 2, button.Location.Y + button.Height + 10); // Position it below the button
            sayac.Width = 100;
            sayac.Height = 50;
            int skor = 0;

            // Button click event handler 
            button.Click += (sender, e) =>
            {

                skor++; // Correctly increment skor
                sayac.Text = skor.ToString();
            };

            // Add the button and label to the form
            mainForm.Controls.Add(button);
            mainForm.Controls.Add(sayac);

            // Run the application
            Application.Run(mainForm);
        }
    }
}
