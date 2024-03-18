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

namespace Monitor
{
    public partial class MainGame : Form
    {
        public Random random = new Random();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasePic));
        public MainGame()
        {
            
            InitializeComponent();
           
            pictureBox3.Image = ((Image)(resources.GetObject(DataBase.PicCharapter)));
            pictureBox2.Image = ((Image)(resources.GetObject(DataBase.SelectEnemy())));
            
            //pictureBox3.Image = Image.FromFile(DataBase.PicCharapter);
            //pictureBox2.Image = Image.FromFile(DataBase.SelectEnemy());
            label1.Text = Convert.ToString(DataBase.HPCharacter);
            label2.Text = Convert.ToString(DataBase.HPEnemy);
            
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 500;
            if (Convert.ToInt32(label1.Text) > 0)
            {
                ChangeBackground();
                chlen();
            }
            DataBase.Timer();
        }
        
        int startValue=DataBase.Time;
        

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            this.Hide();

            Menu menuWindow = new Menu();
            menuWindow.Show();
            
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

        }

        //private void pictureBox8_MouseClick(object sender, MouseEventArgs e)
        //{
        //    back = '1';
        //    this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage" + back)));
        //    this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image"+back)));
        //}
        //private void pictureBox8_Click(object sender, EventArgs e)
        //{
        //    back = '1';
        //    this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage" + back)));
        //    this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image" + back)));
        //}

        //private void pictureBox9_Click(object sender, EventArgs e)
        //{
        //    back = '2';
        //    this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage" + back)));
        //    this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image" + back)));
        //}

        //private void pictureBox9_MouseClick(object sender, MouseEventArgs e)
        //{
        //    back = '2';
        //    this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage" + back)));
        //    this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image" + back)));
        //}

        //private void pictureBox10_Click(object sender, EventArgs e)
        //{
        //    back = '3';
        //    this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage" + back)));
        //    this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image" + back)));
        //}
        //private void pictureBox10_MouseClick(object sender, EventArgs e)
        //{
        //    back = '3';
        //    this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage" + back)));
        //    this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image" + back)));
        //}

        //private void pictureBox11_Click(object sender, EventArgs e)
        //{
        //    back = '4';
        //    this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage" + back)));
        //    this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image" + back)));
        //}

        //private void pictureBox11_MouseClick(object sender, MouseEventArgs e)
        //{
        //    back = '4';
        //    this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage" + back)));
        //    this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image" + back)));
        //}
        

        public void chlen()
        {
            startValue = DataBase.Time;
            int correctAnswer;
            int InCorrectAnswer1;
            int InCorrectAnswer2;
            string exem;
            MathGenerator game = new MathGenerator();

            if (Convert.ToInt32(label2.Text) > 0 && Convert.ToInt32(label1.Text) > 0)
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

                //this.BackgroundImage = Image.FromFile(DataBase.BackHard3);

                label4.Text = "Score: " + Convert.ToString(DataBase.Score);
            }
            else if (Convert.ToInt32(label1.Text) > 0)
            {
                ChangeBackground();
                chlen();
            }

            else
            {
                timer1.Stop();
                this.Hide();
                Game_result win = new Game_result();
                win.Show();
                
            }
        }

        public void ChangeBackground()
        {
            if (DataBase.Dificult == 1)
            {
                int v = random.Next(0, 4);
                switch (v)
                {
                    case 1: 
                        //this.BackgroundImage = Image.FromFile(DataBase.BackEasy1);
                        this.BackgroundImage = ((Image)(resources.GetObject(DataBase.BackEasy1)));
                        //pictureBox2.Image = Image.FromFile(DataBase.SelectEnemy());
                        pictureBox2.Image = ((Image)(resources.GetObject(DataBase.SelectEnemy())));
                        label2.Text = Convert.ToString(DataBase.StaticHPEnemy);
                        break;
                    case 2:
                        //this.BackgroundImage = Image.FromFile(DataBase.BackEasy2);
                        this.BackgroundImage = ((Image)(resources.GetObject(DataBase.BackEasy2)));
                        //pictureBox2.Image = Image.FromFile(DataBase.SelectEnemy());
                        pictureBox2.Image = ((Image)(resources.GetObject(DataBase.SelectEnemy())));
                        label2.Text = Convert.ToString(DataBase.StaticHPEnemy);
                        break;
                    case 3:
                        //this.BackgroundImage = Image.FromFile(DataBase.BackEasy3);
                        this.BackgroundImage = ((Image)(resources.GetObject(DataBase.BackEasy3)));
                        //pictureBox2.Image = Image.FromFile(DataBase.SelectEnemy());
                        pictureBox2.Image = ((Image)(resources.GetObject(DataBase.SelectEnemy())));
                        label2.Text = Convert.ToString(DataBase.StaticHPEnemy);
                        break;
                    case 4:
                        //this.BackgroundImage = Image.FromFile(DataBase.BackEasy4);
                        this.BackgroundImage = ((Image)(resources.GetObject(DataBase.BackEasy4)));
                        //pictureBox2.Image = Image.FromFile(DataBase.SelectEnemy());
                        pictureBox2.Image = ((Image)(resources.GetObject(DataBase.SelectEnemy())));
                        label2.Text = Convert.ToString(DataBase.StaticHPEnemy);
                        break;
                }
            }
            if (DataBase.Dificult == 2)
            {
                int v = random.Next(0, 5);
                switch (v)
                {
                    case 1:
                        //this.BackgroundImage = Image.FromFile(DataBase.BackNorm1);
                        this.BackgroundImage = ((Image)(resources.GetObject(DataBase.BackNorm1)));
                        //pictureBox2.Image = Image.FromFile(DataBase.SelectEnemy());
                        pictureBox2.Image = ((Image)(resources.GetObject(DataBase.SelectEnemy())));
                        label2.Text = Convert.ToString(DataBase.StaticHPEnemy);
                        break;
                    case 2:
                        //this.BackgroundImage = Image.FromFile(DataBase.BackNorm2);
                        this.BackgroundImage = ((Image)(resources.GetObject(DataBase.BackNorm2)));
                        //pictureBox2.Image = Image.FromFile(DataBase.SelectEnemy());
                        pictureBox2.Image = ((Image)(resources.GetObject(DataBase.SelectEnemy())));
                        label2.Text = Convert.ToString(DataBase.StaticHPEnemy);
                        break;
                    case 3:
                        //this.BackgroundImage = Image.FromFile(DataBase.BackNorm3);
                        this.BackgroundImage = ((Image)(resources.GetObject(DataBase.BackNorm3)));
                        //pictureBox2.Image = Image.FromFile(DataBase.SelectEnemy());
                        pictureBox2.Image = ((Image)(resources.GetObject(DataBase.SelectEnemy())));
                        label2.Text = Convert.ToString(DataBase.StaticHPEnemy);
                        break;
                    case 4:
                        //this.BackgroundImage = Image.FromFile(DataBase.BackNorm4);
                        this.BackgroundImage = ((Image)(resources.GetObject(DataBase.BackNorm4)));
                        //pictureBox2.Image = Image.FromFile(DataBase.SelectEnemy());
                        pictureBox2.Image = ((Image)(resources.GetObject(DataBase.SelectEnemy())));
                        label2.Text = Convert.ToString(DataBase.StaticHPEnemy);
                        break;
                    case 5:
                        //this.BackgroundImage = Image.FromFile(DataBase.BackNorm5);
                        this.BackgroundImage = ((Image)(resources.GetObject(DataBase.BackNorm5)));
                        //pictureBox2.Image = Image.FromFile(DataBase.SelectEnemy());
                        pictureBox2.Image = ((Image)(resources.GetObject(DataBase.SelectEnemy())));
                        label2.Text = Convert.ToString(DataBase.StaticHPEnemy);
                        break;
                }
            }
            if (DataBase.Dificult == 3)
            {
                int v = random.Next(0, 6);
                switch (v)
                {
                    case 1:
                        //this.BackgroundImage = Image.FromFile(DataBase.BackHard1);
                        this.BackgroundImage = ((Image)(resources.GetObject(DataBase.BackHard1)));
                        //pictureBox2.Image = Image.FromFile(DataBase.SelectEnemy());
                        pictureBox2.Image = ((Image)(resources.GetObject(DataBase.SelectEnemy())));
                        label2.Text = Convert.ToString(DataBase.StaticHPEnemy);
                        break;
                    case 2:
                        //this.BackgroundImage = Image.FromFile(DataBase.BackHard2);
                        this.BackgroundImage = ((Image)(resources.GetObject(DataBase.BackHard2)));
                        // pictureBox2.Image = Image.FromFile(DataBase.SelectEnemy());
                        pictureBox2.Image = ((Image)(resources.GetObject(DataBase.SelectEnemy())));
                        label2.Text = Convert.ToString(DataBase.StaticHPEnemy);
                        break;
                    case 3:
                        //this.BackgroundImage = Image.FromFile(DataBase.BackHard3);
                        this.BackgroundImage = ((Image)(resources.GetObject(DataBase.BackHard3)));
                        //pictureBox2.Image = Image.FromFile(DataBase.SelectEnemy());
                        pictureBox2.Image = ((Image)(resources.GetObject(DataBase.SelectEnemy())));
                        label2.Text = Convert.ToString(DataBase.StaticHPEnemy);
                        break;
                    case 4:
                        //this.BackgroundImage = Image.FromFile(DataBase.BackHard4);
                        this.BackgroundImage = ((Image)(resources.GetObject(DataBase.BackHard4)));
                        //pictureBox2.Image = Image.FromFile(DataBase.SelectEnemy());
                        pictureBox2.Image = ((Image)(resources.GetObject(DataBase.SelectEnemy())));
                        label2.Text = Convert.ToString(DataBase.StaticHPEnemy);
                        break;
                    case 5:
                        //this.BackgroundImage = Image.FromFile(DataBase.BackHard5);
                        this.BackgroundImage = ((Image)(resources.GetObject(DataBase.BackHard5)));
                        //pictureBox2.Image = Image.FromFile(DataBase.SelectEnemy());
                        pictureBox2.Image = ((Image)(resources.GetObject(DataBase.SelectEnemy())));
                        label2.Text = Convert.ToString(DataBase.StaticHPEnemy);
                        break;
                    case 6:
                        //this.BackgroundImage = Image.FromFile(DataBase.BackHard6);
                        this.BackgroundImage = ((Image)(resources.GetObject(DataBase.BackHard6)));
                        //pictureBox2.Image = Image.FromFile(DataBase.SelectEnemy());
                        pictureBox2.Image = ((Image)(resources.GetObject(DataBase.SelectEnemy())));
                        label2.Text = Convert.ToString(DataBase.StaticHPEnemy);
                        break;
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == Convert.ToString(DataBase.CorrectAnswer))
            {
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - DataBase.AttackCharacter);
                DataBase.Score += DataBase.Dificult;
                progressBar1.Step += 10;
            }
            else
            {
                label1.Text = Convert.ToString(Convert.ToInt32(label1.Text) - DataBase.AttackEnemy);
                DataBase.HPCharacter -= DataBase.AttackEnemy;
                progressBar1.Value = (DataBase.HPCharacter / DataBase.StaticHP) * 100;
            }
            chlen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == Convert.ToString(DataBase.CorrectAnswer))
            {
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - DataBase.AttackCharacter);
                DataBase.Score += DataBase.Dificult;
                progressBar1.Step += 10;
            }
            else
            {
                label1.Text = Convert.ToString(Convert.ToInt32(label1.Text) - DataBase.AttackEnemy);
                DataBase.HPCharacter -= DataBase.AttackEnemy;
                progressBar1.Value = (DataBase.HPCharacter / DataBase.StaticHP) * 100;
            }
            chlen();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == Convert.ToString(DataBase.CorrectAnswer))
            {
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - DataBase.AttackCharacter);
                DataBase.Score += DataBase.Dificult;
                
            }
            else
            {
                label1.Text = Convert.ToString(Convert.ToInt32(label1.Text) - DataBase.AttackEnemy);
                DataBase.HPCharacter -= DataBase.AttackEnemy;
                progressBar1.Value = (DataBase.HPCharacter / DataBase.StaticHP) * 100;
            }

            chlen();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Convert.ToInt32(label1.Text) - (DataBase.AttackEnemy/2));
            DataBase.HPCharacter -= DataBase.AttackEnemy/2;
            progressBar1.Value = (DataBase.HPCharacter / DataBase.StaticHP) * 100;

            chlen();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(startValue != 0)
            {
                label5.Text = startValue.ToString();
                startValue--;
            }
            else
            {
                label1.Text = Convert.ToString(Convert.ToInt32(label1.Text) - DataBase.AttackEnemy);
                chlen();
            }
        }
    }





}
