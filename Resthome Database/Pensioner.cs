using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resthome_Database
{
    internal class Pensioner : Personal
    {
        public Pensioner() 
        {

        }

        public Pensioner(string firstname, string lastname, int id, int age, string roomnumber, int carelevel) : base(firstname, lastname, id, age)
        {
            this.Roomnumber = roomnumber;
            this.Carelevel = carelevel;
        }

        public string Roomnumber { get; set; } 

        public int Carelevel { get; set; }
    }
}
