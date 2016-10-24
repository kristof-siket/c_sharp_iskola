using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace futarszolgalat
{ 
    public class Kuldemeny : INotifyPropertyChanged
    {
        private int gramm;

        public string CimzettNev { get; set; }
        public string CimzettOrszag { get; set; }
        public string CimzettVaros { get; set; }
        public string CimzettUtcaHazszam { get; set; }
        public string CimzettIrSzam { get; set; }
        public int Gramm { get { return gramm; } set { gramm = value; OnPropertyChanged(); } }
        public BindingList<String> Megjegyzesek { get; set; }
        public FutarSzolgaltatas Szolgaltatas { get; set; }
        public int Ar
        {
            get { return Szolgaltatas.Alapar + (Szolgaltatas.GrammAr * Gramm); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName]string s = "")
        {
            if (PropertyChanged == null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(s));
            }
        }
    }
}
