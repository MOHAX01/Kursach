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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasePic));
        public Hero()
        {
            InitializeComponent();
            Person.Proc();
            Pic = Person.person[current].NamePicM;
            pictureBox1.Image = ((Image)(resources.GetObject(Pic)));
            label1.Text = Person.person[current].NameHero;
            label2.Text = Person.person[current].InfoM;
            label3.Text = "Hp: " + Convert.ToString(Person.person[current].HpHero);
            label4.Text = "Attack: " + Convert.ToString(Person.person[current].AttackHero);
        }
        public int current=0;
        public int gender=0;
        public string Pic;
        public string info;




        private void button1_Click(object sender, EventArgs e)
        {
            if (current >= Person.person.Length - 1) current = 0;
            else current++;
            switch (gender)
            {
                case 0:
                    {
                        Pic = Person.person[current].NamePicM;
                        info = Person.person[current].InfoM;
                        break;
                    }
                case 1:
                    {
                        Pic = Person.person[current].NamePicF;
                        info = Person.person[current].InfoF;
                        break;
                    }
            }
            pictureBox1.Image = ((Image)(resources.GetObject(Pic)));
            label1.Text = Person.person[current].NameHero;
            label2.Text = info;
            label3.Text = "Hp: " + Convert.ToString(Person.person[current].HpHero);
            label4.Text = "Attack: " + Convert.ToString(Person.person[current].AttackHero);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (current == 0 ) current = Person.person.Length - 1;
            else current--;
            switch (gender)
            {
                case 0:
                    {
                        Pic = Person.person[current].NamePicM;
                        info = Person.person[current].InfoM;
                        break;
                    }
                case 1:
                    {
                        Pic = Person.person[current].NamePicF;
                        info = Person.person[current].InfoF;
                        break;
                    }
            }
            pictureBox1.Image = ((Image)(resources.GetObject(Pic)));
            label1.Text = Person.person[current].NameHero;
            label2.Text = info;
            label3.Text = "Hp: " + Convert.ToString(Person.person[current].HpHero);
            label4.Text = "Attack: " + Convert.ToString(Person.person[current].AttackHero);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DataBase.Sel_Hero(current, gender);

            this.Hide();
            MainGame Window = new MainGame();
            Window.WindowState = this.WindowState;
            Window.Show();
            Window.Starter();
            Window.ChangeBackground();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gender = 0;
            Pic = Person.person[current].NamePicM;
            info = Person.person[current].InfoM;
            pictureBox1.Image = ((Image)(resources.GetObject(Pic)));
            label2.Text= info;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gender = 1;
            Pic = Person.person[current].NamePicF;
            info = Person.person[current].InfoF;
            pictureBox1.Image = ((Image)(resources.GetObject(Pic)));
            label2.Text= info;
        }
    }
}
