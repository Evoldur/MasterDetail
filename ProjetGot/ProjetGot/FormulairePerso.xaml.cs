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

namespace ProjetGot
{
    /// <summary>
    /// Logique d'interaction pour FormulairePerso.xaml
    /// </summary>
    public partial class FormulairePerso : Window
    {
        Manager allCharacters;

        public FormulairePerso(Manager liste)
        {
            InitializeComponent();
            allCharacters = liste;
        }

        

        private void Quitter(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AjouterPerso(object sender, RoutedEventArgs e)
        {
            string prenom = UCperso.txtPrenom.Text;
            string portrait = UCperso.txtPortrait.Text;
            Sexe sexe = Sexe.Homme;
            if (UCperso.rbHomme.IsChecked == false)
            {
                sexe = Sexe.Femme;
            }
            Famille famille = (Famille)UCperso.ComboFamille.SelectedItem;
            Perso pere = (Perso)UCperso.ComboPere.SelectedItem;
            Perso mere = (Perso)UCperso.ComboMere.SelectedItem;
            string desc = UCperso.txtDescription.Text;
            famille.persos.Add(new Perso(prenom, portrait, desc, pere, mere, sexe));
            allCharacters.TousPersonnages.Add(new Perso(prenom, portrait, desc, pere, mere, sexe));
            Close();
        }
    }
}
