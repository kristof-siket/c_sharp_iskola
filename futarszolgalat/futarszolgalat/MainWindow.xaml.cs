using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace futarszolgalat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel VM;
        public MainWindow()
        {
            VM = ViewModel.Get();
            DataContext = VM;
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            VM.Kuldemenyek = new ObservableCollection<Kuldemeny>();
            KuldemenyAdatWindow KAW = new KuldemenyAdatWindow();
            if (KAW.ShowDialog() == true)
            {
                VM.Kuldemenyek.Add(KAW.UjKuldemeny);
            }
        }
    }
}
