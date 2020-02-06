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
        KnjizaraBaza KB = new KnjizaraBaza();
        private string pretraga;
        public string Pretraga
        {
            get => pretraga;
            set
            {
                pretraga = value;

                KB = new KnjizaraBaza();
                if (string.IsNullOrEmpty(pretraga) || string.IsNullOrWhiteSpace(pretraga))
                {
                    
                    dgBiblioteka.ItemsSource = KB.dbKnjiga.ToList();
                }
                else
                {
                    

                    dgBiblioteka.ItemsSource = KB.dbKnjiga.Where(s => s.Autor.ToLower().Contains(pretraga.ToLower()) ||
                                                                     s.ISBN.ToLower().Contains(pretraga.ToLower()) ||
                                                                     s.Naziv.ToLower().Contains(pretraga.ToLower())).ToList();
                }
            }
        }
        public Profil()
        {
            InitializeComponent();

            KB.dbKnjiga.ToList();
            dgBiblioteka.ItemsSource = KB.dbKnjiga.Local;

            KB.SaveChanges();

            txtPretraga.DataContext = this;


        }

        private void odust_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.BindingGroup.CommitEdit();
            this.Close();
        }

        
    }
}
