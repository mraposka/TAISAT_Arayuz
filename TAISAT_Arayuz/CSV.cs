using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAISAT_Arayuz
{
    internal class CSV
    {
        [Name("PAKET NUMARASI")]
        [Index(0)]
        public string packageNo { get; set; }
        [Name("UYDU STATÜSÜ")]
        [Index(1)]
        public string uyduStatus { get; set; }
        [Name("HATA KODU")]
        [Index(2)]
        public string errorCode { get; set; }
        [Name("GÖNDERME SAATİ>")]
        [Index(3)]
        public string time { get; set; }
        [Name("BASINÇ1")]
        [Index(4)]
        public string pressure1 { get; set; }
        [Name("BASINÇ2")]
        [Index(5)]
        public string pressure2 { get; set; }
        [Name("YÜKSEKLİK1")]
        [Index(6)]
        public string altitude1 { get; set; }
        [Name("YÜKSEKLİK2")]
        [Index(7)]
        public string altitude2 { get; set; }
        [Name("İRTİFA FARKI")]
        [Index(8)]
        public string altitudeDiff { get; set; }
        [Name("İNİŞ HIZI")]
        [Index(9)]
        public string velocity { get; set; }
        [Name("SICAKLIK")]
        [Index(10)]
        public string temperature { get; set; }
        [Name("PİL GERİLİMİ")]
        [Index(11)]
        public string voltage { get; set; }
        [Name("GPS1 LATITUDE")]
        [Index(12)]
        public string gpsLatitude { get; set; }
        [Name("GPS1 LONGITUDE")]
        [Index(13)]
        public string gpsLongitude { get; set; }
        [Name("GPS1 ALTITUDE")]
        [Index(14)]
        public string gpsAltitude { get; set; }
        [Name("PITCH")]
        [Index(15)]
        public string pitch { get; set; }
        [Name("ROLL")]
        [Index(16)]
        public string roll { get; set; }
        [Name("YAW")]
        [Index(17)]
        public string yaw { get; set; }
        [Name("TAKIM NO")]
        [Index(18)]
        public string takimNo { get; set; }
    }
}
