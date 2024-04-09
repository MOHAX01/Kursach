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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monsters));
        public Change_Character()
        {
            InitializeComponent();
        }
        private int GenderWarrior=1;
        private int GenderAssasin=1;
        private int GenderWizard=1;
        private int GenderSummoner=1;
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
            DataBase.PicCharapter = DataBase.ChangePerson(GenderWarrior,1);
            DataBase.Warrior();

            this.Hide();
            MainGame Window = new MainGame();
            Window.WindowState = this.WindowState;
            Window.Show();
            Window.Starter();
            Window.ChangeBackground();
            DataBase.Score = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataBase.PicCharapter = DataBase.ChangePerson(GenderAssasin,2);
            DataBase.Assasin();

            this.Hide();
            MainGame Window = new MainGame();
            Window.WindowState = this.WindowState;
            Window.Show();
            Window.Starter();
            Window.ChangeBackground();
            DataBase.Score = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataBase.PicCharapter = DataBase.ChangePerson(GenderWizard,3);
            DataBase.Wizard();

            this.Hide();
            MainGame Window = new MainGame();
            Window.WindowState = this.WindowState;
            Window.Show();
            Window.Starter();
            Window.ChangeBackground();
            DataBase.Score = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataBase.PicCharapter = DataBase.ChangePerson(GenderSummoner,4);
            DataBase.None();

            this.Hide();
            MainGame Window = new MainGame();
            Window.WindowState = this.WindowState;
            Window.Show();
            Window.Starter();
            Window.ChangeBackground();
            DataBase.Score = 0;
        }

        private void Change_Character_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            DataBase.PicCharapter = DataBase.ChangePerson(GenderWarrior, 1); ;
            DataBase.Warrior();

            this.Hide();
            MainGame Window = new MainGame();
            Window.WindowState = this.WindowState;
            Window.Show();
            Window.Starter();
            Window.ChangeBackground();
            DataBase.Score = 0;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            DataBase.PicCharapter = DataBase.ChangePerson(GenderAssasin, 2);
            DataBase.Assasin();

            this.Hide();
            MainGame Window = new MainGame();
            Window.WindowState = this.WindowState;
            Window.Show();
            Window.Starter();
            Window.ChangeBackground();
            DataBase.Score = 0;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            DataBase.PicCharapter = DataBase.ChangePerson(GenderWizard,3);
            DataBase.Wizard();

            this.Hide();
            MainGame Window = new MainGame();
            Window.WindowState = this.WindowState;
            Window.Show();
            Window.Starter();
            Window.ChangeBackground();
            DataBase.Score = 0;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            DataBase.PicCharapter = DataBase.ChangePerson(GenderSummoner, 4);
            DataBase.None();

            this.Hide();
            MainGame Window = new MainGame();
            Window.WindowState = this.WindowState;
            Window.Show();
            Window.Starter();
            Window.ChangeBackground();
            DataBase.Score = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DataBase.PicCharapter = DataBase.ChangePerson(GenderWarrior, 1); ;
            DataBase.Warrior();

            this.Hide();
            MainGame Window = new MainGame();
            Window.WindowState = this.WindowState;
            Window.Show();
            Window.Starter();
            Window.ChangeBackground();
            DataBase.Score = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DataBase.PicCharapter = DataBase.ChangePerson(GenderAssasin, 2);
            DataBase.Assasin();

            this.Hide();
            MainGame Window = new MainGame();
            Window.WindowState = this.WindowState;
            Window.Show();
            Window.Starter();
            Window.ChangeBackground();
            DataBase.Score = 0;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DataBase.PicCharapter = DataBase.ChangePerson(GenderWizard, 3);
            DataBase.Wizard();

            this.Hide();
            MainGame Window = new MainGame();
            Window.WindowState = this.WindowState;
            Window.Show();
            Window.Starter();
            Window.ChangeBackground();
            DataBase.Score = 0;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DataBase.PicCharapter = DataBase.ChangePerson(GenderSummoner, 4);
            DataBase.None();

            this.Hide();
            MainGame Window = new MainGame();
            Window.WindowState = this.WindowState;
            Window.Show();
            Window.Starter();
            Window.ChangeBackground();
            DataBase.Score = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ((Image)(resources.GetObject("WarriorMale")));
            GenderWarrior = 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ((Image)(resources.GetObject("WarriorFemale")));
            GenderWarrior = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = ((Image)(resources.GetObject("AssasinMale")));
            GenderAssasin = 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = ((Image)(resources.GetObject("AssasinFemale")));
            GenderAssasin = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = ((Image)(resources.GetObject("WizardMale")));
            GenderWizard = 1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = ((Image)(resources.GetObject("WizardFemale")));
            GenderWizard = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = ((Image)(resources.GetObject("SummonerMale")));
            GenderSummoner = 1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = ((Image)(resources.GetObject("SummonerFemale")));
            GenderSummoner = 0;
        }

        private void Change_Character_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
