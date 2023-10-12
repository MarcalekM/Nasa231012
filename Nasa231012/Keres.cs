using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasa231012
{
    class Keres
    {
        public string Cim { get;  set; }
        public String DatumIdo { get;  set; }
        public string Get { get; set; }
        public string HttpKod { get; set; }
        public string Meret { get; set; }

        public Keres(string s)
        {
            var v = s.Split('*');
            Cim = v[0];
            DatumIdo = v[1];
           Get = v[2];
            var a = v[3].Split(' ');
            HttpKod = a[0];
            Meret = a[1];
        }
    }
}
