using Microsoft.Identity.Client;
using P02_SalesDatabase.Data;
using P02_SalesDatabase.Models;

namespace P02_SalesDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using SalesDbContext context = new();

            try
            {
                Sale sale = new() 
                { 
                    Customer = new Customer { Name = "Kero", Email = "dfas", CreaditCardNumber = 54657 },
                    Product = new Product { Name = "keypowred", Price = 900, Quantity = 4 }, 
                    Store = new Store { Name = "Cairo" } 
                };

                context.Sales.Add(sale);
                context.SaveChanges(); // very good
            }
            catch (Exception ex)
            {
                Console.WriteLine("");
            }
        }
    }
}
