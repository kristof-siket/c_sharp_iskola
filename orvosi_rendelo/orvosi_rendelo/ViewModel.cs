using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orvosi_rendelo
{
    public class ViewModel
    {
        private static ViewModel _peldany;

        private ViewModel()
        {
            Betegek = new ObservableCollection<Beteg>()
            {
                new Beteg() { Kezelesek=new List<Kezeles>(), Nev="Siket Kristóf", SzDatum=DateTime.Parse("1996.09.06."), SzHely="Budapest", TajSzam="010101010" },
                new Beteg() { Kezelesek=new List<Kezeles>(), Nev="Gareth Bale", SzDatum=DateTime.Parse("1986.10.09."), SzHely="Cardiff", TajSzam="020202020" },
                new Beteg() { Kezelesek=new List<Kezeles>(), Nev="Zámbó Jimmy", SzDatum=DateTime.Parse("1956.05.06."), SzHely="Budapest", TajSzam="435435345" },
                new Beteg() { Kezelesek=new List<Kezeles>(), Nev="Tupac Amaru Shakur", SzDatum=DateTime.Parse("1970.09.13."), SzHely="Los Angeles", TajSzam="34324234323" },
                new Beteg() { Kezelesek=new List<Kezeles>(), Nev="Muhammad Ali", SzDatum=DateTime.Parse("1941.11.06."), SzHely="New York", TajSzam="999999999" },
            };

            Kezelesek = new ObservableCollection<Kezeles>()
            {
                new Kezeles() { BNO="BH3829", Jegyzet="Tutira meg fog halni" },
                new Kezeles() { BNO="HT8343", Jegyzet="Szopogasson strepfen-t, igyon Coldrexet" },
                new Kezeles() { BNO="TZ7672", Jegyzet="Sebhintőporral, betadinnal kezelni 2 hétig." },
                new Kezeles() { BNO="KS8327", Jegyzet="Hozzák a koporsót" },
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

        public ObservableCollection<Beteg> Betegek { get; set; }
        public Beteg KivalasztottBeteg { get; set; }

        public ObservableCollection<Kezeles> Kezelesek { get; set; }
        public Kezeles KivalasztottKezeles { get; set; }

    }
}
