using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using Microsoft.Win32;
using System.Threading.Tasks;

namespace ProxyCreater
{
    class Program
    {
        static void Main(string[] args)
        {
            //karakusnavy@gmail.com
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------------");
            Console.WriteLine("Welcome to proxy creater");
            Console.WriteLine("------------------------");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Type 1 to Start : ");
            if (int.Parse(Console.ReadLine()) != 1) return;
            Random rnd = new Random();
            List<string> list = new List<string>();
            Thread process = new Thread(new ThreadStart(createproxy));
            process.Start();            
            void createproxy(){
                string proxy, ssa = "8080";
                for (int i = 0; i < 10000; i++){
                    proxy = rnd.Next(40, 200).ToString() + "." + rnd.Next(100, 147).ToString() + "." + rnd.Next(0, 255).ToString() + "." + rnd.Next(0, 255).ToString();
                    list.Add(proxy + ":" + ssa);
                }//karakusnavy@gmail.com
                String[] proxy_list = new String[list.Count];
                list.CopyTo(proxy_list, 0);
                System.IO.File.WriteAllLines("proxy_list.txt", proxy_list);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("------------------------");
                Console.WriteLine("SUCCESFULL! 10.000 PROXY IS CREATED");
                Console.WriteLine("------------------------");
            }
            Console.ReadKey();
            //karakusnavy@gmail.com
        }
    }
}
