using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wagenparken
{
    class AutoMerk
    {
        public string naam { get; set; }
        public string uitleg { get; set; }
        public AutoMerk(string Naam, string Uitleg)
        {
            naam = Naam;
            uitleg = Uitleg;
        }
        public AutoMerk() { }
    }
}
