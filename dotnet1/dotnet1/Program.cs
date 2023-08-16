using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Write smth:");
            String text = Console.ReadLine();
            if (text != "")
            {

                String buff;
                buff = text.Substring(0, 1);
                text = text + text.Substring(text.Length - 1, 1);
                String mass = "";
                int g = 0;
                for (int i = 1; i <= text.Length - 1; i++)
                {
                    if (buff[g] != text[i])
                    {
                        buff = buff + text[i];
                        g++;
                    }
                    else
                    {
                        if (mass.Length <= buff.Length) mass = buff;
                        //Console.WriteLine(mass + " - " + mass.Length);
                        //Console.WriteLine(buff + " - " + buff.Length);
                        buff = "";
                        buff = buff + text[i];
                        g = 0;
                    }
                }

                Console.WriteLine("Максимальное количество неодинаковых последовательных символов в строке:\n" + mass.Length);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Вы ничего не ввели.");
                Console.ReadKey();
            }
        }
    }
}
