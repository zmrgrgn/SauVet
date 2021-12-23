﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Hekim:IEntity
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TelNo { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Gorev { get; set; }
        public string TcNo { get; set; }
        public string SicilNo { get; set; }
    }
}
