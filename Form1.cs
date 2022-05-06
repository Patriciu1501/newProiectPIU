using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newProiectPIU {
    public partial class Form1 : Form {


        private Button adminMenuButton;
        private Button bibliotecaMenuButton;
        private Label backgroundLabel;

        public Form1() {
            InitializeComponent();
            backgroundLabel = new Label() { Visible = true, BackColor = Color.Bisque, Width = 600, Height = 600 };


            adminMenuButton = new Button();
            adminMenuButton.Location = new Point(200, 200);
            adminMenuButton.ForeColor = Color.White;
            adminMenuButton.FlatStyle = FlatStyle.Flat;
            adminMenuButton.FlatAppearance.BorderSize = 0;
            adminMenuButton.BackColor = Color.FromArgb(40, 50, 90);
            adminMenuButton.Text = "Menu administrator";
            adminMenuButton.Width = 200;
            adminMenuButton.Visible = true;
            Controls.Add(adminMenuButton);

            bibliotecaMenuButton = new Button();
            bibliotecaMenuButton.Location = new Point(200, 200 + adminMenuButton.Height);
            bibliotecaMenuButton.ForeColor = Color.White;
            bibliotecaMenuButton.FlatStyle = FlatStyle.Flat;
            bibliotecaMenuButton.FlatAppearance.BorderSize = 0;
            bibliotecaMenuButton.BackColor = Color.FromArgb(40, 50, 90);
            bibliotecaMenuButton.Text = "Menu biblioteca";
            bibliotecaMenuButton.Width = 200;
            bibliotecaMenuButton.Visible = true;
            Controls.Add(bibliotecaMenuButton);
            BackColor = Color.FromArgb(179, 239, 255);

            Controls.Add(backgroundLabel);
        }

        private void adminMenuButton_Click(object sender, EventArgs e) {

            adminMenuButton.Visible = false;
            bibliotecaMenuButton.Visible = false;

        }
    }
}
