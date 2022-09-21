using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Indexer obj = new Indexer();

            obj[0] = "Rocky";
            obj[1] = "Rizwanullah";
            obj[2] = "Saaho";
            obj[3] = "Charan";
            obj[4] = "Mounav";

            Console.WriteLine("displaying the object : " + obj);
            Console.WriteLine("\nNames Stored in the Indexer Class are below ones");
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(obj[i]);
            }
        }

        class Indexer
        {
            private string[] names = new string[5];

            public string this[int i]
            {
                get { return names[i]; }

                set { names[i] = value; }
            }
        }
    }
}
