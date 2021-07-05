using System;
using System.Collections.Generic;
using System.IO;

namespace sort
{
    class Program
    {
        static void Main(string[] args)
        {   long a = 0;
            List<long> elements = new List<long>();

            string path = @"D:\sort3.txt";

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    elements.Add((long)Convert.ToInt64(line));
                }
                elements.Sort();
                elements.Reverse();
            }

            Console.WriteLine(elements[0].ToString() + ' ' + elements[1].ToString() + ' '+ elements[2].ToString() + ' ' + elements[3].ToString() + ' ' + elements[4].ToString()); ;
        }
    }
}
