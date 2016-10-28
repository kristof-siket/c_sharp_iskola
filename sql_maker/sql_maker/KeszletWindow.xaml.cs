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

namespace sql_maker
{
    /// <summary>
    /// Interaction logic for KeszletWindow.xaml
    /// </summary>
    public partial class KeszletWindow : Window
    {
        ViewModel VM;
        public KeszletWindow()
        {
            VM = ViewModel.Get();
            DataContext = VM;
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            VM.Query += string.Format("INSERT INTO Keszlet values ('{0}', '{1}', '{2}', {3});\n", txtGyarto.Text, txtModell.Text, txtSzin.Text, txtKeszlet.Text);
            txtKeszlet.Text = "";
            txtGyarto.Text = "";
            txtModell.Text = "";
            txtSzin.Text = "";
        }

        private void keszlet_closing_handler(object sender, System.ComponentModel.CancelEventArgs e)
        {
            VM.FajlbaKiir("add_keszlet.sql");
        }
    }
}
