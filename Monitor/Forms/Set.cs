using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monitor.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WMPLib;
using Monitor.Properties;
using System.Resources;

namespace Monitor.Forms
{
    public partial class Set : Form
    {
        ComponentResourceManager resources = new ComponentResourceManager(typeof(BasePic));
        public Set()
        {
            InitializeComponent();
            DataBase.FlagClose = 0;


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {         
            DataBase.FlagSetting = 1;
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {          
            //Application.Restart();
            DataBase.FlagClose = 1;
            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }      



        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button5.BackgroundImage = ((Image)(resources.GetObject("ON")));
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button5.BackgroundImage = ((Image)(resources.GetObject("OFF")));
        }
        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackgroundImage = ((Image)(resources.GetObject("ON")));
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackgroundImage = ((Image)(resources.GetObject("OFF")));
        }
        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BackgroundImage = ((Image)(resources.GetObject("ON")));
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackgroundImage = ((Image)(resources.GetObject("OFF")));
        }
    }
}
