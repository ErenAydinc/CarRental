using Business.Concrete;
using DateAccess.Concrete;
using DateAccess.Concrete.EntityFramework;
using Entites.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            Console.WriteLine("           |Arabanın Markası|          "+"       |Günlük Kiralama Bedeli|       "+"        |Kiralanan Arabanın Modeli|      ");
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine("                 " +car.Description+"       "+"                    "+car.DailyPrice+"                          "+"      "+car.ModelYear );
            }



            //carManager.Add(new Car { BrandId = 2, Description = "BMW 320i", DailyPrice = 2000, ColorId = 2, ModelYear = "2018" });
            //colorManager.Add(new Color { ColorName = "Kırmızı", ColorId = 1 });
            //brandManager.Add(new Brand { BrandId = 1, BrandName = "Renault" });




            // carManager.Delete(new Car { Id });



        }
    }
}
