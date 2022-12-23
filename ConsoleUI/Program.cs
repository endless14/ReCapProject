using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMomery;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager productManager = new CarManager(new EfCarDal());
            foreach (var prodcut in productManager.GetAll()) 
            {
                Console.WriteLine(prodcut.DailyPrice);
            }
        }
    }
}
