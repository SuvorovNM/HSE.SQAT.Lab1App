using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSE.SQAT.Lab1App
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = -1;
            do
            {
                Console.WriteLine("Выберите функцию: ");
                Console.WriteLine(@"1) Удаление каждого второго элемента;
2) Найти корни квадратного уравнения;
3) Есть ли ферзи, бьющие друг друга;
4) Виход");
                string input = Console.ReadLine();
                bool correct = Int32.TryParse(input, out option);
                if (option < 1 || option > 4 || !correct)
                    Console.WriteLine("Некорректный ввод!");
                else
                {
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Введите строку: ");
                            input = Console.ReadLine();
                            List<string> output1 = ListExecuter.DeleteEverySecondElement(input);
                            foreach (string t in output1)
                            {
                                Console.Write(t + " ");
                            }
                            break;
                        case 2:
                            double a, b, c;
                            Console.WriteLine("Введите a:");
                            string parameterA = Console.ReadLine();
                            Double.TryParse(parameterA, out a);
                            Console.WriteLine("Введите b:");
                            string parameterB = Console.ReadLine();
                            Double.TryParse(parameterB, out b);
                            Console.WriteLine("Введите c:");
                            string parameterC = Console.ReadLine();
                            Double.TryParse(parameterC, out c);
                            List<double> output2 = Mathematics.GetSquareRoots(a, b, c);
                            if (output2 == null || output2.Count == 0) Console.WriteLine("Корней нет!");
                            else
                                foreach (double elem in output2)
                                {
                                    Console.Write(elem + " ");
                                }
                            break;
                        case 3:
                            sbyte firstX, firstY, secondX, secondY;
                            Console.WriteLine("Введите координату Х первого ферзя: ");
                            SByte.TryParse(Console.ReadLine(), out firstX);
                            Console.WriteLine("Введите координату Y первого ферзя: ");
                            SByte.TryParse(Console.ReadLine(), out firstY);
                            Console.WriteLine("Введите координату Х второго ферзя: ");
                            SByte.TryParse(Console.ReadLine(), out secondX);
                            Console.WriteLine("Введите координату Y второго ферзя: ");
                            SByte.TryParse(Console.ReadLine(), out secondY);
                            bool canBeat = ChessChecker.SearchForStrikingQueens(firstX, firstY, secondX, secondY);
                            if (canBeat) Console.WriteLine("Ферзи бьют друг друга");
                            else Console.WriteLine("Ферзи не бьют друг друга");
                            break;
                    }
                    Console.WriteLine();
                }
            } while (option != 4);
        }
    }
}
