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
    }
}
