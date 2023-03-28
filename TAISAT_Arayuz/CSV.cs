using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAISAT_Arayuz
{ 
    internal class CSV
    {
        public string packageNo { get; set; }
        public string uyduStatus { get; set; }
        public string errorCode { get; set; }
        public string time { get; set; }
        public string pressure1 { get; set; }
        public string pressure2 { get; set; }
        public string altitude1 { get; set; }
        public string altitude2 { get; set; }
        public string altitudeDiff { get; set; }
        public string velocity { get; set; }
        public string temperature { get; set; }
        public string voltage { get; set; }
        public string gpsLatitude { get; set; }
        public string gpsLongitude { get; set; }
        public string gpsAltitude { get; set; }
        public string pitch { get; set; }
        public string roll { get; set; }
        public string yaw { get; set; }
        public string takimNo { get; set; }
    }
}
