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

namespace WpfApp15
{
    /// <summary>
    /// Interaction logic for Profil.xaml
    /// </summary>
    public partial class Profil : Window
    {
        public Profil()
        {
            InitializeComponent();
            if (DataContext == null)
                DataContext = new Knjiga();
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.BindingGroup.CommitEdit();
            this.Close();
        }

        private void odust_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dgClanovi_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        //private string pret;
        //public string Pretraga
        //{
        //    get => pret;

        //    set
        //    {
        //        pret = value;
                
        //        dgProfilIznajmljeno.ItemsSource = 
                    
        //    }
        //}
    }
}
