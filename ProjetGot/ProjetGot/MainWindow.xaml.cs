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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Metier;
using System.Collections.ObjectModel;

namespace ProjetGot
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickAddFamille(object sender, RoutedEventArgs e)
        {
            CollectionViewSource collection = (FenetrePrincipale.Resources["Liste"] as CollectionViewSource);
            Manager Liste = (Manager) collection.Source;
            FormulaireFamille formulairefamille = new FormulaireFamille(Liste);
            formulairefamille.ShowDialog();
        }

        private void ListPerso_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ClickAddPerso(object sender, RoutedEventArgs e)
        {
            CollectionViewSource collection = (FenetrePrincipale.Resources["Liste"] as CollectionViewSource);
            Manager Liste = (Manager)collection.Source;
            FormulairePerso formulaireP = new FormulairePerso(Liste);
            formulaireP.ShowDialog();
            
        }

        private void ClickModifPerso(object sender, RoutedEventArgs e)
        {
            CollectionViewSource collection = (FenetrePrincipale.Resources["Liste"] as CollectionViewSource);
            Manager Liste = (Manager)collection.Source;
            Perso p = (Perso)ListPerso.SelectedItem;
            Famille f = (Famille)List.SelectedItem;
            FormulaireModif formmod = new FormulaireModif(p,f, Liste);
            formmod.ShowDialog();
        }

      
        private void ClickSupprPerso(object sender, RoutedEventArgs e)
        {
            CollectionViewSource collection = (FenetrePrincipale.Resources["Liste"] as CollectionViewSource);
            Manager Liste = (Manager)collection.Source;
            Liste.TousPersonnages.Remove((Perso)ListPerso.SelectedItem);
            ((Famille)List.SelectedItem).persos.Remove((Perso)ListPerso.SelectedItem);
        }

        private void ClickSupprFamille(object sender, RoutedEventArgs e)
        {
            CollectionViewSource collection = (FenetrePrincipale.Resources["Liste"] as CollectionViewSource);
            Manager Liste = (Manager)collection.Source;
            foreach (Perso p in ((Famille)List.SelectedItem).persos)
            {
                Liste.TousPersonnages.Remove(p);
            }
            Liste.Remove((Famille)List.SelectedItem);
        }
    }
}
