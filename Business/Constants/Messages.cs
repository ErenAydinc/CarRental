using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //Ortak Mesajlar
        public static string Maintenance = "Sistem Bakımdadır";

        //Car Messages
        public static string CarAdded = "Aracınız Başarıyla Eklendi";
        public static string CarDeleted = "Aracınız Başarıyla Silinmiştir";
        public static string CarUpdated = "Aracınız Başarıyla Güncellenmiştir";
        public static string CarDescriptionInvaild = "Aracınızın İsmi En Az 2 Karakter Olmalıdır";
        public static string CarPriceInvaild = "Aracın Değeri 0 dan büyük olmalıdır";
        public static string CarListed = "Arabalar Listelendi";

        //Brand Messages
        public static string BrandAdded = "Marka Başarıyla Eklendi";
        public static string BrandDeleted = "Marka Başarıyla Silinmiştir";
        public static string BrandUpdated = "Marka Başarıyla Güncellenmiştir";

        //Color Messages
        public static string ColorAdded = "Renk Başarıyla Eklendi";
        public static string ColorDeleted = "Renk Başarıyla Silinmiştir";
        public static string ColorUpdated = "Renk Başarıyla Güncellenmiştir";

        //Rental Messages
        public static string RentalAdded = "Kiralama Başarılı";
        public static string RentalDeleted = "Kiralama Silindi";
        public static string RentalUpdated = "Kiralama Güncellendi";
        public static string CarNotAvailable = "Araba Önceden Kiralanmıştır";
        public static string CarAvailable = "Araba Müsait";

        //User Messages
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdated = "Kullanıcı Güncellendi";

        //Customer Messages
        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUpdated = "Müşteri Güncellendi";
    }
}
