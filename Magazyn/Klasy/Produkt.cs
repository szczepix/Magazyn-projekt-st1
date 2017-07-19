using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn
{
    public class Produkt
    {
        private string name = String.Empty;

        public Produkt()
        {
            
        }
        public Produkt(string name)
        {
            ProduktName = name;
        }

        public int ProduktID { get; set; }
        public string ProduktName { get; set; }





    }
}
