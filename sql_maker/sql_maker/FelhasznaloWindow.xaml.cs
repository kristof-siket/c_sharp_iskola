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
    /// Interaction logic for FelhasznaloWindow.xaml
    /// </summary>
    public partial class FelhasznaloWindow : Window
    {
        ViewModel VM;

        public FelhasznaloWindow()
        {
            VM = ViewModel.Get();
            this.DataContext = VM;
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            VM.Query = string.Format("INSERT INTO Felhasznalo values ('{0}', {1}, {2}, {3}, {4}, {5}, {6});\n", txtFelhNev.Text, txtEMail.Text, txtJelszo.Text, txtTeljesNev.Text, txtTelefon.Text, txtLakcim.Text, txtAdmin.Text);
            txtAdmin.Text = "";
            txtEMail.Text = "";
            txtFelhNev.Text = "";
            txtJelszo.Text = "";
            txtLakcim.Text = "";
            txtTelefon.Text = "";
            txtTeljesNev.Text = "";
        }
    }
}
