using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi";
        public static string CarUpdated = "Araç güncellendi";
        public static string CarDeleted = "Araç silindi";
        public static string CarListed = "Araç listelendi";
        public static string CarDailyPriceInvalid = "Araba günlük fiyatı 0'dan büyük olmalıdır.";
        public static string CarNameInvalid = "Araba ismi en az 2 karakter olmalıdır";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandListed = "Marka listelendi";
        public static string ColorAdded = "Renk eklendi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorListed = "Renk listelendi";

        public static string Listed = "Listelendi";
        public static string Added = "Eklendi";
        public static string Updated = "Güncellendi";
        public static string Deleted = "Silindi";

        public static string CarImageLimitExceded = "Bir arabanın en fazla 5 resmi olabilir.";

        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Şifre Hatalı";

        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExistis = "Bu kullanıcı mevcut";
        public static string UserRegister ="Kullancı başarıyla kaydedildi";

        public static string AccessTokenCreated = "Access Token oluşturuldu.";
        public static string AuthorizationDenied="Yetkin Yok";
    }
}
