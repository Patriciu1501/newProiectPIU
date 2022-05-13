using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using newProiectPIU.AdministrareDate;

namespace newProiectPIU {
    class AdminMenu {

        public enum AdministrareVarianta { Carti, Persoane };
        AdministrareVarianta administrareVarianta;
        public static Panel menu;
        public Label logo;
        public RadioButton radioCarti;
        public RadioButton radioPersoane;
        public Label administrareText;
        public Label optiuniText;
        public Button inapoi;
        public Label imageInapoi;

        // persoane-admin
        CheckBox adaugaPersoana;
        Label adaugaPersoanaOptiuneText;
        Label numePersoanaText;
        Label prenumePersoanaText;
        Label dataNasteriiPersoanaText;
        Label tipPersoanaText;
        TextBox numePersoanaTextBox;
        TextBox prenumePersoanaTextBox;
        ComboBox dataZiua;
        ComboBox dataLuna;
        ComboBox dataAnul;
        ComboBox studentProfesorBibliotecar;
        Button adaugaPersoanaButton;


        CheckBox getFullDatePersoana;
        ListBox zonaDatePersoane;
        CheckBox getDateDupaCriteriuPersoana;
        ListBox zoneDatePersoana;
        




        public AdminMenu() {


            menu = new Panel() { Visible = false };
            menu.Size = new Size(850, 950);

            logo = new Label() { Visible = true, Size = new Size(420, 290) };
            logo.Image = Image.FromFile(@"C:\Users\bogat\source\repos\newProiectPIU\Images\menuAdministratorLogo.png");
            logo.Location = new Point(230, 0);

            administrareText = new Label() { Text = "Administrare: ", Visible = true, Size = new Size(120, 30) };
            administrareText.Location = new Point(125, 300);
            administrareText.Font = new Font("Nirmala UI", 12, FontStyle.Bold);

            administrareVarianta = AdministrareVarianta.Persoane;
            radioCarti = new RadioButton() { Visible = true, Location = new Point(240, 300), Text = "Carti" };
            radioPersoane = new RadioButton() { Visible = true, Location = new Point(240, 320), Text = "Persoane" };
            radioCarti.Font = new Font("Nirmala UI", 10, FontStyle.Regular);
            radioPersoane.Font = new Font("Nirmala UI", 10, FontStyle.Regular);
            radioPersoane.Checked = true;

            inapoi = new Button();

            inapoi = new Button();
            inapoi.Name = "Admin";
            inapoi.Visible = true;
            inapoi.ForeColor = Color.Black;
            //inapoi.BackColor = Color.FromArgb(255, 246, 205);
            inapoi.Text = "Inapoi";
            inapoi.FlatStyle = FlatStyle.Flat;
            inapoi.FlatAppearance.BorderSize = 0;
            inapoi.FlatAppearance.MouseOverBackColor = Color.Transparent;
            inapoi.FlatAppearance.MouseDownBackColor = Color.Transparent;
            inapoi.Font = new Font("Nirmala UI", 11, FontStyle.Bold);
            inapoi.Size = new Size(61, 30);
            inapoi.Location = new Point(23, 0);
            inapoi.MouseEnter += Inapoi_MouseEnter;
            inapoi.MouseLeave += Inapoi_MouseLeave;
            inapoi.MouseClick += Inapoi_MouseClick;

            imageInapoi = new Label() { Visible = true };
            imageInapoi.Size = new Size(26, 26);
            imageInapoi.Image = Image.FromFile(@"C:\Users\bogat\source\repos\newProiectPIU\Images\inapoiDefault.png");
            imageInapoi.Location = new Point(0, 0);
            imageInapoi.MouseEnter += ImageInapoi_MouseEnter;
            imageInapoi.MouseLeave += ImageInapoi_MouseLeave;
            imageInapoi.Click += ImageInapoi_Click;

            optiuniText = new Label() { Visible = true, Text = "Optiuni:" };
            optiuniText.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
            optiuniText.Location = new Point(480, 300);
            optiuniText.Size = new Size(75, 30);

           

            adaugaPersoana = new CheckBox() { Visible = true, Text = "Adauga persoana" };
            adaugaPersoana.Font = new Font("Nirmala UI", 10, FontStyle.Regular);
            adaugaPersoana.Location = new Point(optiuniText.Location.X + optiuniText.Width, optiuniText.Location.Y);
            adaugaPersoana.Size = new Size(135, 24);
            adaugaPersoana.CheckedChanged += AdaugaPersoana_CheckedChanged;

            adaugaPersoanaOptiuneText = new Label() { Visible = false, Text = "Adauga persoana" };
            adaugaPersoanaOptiuneText.Font = new Font("Nirmala UI", 13, FontStyle.Bold);
            adaugaPersoanaOptiuneText.Size = new Size(180, 30);
            adaugaPersoanaOptiuneText.Location = new Point(15, 400);
            

            numePersoanaText = new Label() { Visible = false, Size = new Size(60, 30) };
            numePersoanaText.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
            numePersoanaText.Text = "Nume:";
            numePersoanaText.Location = new Point(15, 450);

            numePersoanaTextBox = new TextBox() { Visible = false, Size = new Size(180, 25) };
            numePersoanaTextBox.Font = new Font("Nirmala UI", 11, FontStyle.Bold);
            numePersoanaTextBox.Location = new Point(numePersoanaText.Location.X + numePersoanaText.Width + 30, numePersoanaText.Location.Y);

            prenumePersoanaText = new Label() { Visible = false, Size = new Size(80, 30) };
            prenumePersoanaText.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
            prenumePersoanaText.Text = "Prenume:";
            prenumePersoanaText.Location = new Point(15, 480);

            prenumePersoanaTextBox = new TextBox() { Visible = false, Size = new Size(180, 25) };
            prenumePersoanaTextBox.Font = new Font("Nirmala UI", 11, FontStyle.Bold);
            prenumePersoanaTextBox.Location = new Point(prenumePersoanaText.Location.X + prenumePersoanaText.Width + 10, prenumePersoanaText.Location.Y);



           dataNasteriiPersoanaText = new Label() { Visible = false, Size = new Size(120, 30) };
           dataNasteriiPersoanaText.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
           dataNasteriiPersoanaText.Text = "Data nasterii:";
           dataNasteriiPersoanaText.Location = new Point(15, 520);

            dataZiua = new ComboBox() { Visible = false, Size = new Size(40, 40) };
            dataZiua.Font = new Font("Nirmala UI", 10, FontStyle.Regular);
            
            for(int i = 1; i <= 31; i++) {

                dataZiua.Items.Add(i.ToString());
            }

            dataZiua.Text = "ZZ";
            dataZiua.Location = new Point(dataNasteriiPersoanaText.Location.X + dataNasteriiPersoanaText.Width, dataNasteriiPersoanaText.Location.Y); ;



            dataLuna = new ComboBox() { Visible = false, Size = new Size(40, 40) };
            dataLuna.Font = new Font("Nirmala UI", 10, FontStyle.Regular);

            for (int i = 1; i <= 12; i++) {

                string luna = string.Empty;

                if(i < 10) {

                    luna = "0" + i.ToString();
                }

                else luna = i.ToString();

                dataLuna.Items.Add(luna);
            }

            dataLuna.Text = "LL";
            dataLuna.Location = new Point(dataZiua.Location.X + dataZiua.Width, dataZiua.Location.Y); ;


            dataAnul = new ComboBox() { Visible = false, Size = new Size(60, 40) };
            dataAnul.Font = new Font("Nirmala UI", 10, FontStyle.Regular);

            for (int i = 1920; i <= 2022; i++) {

                dataAnul.Items.Add(i.ToString());
            }

            dataAnul.Text = "AAAA";
            dataAnul.Location = new Point(dataLuna.Location.X + dataLuna.Width, dataLuna.Location.Y); ;



            adaugaPersoanaButton = new Button();
            adaugaPersoanaButton.Name = "Admin";
            adaugaPersoanaButton.Visible = false;
            adaugaPersoanaButton.ForeColor = Color.Black;
            adaugaPersoanaButton.BackColor = Color.FromArgb(255, 246, 205);
            adaugaPersoanaButton.Text = "Adauga";
            adaugaPersoanaButton.FlatStyle = FlatStyle.Flat;
            adaugaPersoanaButton.FlatAppearance.BorderSize = 0;
            adaugaPersoanaButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            adaugaPersoanaButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            adaugaPersoanaButton.Font = new Font("Nirmala UI", 13, FontStyle.Bold);
            adaugaPersoanaButton.Size = new Size(180, 30);
            adaugaPersoanaButton.Location = new Point(50, 550);
            adaugaPersoanaButton.MouseEnter += AdaugaPersoanaButton_MouseEnter;
            adaugaPersoanaButton.MouseLeave += AdaugaPersoanaButton_MouseLeave;
            adaugaPersoanaButton.MouseClick += AdaugaPersoanaButton_MouseClick;









            getFullDatePersoana = new CheckBox() { Visible = true, Text = "Afisare toate persoane" };
            getFullDatePersoana.Font = new Font("Nirmala UI", 10, FontStyle.Regular);
            getFullDatePersoana.Location = new Point(adaugaPersoana.Location.X, adaugaPersoana.Location.Y + adaugaPersoana.Height);
            getFullDatePersoana.Size = new Size(180, 24);











            getDateDupaCriteriuPersoana = new CheckBox() { Visible = true, Text = "Cautare dupa nume" };
            getDateDupaCriteriuPersoana.Font = new Font("Nirmala UI", 10, FontStyle.Regular);
            getDateDupaCriteriuPersoana.Location = new Point(getFullDatePersoana.Location.X, getFullDatePersoana.Location.Y + getFullDatePersoana.Height);
            getDateDupaCriteriuPersoana.Size = new Size(180, 24);



            menu.Controls.Add(logo);
            menu.Controls.Add(radioCarti);
            menu.Controls.Add(radioPersoane);
            menu.Controls.Add(inapoi);
            menu.Controls.Add(imageInapoi);
            menu.Controls.Add(administrareText);
            menu.Controls.Add(optiuniText);
            menu.Controls.Add(adaugaPersoana);
            menu.Controls.Add(adaugaPersoanaOptiuneText);
            menu.Controls.Add(getFullDatePersoana);
            menu.Controls.Add(numePersoanaText);
            menu.Controls.Add(numePersoanaTextBox);
            menu.Controls.Add(prenumePersoanaText);
            menu.Controls.Add(prenumePersoanaTextBox);
            menu.Controls.Add(getDateDupaCriteriuPersoana);
            menu.Controls.Add(dataNasteriiPersoanaText);
            menu.Controls.Add(dataZiua);
            menu.Controls.Add(dataLuna);
            menu.Controls.Add(dataAnul);
            menu.Controls.Add(adaugaPersoanaButton);

        }


