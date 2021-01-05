﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OgrenciLinqApp
{
    class Sehir
    {
        public int SehirId { get; set; }
        public string SehirAdi { get; set; }
        public List<Sehir> Liste { get; set; }

        public Sehir()
        {
            Liste = new List<Sehir>
            {
                new Sehir(55,"Samsun"),
                new Sehir(53,"Rize"),
                new Sehir(60,"Tokat"),
                new Sehir(34,"İstanbul"),
                new Sehir(37,"Kastamonu"),



            };
            

        }

        public Sehir(int id, string adi)
        {
            SehirId = id;
            SehirAdi = adi;
        }

       

        public override string ToString()
        {
            return $"{SehirId,-15}{SehirAdi,-15}";
        }
    }

    
}
