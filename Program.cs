﻿using System;
using System.Windows.Forms;
using System.Drawing;

namespace NewNamespace
{
    class NewClass
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create a new window
            Form mainForm = new Form();
            mainForm.Text = "My Application Window";
            mainForm.Width = 1600;
            mainForm.Height = 1200;

            // Create the button
            Button button = new Button();
            button.Text = "CLICK ME!";
            button.Width = 700;
            button.Height = 450;
            button.Font = new Font("Arial", 24, FontStyle.Bold); // Set the font

            // Center the button
            button.Location = new Point((mainForm.Width - button.Width) / 2, (mainForm.Height - button.Height) / 2 - 50);

            // Create the label
            Label sayac = new Label();
            sayac.Location = new Point((mainForm.Width - sayac.Width) / 2, button.Location.Y + button.Height + 10); // Position it below the button
            sayac.Width = 100;
            sayac.Height = 50;
            int skor = 0;
            sayac.BorderStyle = BorderStyle.FixedSingle;
            sayac.TextAlign = ContentAlignment.MiddleCenter;
            sayac.Font = new Font("Arial", 14, FontStyle.Bold);

            //create upgrade
            Button upgrade = new Button();
            upgrade.Location = new Point(0, 0);
            upgrade.Height = 100;
            upgrade.Width = 200;
            upgrade.Text = "x2";
            upgrade.Font = new Font("Arial", 16, FontStyle.Bold);

            bool doublepoints = false;

            //upgrade click handler
            upgrade.Click += (sender, e) =>
            {
                doublepoints = true;
                upgrade.Visible = false;
            };


            // Button click event handler 
            button.Click += (sender, e) =>
            {
                if (doublepoints==true)
                {
                    skor += 2;
                }
                else
                {
                    skor += 1;
                }
                sayac.Text = skor.ToString();
            };

            // Add the button and label to the window
            mainForm.Controls.Add(button);
            mainForm.Controls.Add(sayac);
            mainForm.Controls.Add(upgrade);

            // Run the application
            Application.Run(mainForm);
        }
    }
}
