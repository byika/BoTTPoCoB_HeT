using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Введите длину линии:");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите символ заполнитель:");
            char fillChar = char.Parse(Console.ReadLine());

            Console.WriteLine("Выберите направление линии (1 - горизонтальная, 2 - вертикальная):");
            char direction = char.Parse(Console.ReadLine());

            if (direction == '1')
            {
                DrawHorizontalLine(length, fillChar);
            }
            else if (direction == '2')
            {
                DrawVerticalLine(length, fillChar);
            }
            else
            {
                Console.WriteLine("Неверно указано направление линии.");
            }

            Console.ReadLine();
            }

            static void DrawHorizontalLine(int length, char fillChar)
            {
                for (int i = 0; i < length; i++)
                {
                    Console.Write(fillChar);
                }
                Console.WriteLine();
            }

            static void DrawVerticalLine(int length, char fillChar)
            {
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine(fillChar);
                }
            */

            int[] numbers = new int[5];

            Console.WriteLine("Введите пять чисел:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Число : ", i + 1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            int min = numbers[0];
            int max = numbers[0];
            int product = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                product *= numbers[i];

                if (numbers[i] < min)
                    min = numbers[i];

                if (numbers[i] > max)
                    max = numbers[i];
            }

            Console.WriteLine("Сумма чисел: ", sum);
            Console.WriteLine("Минимум: ", min);
            Console.WriteLine("Максимум: ", max);
            Console.WriteLine("Произведение чисел: ", product);

            Console.ReadLine();

        }
    }
}

