using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CariRumah.Models
{
    public class Rumah
    {
        public int id { get; set; }
        public string tipe { get; set; }
        public string alamat { get; set; }
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
    }
}