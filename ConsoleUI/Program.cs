using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car Id:"+car.CarId+" "+"Brand Id:"+car.BrandId+" "+"Color Id:"+car.ColorId+" "+"Yera Of Model:"+car.ModelYear+
                    " "+"Daily Price O f The Car:"+car.DailyPrice+" "+"Car Descreption:"+car.Description);
            }
            
            
            
        }
    }
}
