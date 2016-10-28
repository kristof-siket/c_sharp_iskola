using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sql_maker
{
    public class ViewModel
    {
        private static ViewModel _peldany;

        private ViewModel()
        {

        }

        public static ViewModel Get()
        {
            if (_peldany == null)
            {
                _peldany = new ViewModel();
            }
            return _peldany;
        }

    }
}
