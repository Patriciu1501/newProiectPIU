using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using newProiectPIU.AdministrareDate;

namespace newProiectPIU {
    partial class AdminMenu {

        public enum AdministrareVarianta { Carti, Persoane };
        AdministrareVarianta administrareVarianta;

        public static Panel menu;
        public Label logo;
        public RadioButton radioCarti;
        public RadioButton radioPersoane;
        public Label administrareText;
        public Label optiuniText;

        public Panel optiuneInapoi;
        public Button inapoi;
        public Label imageInapoi;

        // persoane-admin
        CheckBox adaugaPersoanaCarte;
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
        Panel optiuneAdauga;
        Label imageAdd;
        Button adaugaPersoanaButton;


        CheckBox getFullDatePersoanaCarte;
        DataGridView zonaDatePersoane;


        CheckBox getDateDupaCriteriuPersoanaCarte;

        




        public AdminMenu() {


            menu = new Panel() { Visible = false };
            menu.Size = new Size(950, 1050);

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
            radioPersoane.CheckedChanged += RadioChecked;

            optiuneInapoi = new Panel() { Visible = true, Size = new Size(350, 54) };
            optiuneInapoi.Location = new Point(23, 0);


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
            inapoi.MouseEnter += InapoiMouseEnter;
            inapoi.MouseLeave += InapoiMouseLeave;
            inapoi.MouseClick += InapoiMouseClick;

            imageInapoi = new Label() { Visible = true };
            imageInapoi.Size = new Size(26, 26);
            imageInapoi.Image = Image.FromFile(@"C:\Users\bogat\source\repos\newProiectPIU\Images\inapoiDefault.png");
            imageInapoi.Location = new Point(0, 0);
            imageInapoi.MouseEnter += InapoiMouseEnter;
            imageInapoi.MouseLeave += InapoiMouseLeave;
            imageInapoi.Click += InapoiMouseClick;

            optiuneInapoi.Controls.Add(inapoi);
            optiuneInapoi.Controls.Add(imageInapoi);


            optiuniText = new Label() { Visible = true, Text = "Optiuni:" };
            optiuniText.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
            optiuniText.Location = new Point(480, 300);
            optiuniText.Size = new Size(75, 30);

           

            adaugaPersoanaCarte = new CheckBox() { Visible = true, Text = "Adauga persoana" };
            adaugaPersoanaCarte.Font = new Font("Nirmala UI", 10, FontStyle.Regular);
            adaugaPersoanaCarte.Location = new Point(optiuniText.Location.X + optiuniText.Width, optiuniText.Location.Y);
            adaugaPersoanaCarte.Size = new Size(135, 24);
            adaugaPersoanaCarte.CheckedChanged += AdaugaPersoana_CheckedChanged;

            adaugaPersoanaOptiuneText = new Label() { Visible = false, Text = "Adauga persoana" };
            adaugaPersoanaOptiuneText.Font = new Font("Nirmala UI", 15, FontStyle.Bold);
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



            tipPersoanaText = new Label() { Visible = false, Size = new Size(80, 30) };
            tipPersoanaText.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
            tipPersoanaText.Text = "Statut:";
            tipPersoanaText.Location = new Point(prenumePersoanaText.Location.X, prenumePersoanaText.Location.Y + prenumePersoanaText.Height);

            studentProfesorBibliotecar = new ComboBox() { Visible = false, Size = new Size(80, 40) };
            studentProfesorBibliotecar.Font = new Font("Nirmala UI", 10, FontStyle.Regular);
            studentProfesorBibliotecar.Text = "Tipul";
            studentProfesorBibliotecar.Items.Add("Student");
            studentProfesorBibliotecar.Items.Add("Profesor");
            studentProfesorBibliotecar.Items.Add("Bibliotecar");
            studentProfesorBibliotecar.Location = new Point(prenumePersoanaTextBox.Location.X, tipPersoanaText.Location.Y);


            dataNasteriiPersoanaText = new Label() { Visible = false, Size = new Size(120, 30) };
            dataNasteriiPersoanaText.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
            dataNasteriiPersoanaText.Text = "Data nasterii:";
            dataNasteriiPersoanaText.Location = new Point(tipPersoanaText.Location.X, tipPersoanaText.Location.Y + tipPersoanaText.Height);

            dataZiua = new ComboBox() { Visible = false, Size = new Size(40, 40) };
            dataZiua.Font = new Font("Nirmala UI", 10, FontStyle.Regular);
            
            for(int i = 1; i <= 31; i++) {

                string ziua = string.Empty;

                if (i < 10) {

                    ziua = "0" + i.ToString();
                }

                else ziua = i.ToString();

                dataZiua.Items.Add(ziua);
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



            optiuneAdauga = new Panel() { Visible = true, Size = new Size(350, 54) };
            optiuneAdauga.Location = new Point(95, 575);;

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
            adaugaPersoanaButton.Font = new Font("Nirmala UI", 15, FontStyle.Bold);
            adaugaPersoanaButton.Location = new Point(0, 0);
            adaugaPersoanaButton.Size = new Size(90, 35);
            adaugaPersoanaButton.MouseEnter += AdaugaMouseEnter;
            adaugaPersoanaButton.MouseLeave += AdaugaMouseLeave;
            adaugaPersoanaButton.MouseClick += AdaugaMouseClick;


            imageAdd = new Label() { Visible = false };
            imageAdd.Size = new Size(26, 26);
            imageAdd.Image = Image.FromFile(@"C:\Users\bogat\source\repos\newProiectPIU\Images\addDefault.png");
            imageAdd.Location = new Point(adaugaPersoanaButton.Width, 7);
            imageAdd.MouseEnter += AdaugaMouseEnter;
            imageAdd.MouseLeave += AdaugaMouseLeave;
            imageAdd.MouseClick += AdaugaMouseClick;


            optiuneAdauga.Controls.Add(imageAdd);
            optiuneAdauga.Controls.Add(adaugaPersoanaButton);




            getFullDatePersoanaCarte = new CheckBox() { Visible = true, Text = "Afisare persoane" };
            getFullDatePersoanaCarte.Font = new Font("Nirmala UI", 10, FontStyle.Regular);
            getFullDatePersoanaCarte.Location = new Point(adaugaPersoanaCarte.Location.X, adaugaPersoanaCarte.Location.Y + adaugaPersoanaCarte.Height);
            getFullDatePersoanaCarte.Size = new Size(180, 24);
            getFullDatePersoanaCarte.CheckedChanged += GetFullDateCheckedChanged;



            zonaDatePersoane = new DataGridView() { Visible = false, Size = new Size(460, 150) };
            zonaDatePersoane.AllowUserToAddRows = true;
            zonaDatePersoane.AllowUserToDeleteRows = true;
            zonaDatePersoane.Columns.Add(new DataGridViewTextBoxColumn() { Visible = true, HeaderText = "Nume" });
            zonaDatePersoane.Columns.Add(new DataGridViewTextBoxColumn() { Visible = true, HeaderText = "Prenume"});
            zonaDatePersoane.Columns.Add(new DataGridViewTextBoxColumn() { Visible = true, HeaderText = "Statut" });
            zonaDatePersoane.Columns.Add(new DataGridViewTextBoxColumn() { Visible = true, HeaderText = "Data nasterii" });
            //zonaDatePersoane.ColumnHeadersDefaultCellStyle.BackColor = Color.Purple;
            zonaDatePersoane.Location = new Point(300, 400);
            zonaDatePersoane.BackgroundColor = Color.FromArgb(255, 246, 205);
            zonaDatePersoane.BorderStyle = BorderStyle.None;






            getDateDupaCriteriuPersoanaCarte = new CheckBox() { Visible = true, Text = "Cautare dupa nume" };
            getDateDupaCriteriuPersoanaCarte.Font = new Font("Nirmala UI", 10, FontStyle.Regular);
            getDateDupaCriteriuPersoanaCarte.Location = new Point(getFullDatePersoanaCarte.Location.X, getFullDatePersoanaCarte.Location.Y + getFullDatePersoanaCarte.Height);
            getDateDupaCriteriuPersoanaCarte.Size = new Size(180, 24);



            menu.Controls.Add(logo);
            menu.Controls.Add(radioCarti);
            menu.Controls.Add(radioPersoane);
            menu.Controls.Add(optiuneInapoi);
            menu.Controls.Add(administrareText);
            menu.Controls.Add(optiuniText);
            menu.Controls.Add(adaugaPersoanaCarte);
            menu.Controls.Add(adaugaPersoanaOptiuneText);
            menu.Controls.Add(getFullDatePersoanaCarte);
            menu.Controls.Add(numePersoanaText);
            menu.Controls.Add(numePersoanaTextBox);
            menu.Controls.Add(prenumePersoanaText);
            menu.Controls.Add(prenumePersoanaTextBox);
            menu.Controls.Add(getDateDupaCriteriuPersoanaCarte);
            menu.Controls.Add(dataNasteriiPersoanaText);
            menu.Controls.Add(dataZiua);
            menu.Controls.Add(dataLuna);
            menu.Controls.Add(dataAnul);
            menu.Controls.Add(tipPersoanaText);
            menu.Controls.Add(studentProfesorBibliotecar);
            menu.Controls.Add(optiuneAdauga);
            menu.Controls.Add(zonaDatePersoane);

        }

        private void RadioChecked(object sender, EventArgs e) {
            
            if((sender as RadioButton).Checked) {

                administrareVarianta = AdministrareVarianta.Persoane;
                adaugaPersoanaCarte.Text = "Adauga persoana";
                getFullDatePersoanaCarte.Text = "Afisare persoane";
                getDateDupaCriteriuPersoanaCarte.Text = "Cautare dupa nume";
                adaugaPersoanaCarte.Checked = false;
                getDateDupaCriteriuPersoanaCarte.Checked = false;
                getFullDatePersoanaCarte.Checked = false;
               
            }

            else if (!(sender as RadioButton).Checked) {

                administrareVarianta = AdministrareVarianta.Carti;
                adaugaPersoanaCarte.Text = "Adauga carte";
                getFullDatePersoanaCarte.Text = "Afisare carti";
                getDateDupaCriteriuPersoanaCarte.Text = "Cautare dupa autor";
                adaugaPersoanaCarte.Checked = false;
                getDateDupaCriteriuPersoanaCarte.Checked = false;
                getFullDatePersoanaCarte.Checked = false;

            }
        }

        private void AdaugaMouseEnter(object sender, EventArgs e) {

            Panel parent = null;

            (sender as Control).Cursor = Cursors.Hand;
            parent = (sender as Control).Parent as Panel;

            foreach (var i in parent.Controls) {

                if (i is Label) (i as Label).Image = Image.FromFile(@"C:\Users\bogat\source\repos\newProiectPIU\Images\addFocused.png");
                else if (i is Button) (i as Button).ForeColor = FirstMenu.changedColor;
            }
        }


        private void AdaugaMouseLeave(object sender, EventArgs e) {

            Panel parent = null;

            (sender as Control).Cursor = Cursors.Default;
            parent = (sender as Control).Parent as Panel;

            foreach (var i in parent.Controls) {

                if (i is Label) (i as Label).Image = Image.FromFile(@"C:\Users\bogat\source\repos\newProiectPIU\Images\addDefault.png");
                else if (i is Button) (i as Button).ForeColor = Color.Black;
            }
        }


        private void AdaugaMouseClick(object sender, EventArgs e) {

            string nume = numePersoanaTextBox.Text;
            string prenume = prenumePersoanaTextBox.Text;
            string statut = studentProfesorBibliotecar.Text;
            string dataNasterii = dataZiua.Text + "/" + dataLuna.Text + "/" + dataAnul.Text;

            numePersoanaTextBox.Clear();
            prenumePersoanaTextBox.Clear();
            studentProfesorBibliotecar.Text = "Tip";
            dataZiua.Text = "ZZ";
            dataLuna.Text = "LL";
            dataAnul.Text = "AAAA";


            AdministrarePersoane_FisierText.AdaugarePersoana(nume, prenume, statut, dataNasterii);
            AdministrarePersoane_FisierText.GetFullDate(zonaDatePersoane);

            
        }


        private void InapoiMouseEnter(object sender, EventArgs e) {

            Panel parent = null;

            (sender as Control).Cursor = Cursors.Hand;
            parent = (sender as Control).Parent as Panel;

            foreach (var i in parent.Controls) {

                if (i is Label) (i as Label).Image = Image.FromFile(@"C:\Users\bogat\source\repos\newProiectPIU\Images\inapoiFocused.png");
                else if (i is Button) (i as Button).ForeColor = FirstMenu.changedColor;
            }
        }



        private void InapoiMouseLeave(object sender, EventArgs e) {

            Panel parent = null;

            (sender as Control).Cursor = Cursors.Default;
            parent = (sender as Control).Parent as Panel;

            foreach (var i in parent.Controls) {

                if (i is Label) (i as Label).Image = Image.FromFile(@"C:\Users\bogat\source\repos\newProiectPIU\Images\inapoiDefault.png");
                else if (i is Button) (i as Button).ForeColor = Color.Black;
            }
        }


        private void InapoiMouseClick(object sender, EventArgs e) {

            menu.Visible = false;
            FirstMenu.menu.Visible = true;
        }



       
        private void AdaugaPersoana_CheckedChanged(object sender, EventArgs e) {
            
            if(adaugaPersoanaCarte.Checked == true && administrareVarianta == AdministrareVarianta.Persoane) {

                numePersoanaText.Visible = true;
                numePersoanaTextBox.Visible = true;
                prenumePersoanaText.Visible = true;
                prenumePersoanaTextBox.Visible = true;
                dataNasteriiPersoanaText.Visible = true;
                dataZiua.Visible = true;
                dataLuna.Visible = true;
                dataAnul.Visible = true;
                adaugaPersoanaOptiuneText.Visible = true;
                tipPersoanaText.Visible = true;
                studentProfesorBibliotecar.Visible = true;
                

                foreach (var i in optiuneAdauga.Controls) (i as Control).Visible = true;
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
                tipPersoanaText.Visible = false;
                studentProfesorBibliotecar.Visible = false;
                foreach (var i in optiuneAdauga.Controls) (i as Control).Visible = false;
            }
        }


        private void GetFullDateCheckedChanged(object sender, EventArgs e) {

            if (getFullDatePersoanaCarte.Checked && administrareVarianta == AdministrareVarianta.Persoane) {
                zonaDatePersoane.Visible = true;
            }

            else {

                zonaDatePersoane.Visible = false;
            }
        }


       

      
    }
}

