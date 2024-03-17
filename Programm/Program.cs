using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Profile;
using MathGen;
using System.Net;
using System.Reflection.Emit;

namespace Programm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentProfile child1 = new StudentProfile("Tom", "2A");
            child1.Print();
            //on/off Programm
            Console.Write("Do you want play math game?   y/n     ");
            if (Console.ReadLine() == "y")
            {
                Console.Clear();
                for (int proc = 0; proc < 1; proc++)
                {
                    //MathGenerator game = new MathGenerator();
                    //Console.Write("Choose dificult  1/2/3      ");
                    //game.dificult= Convert.ToInt32(Console.ReadLine());
                    //if (game.dificult == 1) Console.ForegroundColor = ConsoleColor.Green;
                    //if (game.dificult == 2) Console.ForegroundColor = ConsoleColor.Yellow;
                    //if (game.dificult == 3) Console.ForegroundColor = ConsoleColor.Red;
                    //if(game.dificult > 3)
                    //{
                    //    proc--;
                    //    continue;
                    //}
                    Console.Clear();
                    

                    MathGenerator game = new MathGenerator();
                    int correctAnswer;
                    int InCorrectAnswer1;
                    int InCorrectAnswer2;
                    string exm;
                    game.GenerateQuiz(3, out correctAnswer, out InCorrectAnswer1, out InCorrectAnswer2, out exm);
                    
                    Console.WriteLine(exm,correctAnswer,InCorrectAnswer1,InCorrectAnswer2);
                    Console.WriteLine(correctAnswer);

                    Console.WriteLine("------------");
                    child1.point += game.Point;
                    Console.WriteLine($"You have {child1.point} points");
                    Console.Write("Do you want to continue play math game?   y/n    ");
                    if (Console.ReadLine() == "y") proc--;
                    else proc++;
                    Console.Clear();
                    Console.ResetColor();
                }
            }
            Console.WriteLine("Thanks for the game");
            Console.ReadKey();
        }
    }
}
