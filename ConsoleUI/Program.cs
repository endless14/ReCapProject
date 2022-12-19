using Business.Concrete;
using DataAccess.Concrete.InMomery;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMomeryProductDal());
            foreach (var prodcut in productManager.GetAll()) 
            {
                Console.WriteLine(prodcut.DailyPrice);
            }
        }
    }
}
