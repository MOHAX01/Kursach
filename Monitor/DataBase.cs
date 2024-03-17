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
        #endregion

        #region Backgrounds

        ///   Easy
        public static string BackEasy1 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Easy\\vecteezy_african-desert-landscape-background-for-game_12746791.jpg";
        public static string BackEasy2 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Easy\\vecteezy_cartoon-nature-landscape-summer-evening-forest_12816545.jpg";
        public static string BackEasy3 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Easy\\vecteezy_forest-game-background_.jpg";
        public static string BackEasy4 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Easy\\vecteezy_purple-alien-space-planet-game-cartoon-background_23869659.jpg";

        /// Noramal
        public static string BackNorm1 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Normal\\hills2.png";
        public static string BackNorm2 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Normal\\hills3.png";
        public static string BackNorm3 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Normal\\trees.png";
        public static string BackNorm4 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Normal\\trees3.png";
        public static string BackNorm5 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Normal\\illustration2.png";

        /// Hard
        public static string BackHard1 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Hard\\vecteezy_2d-hero-battle-pvp-arena-background-casual-game-art-design_26843980.jpg";
        public static string BackHard2 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Hard\\vecteezy_2d-hero-battle-pvp-arena-background-casual-game-art-design_30606313.jpg";
        public static string BackHard3 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Hard\\vecteezy_2d-hero-battle-pvp-arena-background-casual-game-art-design_30606321.jpg";
        public static string BackHard4 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Hard\\vecteezy_2d-hero-battle-pvp-arena-background-casual-game-art-design_31688145.jpg";
        public static string BackHard5 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Hard\\vecteezy_2d-hero-battle-pvp-arena-background-casual-game-art-design_31688148.jpg";
        public static string BackHard6 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Hard\\vecteezy_2d-hero-battle-pvp-arena-background-casual-game-art-design_31688151.jpg";

        #endregion

        #region Persons
        
        /// Warrior
        
        public static void Warrior()
        {
            if (Dificult == 1)
            {
                HPCharacter = 200;
                AttackCharacter = 10;

                HPEnemy = 30;
                StaticHPEnemy = 30;
                AttackEnemy = 10;
            }
            if (Dificult == 2)
            {
                HPCharacter = 150;
                AttackCharacter = 15;

                HPEnemy = 80;
                StaticHPEnemy = 80;
                AttackEnemy = 20;
            }
            if (Dificult == 3)
            {
                HPCharacter = 100;
                AttackCharacter = 20;

                HPEnemy = 150;
                StaticHPEnemy = 150;
                AttackEnemy = 30;
            }
        }
        public static string PicWarrior = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Main_Chapter\\Desktop_240310_1227-Photoroom.png-Photoroom.png";
        /// Assasin
        public static void Assasin()
        {
            if (Dificult == 1)
            {
                HPCharacter = 160;
                AttackCharacter = 15;

                HPEnemy = 40;
                StaticHPEnemy = 40;
                AttackEnemy = 15;
            }
            if (Dificult == 2)
            {
                HPCharacter = 120;
                AttackCharacter = 20;

                HPEnemy = 100;
                StaticHPEnemy = 100;
                AttackEnemy = 25;
            }
            if (Dificult == 3)
            {
                HPCharacter = 80;
                AttackCharacter = 30;

                HPEnemy = 180;
                StaticHPEnemy = 180;
                AttackEnemy = 35;
            }
        }
        public static string PicAssasin = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Main_Chapter\\Desktop_240310_1228-Photoroom.png-Photoroom.png";
        ///Wizard
        public static void Wizard()
        {
            if (Dificult == 1)
            {
                HPCharacter = 120;
                AttackCharacter = 20;

                HPEnemy = 20;
                StaticHPEnemy = 20;
                AttackEnemy = 10;
            }
            if (Dificult == 2)
            {
                HPCharacter = 90;
                AttackCharacter = 30;

                HPEnemy = 60;
                StaticHPEnemy = 60;
                AttackEnemy = 15;
            }
            if (Dificult == 3)
            {
                HPCharacter = 60;
                AttackCharacter = 40;

                HPEnemy = 100;
                StaticHPEnemy = 100;
                AttackEnemy = 20;
            }
        }
        public static string PicWizzard = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Main_Chapter\\Desktop_240310_1229-Photoroom.png-Photoroom.png";
        ///None
        public static void None()
        {
            if (Dificult == 1)
            {
                HPCharacter = 130;
                AttackCharacter = 25;

                HPEnemy = 50;
                StaticHPEnemy = 50;
                AttackEnemy = 15;
            }
            if (Dificult == 2)
            {
                HPCharacter = 100;
                AttackCharacter = 40;

                HPEnemy = 120;
                StaticHPEnemy = 120;
                AttackEnemy = 20;
            }
            if (Dificult == 3)
            {
                HPCharacter = 70;
                AttackCharacter = 60;

                HPEnemy = 200;
                StaticHPEnemy = 200;
                AttackEnemy = 25;
            }
        }
        public static string PicNone = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Main_Chapter\\Desktop_240310_1229_1-Photoroom.png-Photoroom.png";
        #endregion

        #region Selected Character

        public static int HPCharacter;
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
        public static string PicEnemy1 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy1.png";
        public static string PicEnemy2 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy2.png";
        public static string PicEnemy3 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy3.png";
        public static string PicEnemy4 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy4.png";
        public static string PicEnemy5 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy5.png";
        public static string PicEnemy6 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy6.png";
        public static string PicEnemy7 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy7.png";
        public static string PicEnemy8 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy8.png";
        public static string PicEnemy9 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy9.png";
        public static string PicEnemy10 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy10.png";
        public static string PicEnemy11 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy11.png";
        public static string PicEnemy12 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy12.png";
        public static string PicEnemy13 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy13.png";
        public static string PicEnemy14 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy14.png";
        public static string PicEnemy15 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy15.png";
        public static string PicEnemy16 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy16.png";
        public static string PicEnemy17 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy17.png";
        public static string PicEnemy18 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy18.png";
        public static string PicEnemy19 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy19.png";
        public static string PicEnemy20 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy20.png";
        public static string PicEnemy21 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy21.png";
        public static string PicEnemy22 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy22.png";
        public static string PicEnemy23 = "C:\\All programms\\VisualStudio\\Projects\\Kursach\\Monitor\\Resources\\Enemy\\Enemy23.png";

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
