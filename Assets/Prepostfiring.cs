using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {



        }


        public static void PreExport()
        {

            Console.WriteLine("From inside the project: This is a pre-export method firing");


        }

        public static void PostExport(string path)
        {

            Console.WriteLine("From inside the project: This is a post-export method firing, and this is the path we ingested: " + path);

        }

    }
}

