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
    public partial class Game_result : Form
    {
        public Game_result()
        {
            InitializeComponent();
            label1.Text = "Score: " + DataBase.Score.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu menuWindow = new Menu();
            menuWindow.WindowState = this.WindowState;
            menuWindow.Show();
            
        }
    }
}
