using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wagenparken
{
    class Garage
    {
        public string naam { get; set; }
        public string adress { get; set; }
        public int capaciteit { get; set; }
        public Auto[] autos { get; set; }
        public Garage(string Naam,string Adress,int Capaciteit,Auto[] Autos) 
        {
            naam = Naam;
            adress = Adress;
            capaciteit = Capaciteit;
            autos = Autos;
        }
    }
}
