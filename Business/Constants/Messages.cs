﻿using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string CarListed = "Arabalar listelendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandNameInvalid = "Marka ismi geçersiz";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandListed = "Markalar listelendi";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorListed = "Renkler listelendi";
        public static string ColorNameInvalid = "Renk ismi geçersiz";

        public static string UserNameInvalid = "Kullanıcı ismi geçersiz";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserListed = "Kullanıcılar listelendi";

        public static string CustomerNameInvalid = "Müşteri ismi geçersiz";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerListed = "Müşteriler listelendi";

        public static string RentalFull = "Boşta araç yok";

        public static string CarImageLimitExceeded = "En fazla 5 resim eklenebilir";

        public static string AuthorizationDenied = "Yetkilendirme reddedildi";
        public static string User_Not_Found = "Kullanıcı bulunamadı";
        public static string User_Password_Doesnt_Match = "Şifre eşleşmedi";
        public static string User_Already_Exist = "Kullanıcı zaten var";
        public static string User_Token_Created = "Kullanıcı tokeni oluşturuldu";
        public static string User_Register_Message = "";
        public static string SuccessfulLogin = "Başarılı giriş";


        public static string AddedCarImage = "Resim eklendi";
        public static string DeletedCarImage = "Resim silindi";
        public static string ListedCarImages = "Resimler listelendi";
        public static string GetByIdCarImage = "Numaraya göre getirildi";
        public static string UpdatedCarImage = "Resim güncellendi";
        public static string ErrorUpdateCarImage = "Resim güncellenirken hata oluştu";

        public static string PasswordError = "Parola hatalı";
        public static string CardAdded = "Kart eklendi";
        public static string CardExist = "Kart daha önce kaydedilmiş";
        public static string CardInfoSuccess = "Kart bilgileri doğrulandı";
        public static string CardDeleted = "Kart silindi";
        public static string CardUpdated = "Kart bilgileri güncellendi";
        public static string InsufficientBalance = "Yetersiz bakiye";

        public static string MaintenanceTime = "Hata Maintenance";
        internal static string findexPointMax = "En yüksek findex puanına sahipsiniz";
        internal static string findexPointAdd = "Findex puanı eklendi";
        internal static string cardInfoError = "KArt Bilgileri Hatalı";
        internal static string succeed = "Başarılı";

        public static string PasswordSame = "Aynı parola";
        public static string PasswordUpdated = "Parola güncellendi";

        public static string TypeAdded = "Type is added";
        public static string TypeDeleted = "Type is deleted";
        public static string TypeUpdated = "Type is updated";

        public static string ScoreAdded = "Score is added";
        public static string ScoreDeleted = "Score is deleted";
        public static string ScoreUpdated = "Score is updated";
    }
}
