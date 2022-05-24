using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newProiectPIU {

    internal class FirstMenu {

        public static readonly Color changedColor = Color.FromArgb(219, 147, 3);

        public Panel adminMenuOption;
        public Button adminMenuButton;
        public Label adminPicture;
        public Panel bibliotecaMenuOption;
        public Button bibliotecaMenuButton;
        public Label bookPicture;
        public Form adminData;
        public static Panel menu;

        public Label logo;
        public TextBox passwordBox;
        public TextBox usernameBox;
        public Label passwordText;
        public Label usernameText;
        public Button enterAdminData;
        public Button exitAdminData;
        public bool accesToAdmin;



        public FirstMenu() {


            menu = new Panel() { Visible = true };
            menu.Size = new Size(670, 520);
            adminData = new Form() { Size = new Size(280, 150), Text = "Enter data" };
            adminData.FormClosing += AnotherExitAdminData_Click;

            usernameText = new Label() { Visible = true, Size = new Size(95, 30), Text = "Username:" };
            usernameText.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
            usernameText.Location = new Point(10, 15);
            usernameBox = new TextBox() { Visible = true, Size = new Size(120, 50) };
            usernameBox.Location = new Point(usernameText.Location.X + usernameText.Width + 2, usernameText.Location.Y + 3);
            usernameBox.Font = new Font("Nirmala UI", 10, FontStyle.Bold);
            usernameBox.MaxLength = 15;

            adminData.Controls.Add(usernameText);
            adminData.Controls.Add(usernameBox);
            

            passwordText = new Label() { Visible = true, Size = new Size(95, 30), Text = "Password:" };
            passwordText.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
            passwordText.Location = new Point(10, usernameText.Location.Y + usernameText.Height);
            passwordBox = new TextBox() { Visible = true, Size = new Size(120, 50) };
            passwordBox.Location = new Point(50, 70);
            passwordBox.Location = new Point(passwordText.Location.X + passwordText.Width + 2, passwordText.Location.Y);
            passwordBox.Font = new Font("Nirmala UI", 10, FontStyle.Bold);
            passwordBox.MaxLength = 15;
            passwordBox.PasswordChar = '*';
            passwordBox.KeyDown += PasswordBox_KeyDown;
            adminData.Controls.Add(passwordText);
            adminData.Controls.Add(passwordBox);

            enterAdminData = new Button() { Visible = true, Size = new Size(60, 20), Text = "Enter" };
            enterAdminData.Location = new Point(passwordBox.Location.X, passwordBox.Location.Y + passwordBox.Height + 10);
            enterAdminData.Click += EnterAdminData_Click;
            exitAdminData = new Button() { Visible = true, Size = new Size(60, 20), Text = "Exit" };
            exitAdminData.Location = new Point(passwordBox.Location.X + enterAdminData.Width, passwordBox.Location.Y + passwordBox.Height + 10);
            exitAdminData.Click += ExitAdminData_Click;
            adminData.Controls.Add(enterAdminData);
            adminData.Controls.Add(exitAdminData);

            logo = new Label() { Visible = true, Size = new Size(350, 290) };
            logo.Image = Image.FromFile(@"C:\Users\bogat\source\repos\newProiectPIU\Images\logo.png");
            logo.Location = new Point(250, 70);
            logo.Click += Logo_Click;
            logo.MouseEnter += Logo_MouseEnter;
            logo.MouseLeave += Logo_MouseLeave;

            bibliotecaMenuOption = new Panel() { Visible = true, Size = new Size(350, 54) };
            bibliotecaMenuOption.Location = new Point(243, 385);
         
 

             bookPicture = new Label() { Size = new Size(50, 50), BackColor = Color.Red, Visible = true };
             bookPicture.BackColor = Color.Transparent;
             bookPicture.Image = Image.FromFile(@"C:\Users\bogat\source\repos\newProiectPIU\Images\bookDefault.png");
             bookPicture.MouseEnter += BibliotecaMenuMouseEnter;
             bookPicture.MouseLeave += BibliotecaMenuMouseLeave;

            
             bibliotecaMenuButton = new Button();
             bibliotecaMenuButton.Name = "Biblioteca";
             bibliotecaMenuButton.Visible = true;
             bibliotecaMenuButton.ForeColor = Color.Black;
             bibliotecaMenuButton.BackColor = Color.FromArgb(255, 246, 205);
             bibliotecaMenuButton.Text = "Menu biblioteca";
             bibliotecaMenuButton.Size = new Size(300, 54);
             bibliotecaMenuButton.FlatStyle = FlatStyle.Flat;
             bibliotecaMenuButton.FlatAppearance.BorderSize = 0;
             bibliotecaMenuButton.Font = new Font("Nirmala UI", 26, FontStyle.Bold);
             bibliotecaMenuButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
             bibliotecaMenuButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
             bibliotecaMenuButton.Location = new Point(bookPicture.Width, 0);
             bibliotecaMenuButton.MouseEnter += BibliotecaMenuMouseEnter;
             bibliotecaMenuButton.MouseLeave += BibliotecaMenuMouseLeave;

             bibliotecaMenuOption.Controls.Add(bibliotecaMenuButton);
             bibliotecaMenuOption.Controls.Add(bookPicture);


            adminMenuOption = new Panel() { Visible = true, Size = new Size(411, 54) };
            adminMenuOption.Location = new Point(bibliotecaMenuOption.Location.X, bibliotecaMenuOption.Height + bibliotecaMenuOption.Location.Y + 20);
            
            adminPicture = new Label() { Size = new Size(50, 50), BackColor = Color.Red, Visible = true };
            adminPicture.BackColor = Color.Transparent;
            adminPicture.Image = Image.FromFile(@"C:\Users\bogat\source\repos\newProiectPIU\Images\adminDefault.png");
            adminPicture.MouseEnter += AdminMenuMouseEnter;
            adminPicture.MouseLeave += AdminMenuMouseLeave;
            adminPicture.MouseClick += AdminMenuMouseClick;

            adminMenuButton = new Button();
            adminMenuButton.Name = "Admin";
            adminMenuButton.Visible = true;
            adminMenuButton.ForeColor = Color.Black;
            adminMenuButton.BackColor = Color.FromArgb(255, 246, 205);
            adminMenuButton.Text = "Menu administrator";
            adminMenuButton.FlatStyle = FlatStyle.Flat;
            adminMenuButton.FlatAppearance.BorderSize = 0;
            adminMenuButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            adminMenuButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            adminMenuButton.Font = new Font("Nirmala UI", 26, FontStyle.Bold);
            adminMenuButton.Size = new Size(361, 54);
            adminMenuButton.Location = new Point(adminPicture.Width, 0);
            adminMenuButton.MouseEnter += AdminMenuMouseEnter;
            adminMenuButton.MouseLeave += AdminMenuMouseLeave;
            adminMenuButton.MouseClick += AdminMenuMouseClick;
            
            adminMenuOption.Controls.Add(adminPicture);
            adminMenuOption.Controls.Add(adminMenuButton);

            



            menu.Controls.Add(logo);
            menu.Controls.Add(bibliotecaMenuOption);
            menu.Controls.Add(adminMenuOption);

        }

        private void PasswordBox_KeyDown(object sender, KeyEventArgs e) {

           if(e.KeyCode == Keys.Enter) EnterAdminData_Click(sender, e);
        }

        private void Logo_MouseLeave(object sender, EventArgs e) {


            (sender as Label).Cursor = Cursors.Default;
        }

        private void Logo_MouseEnter(object sender, EventArgs e) {

            (sender as Label).Cursor = Cursors.Hand;
        }

        private void Logo_Click(object sender, EventArgs e) {

            System.Diagnostics.Process.Start("https://github.com/Patriciu1501/newProiectPIU");
        }

        public void BibliotecaMenuMouseEnter(object sender, EventArgs e) {

            Panel parent = null;

            if (sender is Label) {

                parent = (sender as Label).Parent as Panel;
                (sender as Label).Cursor = Cursors.Hand;
            }

            else if (sender is Button) {

                parent = (sender as Button).Parent as Panel;
                (sender as Button).Cursor = Cursors.Hand;
            }

            foreach(var i in parent.Controls) {

                if (i is Label) (i as Label).Image = Image.FromFile(@"C:\Users\bogat\source\repos\newProiectPIU\Images\bookFocused.png");
                else if (i is Button) (i as Button).ForeColor = changedColor;
            }

        }


        public void BibliotecaMenuMouseLeave(object sender, EventArgs e) {

            Panel parent = null;

            if (sender is Label) {

                parent = (sender as Label).Parent as Panel;
                (sender as Label).Cursor = Cursors.Default;
            }

            else if (sender is Button) {

                parent = (sender as Button).Parent as Panel;
                (sender as Button).Cursor = Cursors.Default;
            }

            foreach (var i in parent.Controls) {

                if (i is Label) (i as Label).Image = Image.FromFile(@"C:\Users\bogat\source\repos\newProiectPIU\Images\bookDefault.png");
                else if (i is Button) (i as Button).ForeColor = Color.Black;
            }

        }


        public void AdminMenuMouseEnter(object sender, EventArgs e) {

            Panel parent = null;

            if (sender is Label) {

                parent = (sender as Label).Parent as Panel;
                (sender as Label).Cursor = Cursors.Hand;
            }

            else if (sender is Button) {

                parent = (sender as Button).Parent as Panel;
                (sender as Button).Cursor = Cursors.Hand;
            }

            foreach (var i in parent.Controls) {

                if (i is Label) (i as Label).Image = Image.FromFile(@"C:\Users\bogat\source\repos\newProiectPIU\Images\adminFocused.png");
                else if (i is Button) (i as Button).ForeColor = changedColor;
            }

        }


        public void AdminMenuMouseLeave(object sender, EventArgs e) {

            Panel parent = null;

            if (sender is Label) {

                parent = (sender as Label).Parent as Panel;
                (sender as Label).Cursor = Cursors.Default;
            }

            else if (sender is Button) {

                parent = (sender as Button).Parent as Panel;
                (sender as Button).Cursor = Cursors.Default;
            }

            foreach (var i in parent.Controls) {

                if (i is Label) (i as Label).Image = Image.FromFile(@"C:\Users\bogat\source\repos\newProiectPIU\Images\adminDefault.png");
                else if (i is Button) (i as Button).ForeColor = Color.Black;
            }

        }


        public void AdminMenuMouseClick(object sender, EventArgs e) {

            adminData.ShowDialog();
        }

        public void inapoiMenuAdministrator(object sender, EventArgs e) {

            (sender as Button).Parent.Visible = false;

        }

        private void EnterAdminData_Click(object sender, EventArgs e) {

            StreamReader fisier = new StreamReader(@"C:\Users\bogat\source\repos\newProiectPIU\adminText.txt");
            string data = fisier.ReadLine();
            string[] splits = data.Split(';');

            if (splits[0] == usernameBox.Text && splits[1] == passwordBox.Text) {

                usernameBox.Clear();
                passwordBox.Clear();
                ExitAdminData_Click(sender, e);
                menu.Visible = false;
                AdminMenu.menu.Visible = true;
            }

            else {

                passwordBox.Clear();
                usernameBox.Text = "INVALID DATA";
            }

            fisier.Close();
        }


        private void AnotherExitAdminData_Click(object sender, FormClosingEventArgs e) {

            usernameBox.Clear();
            passwordBox.Clear();

        }


        private void ExitAdminData_Click(object sender, EventArgs e) {

            usernameBox.Clear();
            passwordBox.Clear();
            adminData.Close();
        }

    }

}