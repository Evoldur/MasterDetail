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
using Metier;
using System.Collections.ObjectModel;
using Microsoft.Win32;

namespace ProjetGot
{
    /// <summary>
    /// Logique d'interaction pour FormulaireFamille.xaml
    /// </summary>
    public partial class FormulaireFamille : Window
    {
        private Manager Liste { get; set; }

        public FormulaireFamille(Manager liste)
        {
            Liste = liste;
            InitializeComponent();
        }

        public void ValiderFamille(object sender, RoutedEventArgs e)
        {
            string nom = formulaireFamille.txtNomFamille.Text;
            string embleme = formulaireFamille.txtEmbleme.Text;
            string devise = formulaireFamille.txtDevise.Text;
            Liste.Add(new Famille(txtNomFamille.Text, txtEmbleme.Text, txtDevise.Text,new ObservableCollection<Perso>()));
            Close();
        }

        private void QuitterFormulaire(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Parcourir(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string filename = dlg.FileName;
                txtEmbleme.Text = filename;
            }
        }
    }
}
