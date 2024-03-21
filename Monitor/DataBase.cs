using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor
{
    static class DataBase
    {
        #region Math Exem
        public static int Dificult;
        public static double CorrectAnswer;
        public static double InCorrectAnswer1;
        public static double InCorrectAnswer2;
        public static int[] Answers = new int[3];
        public static int Score;
        public static int Time;
        public static int Flag = 1;

        public static void Timer()
        {
            if (Dificult == 1) Time = 10;     //10
            if (Dificult == 2) Time = 15;     //15
            if (Dificult == 3) Time = 20;     //20
        }

        #endregion

        #region Backgrounds

        ///   Easy
        //public static string BackEasy1 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Easy\\Easy1.jpg";
        //public static string BackEasy2 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Easy\\Easy2.jpg";
        //public static string BackEasy3 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Easy\\Easy3.jpg";
        //public static string BackEasy4 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Easy\\Easy4.jpg";

        public static string BackEasy1 = "Easy1";
        public static string BackEasy2 = "Easy2";
        public static string BackEasy3 = "Easy3";
        public static string BackEasy4 = "Easy4";

        /// Noramal
        //public static string BackNorm1 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Normal\\Normal1.png";
        //public static string BackNorm2 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Normal\\Normal2.png";
        //public static string BackNorm3 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Normal\\Normal3.png";
        //public static string BackNorm4 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Normal\\Normal4.png";
        //public static string BackNorm5 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Normal\\Normal5.png";

        public static string BackNorm1 = "Normal1";
        public static string BackNorm2 = "Normal2";
        public static string BackNorm3 = "Normal3";
        public static string BackNorm4 = "Normal4";
        public static string BackNorm5 = "Normal5";

        /// Hard
        //public static string BackHard1 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Hard\\Hard1.jpg";
        //public static string BackHard2 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Hard\\Hard2.jpg";
        //public static string BackHard3 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Hard\\Hard3.jpg";
        //public static string BackHard4 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Hard\\Hard4.jpg";
        //public static string BackHard5 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Hard\\Hard5.jpg";
        //public static string BackHard6 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Hard\\Hard6.jpg";

        public static string BackHard1 = "Hard1";
        public static string BackHard2 = "Hard2";
        public static string BackHard3 = "Hard3";
        public static string BackHard4 = "Hard4";
        public static string BackHard5 = "Hard5";
        public static string BackHard6 = "Hard6";

        #endregion

        #region Persons

        /// Warrior

        public static void Warrior()
        {
            if (Dificult == 1)
            {
                HPCharacter = 200;
                StaticHP = 200;
                AttackCharacter = 10;

                HPEnemy = 30;
                StaticHPEnemy = 30;
                AttackEnemy = 10;
            }
            if (Dificult == 2)
            {
                HPCharacter = 150;
                StaticHP = 150;
                AttackCharacter = 15;

                HPEnemy = 80;
                StaticHPEnemy = 80;
                AttackEnemy = 20;
            }
            if (Dificult == 3)
            {
                HPCharacter = 100;
                StaticHP = 100;
                AttackCharacter = 20;

                HPEnemy = 150;
                StaticHPEnemy = 150;
                AttackEnemy = 30;
            }
        }
        //public static string PicWarrior = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Main_Chapter\\Warrior.png";

        public static string PicWarrior = "Warrior";

        /// Assasin
        public static void Assasin()
        {
            if (Dificult == 1)
            {
                HPCharacter = 160;
                StaticHP = 160;
                AttackCharacter = 15;

                HPEnemy = 40;
                StaticHPEnemy = 40;
                AttackEnemy = 15;
            }
            if (Dificult == 2)
            {
                HPCharacter = 120;
                StaticHP = 120;
                AttackCharacter = 20;

                HPEnemy = 100;
                StaticHPEnemy = 100;
                AttackEnemy = 25;
            }
            if (Dificult == 3)
            {
                HPCharacter = 80;
                StaticHP = 80;
                AttackCharacter = 30;

                HPEnemy = 180;
                StaticHPEnemy = 180;
                AttackEnemy = 35;
            }
        }
        //public static string PicAssasin = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Main_Chapter\\Assasin.png";

        public static string PicAssasin = "Assasin";

        ///Wizard
        public static void Wizard()
        {
            if (Dificult == 1)
            {
                HPCharacter = 120;
                StaticHP = 120;
                AttackCharacter = 20;

                HPEnemy = 20;
                StaticHPEnemy = 20;
                AttackEnemy = 10;
            }
            if (Dificult == 2)
            {
                HPCharacter = 90;
                StaticHP = 90;
                AttackCharacter = 30;

                HPEnemy = 60;
                StaticHPEnemy = 60;
                AttackEnemy = 15;
            }
            if (Dificult == 3)
            {
                HPCharacter = 60;
                StaticHP = 60;
                AttackCharacter = 40;

                HPEnemy = 100;
                StaticHPEnemy = 100;
                AttackEnemy = 20;
            }
        }
        //public static string PicWizzard = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Main_Chapter\\Wizzard.png";

        public static string PicWizzard = "Wizzard";


        ///None
        public static void None()
        {
            if (Dificult == 1)
            {
                HPCharacter = 130;
                StaticHP = 130;
                AttackCharacter = 25;

                HPEnemy = 50;
                StaticHPEnemy = 50;
                AttackEnemy = 15;
            }
            if (Dificult == 2)
            {
                HPCharacter = 100;
                StaticHP = 100;
                AttackCharacter = 40;

                HPEnemy = 120;
                StaticHPEnemy = 120;
                AttackEnemy = 20;
            }
            if (Dificult == 3)
            {
                HPCharacter = 70;
                StaticHP = 70;
                AttackCharacter = 60;

                HPEnemy = 200;
                StaticHPEnemy = 200;
                AttackEnemy = 25;
            }
        }
        //public static string PicNone = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Main_Chapter\\None.png";

        public static string PicNone = "None";

        #endregion

        #region Selected Character

        public static int HPCharacter;
        public static int StaticHP;
        public static int AttackCharacter;
        public static int Heal = Convert.ToInt32(HPCharacter * 0.25);
        public static string PicCharapter;
        #endregion

        #region Enemy
        /// Stats
        public static int HPEnemy;
        public static int StaticHPEnemy;
        public static int AttackEnemy;
        public static int KillEnemy;
        /// Pics
        //public static string PicEnemy1 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy1.png";
        //public static string PicEnemy2 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy2.png";
        //public static string PicEnemy3 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy3.png";
        //public static string PicEnemy4 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy4.png";
        //public static string PicEnemy5 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy5.png";
        //public static string PicEnemy6 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy6.png";
        //public static string PicEnemy7 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy7.png";
        //public static string PicEnemy8 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy8.png";
        //public static string PicEnemy9 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy9.png";
        //public static string PicEnemy10 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy10.png";
        //public static string PicEnemy11 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy11.png";
        //public static string PicEnemy12 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy12.png";
        //public static string PicEnemy13 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy13.png";
        //public static string PicEnemy14 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy14.png";
        //public static string PicEnemy15 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy15.png";
        //public static string PicEnemy16 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy16.png";
        //public static string PicEnemy17 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy17.png";
        //public static string PicEnemy18 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy18.png";
        //public static string PicEnemy19 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy19.png";
        //public static string PicEnemy20 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy20.png";
        //public static string PicEnemy21 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy21.png";
        //public static string PicEnemy22 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy22.png";
        //public static string PicEnemy23 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy23.png";

        public static string PicEnemy1 = "Enemy1";
        public static string PicEnemy2 = "Enemy2";
        public static string PicEnemy3 = "Enemy3";
        public static string PicEnemy4 = "Enemy4";
        public static string PicEnemy5 = "Enemy5";
        public static string PicEnemy6 = "Enemy6";
        public static string PicEnemy7 = "Enemy7";
        public static string PicEnemy8 = "Enemy8";
        public static string PicEnemy9 = "Enemy9";
        public static string PicEnemy10 = "Enemy10";
        public static string PicEnemy11 = "Enemy11";
        public static string PicEnemy12 = "Enemy12";
        public static string PicEnemy13 = "Enemy13";
        public static string PicEnemy14 = "Enemy14";
        public static string PicEnemy15 = "Enemy15";
        public static string PicEnemy16 = "Enemy16";
        public static string PicEnemy17 = "Enemy17";
        public static string PicEnemy18 = "Enemy18";
        public static string PicEnemy19 = "Enemy19";
        public static string PicEnemy20 = "Enemy20";
        public static string PicEnemy21 = "Enemy21";
        public static string PicEnemy22 = "Enemy22";
        public static string PicEnemy23 = "Enemy23";

        public static string SelectEnemy()
        {
            Random random = new Random();
            int v = random.Next(1, 23);

            switch (v)
            {
                    case 1: return PicEnemy1;
                    case 2: return PicEnemy2;
                    case 3: return PicEnemy3;
                    case 4: return PicEnemy4;
                    case 5: return PicEnemy5;
                    case 6: return PicEnemy6;
                    case 7: return PicEnemy7;
                    case 8: return PicEnemy8;
                    case 9: return PicEnemy9;
                    case 10: return PicEnemy10;
                    case 11: return PicEnemy11;
                    case 12: return PicEnemy12;
                    case 13: return PicEnemy13;
                    case 14: return PicEnemy14;
                    case 15: return PicEnemy15;
                    case 16: return PicEnemy16;
                    case 17: return PicEnemy17;
                    case 18: return PicEnemy18;
                    case 19: return PicEnemy19;
                    case 20: return PicEnemy20;
                    case 21: return PicEnemy21;
                    case 22: return PicEnemy22;
                    case 23: return PicEnemy23;
                    default: return null;
            }
        }

        #endregion
    }
}
