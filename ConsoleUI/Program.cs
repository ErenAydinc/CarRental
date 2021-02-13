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
            //Araba Yazdırma İşlemleri

            //CarManagerTest();

            //////////////////////////////////////////////////////////////////




            //Müşteri Yazdırma işlemleri

            //CustomerManager();




            //Marka Ekleme İşlemleri

            //BrandManager();

            /////////////////////////////////////////////////////////////////////






            //Renk Ekleme İşlemleri

            //ColorManager();

            ////////////////////////////////////////////////////////////////////////////////////////////////////



            //Kullanıcı Ekleme İşlemleri

            //UserManager();

            /////////////////////////////////////////////////////////////////////////
            


            //Kiralama İşlemleri
            RentalManager();

        }

        private static void RentalManager()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            foreach (var rent in rentalManager.GetAll().Data)
            {
                Console.WriteLine(rent.CustomerId + "   " + rent.RentDate + "  " + rent.ReturnDate);
            }
            //rentalManager.Add(new Rental { CustomerId = 1, RentDate = DateTime.Now, ReturnDate =new DateTime(2020,02,13) });
        }

        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        private static void UserManager()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.FirstName + "     " + user.LastName + "      " + user.Email);
            }
            userManager.Add(new User { Email = "erenaydinc@gmail.com", FirstName = "Eren", LastName = "Aydinç", Password = "Erenss4545" });
        }

        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        private static void ColorManager()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorName = "Kırmızı", ColorId = 1 });
        }
        
        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        private static void BrandManager()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandId = 1, BrandName = "Renault" });
        }

        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        private static void CustomerManager()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(customer.CompanyName + customer.UserId);
            }
            //Müşteri ekleme işlemleri

            customerManager.Add(new Customer { CompanyName = "EA Limited AŞ",UserId=1});
        }

        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        private static void CarManagerTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("           |Arabanın Markası|          " + "       |Günlük Kiralama Bedeli|       " + "        |Kiralanan Arabanın Modeli|      ");
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine("                 " + car.Description + "       " + "                    " + car.DailyPrice + "                          " + "      " + car.ModelYear);
            }
            //Araba ekleme işlemleri
            carManager.Add(new Car { BrandId = 2, Description = "BMW 320i", DailyPrice = 2000, ColorId = 2, ModelYear = "2018" });
        }
    }
}
