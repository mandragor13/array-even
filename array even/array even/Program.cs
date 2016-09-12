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
            // В шарпе обычно используется camel case, то есть переменные пишутся вот так inputSize. 
            // Это же верно для всех названияй. Слова разделяются заглавной буквой
            Console.WriteLine("задайте размер массива");
            while (!int.TryParse(Console.ReadLine(), out input_size ))
                {// скобки выравнваются по управляющей конструкции, к которой относятся, то есть на Tab левее, чем сейчас.
                    Console.WriteLine("Не корректное число");
                }

            int[] sample = new int[input_size];
            Console.WriteLine("Введите число");
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Не корректное число");
            }

            int i,j=0; // объявление каждой переменной в отдельной строке.
            // можно сначала привести число к правильному виду (увеличить его на единицу, если надо)
            // чтобы потом проверять число каждый раз внутри цикла. Тогда цикл существенно упростится, программа будет работать быстрее

            // кстати переменную счетчик в таком простом цикле лучше объявить прямо в цикле 
            // for (int i = 0; i < input_size; i ++)
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

                input ++; // пишется слитно input++
                
            }

            for (i = 0; i < input_size; i++)
            {
                Console.WriteLine("sample[" + i + "]: " + sample[i]);
            }
            Console.ReadLine();
        }

    }
}
