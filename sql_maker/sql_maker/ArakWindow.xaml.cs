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
    /// Interaction logic for ArakWindow.xaml
    /// </summary>
    public partial class ArakWindow : Window
    {
        ViewModel VM;
        public ArakWindow()
        {
            VM = ViewModel.Get();
            this.DataContext = VM;
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            VM.Query += string.Format("INSERT INTO Arak values ('{0}', '{1}', '{2}', {3});\n", txtGyarto.Text, txtModell.Text, cmbKateg.SelectedItem.ToString(), txtAr.Text);
            txtAr.Text = "";
            txtGyarto.Text = "";
            txtModell.Text = "";
            cmbKateg.SelectedItem = null;
        }

        private void arak_closing_handler(object sender, System.ComponentModel.CancelEventArgs e)
        {
            VM.FajlbaKiir("add_arak.sql");
        }
    }
}
