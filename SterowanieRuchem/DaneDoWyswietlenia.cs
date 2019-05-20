﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SterowanieRuchem
{
    class DaneDoWyswietlenia
    {
        public int Poczatek { get; set; }
        public int Koniec { get; set; }
        public string Kierunek { get; } = "->";
        public Boolean SI { get; set; }

        public double[] srednie { get; set; }
        public double[] kontrolne { get; set; }

        public DaneDoWyswietlenia(int poczatek, int koniec, Boolean si = false)
        {
            srednie = new double[24];
            kontrolne = new double[24];
            
            this.Poczatek = poczatek;
            this.Koniec = koniec;
            this.SI = si;
        }

        public void UstawSrednia(double srednia, int godzina, Boolean czyKontrolne)
        {
            double[] dane;
            if (czyKontrolne)
                dane = kontrolne;
            else
                dane = srednie;

            dane[godzina] = srednia;
        }
    }
}
