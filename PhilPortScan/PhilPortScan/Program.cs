using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhilPortScan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PhilPortScan");
            Console.Clear();
            Console.Title = "PhilPortScan";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Target IP:");
            string ip = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Start Port:");
            string sPort = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("End Port:");
            string ePort = Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Start? [ENTER]");
            Console.ReadKey();
            Helper helper = new Helper(ip, sPort, ePort);
            helper.RunScan();
            Console.ReadKey();
        }
    }
}
