using Core.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string Added = "Eklendi";
        public static string Deleted = "Silindi";
        public static string Listed = "Listelendi";
        public static string Updated = "Güncellendi";
        public static string Get { get; internal set; }
        public static string MissingCharacter { get; internal set; }
        public static string NotEmail { get; internal set; }
        public static string NotFoundCapitalLetter { get; internal set; }

        public static string NotFoundUser = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Bu email daha önce alınmış";
        public static string UserRegistered = "Kayıt Başarılı";
        public static string TokenCreated = "Token oluşturuldu";
        
    }
}
