using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Please note - THIS IS A BAD APPLICATION - DO NOT REPLICATE WHAT IT DOES
// This application was designed to simulate a poorly-built application that
// you need to support. Do not follow any of these practices. This is for 
// demonstration purposes only. You have been warned.
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string w;
            int i, t = 0, ttl;
            List<TimeSheetEntry> ents = new List<TimeSheetEntry>();
            Console.Write("Enter what you did: ");
            w = Convert.ToString(Console.ReadLine());
            Console.Write("How long did you do it for: ");
            try//System.FormatException
            {
               t = int.Parse(Console.ReadLine());
            }
            catch(SystemException b)
            {
                Console.WriteLine("It must be an integer... Program exiting...");
                System.Threading.Thread.Sleep(3000);
                Environment.Exit(1);
            }
            
            TimeSheetEntry ent = new TimeSheetEntry();
            ent.HoursWorked = t;
            ent.WorkDone = w;
            ents.Add(ent);
            Console.Write("Do you want to enter more time:");

            String yesno = Convert.ToString(Console.ReadLine()); // Converting yes and no
            bool cont = false;
            if (yesno == "yes")
            {
                cont = true;
            }                 
            else
            {
                if (yesno == "no")
                        cont = false;
                else
                {
                    Console.WriteLine("It must be yes or no... Program exiting...");
                    System.Threading.Thread.Sleep(3000);
                    Environment.Exit(1);
                }

            }



            while (cont == true) // 
            {
                Console.Write("Enter what you did: ");
                w = Console.ReadLine();
                Console.Write("How long did you do it for: ");
                t = int.Parse(Console.ReadLine());
                ent.HoursWorked = t;
                ent.WorkDone = w;
                ents.Add(ent);
                Console.Write("Do you want to enter more time:");
                yesno = Convert.ToString(Console.ReadLine()); // Converting yes and no
                cont = false;

                if (yesno == "yes")
                {
                    cont = true;
                }
                else
                {
                    if (yesno == "no")
                        cont = false;
                    else
                    {
                        Console.WriteLine("It must be yes or no... Program exiting...");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(1);
                    }

                }
            } 
            ttl = 0;
            
            
            for (i = 0; i < ents.Count; i++)
            {
                if (ents[i].WorkDone.Contains("ACME"))
                {
                    ttl += 1; // Changed i for 1 

                }
            }
            Console.WriteLine("Simulating Sending email to Acme");
            Console.WriteLine("Your bill is $" + ttl * 150 + " for the hours worked.");
            int a = ttl * 150;
            ttl = 0;
            for (i = 0; i < ents.Count; i++)
            {
                if (ents[i].WorkDone.Contains("ABC")) 
                {
                    ttl = ttl + 1; // Changed i for 1 
                }
            }
            int c = ttl * 125;
            Console.WriteLine("Simulating Sending email to ABC");
            Console.WriteLine("Your bill is $" + c + " for the hours worked.");
            
            ttl = 0;
            for (i = 0; i < ents.Count; i++)
            {
                ttl += ents[i].HoursWorked;
            }
            if (ttl > 40)
            {
                Console.WriteLine("You will get paid $" + ttl * 15 + a + c + " for your work."); // It fails to do the sum
            }
            else
            {
                Console.WriteLine("You will get paid $" + ttl * 10 + a + c + " for your time."); // It fails to do the sum
            }
            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }
    }

    public class TimeSheetEntry
    {
        public string WorkDone;
        public int HoursWorked;
    }
}
