using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public class Messages
    {
        public static string CarAdded = "Araç Eklendi";
        public static string CarNameInvalid = "Araç ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda!!!";
        public static string ProductListed = "Araçlar listelendi";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string AccessTokenCreated = "Token oluşturuldu";
        public static string CarNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string CarCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir.";
        public static string BrandLimitExceded = "Marka limiti aşıldığı için yeni ürün eklenemiyor";
    }
}
