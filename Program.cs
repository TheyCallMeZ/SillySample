using System;
using System.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SillySample.Models;


namespace SillySample
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                WriteMenu(); //Show Menu Options
                Console.Write("What'll it be: ");
                var input = Console.ReadKey();

                Console.WriteLine(" "); //Blank Line
                switch (input.KeyChar.ToString())
                {
                    case "1": //Our First Table
                        using (var db = new SillySampleContext())
                        {
                            var ven = db.Set<Vendor>().ToList();

                            foreach (var v in ven)
                            { 
                                Console.WriteLine(JsonConvert.SerializeObject(v)); // Serializing to Json to display since it gets the job done...
                            }
                        }
                        break;

                    case "2": //Our Second Table
                        using (var db = new SillySampleContext())
                        {
                            var stuff = db.Set<Product>().ToList();

                            foreach (var p in stuff)
                            {
                                Console.WriteLine(JsonConvert.SerializeObject(p)); // Serializing to Json to display since it gets the job done...
                            }
                        }
                        break;

                    case "3": //Our View
                        using (var db = new SillySampleContext())
                        {
                            var vpList = db.Set<VendorProduct>().ToList();

                            foreach (var vp in vpList)
                            {
                                Console.WriteLine(JsonConvert.SerializeObject(vp)); // Serializing to Json to display since it gets the job done...
                            }
                        }
                        break;

                    case "4":
                        using (var db = new SillySampleContext())
                        {
                            var vendorName = "Nontindo";
                            var vpList = db.Set<VendorProduct>()
                                .FromSqlInterpolated($"EXEC GetVendorProductByVendorName @VendorName={vendorName}")
                                .ToList();

                            foreach (var vp in vpList)
                            {
                                Console.WriteLine(JsonConvert.SerializeObject(vp)); // Serializing to Json to display since it gets the job done...
                            }
                        }
                        break;

                    case "q":
                       Environment.Exit(0); //Exit all happy like
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red; //Write the Error message in Red
                        Console.WriteLine("Not a Valid Choice, please try again...");
                        Console.ResetColor(); //Change the Console Colors back to default
                        break;
                }
            }
           
        }

        static void WriteMenu()
        {
            Console.WriteLine("======================================");//Top
            Console.WriteLine("| 1.) List Products                  |");
            Console.WriteLine("| 2.) List Vendors                   |");
            Console.WriteLine("| 3.) List all Vendor Products       |");
            Console.WriteLine("| 4.) List One Vendor's Products     |");
            Console.WriteLine("| q.) Quit doing things!             |");
            Console.WriteLine("======================================");//Bottom
        }
    }
}
