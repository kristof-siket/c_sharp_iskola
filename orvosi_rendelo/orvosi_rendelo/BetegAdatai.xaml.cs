using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace orvosi_rendelo
{
    /// <summary>
    /// Interaction logic for BetegAdatai.xaml
    /// </summary>
    public partial class BetegAdatai : Window
    {
        public Beteg UjBeteg { get; set; }
        public BetegAdatai(bool mod = false)
        {
            if (mod)
            {
                DataContext = ViewModel.Get().KivalasztottBeteg;
            }
            else
            {
                UjBeteg = new Beteg();
                DataContext = UjBeteg;
            }

            InitializeComponent();
        }

        private void btn_Save_Clk(object sender, RoutedEventArgs e)
        {
            txtNev.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtSzhely.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtTaj.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            dtpSzd.GetBindingExpression(DatePicker.SelectedDateProperty).UpdateSource();
            this.DialogResult = true;
        }

    }
}
