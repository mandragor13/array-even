using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_even
{
    class Program
    {
       public static void Main(string[] args)
        {
            int input_size;
            Console.WriteLine("задайте размер массива");
            while (!int.TryParse(Console.ReadLine(), out input_size ))
                {
                    Console.WriteLine("Не корректное число");
                }

            int[] sample = new int[input_size];
            Console.WriteLine("Введите число");
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Не корректное число");
            }

            int i,j=0;
            for (i = 0; i < input_size; i ++)
            {
                if (input % 2 == 0)
                {
                    sample[j] = input;
                    j++;
                }
                else
                {
                    i--;
                }

                input ++;
                
            }

            for (i = 0; i < input_size; i++)
            {
                Console.WriteLine("sample[" + i + "]: " + sample[i]);
            }
            Console.ReadLine();
        }

    }
}
