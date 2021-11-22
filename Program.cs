using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(0, 10);
                Console.Write("{0} ", array[i]);

                string path = "Tanya.txt";
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("array[]", array);
                }
                

            }
        }

    }

}
