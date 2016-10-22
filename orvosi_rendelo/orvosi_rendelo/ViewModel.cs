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
            Betegek = new ObservableCollection<Beteg>();
            
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
        public Beteg Kivalasztott { get; set; }
    }
}
