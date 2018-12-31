using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Phonebook.Models;


namespace Phonebook
{
    public class Program
    {
        public static void Main(string[] args)
        {

            

             using(var dbContext = new Phonebook11Context())
             {
             var contacts = dbContext.Contacts.ToList();

            foreach (var c in contacts)

            {

                System.Console.WriteLine($"Name:{c.Name}");

                System.Console.WriteLine($"Phone Number:{c.Number}");

                System.Console.WriteLine($"Address:{c.Address}");

                System.Console.WriteLine($"Email:{c.Email}");

            }
             }


            CreateWebHostBuilder(args).Build().Run();
            

        }
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
            

    }
}
