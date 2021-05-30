using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpApp
{
    class Program
    {
        static int Main(string[] args)
        {
            // display a simple msg to the user
            Console.WriteLine("******* My first C# App ******* ");
            Console.WriteLine("Hello World");
            Console.WriteLine();

            //wait for any key to be pressed before shutting down

            // process any incoming args
            //for (int i = 0; i < args.Length; i++)
            //{
            //    Console.WriteLine("Arg: {0}", args[i]);
            //}

            //process any incoming arg using foreach loop
            //foreach (string arg in args)
            //{
            //    Console.WriteLine("Arg: {0}", arg);

            //}
            //Get arguments using system.Environment.
            string[] theArgs = Environment.GetCommandLineArgs();
            foreach (string arg in theArgs)
            {
                Console.WriteLine("Arg: {0}", arg);

            }

            // helper method within the program class
            ShowEnvironmentDetails();
            Console.ReadLine();

            // return an arbitrary error code
            return -1;
        }

        private static void ShowEnvironmentDetails()
        {
            //print out the drives in the machine,
            //and other interesting details
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of Processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".Net Version {0}", Environment.Version);
        }
    }
}
