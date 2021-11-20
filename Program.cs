using System;

namespace Welang
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Vars
            string cmd = "defaultvalue";

            // Name, Version and Creator
            Console.WriteLine("Welang // Version 1.0.0 - DetBird");

            // Infinite Loop
            while(true)
            {
                string currentTime = DateTime.Now.ToString("HH:mm:ss");
                Console.Write("WL > ");
                cmd = Console.ReadLine();

                foreach(string a in cmd.Split("\n"))
                {
                    // Print Function
                    if(cmd.StartsWith("wl.print::"))
                    {
                        Console.WriteLine(a.Substring(10));
                    }

                    else if(cmd == "wl.time")
                    {
                        Console.WriteLine("Your current time is: " + currentTime);
                    }

                    else if(cmd == "wl.clear")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("[WL] Console cleared successfully.");
                    }

                    // Error
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("[WL " + currentTime + "] Error :: Here -> ..." + cmd + " ; parameter not found.");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }
            }
        }
    }
}