using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sql_maker
{
    public enum Kategoriak { Telefon, Tablet, Laptop, PC, Okosóra, Egyéb}
    public class ViewModel
    {
        private static ViewModel _peldany;

        private ViewModel()
        {
            OsszesTabla = new ObservableCollection<string>();
            OsszesTabla.Add("Felhasznalo");
            OsszesTabla.Add("Arak");
            OsszesTabla.Add("Keszlet");
            OsszesTabla.Add("Rendeles");
            
        }

        public static ViewModel Get()
        {
            if (_peldany == null)
            {
                _peldany = new ViewModel();
            }
            return _peldany;
        }

        public ObservableCollection<string> OsszesTabla { get; set; }
        public string KivalasztottTabla { get; set; }

        public string Query { get; set; }

        public void FajlbaKiir(string fajlnev)
        {
            StreamWriter sw = new StreamWriter(fajlnev);
            sw.WriteLine(Query);
            sw.Close();
        }

        public Array OsszesKategoria
        {
            get { return Enum.GetValues(typeof(Kategoriak)); }
        }

    }
}
