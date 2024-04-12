using Monitor.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathGen;
using Monitor.Forms;
using System.Diagnostics.Tracing;
using Monitor;
using System.Reflection.Emit;

namespace Monitor
{
    public partial class MainGame : Form
    {
        public Random random = new Random();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasePic));
        public MainGame()
        {

            InitializeComponent();
            DataBase.FlagSetting = 1;
            panel2.BackgroundImage = ((Image)(resources.GetObject(DataBase.PicCharapter)));
            pictureBox2.Visible= false;
            string m = Convert.ToString(random.Next(1, 35));
            panel3.BackgroundImage = ((Image)(resources.GetObject($"Enemy{m}")));
            DataBase.Timer();
            label1.Text = Convert.ToString(DataBase.HPCharacter);
            label2.Text = Convert.ToString(DataBase.HPEnemy);
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
            



            if (Convert.ToInt32(label1.Text) > 0)
            {
                ChangeBackground();
                Starter();
            }


        }

        int startValue = DataBase.Time;
        int statusValue = 0;


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            DataBase.FlagSetting = 0;
            timer1.Stop();
            timer1.Dispose();
            Set window = new Set();
            window.ShowDialog();
            if(DataBase.FlagClose == 1)
            {
                Menu win = new Menu();
                win.Show();
                this.Hide();
            }
            else
            {
                DataBase.FlagSetting = 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Point lastPoint;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3 = null;
        }

        public void Starter()
        {
            DataBase.FlagButton = 1;
            if ( DataBase.HPCharacter > 0 )
            {
                startValue = DataBase.Time;
            }

            int correctAnswer;
            int InCorrectAnswer1;
            int InCorrectAnswer2;
            string exem;
            MathGenerator game = new MathGenerator();

            if (DataBase.HPEnemy > 0 && DataBase.HPCharacter > 0)
            {
                game.GenerateQuiz(DataBase.Dificult, out correctAnswer, out InCorrectAnswer1, out InCorrectAnswer2, out exem);
                label3.Text = exem;
                DataBase.CorrectAnswer = correctAnswer;
                DataBase.InCorrectAnswer1 = InCorrectAnswer1;
                DataBase.InCorrectAnswer2 = InCorrectAnswer2;

                DataBase.Answers[0] = Convert.ToInt32(DataBase.CorrectAnswer);
                DataBase.Answers[1] = Convert.ToInt32(DataBase.InCorrectAnswer1);
                DataBase.Answers[2] = Convert.ToInt32(DataBase.InCorrectAnswer2);

                int F = random.Next(0, 3);
                string FirstAnswer = Convert.ToString(DataBase.Answers[F]);


                button1.Text = FirstAnswer;
                button1.Update();
                button1.Refresh();

                int S = random.Next(0, 3);
                while (S == F)
                {
                    S = random.Next(0, 3);
                }
                string SecondAnswer = Convert.ToString(DataBase.Answers[S]);


                button2.Text = SecondAnswer;
                button2.Update();
                button2.Refresh();


                int T = random.Next(0, 3);
                while (T == S || T == F)
                {
                    T = random.Next(0, 3);
                }
                string ThirdAnswer = Convert.ToString(DataBase.Answers[T]);


                button3.Text = ThirdAnswer;
                button3.Update();
                button3.Refresh();

                label4.Text = "Score: " + Convert.ToString(DataBase.Score);
            }
            else 
            {
                if (DataBase.HPCharacter > 0)
                {
                    statusValue = 3;
                    DataBase.FlagButton = 0;
                    progressBar2.Value = 0;
                }
                else
                {
                    DataBase.FlagSetting = 0;
                    timer1.Stop();
                    this.Hide();
                    Game_result win = new Game_result();
                    win.WindowState = this.WindowState;
                    win.Show();

                }
            }
            
        }

        public void ChangeBackground()
        {
            if (DataBase.Dificult == 1)
            {
                int v = random.Next(0, 4);
                string m = Convert.ToString(random.Next(1, 35));
                switch (v)
                {
                    case 1:
                        this.BackgroundImage = ((Image)(resources.GetObject(DataBase.BackEasy1)));
                        panel3.BackgroundImage = ((Image)(resources.GetObject($"Enemy{m}")));
                        label2.Text = Convert.ToString(DataBase.StaticHPEnemy);
                        DataBase.HPEnemy = DataBase.StaticHPEnemy;
                        progressBar2.Value = 100;
                        break;
                    case 2:
                        this.BackgroundImage = ((Image)(resources.GetObject(DataBase.BackEasy2)));
                        panel3.BackgroundImage = ((Image)(resources.GetObject($"Enemy{m}")));
                        label2.Text = Convert.ToString(DataBase.StaticHPEnemy);
                        DataBase.HPEnemy = DataBase.StaticHPEnemy;
                        progressBar2.Value = 100;
                        break;
                    case 3:
                        this.BackgroundImage = ((Image)(resources.GetObject(DataBase.BackEasy3)));
                        panel3.BackgroundImage = ((Image)(resources.GetObject($"Enemy{m}")));
                        label2.Text = Convert.ToString(DataBase.StaticHPEnemy);
                        DataBase.HPEnemy = DataBase.StaticHPEnemy;
                        progressBar2.Value = 100;
                        break;
                    case 4:
                        this.BackgroundImage = ((Image)(resources.GetObject(DataBase.BackEasy4)));
                        panel3.BackgroundImage = ((Image)(resources.GetObject($"Enemy{m}")));
                        label2.Text = Convert.ToString(DataBase.StaticHPEnemy);
                        DataBase.HPEnemy = DataBase.StaticHPEnemy;
                        progressBar2.Value = 100;
                        break;
                }
            }
            if (DataBase.Dificult == 2)
            {
                int v = random.Next(0, 5);
                string m = Convert.ToString(random.Next(1, 35));
                switch (v)
                {
                    case 1:
                        this.BackgroundImage = ((Image)(resources.GetObject(DataBase.BackNorm1)));
                        panel3.BackgroundImage = ((Image)(resources.GetObject($"Enemy{m}")));
                        label2.Text = Convert.ToString(DataBase.StaticHPEnemy);
                        DataBase.HPEnemy = DataBase.StaticHPEnemy;
                        progressBar2.Value = 100;
                        break;
                    case 2:
                        this.BackgroundImage = ((Image)(resources.GetObject(DataBase.BackNorm2)));
                        panel3.BackgroundImage = ((Image)(resources.GetObject($"Enemy{m}")));
                        label2.Text = Convert.ToString(DataBase.StaticHPEnemy);
                        DataBase.HPEnemy = DataBase.StaticHPEnemy;
                        progressBar2.Value = 100;
                        break;
                    case 3:
                        this.BackgroundImage = ((Image)(resources.GetObject(DataBase.BackNorm3)));
                        panel3.BackgroundImage = ((Image)(resources.GetObject($"Enemy{m}")));
                        label2.Text = Convert.ToString(DataBase.StaticHPEnemy);
                        DataBase.HPEnemy = DataBase.StaticHPEnemy;
                        progressBar2.Value = 100;
                        break;
                    case 4:
                        this.BackgroundImage = ((Image)(resources.GetObject(DataBase.BackNorm4)));
                        panel3.BackgroundImage = ((Image)(resources.GetObject($"Enemy{m}")));
                        label2.Text = Convert.ToString(DataBase.StaticHPEnemy);
                        DataBase.HPEnemy = DataBase.StaticHPEnemy;
                        progressBar2.Value = 100;
                        break;
                    case 5:
                        this.BackgroundImage = ((Image)(resources.GetObject(DataBase.BackNorm5)));
                        panel3.BackgroundImage = ((Image)(resources.GetObject($"Enemy{m}")));
                        label2.Text = Convert.ToString(DataBase.StaticHPEnemy);
                        DataBase.HPEnemy = DataBase.StaticHPEnemy;
                        progressBar2.Value = 100;
                        break;
                }
            }
            if (DataBase.Dificult == 3)
            {
                int v = random.Next(0, 6);
                string m = Convert.ToString(random.Next(1, 35));
                switch (v)
                {
                    case 1:
                        this.BackgroundImage = ((Image)(resources.GetObject(DataBase.BackHard1)));
                        panel3.BackgroundImage = ((Image)(resources.GetObject($"Enemy{m}")));
                        label2.Text = Convert.ToString(DataBase.StaticHPEnemy);
                        DataBase.HPEnemy = DataBase.StaticHPEnemy;
                        progressBar2.Value = 100;
                        break;
                    case 2:
                        this.BackgroundImage = ((Image)(resources.GetObject(DataBase.BackHard2)));
                        panel3.BackgroundImage = ((Image)(resources.GetObject($"Enemy{m}")));
                        label2.Text = Convert.ToString(DataBase.StaticHPEnemy);
                        DataBase.HPEnemy = DataBase.StaticHPEnemy;
                        progressBar2.Value = 100;
                        break;
                    case 3:
                        this.BackgroundImage = ((Image)(resources.GetObject(DataBase.BackHard3)));
                        panel3.BackgroundImage = ((Image)(resources.GetObject($"Enemy{m}")));
                        label2.Text = Convert.ToString(DataBase.StaticHPEnemy);
                        DataBase.HPEnemy = DataBase.StaticHPEnemy;
                        progressBar2.Value = 100;
                        break;
                    case 4:
                        this.BackgroundImage = ((Image)(resources.GetObject(DataBase.BackHard4)));
                        panel3.BackgroundImage = ((Image)(resources.GetObject($"Enemy{m}")));
                        label2.Text = Convert.ToString(DataBase.StaticHPEnemy);
                        DataBase.HPEnemy = DataBase.StaticHPEnemy;
                        progressBar2.Value = 100;
                        break;
                    case 5:
                        this.BackgroundImage = ((Image)(resources.GetObject(DataBase.BackHard5)));
                        panel3.BackgroundImage = ((Image)(resources.GetObject($"Enemy{m}")));
                        label2.Text = Convert.ToString(DataBase.StaticHPEnemy);
                        DataBase.HPEnemy = DataBase.StaticHPEnemy;
                        progressBar2.Value = 100;
                        break;
                    case 6:
                        this.BackgroundImage = ((Image)(resources.GetObject(DataBase.BackHard6)));
                        panel3.BackgroundImage = ((Image)(resources.GetObject($"Enemy{m}")));
                        label2.Text = Convert.ToString(DataBase.StaticHPEnemy);
                        DataBase.HPEnemy = DataBase.StaticHPEnemy;
                        progressBar2.Value = 100;
                        break;
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (DataBase.FlagButton == 1)
            {
                if (button1.Text == Convert.ToString(DataBase.CorrectAnswer))
                {
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - DataBase.AttackCharacter);
                    DataBase.HPEnemy = Convert.ToInt32(label2.Text);
                    DataBase.Score += DataBase.Dificult;
                    if (DataBase.HPEnemy > 0)
                    {
                        progressBar2.Value = Convert.ToInt32(((Convert.ToDouble(DataBase.HPEnemy) / Convert.ToDouble(DataBase.StaticHPEnemy)) * 100));
                    }
                    else
                    {
                        progressBar2.Value = 0;
                    }
                }
                else
                {
                    label1.Text = Convert.ToString(Convert.ToInt32(label1.Text) - DataBase.AttackEnemy);
                    DataBase.HPCharacter -= DataBase.AttackEnemy;
                    if (DataBase.HPCharacter > 0)
                    {
                        progressBar1.Value = Convert.ToInt32((Convert.ToDouble(DataBase.HPCharacter) / Convert.ToDouble(DataBase.StaticHP)) * 100);
                    }
                    else
                    {
                        timer1.Stop();
                        //this.Close();
                    }
                }
                Starter();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DataBase.FlagButton == 1)
            {
                if (button2.Text == Convert.ToString(DataBase.CorrectAnswer))
                {
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - DataBase.AttackCharacter);
                    DataBase.HPEnemy = Convert.ToInt32(label2.Text);
                    DataBase.Score += DataBase.Dificult;
                    if (DataBase.HPEnemy > 0)
                    {
                        progressBar2.Value = Convert.ToInt32(((Convert.ToDouble(DataBase.HPEnemy) / Convert.ToDouble(DataBase.StaticHPEnemy)) * 100));
                    }
                    else
                    {
                        progressBar2.Value = 0;
                    }
                }
                else
                {
                    label1.Text = Convert.ToString(Convert.ToInt32(label1.Text) - DataBase.AttackEnemy);
                    DataBase.HPCharacter -= DataBase.AttackEnemy;
                    if (DataBase.HPCharacter > 0)
                    {
                        progressBar1.Value = Convert.ToInt32((Convert.ToDouble(DataBase.HPCharacter) / Convert.ToDouble(DataBase.StaticHP)) * 100);
                    }
                    else
                    {
                        timer1.Stop();
                        //this.Close();
                    }
                }
                Starter();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DataBase.FlagButton == 1)
            {
                if (button3.Text == Convert.ToString(DataBase.CorrectAnswer))
                {
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - DataBase.AttackCharacter);
                    DataBase.HPEnemy = Convert.ToInt32(label2.Text);
                    DataBase.Score += DataBase.Dificult;
                    if (DataBase.HPEnemy > 0)
                    {
                        progressBar2.Value = Convert.ToInt32(((Convert.ToDouble(DataBase.HPEnemy) / Convert.ToDouble(DataBase.StaticHPEnemy)) * 100));
                    }
                    else
                    {
                        progressBar2.Value = 0;
                    }
                }
                else
                {
                    label1.Text = Convert.ToString(Convert.ToInt32(label1.Text) - DataBase.AttackEnemy);
                    DataBase.HPCharacter -= DataBase.AttackEnemy;
                    if (DataBase.HPCharacter > 0)
                    {
                        progressBar1.Value = Convert.ToInt32((Convert.ToDouble(DataBase.HPCharacter) / Convert.ToDouble(DataBase.StaticHP)) * 100);
                    }
                    else
                    {
                        timer1.Stop();
                        //this.Close();
                    }
                }

                Starter();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DataBase.FlagButton == 1)
            {
                label1.Text = Convert.ToString(Convert.ToInt32(label1.Text) - (DataBase.AttackEnemy / 2));
                DataBase.HPCharacter -= DataBase.AttackEnemy / 2;
                if (DataBase.HPCharacter > 0)
                {
                    progressBar1.Value = Convert.ToInt32((Convert.ToDouble(DataBase.HPCharacter) / Convert.ToDouble(DataBase.StaticHP)) * 100);
                }
                else
                {
                    timer1.Stop();
                    //this.Close();
                }
                Starter();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DataBase.FlagSetting == 1)
            {

                if (startValue != 0 && statusValue == 0)
                {

                    pictureBox8.Image = null;
                    label5.Text = startValue.ToString();
                    startValue--;
                }
                else
                {
                    if (statusValue != 0)
                    {
                        pictureBox8.Image = (Image)(resources.GetObject("Win"));
                        statusValue--;
                    }
                    else
                    {
                        

                        label1.Text = Convert.ToString(Convert.ToInt32(label1.Text) - (DataBase.AttackEnemy / 2));
                        DataBase.HPCharacter -= DataBase.AttackEnemy / 2;
                        if (DataBase.HPCharacter > 0)
                        {
                            progressBar1.Value = Convert.ToInt32((Convert.ToDouble(DataBase.HPCharacter) / Convert.ToDouble(DataBase.StaticHP)) * 100);
                        }
                        else
                        {
                            timer1.Stop();
                            //this.Close();
                        }
                        
                    }
                    if (statusValue == 0)
                    {
                        pictureBox8.Image = null;
                        ChangeBackground();
                        Starter();
                    }
                }
                if (DataBase.HPCharacter < 0)
                {
                    timer1.Stop();
                }
            }
            else timer1.Stop();
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

