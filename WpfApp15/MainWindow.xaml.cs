using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace WpfApp15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
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
                    dgClanovi.ItemsSource = KB.dbClanovi.ToList();
                else
                    dgClanovi.ItemsSource = KB.dbClanovi.Where(s => s.Ime.ToLower().Contains(pretraga.ToLower()) ||
                                                                      s.Prezime.ToLower().Contains(pretraga.ToLower())).ToList();

                //ObservableCollection<Student> studenti = new ObservableCollection<Student>();
                //foreach (Student s in db.dbStudenti.Local)
                //	if (s.Ime.ToLower().Contains(pretraga.ToLower()) ||
                //		s.Prezime.ToLower().Contains(pretraga.ToLower()))
                //		studenti.Add(s);
                //dgStudenti.ItemsSource = studenti;



            }
        }

        public MainWindow()
        {
            InitializeComponent();
            KB.dbKnjiga.ToList();
            KB.dbClanovi.ToList();
          //  KB.dbKnjiga.Add(new Knjiga("A001", "Rat", "Irfan", "2020", "Da"));
          //  KB.dbKnjiga.Add(new Knjiga("A002", "Peacekeeper", "Ruza", "1950", "Ne"));
          //  KB.dbClanovi.Add(new Clanovi("Armin", "Mujkovic", "//","Save Kovacevica 192"));
          //KB.dbClanovi.Add(new Clanovi("Edin", "Kurtanovic", "//", "Stevana Nemanje e/27"));
           KB.SaveChanges();
            
            dgKnjiga.ItemsSource = KB.dbKnjiga.Local;
            dgClanovi.ItemsSource = KB.dbClanovi.Local;
            txtPretraga.DataContext = this;


        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            Izmena novaIzmena = new Izmena();
            novaIzmena.Owner = this;
            novaIzmena.DataContext = dgKnjiga.SelectedItem;
            if(novaIzmena.ShowDialog() == true)
            {
               
            }
        }

        
        private void dgClanovi_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
                Profil noviProfil = new Profil();
                noviProfil.Owner = this;
                noviProfil.DataContext = dgClanovi.SelectedItem;
                if (noviProfil.ShowDialog() == true)
                {
                    KB.SaveChanges();
                    KB = new KnjizaraBaza();

                    dgClanovi.ItemsSource = KB.dbClanovi.ToList();
                }
            
        }

        private void txtPretraga_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }


    public class KnjizaraBaza:DbContext
    {
        public DbSet<Knjiga> dbKnjiga { set; get; }
        public DbSet<Clanovi> dbClanovi { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Knjiga>().HasKey(k => k.ISBN);
            modelBuilder.Entity<Clanovi>().HasKey(c => c.ID);
        }


    }

    

}