        private void AdaugaPersoanaButton_MouseClick(object sender, EventArgs e) {

            string nume = numePersoanaTextBox.Text;
            string prenume = prenumePersoanaTextBox.Text;
            string dataNasterii = dataZiua.Text + "/" + dataLuna.Text + "/" + dataAnul.Text;

            numePersoanaTextBox.Clear();
            prenumePersoanaTextBox.Clear();
            dataZiua.Text = "ZZ";
            dataLuna.Text = "LL";
            dataAnul.Text = "AAAA";


            AdministrarePersoane_FisierText.AdaugarePersoana(nume, prenume, dataNasterii);

        }

        private void AdaugaPersoanaButton_MouseEnter(object sender, EventArgs e) {

            adaugaPersoanaButton.ForeColor = Color.FromArgb(219, 147, 3);
        }


        private void AdaugaPersoanaButton_MouseLeave(object sender, EventArgs e) {

            adaugaPersoanaButton.ForeColor = Color.Black;
        }

       
        private void AdaugaPersoana_CheckedChanged(object sender, EventArgs e) {
            
            if(adaugaPersoana.Checked == true) {

                numePersoanaText.Visible = true;
                numePersoanaTextBox.Visible = true;
                prenumePersoanaText.Visible = true;
                prenumePersoanaTextBox.Visible = true;
                dataNasteriiPersoanaText.Visible = true;
                dataZiua.Visible = true;
                dataLuna.Visible = true;
                dataAnul.Visible = true;
                adaugaPersoanaOptiuneText.Visible = true;
                adaugaPersoanaButton.Visible = true;
            }

            else {

                numePersoanaText.Visible = false;
                numePersoanaTextBox.Visible = false;
                prenumePersoanaText.Visible = false;
                prenumePersoanaTextBox.Visible = false;
                dataNasteriiPersoanaText.Visible = false;
                dataZiua.Visible = false;
                dataLuna.Visible = false;
                dataAnul.Visible = false;
                adaugaPersoanaOptiuneText.Visible = false;
                adaugaPersoanaButton.Visible = false;
            }
        }

