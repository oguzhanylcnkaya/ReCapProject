﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorGet= "Renk getirildi";
        public static string ColorGetAll = "Renkler getirildi";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandGet = "Marka getirildi";
        public static string BrandGetAll = "Markalar getirildi";

        public static string CarAdded = "Araba eklendi";
        public static string CarAddedError = "Lütfen araba ismini 2 karakter dahil olmak üzere üstünde ve günlük fiyatı da 0'dan fazla olacak şekilde giriniz!!!";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarGetById = "Araba getirildi";
        public static string CarGetAll = "Arabalar getirildi";
        public static string CarGetDetailsDTO = "Detaylı araba bilgisi getirildi";
        public static string CarGetBrandId = "Seçilen markaya göre arabalar getirildi";
        public static string CarGetColorId = "Seçilen renge göre arabalar getirildi";
    }
}