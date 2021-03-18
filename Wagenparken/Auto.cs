using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wagenparken
{
     class Auto
    {
        public enum Brandstof {Diesel,Benzine,Electrisch, Hybride,Aardgas }
        public enum Transmissie {Automaat,Handschakeld }
        public enum Kleuren {Wit, Groen,Bruin,Zwart,Grijs,Rood,Blauw}
        public AutoMerk merk { get; set; }
        public string  model { get; set; }
        public int bouwjaar { get; set; }
        public Brandstof brandstoftype { get; set; }
        public Transmissie transmissie { get; set; }
        public Kleuren kleur { get; set; }
        public double prijs { get; set; }
        public Auto(AutoMerk Merk,string Model,int Bouwjaar,Brandstof Brandstoftype,Transmissie transmissi,Kleuren Kleur,double Prijs)
        {
            merk = Merk;
            model = Model;
            bouwjaar = Bouwjaar;
            brandstoftype = Brandstoftype;
            transmissie = transmissi;
            kleur = Kleur;
            prijs = Prijs;
        }
    }
}
