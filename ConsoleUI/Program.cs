using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
   public class Program
    {
        static void Main(string[] args)
        {
            /*CarManager carManager = new CarManager(new EfCarDal(), new BrandManager());
            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.ColorName + "/" + car.BrandName + "/" + car.DailyPrice);

                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }*/
           
        }
    }
}
