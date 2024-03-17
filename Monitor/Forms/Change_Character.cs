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
    public partial class Change_Character : Form
    {
        public Change_Character()
        {
            InitializeComponent();
        }

        private void label5_Text()
        {
            DataBase.Warrior();
            label5.Text = "HP: " + DataBase.HPCharacter;
        }
        private void label6_Text()
        {
            DataBase.Warrior();
            label6.Text = "Attack: " + DataBase.AttackCharacter;
        }

        private void label7_Text()
        {
            DataBase.Assasin();
            label7.Text = "HP: " + DataBase.HPCharacter;
        }
        private void label8_Text()
        {
            DataBase.Assasin();
            label8.Text = "Attack: " + DataBase.AttackCharacter;
        }

        private void label9_Text()
        {
            DataBase.Wizard();
            label9.Text = "HP: " + DataBase.HPCharacter;
        }
        private void label10_Text()
        {
            DataBase.Wizard();
            label10.Text = "Attack: " + DataBase.AttackCharacter;
        }

        private void label11_Text()
        {
            DataBase.None();
            label11.Text = "HP: " + DataBase.HPCharacter;
        }
        private void label12_Text()
        {
            DataBase.None();
            label12.Text = "Attack: " + DataBase.AttackCharacter;
        }

        public void Star_Label()
        {
            label5_Text();
            label6_Text();
            label7_Text();
            label8_Text();
            label9_Text();
            label10_Text();
            label11_Text();
            label12_Text();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            DataBase.PicCharapter = DataBase.PicWarrior;


            this.Hide();
            MainGame Window = new MainGame();
            Window.Show();
            Window.chlen();
            Window.ChangeBackground();
            DataBase.Score = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataBase.PicCharapter = DataBase.PicAssasin;

            this.Hide();
            MainGame Window = new MainGame();
            Window.Show();
            Window.chlen();
            Window.ChangeBackground();
            DataBase.Score = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataBase.PicCharapter = DataBase.PicWizzard;

            this.Hide();
            MainGame Window = new MainGame();
            Window.Show();
            Window.chlen();
            Window.ChangeBackground();
            DataBase.Score = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataBase.PicCharapter = DataBase.PicNone;

            this.Hide();
            MainGame Window = new MainGame();
            Window.Show();
            Window.chlen();
            Window.ChangeBackground();
            DataBase.Score = 0;
        }

        private void Change_Character_Load(object sender, EventArgs e)
        {

        }
    }
}
