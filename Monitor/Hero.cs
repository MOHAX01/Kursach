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
    public partial class Hero : Form
    {
        public Hero()
        {
            InitializeComponent();
            Person.Proc();
            
        }
        public int current=0;
        public int gender=0;
        public string Pic;




        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

            current++;
            switch (gender)
            {
                case 0:
                    {
                        Pic = Person.person[current].NamePicM;
                        break;
                    }
                case 1:
                    {
                        Pic = Person.person[current].NamePicF;
                        break;
                    }
            }
            pictureBox1 = BasePic.Person.person[current].NamePicM;
            Person.person[current];
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
