using AxWMPLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using WMPLib;
using MathGen;


using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Monitor
{
    public class Heros
    {
        public string NameHero;
        public string NamePicM;
        public string NamePicF;
        public int AttackHero;
        public int StaticHpHero;
        public int HpHero;
        public string InfoM;
        public string InfoF;

        public Heros(string Name, string PicM, string PicF, int Attack, int HP, int StaticHP, string InfoM, string InfoF)
        {
            this.NameHero = Name;
            this.NamePicM = PicM;
            this.NamePicF = PicF;
            this.AttackHero = Attack;
            this.StaticHpHero = HP;
            this.HpHero = StaticHP;
            this.InfoM = InfoM;
            this.InfoF = InfoF;
        }

    }

    public static class Person
    {
        public static Heros[] person;
        public static int Dificult = DataBase.Dificult;

        public static void Proc()
        {
            person = new Heros[4];
            switch (Dificult)
            {
                case 1:
                    {
                        person[0] = new Heros("Рыцарь",
                            "WarriorMale",
                            "WarriorFemale",
                            10, 200, 200,
                            "Этот герой родом из далекого королевства, известного своими мастерами меча. С раннего детства он был обучен искусству фехтования и владению всеми видами клинков. Его семья была известна как одна из самых талантливых в королевстве, и он был последним в их линии. Когда его родина была атакована и захвачена вражеской армией, он был единственным выжившим из своей семьи. Теперь он странствует по миру, ищущий силу, чтобы отомстить и вернуть свое королевство.",
                            "Эта героиня родом из далекого королевства, известного своими мастерами меча. С раннего детства она был обучена искусству фехтования и владению всеми видами клинков. Её семья была известна как одна из самых талантливых в королевстве, и она была последним в их линии. Когда его родина была атакована и захвачена вражеской армией, она была единственным выжившим из своей семьи. Теперь она странствует по миру, ищущий силу, чтобы отомстить и вернуть свое королевство.");

                        person[1] = new Heros("Вор",
                            "AssasinMale",
                            "AssasinFemale",
                            15, 160, 160,
                            "Этот герой вырос в бедных кварталах большого города, где преступность и коррупция были повсеместны. С раннего возраста он научился воровать, чтобы выжить. Он стал одним из самых искусных воров в городе, известным своей скрытностью и ловкостью. Однако, после того как он украл драгоценный артефакт из храма, он был проклят и теперь преследуется темными силами. Теперь он ищет способ снять проклятие и искупить свои грехи.",
                            "Эта героиня выросла в бедных кварталах большого города, где преступность и коррупция были повсеместны. С раннего возраста она научилась воровать, чтобы выжить. Она стала одним из самых искусных воров в городе, известным своей скрытностью и ловкостью. Однако, после того как она украла драгоценный артефакт из храма, она был проклята и теперь преследуется темными силами. Теперь он ищет способ снять проклятие и искупить свои грехи.");

                        person[2] = new Heros("Маг",
                            "WizardMale",
                            "WizardFemale",
                            20, 120, 120,
                            "Этот герой родился с необычайными магическими способностями, которые он не мог контролировать. Из-за этого он был изгнан из своей деревни и вынужден был жить в одиночестве. Он обучался магии самостоятельно, изучая древние тексты и экспериментируя со своими способностями. Он мечтает найти других магов, которые могут помочь ему контролировать свои силы и использовать их для блага мира.",
                            "Эта героиня родилась с необычайными магическими способностями, которые она не могла контролировать. Из-за этого она была изгнана из своей деревни и вынуждена была жить в одиночестве. Она обучалась магии самостоятельно, изучая древние тексты и экспериментируя со своими способностями. Она мечтает найти других магов, которые могут помочь ей контролировать свои силы и использовать их для блага мира.");

                        person[3] = new Heros("Призыватель",
                            "SummonerMale",
                            "SummonerFemale",
                            25, 130, 130,
                            "Этот герой родом из племени, которое живет в глубине леса и почитает духов природы. Он родился с даром призывать духов животных, которые помогают ему в бою. Он был обучен искусству призыва своим отцом, который был величайшим призывателем в племени. Однако, когда темная сила начала уничтожать лес и духов, Призыватель решил отправиться в путешествие, чтобы найти источник зла и восстановить равновесие природы.",
                            "Эта героиня родом из племени, которое живет в глубине леса и почитает духов природы. Она родилась с даром призывать духов животных, которые помогают ей в бою. Она был обучена искусству призыва своим отцом, который был величайшим призывателем в племени. Однако, когда темная сила начала уничтожать лес и духов, Призывательница решила отправиться в путешествие, чтобы найти источник зла и восстановить равновесие природы.");
                        break;
                    }
                case 2:
                    {
                        person[0] = new Heros("Рыцарь",
                            "WarriorMale",
                            "WarriorFemale",
                            15, 150, 150,
                            "Этот герой родом из далекого королевства, известного своими мастерами меча. С раннего детства он был обучен искусству фехтования и владению всеми видами клинков. Его семья была известна как одна из самых талантливых в королевстве, и он был последним в их линии. Когда его родина была атакована и захвачена вражеской армией, он был единственным выжившим из своей семьи. Теперь он странствует по миру, ищущий силу, чтобы отомстить и вернуть свое королевство.",
                            "Эта героиня родом из далекого королевства, известного своими мастерами меча. С раннего детства она был обучена искусству фехтования и владению всеми видами клинков. Её семья была известна как одна из самых талантливых в королевстве, и она была последним в их линии. Когда его родина была атакована и захвачена вражеской армией, она была единственным выжившим из своей семьи. Теперь она странствует по миру, ищущий силу, чтобы отомстить и вернуть свое королевство.");

                        person[1] = new Heros("Вор",
                            "AssasinMale",
                            "AssasinFemale",
                            20, 120, 120,
                            "Этот герой вырос в бедных кварталах большого города, где преступность и коррупция были повсеместны. С раннего возраста он научился воровать, чтобы выжить. Он стал одним из самых искусных воров в городе, известным своей скрытностью и ловкостью. Однако, после того как он украл драгоценный артефакт из храма, он был проклят и теперь преследуется темными силами. Теперь он ищет способ снять проклятие и искупить свои грехи.",
                            "Эта героиня выросла в бедных кварталах большого города, где преступность и коррупция были повсеместны. С раннего возраста она научилась воровать, чтобы выжить. Она стала одним из самых искусных воров в городе, известным своей скрытностью и ловкостью. Однако, после того как она украла драгоценный артефакт из храма, она был проклята и теперь преследуется темными силами. Теперь она ищет способ снять проклятие и искупить свои грехи.");

                        person[2] = new Heros("Маг",
                            "WizardMale",
                            "WizardFemale",
                            30, 90, 90,
                            "Этот герой родился с необычайными магическими способностями, которые он не мог контролировать. Из-за этого он был изгнан из своей деревни и вынужден был жить в одиночестве. Он обучался магии самостоятельно, изучая древние тексты и экспериментируя со своими способностями. Он мечтает найти других магов, которые могут помочь ему контролировать свои силы и использовать их для блага мира.",
                            "Эта героиня родилась с необычайными магическими способностями, которые она не могла контролировать. Из-за этого она была изгнана из своей деревни и вынуждена была жить в одиночестве. Она обучалась магии самостоятельно, изучая древние тексты и экспериментируя со своими способностями. Она мечтает найти других магов, которые могут помочь ей контролировать свои силы и использовать их для блага мира.");

                        person[3] = new Heros("Призыватель",
                            "SummonerMale",
                            "SummonerFemale",
                            40, 100, 100,
                            "Этот герой родом из племени, которое живет в глубине леса и почитает духов природы. Он родился с даром призывать духов животных, которые помогают ему в бою. Он был обучен искусству призыва своим отцом, который был величайшим призывателем в племени. Однако, когда темная сила начала уничтожать лес и духов, Призыватель решил отправиться в путешествие, чтобы найти источник зла и восстановить равновесие природы.",
                            "Эта героиня родом из племени, которое живет в глубине леса и почитает духов природы. Она родилась с даром призывать духов животных, которые помогают ей в бою. Она был обучена искусству призыва своим отцом, который был величайшим призывателем в племени. Однако, когда темная сила начала уничтожать лес и духов, Призывательница решила отправиться в путешествие, чтобы найти источник зла и восстановить равновесие природы.");
                        break;
                    }
                case 3:
                    {
                        person[0] = new Heros("Рыцарь",
                            "WarriorMale",
                            "WarriorFemale",
                            20, 100, 100,
                            "Этот герой родом из далекого королевства, известного своими мастерами меча. С раннего детства он был обучен искусству фехтования и владению всеми видами клинков. Его семья была известна как одна из самых талантливых в королевстве, и он был последним в их линии. Когда его родина была атакована и захвачена вражеской армией, он был единственным выжившим из своей семьи. Теперь он странствует по миру, ищущий силу, чтобы отомстить и вернуть свое королевство.",
                            "Эта героиня родом из далекого королевства, известного своими мастерами меча. С раннего детства она был обучена искусству фехтования и владению всеми видами клинков. Её семья была известна как одна из самых талантливых в королевстве, и она была последним в их линии. Когда его родина была атакована и захвачена вражеской армией, она была единственным выжившим из своей семьи. Теперь она странствует по миру, ищущий силу, чтобы отомстить и вернуть свое королевство.");

                        person[1] = new Heros("Вор",
                            "AssasinMale",
                            "AssasinFemale",
                            30, 80, 80,
                            "Этот герой вырос в бедных кварталах большого города, где преступность и коррупция были повсеместны. С раннего возраста он научился воровать, чтобы выжить. Он стал одним из самых искусных воров в городе, известным своей скрытностью и ловкостью. Однако, после того как он украл драгоценный артефакт из храма, он был проклят и теперь преследуется темными силами. Теперь он ищет способ снять проклятие и искупить свои грехи.",
                            "Эта героиня выросла в бедных кварталах большого города, где преступность и коррупция были повсеместны. С раннего возраста она научилась воровать, чтобы выжить. Она стала одним из самых искусных воров в городе, известным своей скрытностью и ловкостью. Однако, после того как она украла драгоценный артефакт из храма, она был проклята и теперь преследуется темными силами. Теперь она ищет способ снять проклятие и искупить свои грехи.");

                        person[2] = new Heros("Маг",
                            "WizardMale",
                            "WizardFemale",
                            40, 60, 60,
                            "Этот герой родился с необычайными магическими способностями, которые он не мог контролировать. Из-за этого он был изгнан из своей деревни и вынужден был жить в одиночестве. Он обучался магии самостоятельно, изучая древние тексты и экспериментируя со своими способностями. Он мечтает найти других магов, которые могут помочь ему контролировать свои силы и использовать их для блага мира.",
                            "Эта героиня родилась с необычайными магическими способностями, которые она не могла контролировать. Из-за этого она была изгнана из своей деревни и вынуждена была жить в одиночестве. Она обучалась магии самостоятельно, изучая древние тексты и экспериментируя со своими способностями. Она мечтает найти других магов, которые могут помочь ей контролировать свои силы и использовать их для блага мира.");

                        person[3] = new Heros("Призыватель",
                            "SummonerMale",
                            "SummonerFemale",
                            60, 70, 70,
                            "Этот герой родом из племени, которое живет в глубине леса и почитает духов природы. Он родился с даром призывать духов животных, которые помогают ему в бою. Он был обучен искусству призыва своим отцом, который был величайшим призывателем в племени. Однако, когда темная сила начала уничтожать лес и духов, Призыватель решил отправиться в путешествие, чтобы найти источник зла и восстановить равновесие природы.",
                            "Эта героиня родом из племени, которое живет в глубине леса и почитает духов природы. Она родилась с даром призывать духов животных, которые помогают ей в бою. Она был обучена искусству призыва своим отцом, который был величайшим призывателем в племени. Однако, когда темная сила начала уничтожать лес и духов, Призывательница решила отправиться в путешествие, чтобы найти источник зла и восстановить равновесие природы.");
                        break;
                    }
            }
        }

        //public static SoundPlayer[,] player;

        //public static void Gen_Mus()
        //{
        //    player = new SoundPlayer[4,2];
        //    player[0, 0] = new SoundPlayer(BasePic.WarriorMale_Audio);
        //    player[0, 1] = new SoundPlayer(BasePic.WarriorFemale_Audio);
        //    player[1, 0] = new SoundPlayer(BasePic.AssasinMale_Audio);
        //    player[1, 1] = new SoundPlayer(BasePic.AssasinMale_Audio);
        //    player[2, 0] = new SoundPlayer(BasePic.WarriorMale_Audio);
        //    player[2, 1] = new SoundPlayer(BasePic.WarriorFemale_Audio);
        //    player[3, 0] = new SoundPlayer(BasePic.SummonerMale_Audio);
        //    player[3, 1] = new SoundPlayer(BasePic.SummonerFemale_Audio);
        //}

    }


    public class Music
    {
        private SoundPlayer[] players;
        private int currentSongIndex;

        public void Play()
        {
            InitializePlayers();
            currentSongIndex = 0;
            PlayNextSong();

        }
        private void InitializePlayers()
        {
            players = new SoundPlayer[6];
            players[0] = new SoundPlayer(BasePic.domitori_taranofu_moments_of_the_past);
            players[1] = new SoundPlayer(BasePic.domitori_taranofu_sakuras_life);
            players[2] = new SoundPlayer(BasePic.ghillie_dhu_the_scottish_highlands_instrumental);
            players[3] = new SoundPlayer(BasePic.neizvesten_daydreams_and_heartaches_by_odd_things);
            players[4] = new SoundPlayer(BasePic.sun_shapes_a_place_only_we_know_instrumental_2);
            players[5] = new SoundPlayer(BasePic.ttrruutthh_strength_surrounds_instrumental);

            //MediaPlayer MyPLayer = new MediaPlayer();
            //MyPLayer.Open(new Uri(BasePic.domitori_taranofu_moments_of_the_past));
        }
        private void PlayNextSong()
        {
            if (currentSongIndex >= players.Length)
            {
                currentSongIndex = 0;
            }
            players[currentSongIndex].Play();

            currentSongIndex++;
        }
    }

    //public class Music
    //{
    //    public WindowsMediaPlayer[] player;
    //    //public MediaPlayer[] player;
    //    public int currentSongIndex;
    //    public void Play()
    //    {
    //        InitializePlayers();
    //        currentSongIndex = 0;
    //        //PlayNextSong();


    //    }
    //    private void InitializePlayers()
    //    {
    //        //player = new MediaPlayer[1];
    //        //player[0] = new MediaPlayer();
    //        //player[0].Open(new Uri("Kursach:///domitori_taranofu_moments_of_the_past.wav"));
    //        ////player[0].Volume = 30 / 100.0f;
    //        //player[0].Play();

    //        player = new WindowsMediaPlayer[1];
    //        player[0] = new WindowsMediaPlayer();
    //        string path = "MP1";
    //        File.WriteAllBytes(path, BasePic.MP1);
    //        //player[0].URL = new Uri("Kursach:///domitori_taranofu_moments_of_the_past.wav").AbsoluteUri;
    //        player[0].settings.baseURL = (new Uri("Kursach:///domitori_taranofu_moments_of_the_past.wav").AbsoluteUri);
    //        player[0].controls.play();
    //        player[0].settings.volume = 50;
    //    }
    //}
    //"C:\All programms\VisualStudio\Projects\Kursach\domitori-taranofu-moments-of-the-past.mp3"





    //public class MathMusic
    //{
    //    public MediaPlayer player = new MediaPlayer();

    //    public int currentSongIndex;
    //    public List<Uri> songs = new List<Uri>();
    //    public void Play()
    //    {

    //        InitializePlayers();
    //        currentSongIndex = 0;
    //        PlaySong(0);
    //        player.MediaEnded += (s, e) => NextSong();
    //        player.Volume = 1;
    //    }
    //    private void InitializePlayers()
    //    {
    //        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
    //        songs.Add(new Uri(Path.Combine(baseDirectory, "domitori_taranofu_moments_of_the_past"), UriKind.Absolute));
    //        songs.Add(new Uri(Path.Combine(baseDirectory, "domitori_taranofu_sakuras_life"), UriKind.Absolute));
    //        songs.Add(new Uri(Path.Combine(baseDirectory, "ghillie_dhu_the_scottish_highlands_instrumental"), UriKind.Absolute));
    //        songs.Add(new Uri(Path.Combine(baseDirectory, "neizvesten_daydreams_and_heartaches_by_odd_things"), UriKind.Absolute));
    //        songs.Add(new Uri(Path.Combine(baseDirectory, "sun_shapes_a_place_only_we_know_instrumental_2"), UriKind.Absolute));
    //        songs.Add(new Uri(Path.Combine(baseDirectory, "ttrruutthh_strength_surrounds_instrumental"), UriKind.Absolute));

    //    }
    //    public void PlaySong(int index)
    //    {
    //        player.Open(songs[index]);
    //        player.Play();
    //    }
    //    public void NextSong()
    //    {
    //        currentSongIndex++;
    //        if (currentSongIndex >= songs.Count)
    //        {
    //            currentSongIndex = 0;
    //        }
    //        PlaySong(currentSongIndex);
    //    }
    //    public void Voluem(int Value)
    //    {
    //        player.Volume = Value / 100;

    //    }
    //}

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
        public static int FlagSetting = 1;
        public static int FlagButton = 0;
        public static int FlagClose = 0;
        public static int FlagCheck = 1;
        public static int Volue=10;

        public static void Timer()
        {
            if (Dificult == 1) Time = 10;     //10
            if (Dificult == 2) Time = 15;     //15
            if (Dificult == 3) Time = 20;     //20
        }


        public static string ChangePerson(int Gender, int Class)
        {
            if (Gender == 1)
            {
                switch(Class)
                {
                    case 1: return "WarM";
                    case 2: return "AsM";
                    case 3: return "WizM";
                    case 4: return "SM";
                }
            }
            else
            {
                switch (Class)
                {
                    case 1: return "WarF";
                    case 2: return "AsF";
                    case 3: return "WizF";
                    case 4: return "SF";
                }
            }
            return "";
        }


        #endregion

        #region Backgrounds

        public static string BackEasy1 = "Easy1";
        public static string BackEasy2 = "Easy2";
        public static string BackEasy3 = "Easy3";
        public static string BackEasy4 = "Easy4";

        public static string BackNorm1 = "Normal1";
        public static string BackNorm2 = "Normal2";
        public static string BackNorm3 = "Normal3";
        public static string BackNorm4 = "Normal4";
        public static string BackNorm5 = "Normal5";

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
       

        public static string PicWarrior = "Warrior";


        /// Assasin
        public static void Assasin()
        {
            if (Dificult == 1)
            {
                HPCharacter = 160;
                StaticHP = 160;
                AttackCharacter = 15;

                HPEnemy = 30;
                StaticHPEnemy = 30;
                AttackEnemy = 15;
            }
            if (Dificult == 2)
            {
                HPCharacter = 120;
                StaticHP = 120;
                AttackCharacter = 20;

                HPEnemy = 50;
                StaticHPEnemy = 50;
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


        public static string PicAssasin = "Assasin";

        ///Wizard
        public static void Wizard()
        {
            if (Dificult == 1)
            {
                HPCharacter = 120;
                StaticHP = 120;
                AttackCharacter = 20;

                HPEnemy = 40;
                StaticHPEnemy = 40;
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

        public static string PicNone = "None";




        public static void Sel_Hero(int Num_Hero, int Gen)
        {
            switch (Dificult)
            {
                case 1:
                    {
                        switch (Num_Hero)
                        {
                            case 0:                     //Warrior
                                {
                                    HPCharacter = 120;
                                    StaticHP = 120;
                                    AttackCharacter = 30;
                                    if (Gen == 0) PicCharapter = "WarM";
                                    else PicCharapter = "WarF";
                                    break;
                                }
                            case 1:                     //Assasin
                                {
                                    HPCharacter = 80;
                                    StaticHP = 80;
                                    AttackCharacter = 40;
                                    if (Gen == 0) PicCharapter = "AsM";
                                    else PicCharapter = "AsF";
                                    break;
                                }
                            case 2:                     //Wizzard
                                {
                                    HPCharacter = 100;
                                    StaticHP = 100;
                                    AttackCharacter = 25;
                                    if (Gen == 0) PicCharapter = "WizM";
                                    else PicCharapter = "WizF";
                                    break;
                                }
                            case 3:                     //None
                                {
                                    HPCharacter = 90;
                                    StaticHP = 90;
                                    AttackCharacter = 20;
                                    if (Gen == 0) PicCharapter = "SM";
                                    else PicCharapter = "SF";
                                    break;
                                }
                        }

                        HPEnemy = 80;
                        StaticHPEnemy = 80;
                        AttackEnemy = 10;
                        break;
                    }
                case 2:
                    {
                        switch (Num_Hero)
                        {
                            case 0:                     //Warrior
                                {
                                    HPCharacter = 180;
                                    StaticHP = 180;
                                    AttackCharacter = 45;
                                    if (Gen == 0) PicCharapter = "WarM";
                                    else PicCharapter = "WarF";
                                    break;
                                }
                            case 1:                     //Assasin
                                {
                                    HPCharacter = 120;
                                    StaticHP = 120;
                                    AttackCharacter = 60;
                                    if (Gen == 0) PicCharapter = "AsM";
                                    else PicCharapter = "AsF";
                                    break;
                                }
                            case 2:                     //Wizzard
                                {
                                    HPCharacter = 150;
                                    StaticHP = 150;
                                    AttackCharacter = 40;
                                    if (Gen == 0) PicCharapter = "WizM";
                                    else PicCharapter = "WizF";
                                    break;
                                }
                            case 3:                     //None
                                {
                                    HPCharacter = 135;
                                    StaticHP = 135;
                                    AttackCharacter = 30;
                                    if (Gen == 0) PicCharapter = "SM";
                                    else PicCharapter = "SF";
                                    break;
                                }
                        }

                        HPEnemy = 120;
                        StaticHPEnemy = 120;
                        AttackEnemy = 20;
                        break;
                    }
                case 3:
                    {
                        switch (Num_Hero)
                        {
                            case 0:                     //Warrior
                                {
                                    HPCharacter = 240;
                                    StaticHP = 240;
                                    AttackCharacter = 60;
                                    if (Gen == 0) PicCharapter = "WarM";
                                    else PicCharapter = "WarF";
                                    break;
                                }
                            case 1:                     //Assasin
                                {
                                    HPCharacter = 160;
                                    StaticHP = 160;
                                    AttackCharacter = 80;
                                    if (Gen == 0) PicCharapter = "AsM";
                                    else PicCharapter = "AsF";
                                    break;
                                }
                            case 2:                     //Wizzard
                                {
                                    HPCharacter = 200;
                                    StaticHP = 200;
                                    AttackCharacter = 48;
                                    if (Gen == 0) PicCharapter = "WizM";
                                    else PicCharapter = "WizF";
                                    break;
                                }
                            case 3:                     //None
                                {
                                    HPCharacter = 180;
                                    StaticHP = 180;
                                    AttackCharacter = 40;
                                    if (Gen == 0) PicCharapter = "SM";
                                    else PicCharapter = "SF";
                                    break;
                                }
                        }

                        HPEnemy = 160;
                        StaticHPEnemy = 160;
                        AttackEnemy = 40;
                        break;
                    }
            }
        }

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

        #region Music

        //public static Music ms = new Music();

        //public static void Play()
        //{
        //    ms.Play();
        //}
        
        public static Music Music = new Music();
        public static void Play()
        {
            Music.Play();
        }

        //public static void Voluem(int Value)
        //{
        //    Music.Voluem(Value);
        //    Volue = Value;
        //}

        #endregion

    }
}
