using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{

    public static class Message
    {
        public static string Added = "Eklendi!";
        public static string NameInvalid = "Geçersiz Ad!";
        public static string MaintenanceTime = "Sistem bakımdadır.";
        public static string Listed = "Listelendi!";
        public static string Deleted = "Silindi!";
        public static string Updated = "Güncellendi!";
        public static string CarImageLimit = "Bir arabaya 5'ten fazla resim eklenemez.";
        public static string SuccessMessageDefault = "İşlem başarıyla tamamlandı.";
        public static string AuthorizationDenied = "Bu işlem için yetkiniz yoktur.";
        public static string UserRegistered = "Kayıt olundu!";
        public static string UserNotFound = "Böyle bir kullanıcı bulunamadı.";
        public static string PasswordError = "Hatalı kullanıcı adı veya şifre.";
        public static string SuccessfulLogin = "Başarıyla giriş yaptınız!";
        public static string UserAlreadyExists = "Böyle bir kullanıcı zaten var.";
        public static string AccessTokenCreated = "";
    }
}
