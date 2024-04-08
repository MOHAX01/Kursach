using Monitor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitor
{
    
    public partial class Change_Dif : Form
    {
        public Change_Dif()
        {
            InitializeComponent();
        }

        private void card1_Click(object sender, EventArgs e)
        {
            DataBase.Dificult = 1;
            this.Hide();

            Change_Character window = new Change_Character();
            window.WindowState = this.WindowState;
            window.Show();
            window.Star_Label();
        }

        private void card2_Click(object sender, EventArgs e)
        {
            DataBase.Dificult = 2; 
            this.Hide();

            Change_Character window = new Change_Character();
            window.WindowState = this.WindowState;
            window.Show();
            window.Star_Label();
        }

        private void card3_Click(object sender, EventArgs e)
        {
            DataBase.Dificult = 3;
            this.Hide();

            Change_Character window = new Change_Character();
            window.WindowState = this.WindowState;
            window.Show();
            window.Star_Label();
        }

        private void Change_Dif_Load(object sender, EventArgs e)
        {

        }

        private void Change_Dif_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Change_Dif_Deactivate(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
