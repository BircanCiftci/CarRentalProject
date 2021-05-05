using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarDescriptionInvalid = "Araba bilgisi geçersiz";
        public static string CarListed = "Arabalar listelendi";
        public static string CarListedDailyPrice = "Arabalar fiyatına göre listelendi";
        public static string CarDailyPriceInvalid = "Arba kiralam fiyatı geçerli değil";

        public static string BrandAdded = "Araba markası eklendi";
        public static string BrandNameInvalid = "Araba ismi geçersiz";
        public static string BrandDeleted = "Araba markası silindi";
        public static string BrandUpdated = "Araba markası güncellendi";
        public static string BrandListed = "Araba markaları listelendi";

        public static string ColorAdded = "Araba rengi eklendi";
        public static string ColorNameInvalid = "Araba rengi geçersiz";
        public static string ColorDeleted = "Araba rengi silindi";
        public static string ColorUpdated = "Araba rengi güncellendi";
        public static string ColorListed = "Araba renkleri listelendi";

        public static string RentalAdded = "Araba kiralama bilgisi eklendi";
        public static string RentalDeleted = "Araba kiralama bilgisi silindi";
        public static string RentalUpdated = "Araba kiralama bilgisi güncellendi";
        public static string RentalRentDate = "Araba kiralanamaz. Teslim edilmemiş";
        public static string RentalReturnDate = "Araba teslim edilmemiş";
        public static string RentalListed = "Araba kiralama bilgileri listelendi";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserNameInvalid = "Kullanıcı adı geçersiz";
        public static string UserLastNameInvalid = "Kullanıcı soyadı geçersiz";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserListed = "Kullanıcılar listelendi";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerNameInvalid = "Müşteri adı geçersiz";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerListed = "Müşteriler listelendi";

        public static string MaintenanceTime = "Sistem bakımda";

        public static string CarImageAdded = "Araba resmi eklendi";
        public static string CarImagesLimitExceded = "Limiti geçti";
        public static string CarImageDeleted = "Araba resmi silindi";
        public static string CarImageUpdated = "Araba resmi güncellendi";
        public static string CarNotImageUpdated = "Araba resmi güncellendi";
        
        public static string AuthorizationDenied = " ";
    }
}
