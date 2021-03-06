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

namespace WpfApp15
{
    /// <summary>
    /// Interaction logic for Izmena.xaml
    /// </summary>
    public partial class Izmena : Window
    {
        public Izmena()
        {
            InitializeComponent();
            if (DataContext == null)
                DataContext = new Clanovi();
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.BindingGroup.CommitEdit();
            this.Close();
        }

        private void odustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
