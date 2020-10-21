using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rainbow = new List<string>();
            rainbow.Add("red");
            rainbow.Add("yellow");
            rainbow.Add("orange");
            rainbow.Add("green");
            rainbow.Add("blue");
            rainbow.Add("indigo");
            rainbow.Add("violet");

            for (int i = 0; i <= rainbow.Count; i++)
            {
                Console.WriteLine(rainbow[i]);
            }
            // rainbow.Reverse();
            Console.ReadLine();


            
        }
    }
}
