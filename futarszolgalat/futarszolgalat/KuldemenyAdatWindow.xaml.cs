﻿using System;
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

namespace futarszolgalat
{
    /// <summary>
    /// Interaction logic for KuldemenyAdatWindow.xaml
    /// </summary>
    public partial class KuldemenyAdatWindow : Window
    {
        ViewModel VM = ViewModel.Get();
        public Kuldemeny UjKuldemeny { get; set; }
        public KuldemenyAdatWindow()
        {
            UjKuldemeny = new Kuldemeny { Szolgaltatas = VM.KivalasztottSzolgaltatas};
            DataContext = UjKuldemeny;
            InitializeComponent();
        }
    }
}
