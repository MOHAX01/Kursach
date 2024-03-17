using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MathGen
{
    public class MathGenerator
    {
        private Random random = new Random();
        public int Point;
        ///public int dificult=1;
        public void GenerateQuiz(int dificult, out int correctAnswer, out int InCorrectAnswer1, out int InCorrectAnswer2, out string exem)
        {
            //Console.WriteLine("Генерация математических примеров:");
            int flag;
            exem="";

            double num1 = random.Next(-5, 10); // Генерация случайного числа от 1 до 10
            double num2 = random.Next(-5, 10);
            double num3 = random.Next(-5, 15);
            double num4 = random.Next(-5, 20);

            char operation1 = GetRandomOperation(num1, num2);
            int FlagOperation = 0;
            if (operation1 == '/' || operation1 == '*')
            {
                FlagOperation = 1;
                if (operation1 == '/' && num2 == 0) num2++;
            }

            char operation2;
            if (FlagOperation == 1)
            {
                double res1 = Calculate(num1, num2, operation1);
                operation2 = GetRandomOperation(res1, num3);
            }
            else operation2 = GetRandomOperation(num2, num3);
            if (operation2 == '/' && num3 == 0) num3++;

            char operation3;
            if (operation2 == '*' || operation2 == '/')
            {
                double res1 = Calculate(num2, num3, operation2);
                operation3 = GetRandomOperation(res1, num4);
            }
            else operation3 = GetRandomOperation(num3, num4);
            if (operation3 == '/' && num4 == 0) num4++;
            flag = 1;

            if (num2 <= -1) exem += $"{num1} {operation1} ({num2})";
            else exem += $"{num1} {operation1} {num2}";
            if (dificult >= 2)
            {
                if (num3 <= -1) exem += $" {operation2} ({num3})";
                else exem += $" {operation2} {num3}";
                flag = 2;
            }

            if (dificult == 3)
            {
                if (num3 <= -1) exem += $" {operation3} ({num4})";
                else exem += $" {operation3} {num4}";
                flag = 3;
            }

            exem += " =";





            //if (num2 <= -1) Console.Write($"{num1} {operation1} ({num2})");
            //else Console.Write($"{num1} {operation1} {num2}");

            ////Добавляем дополнительные операнды и операции для более сложных примеров
            //    if (dificult >= 2)
            //{
            //    if (num3 <= -1) Console.Write($" {operation2} ({num3})");
            //    else Console.Write($" {operation2} {num3}");
            //    flag = 2;
            //}
            //if (dificult == 3)
            //{
            //    if (num3 <= -1) Console.Write($" {operation3} ({num4})");
            //    else Console.Write($" {operation3} {num4}");
            //    flag = 3;
            //}

            //Console.Write(" = ");

            //double userAnswer;
            correctAnswer = CalculateAnswerWithPriority(num1, num2, num3, num4, operation1, operation2, operation3, flag);
            InCorrectAnswer1 = random.Next(Convert.ToInt32(correctAnswer) + 2, Convert.ToInt32(correctAnswer) + 10);
            InCorrectAnswer2 = random.Next(Convert.ToInt32(correctAnswer) - 10, Convert.ToInt32(correctAnswer) - 2);

            //if (double.TryParse(Console.ReadLine(), out userAnswer))
            //{
            //    correctAnswer = CalculateAnswerWithPriority(num1, num2, num3, num4, operation1, operation2, operation3, flag);
            //    InCorrectAnswer1 = random.Next(Convert.ToInt32(correctAnswer) + 1, Convert.ToInt32(correctAnswer) + 10);
            //    InCorrectAnswer2 = random.Next(Convert.ToInt32(correctAnswer) - 10, Convert.ToInt32(correctAnswer) - 1);

            //    if (userAnswer == correctAnswer)
            //    {
            //        Console.WriteLine("Верно!\n");
            //        Point += dificult;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Неверно. Правильный ответ: {correctAnswer}\n");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Некорректный ввод. Попробуйте ещё раз.\n");
            //}
        }

        private char GetRandomOperation(double num1, double num2)
        {
            if (num1 % num2 == 0)
            {
                char[] operations = { '+', '-', '*', '/' };
                return operations[random.Next(operations.Length)];
            }
            else
            {
                char[] operations = { '+', '-', '*' };
                return operations[random.Next(operations.Length)];
            }
        }

        private int CalculateAnswerWithPriority(double num1, double num2, double num3, double num4, char operation1, char operation2, char operation3, int flag)
        {
            double result1, result2, result3;

            // Приоритет умножения/деления
            if (flag == 1)      // 1 use
            {
                result3 = Calculate(num1, num2, operation1);
            }
            else
            {
                if (flag == 2)  //2 use
                {
                    if (operation1 == '*' || operation1 == '/')
                    {
                        result1=Calculate(num1, num2, operation1);
                        result3= Calculate(result1, num3, operation2);
                    }
                    else
                    {
                        result1= Calculate(num2, num3, operation2);
                        result3= Calculate(num1, result1, operation1);
                    }
                }
                else    // 3 use
                {
                    if (operation1 == '*' || operation1 == '/')
                    {
                        result1 = Calculate(num1, num2, operation1);
                        if (operation2 == '*' || operation2 == '/')
                        {
                            result2 = Calculate(result1, num3, operation2);
                            result3 = Calculate(result2, num4, operation3);
                        }
                        else
                        {
                            if (operation3 == '*' || operation3 == '/')
                            {
                                result2 = Calculate(num3, num4, operation3);
                                result3 = Calculate(result1, result2, operation2);
                            }
                            else
                            {
                                result2 = Calculate(result1, num3, operation2);
                                result3 = Calculate(result2, num4, operation3);
                            }
                        }
                    }
                    else
                    {
                        if (operation2 == '*' || operation2 == '/')
                        {
                            result1 = Calculate(num2, num3, operation2);
                            if (operation3 == '*' || operation3 == '/')
                            {
                                result2= Calculate(result1, num4, operation3);
                                result3= Calculate(num1, result2, operation1);
                            }
                            else
                            {
                                result2 = Calculate(num1, result1, operation1);
                                result3 = Calculate(result2, num4, operation3);
                            }
                        }
                        else
                        {
                            if (operation3 == '*' || operation3 == '/')
                            {
                                result1 = Calculate(num3, num4, operation3);
                                result2 = Calculate(num1, num2, operation1);
                                result3 = Calculate(result1,result2, operation2);
                            }
                            else
                            {
                                result1 = Calculate(num1, num2, operation1);
                                result2 = Calculate(result1, num3, operation2);
                                result3 = Calculate(result2, num4, operation3);
                            }
                        }
                    }
                }
            }
            return Convert.ToInt32(result3);
        }
        private double Calculate(double num1, double num2, char operation)
        {
            switch (operation)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if (num2 != 0)
                        return num1 / num2;
                    else
                        throw new ArgumentException("Деление на ноль");
                default:
                    throw new ArgumentException("Некорректная операция");
            }
        }
    }
}
