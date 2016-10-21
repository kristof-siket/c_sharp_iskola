using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orvosi_rendelo
{

    /// <summary>
    /// A rendelőben kezelt betegek.
    /// </summary>
    public class Beteg
    {
        public string Nev { get; set; }
        public string SzHely { get; set;}
        public DateTime SzDatum { get; set; }
        public int TajSzam { get; set; }
        public List<Kezeles> Kezelesek;
    }
}
