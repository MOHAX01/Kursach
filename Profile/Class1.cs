using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile
{
    public class StudentProfile
    {
        string name;
        string classs;
        private string difficult;
        private string[] subject = { "Math", "Russian" };
        public int point;

        public StudentProfile(string Name, string Classs)
        {
            name = Name;
            classs = Classs;
            difficult = "Easy";
            point = 0;
        }
        public string ChangeDifficult(string Dif)
        {
            return difficult = Dif;
        }
        public void GetDifficult()
        {
            Console.WriteLine(difficult);
        }
        public void AddSubject(string Sub)
        {
            Array.Resize(ref subject, subject.Length + 1);
            subject[subject.Length - 1] = Sub;
        }
        public void Print()
        {
            Console.WriteLine($"Student Name: {name} \nClass: {classs} \nDifficult: {difficult} \n" +
                $"Point:{point}");
        }
        public void PrintSubject()
        {
            for (int i = 0; i < subject.Length; i++)
            {
                Console.Write(subject[i] + "  ");
            }
            Console.WriteLine();
        }

    }
}
