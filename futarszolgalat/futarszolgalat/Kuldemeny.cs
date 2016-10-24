using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futarszolgalat
{
    public class Kuldemeny
    {
        public string CimzettNev { get; set; }
        public string CimzettOrszag { get; set; }
        public string CimzettVaros { get; set; }
        public string CimzettUtcaHazszam { get; set; }
        public string CimzettIrSzam { get; set; }
        public int Gramm { get; set; }
        public BindingList<String> Megjegyzesek { get; set; }
        public FutarSzolgaltatas Szolgaltatas { get; set; }
        public int Ar
        {
            get { return Szolgaltatas.Alapar + (Szolgaltatas.GrammAr * Gramm); }
        }

    }
}
