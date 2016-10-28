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
    /// Interaction logic for RendelesWindow.xaml
    /// </summary>
    public partial class RendelesWindow : Window
    {
        ViewModel VM;
        public RendelesWindow()
        {
            VM = ViewModel.Get();
            DataContext = VM;
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            VM.Query += string.Format("INSERT INTO Rendeles values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');\n", txtFelhNev.Text, txtGyarto.Text, txtModell.Text, txtSzin.Text, dtpDatum.SelectedDate, txtTeljesitett.Text);
            
            txtFelhNev.Text = "";
            txtGyarto.Text = "";
            txtModell.Text = "";
            txtSzin.Text = "";
            txtTeljesitett.Text = "";
            dtpDatum.SelectedDate = DateTime.Now;
        }

        private void rendeles_closing_handler(object sender, System.ComponentModel.CancelEventArgs e)
        {
            VM.FajlbaKiir("add_rendeles.sql");
        }
    }
}
