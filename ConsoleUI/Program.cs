using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new  InMemoryCarDal());
            foreach (var car in carManager.GetAll()) 
            {
                Console.WriteLine("Arac Numarasi: " + car.Id);
                Console.WriteLine("Arac Aciklamasi: " + car.Description);
                Console.WriteLine("Gunluk Ucret: " + car.DailyPrice);
                Console.WriteLine("Arac Renk Numarasi: " + car.ColorId);
            }
                               
                                                                           
        }
    }
}
