using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {

            ToDo1();
            ToDo2();
        }

        private static void ToDo2()
        {
            using (StreamWriter stream = new StreamWriter(@"F:\1.txt"))
            {
                stream.WriteLine("Saparbek Bainazar 21");
            }
            using (StreamReader stream = new StreamReader(@"F:\1.txt"))
            {
                Console.WriteLine(stream.ReadLine());
            }
            Console.ReadLine();
        }

        private static void ToDo1()
        {



            using (StreamReader stream = new StreamReader(@"F:\1.txt"))
            {
                Dictionary<char, int> symbols = new Dictionary<char, int>();
                char[] bytes = new char[stream.BaseStream.Length];
                stream.ReadBlock(bytes, 0, bytes.Length);
                for (int i = 0; i < bytes.Length; i++)
                {
                    if (symbols.ContainsKey(bytes[i]))
                        symbols[bytes[i]]++;
                    else
                        symbols.Add(bytes[i], 1);
                }
                foreach (var symbol in symbols)
                {
                    Console.WriteLine("Count of {0} = {1}", symbol.Key, symbol.Value);
                }
            }
            Console.ReadLine();
        }
    }
}