        private void Inapoi_MouseClick(object sender, MouseEventArgs e) {

            menu.Visible = false;
            FirstMenu.menu.Visible = true;
        }

        private void ImageInapoi_Click(object sender, EventArgs e) {

            menu.Visible = false;
            FirstMenu.menu.Visible = true;
        }

        private void ImageInapoi_MouseLeave(object sender, EventArgs e) {

            imageInapoi.Image = Image.FromFile(@"C:\Users\bogat\source\repos\newProiectPIU\Images\inapoiDefault.png");
            inapoi.ForeColor = Color.Black;
            imageInapoi.Cursor = Cursors.Default;
        }

        private void ImageInapoi_MouseEnter(object sender, EventArgs e) {

            imageInapoi.Image = Image.FromFile(@"C:\Users\bogat\source\repos\newProiectPIU\Images\inapoiChanged.png");
            inapoi.ForeColor = Color.FromArgb(219, 147, 3);
            imageInapoi.Cursor = Cursors.Hand;
        }

        private void Inapoi_MouseLeave(object sender, EventArgs e) {

            inapoi.ForeColor = Color.Black;
            imageInapoi.Image = Image.FromFile(@"C:\Users\bogat\source\repos\newProiectPIU\Images\inapoiDefault.png");
            inapoi.Cursor = Cursors.Default;
        }

        private void Inapoi_MouseEnter(object sender, EventArgs e) {
            
            inapoi.ForeColor = Color.FromArgb(219, 147, 3);
            imageInapoi.Image = Image.FromFile(@"C:\Users\bogat\source\repos\newProiectPIU\Images\inapoiChanged.png");
            inapoi.Cursor = Cursors.Hand;
        }

      
    }
}

