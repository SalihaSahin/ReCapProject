using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarAdded = "Araba eklendi.";
        public static string CarDeleted = "Araba silindi.";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string CarListed = "Arabalar listelendi.";
        public static string CarUpdated = "Araba güncellendi.";
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted="Renk silindi";
        public static string ColorListed="Renkler listelendi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandListed = "Markalar listelendi";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserListed = "Kullanıcılar listelendi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        internal static string CustomerAdded="Müşteri eklendi";
        internal static string CustomerDeleted="Müşteri silindi";
        internal static string CustomerUpdated = "Müşteri güncellendi";
        internal static string CustomerListed = "Müşteriler listelendi";
        internal static string RentalAdded="Kiralama oluşturuldu";
        internal static string RentalDeleted = "Kiralama silindi";
        internal static string RentalUpdated = "Kiralama güncellendi";
        internal static string RentalListed = "Kiralanan arabalar listelendi";
        internal static object RentalInvaited;
        public static string CarImageLimitExceeded = "Car Image Limit Exceeded";
        public static string CarImageIsNotExists = "Car Image Is Not Exists";

        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
