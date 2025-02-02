using System;
using System.Windows.Forms;
using System.Drawing;

namespace NewNamespace
{
    class NewClass
    {
        private const bool V = false;

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Image image = Image.FromFile("image.png");

            // Create a new window
            Form mainForm = new Form();
            mainForm.Text = "My Application Window";
            mainForm.Width = 1600;
            mainForm.Height = 1200;

            // Create the button
            Button button = new Button();
            button.Width = 700;
            button.Height = 500;
            button.Font = new Font("Arial", 24, FontStyle.Bold); // Set the font
            button.Image = image;
            button.ImageAlign = ContentAlignment.MiddleCenter;
            
            

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
            upgrade.Visible = true;

            //Create price tag for upgrade
            Label price = new Label();
            price.Location = new Point(45,100);
            price.Text = "20 points";
            price.BorderStyle = BorderStyle.FixedSingle;
            price.TextAlign = ContentAlignment.MiddleCenter;
            price.Visible = true;

            int multpoints = 1;

             //create upgrade
            Button upgrade1 = new Button();
            upgrade1.Location = new Point(210, 0);
            upgrade1.Height = 100;
            upgrade1.Width = 200;
            upgrade1.Text = "+1x";
            upgrade1.Font = new Font("Arial", 16, FontStyle.Bold);
            upgrade1.Visible = true;

            //Create price tag for x2 upgrade
            Label price1 = new Label();
            price1.Location = new Point(255,100);

            int price1price=30;
            int price1buyamount=0;
            price1.Text = $"{price1price} points \n {price1buyamount}/10";
            price1.BorderStyle = BorderStyle.FixedSingle;
            price1.TextAlign = ContentAlignment.MiddleCenter;
            price1.Visible = true;
            int addmultpoints=1;

            //upgrade1 handler
            upgrade1.Click += (sender, e) =>
                {
                    if(skor>=price1price&&price1buyamount<10){
            
                    addmultpoints += 1;
                    skor-=price1price;
                    price1price*=15;
                    price1price/=10;
                    price1buyamount+=1;
                    if(price1buyamount==10){
                     price1.Visible = false;
                     upgrade1.Visible = false;
                    }
                    sayac.Text = skor.ToString();
                    };
                    price1.Text = $"{price1price} points \n {price1buyamount}/10";     
                };
        
            //upgrade click handler
            upgrade.Click += (sender, e) =>
                {
                    if(skor>=20){
            
                    multpoints *= 2;
                    skor-=20;
                    upgrade.Visible = false;
                    price.Visible= false;
                    sayac.Text = skor.ToString();
                    };
                };
            


            // Button click event handler 
            button.Click += (sender, e) =>
            {
                
                skor+=multpoints*addmultpoints;
                sayac.Text = skor.ToString();
            };

            // Add the button and label to the window
            mainForm.Controls.Add(button);
            mainForm.Controls.Add(sayac);
            mainForm.Controls.Add(upgrade);
            mainForm.Controls.Add(price);
            mainForm.Controls.Add(upgrade1);
            mainForm.Controls.Add(price1);

            // Run the application
            Application.Run(mainForm);
        }
    }
}
