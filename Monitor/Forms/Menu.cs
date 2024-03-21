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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            Animator.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Form1 Window = new Form1();
            //Window.Show();

            Change_Dif Window = new Change_Dif();
            Window.WindowState = this.WindowState;
            Window.Show();

            //Application.Run(new Form1());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
