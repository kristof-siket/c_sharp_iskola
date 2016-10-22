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
    /// Interaction logic for KezelesWindow.xaml
    /// </summary>
    public partial class KezelesWindow : Window
    {
        ViewModel VM;
        public KezelesWindow()
        {
            
            UjKezeles = new Kezeles();
            VM = ViewModel.Get();
            DataContext = VM;
            InitializeComponent();
        }

        private void btn_SaveTreatment_Clk(object sender, RoutedEventArgs e)
        {
            txt_Jegyzet.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            cmb_BNO.GetBindingExpression(ComboBox.SelectedItemProperty).UpdateSource();
            lst_Kezeles.GetBindingExpression(ListBox.ItemsSourceProperty).UpdateSource();
            this.DialogResult = true;
        }

        public Kezeles UjKezeles { get; set; }
        
    }
}
