﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicShop.BLL
{
    public class StavkaPosudbaInfo
    {
        public virtual DateTime DatumVracanja { get; set; }
        public virtual string Proizvod { get; set; }
        public virtual int Kolicina { get; set; }
        public virtual float Cijena { get; set; }
        public virtual DateTime Datum { get; set; }
    }
}




