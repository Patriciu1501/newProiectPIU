using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newProiectPIU {

   
    public partial class Form1 : Form {



        private FirstMenu firstMenu;
        private AdminMenu adminMenu;
            

        public Form1() {

            firstMenu = new FirstMenu();
            adminMenu = new AdminMenu();
            BackColor = Color.FromArgb(255, 246, 205);
            Size = new Size(900, 700);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Text = "Biblioteca";
           
            Controls.Add(FirstMenu.menu);
            Controls.Add(AdminMenu.menu);
            
        }



        
    }
}
