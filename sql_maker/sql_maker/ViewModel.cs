using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sql_maker
{
    public enum Tablak { Felhasznalo, Arak, Keszlet, Rendeles} // talán ezzel elegánsabb lenne...
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

    }
}
