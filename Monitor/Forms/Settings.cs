using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitor.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            DataBase.Flag = 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        { 
            foreach(Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(Menu))
                {
                    f.Hide();
                }
                else f.Show();
            }

            //Menu win = new Menu();
            //win.Show();
        }
    }
}
