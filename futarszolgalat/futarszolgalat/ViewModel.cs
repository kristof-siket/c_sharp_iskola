using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futarszolgalat
{
    public class ViewModel
    {
        private static ViewModel _peldany;

        private ViewModel()
        {
            Szolgaltatasok = new ObservableCollection<FutarSzolgaltatas>()
            {
                new FutarSzolgaltatas() { Alapar=1000, GrammAr=300, MaxSzallitasiNap=10, MinSzallitasiNap=5, Nev="Alap szállítás" },
                new FutarSzolgaltatas() { Alapar=2000, GrammAr=100, MaxSzallitasiNap=14, MinSzallitasiNap=7, Nev="Hosszútávú szállítás" },
                new FutarSzolgaltatas() { Alapar=1500, GrammAr=400, MaxSzallitasiNap=6, MinSzallitasiNap=3, Nev="Gyors szállítás" },
                new FutarSzolgaltatas() { Alapar=2000, GrammAr=500, MaxSzallitasiNap=3, MinSzallitasiNap=1, Nev="Szupergyors szállítás" },
            };
        }

        public static ViewModel Get()
        {
            if (_peldany == null)
            {
                _peldany = new ViewModel();
            }
            return _peldany;
        }

        public ObservableCollection<FutarSzolgaltatas> Szolgaltatasok;
        public FutarSzolgaltatas KivalasztottSzolgaltatas;
    }
}
