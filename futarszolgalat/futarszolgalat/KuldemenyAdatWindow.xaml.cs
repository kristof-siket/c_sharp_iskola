using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace futarszolgalat
{
    /// <summary>
    /// Interaction logic for KuldemenyAdatWindow.xaml
    /// </summary>
    public partial class KuldemenyAdatWindow : Window
    {
        public Kuldemeny UjKuldemeny { get; set; }
        public KuldemenyAdatWindow()
        {
            UjKuldemeny = new Kuldemeny { Szolgaltatas = ViewModel.Get().KivalasztottSzolgaltatas, Megjegyzesek=new BindingList<string>() };
            DataContext = UjKuldemeny;
            InitializeComponent();
        }

        private void btn_Megjegyzes_Click(object sender, RoutedEventArgs e)
        {
            UjKuldemeny.Megjegyzesek.Add(txtMegjegyzes.Text);
            lstMegjegyzesek.GetBindingExpression(ListBox.ItemsSourceProperty).UpdateSource();
        }

        private void btn_Tarol_Click(object sender, RoutedEventArgs e)
        {
            txtNev.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtOrszag.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtVaros.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtIrszam.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtUtcaHazszam.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            this.DialogResult = true;
        }
    }
}
