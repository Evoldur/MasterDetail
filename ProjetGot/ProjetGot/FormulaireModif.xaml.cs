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
using System.Windows.Forms;


namespace ProjetGot
{
    /// <summary>
    /// Logique d'interaction pour FormulaireModif.xaml
    /// </summary>
    public partial class FormulaireModif : Window
    {
        Manager Mana;
        Perso persoModif;
        Famille familleModif;
        public FormulaireModif(Perso p, Famille f, Manager liste)
        {
            InitializeComponent();
            Mana = liste;
            persoModif = p;
            familleModif = f;
            UCModif.txtPrenom.Text = p.Prenom;
            UCModif.txtPortrait.Text = p.Portrait;
            UCModif.txtDescription.Text = p.Description;
            if (p.sexe == Sexe.Homme)
            {
                UCModif.rbHomme.IsChecked = true;
            }
            else
            {
                UCModif.rbFemme.IsChecked = true;
            }
            UCModif.ComboFamille.SelectedValue = f;
            UCModif.ComboPere.SelectedValue = p.Pere;
            UCModif.ComboMere.SelectedValue = p.Mere;
        }

        private void Quitter(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ValiderModif(object sender, RoutedEventArgs e)
        {
            Mana.TousPersonnages.Remove(persoModif);
            familleModif.persos.Remove(persoModif);
            string prenom = UCModif.txtPrenom.Text;
            string portrait = UCModif.txtPortrait.Text;
            Sexe sexe = Sexe.Homme;
            if (UCModif.rbHomme.IsChecked == false)
            {
                sexe = Sexe.Femme;
            }
            Famille famille = (Famille)UCModif.ComboFamille.SelectedItem;
            Perso pere = (Perso)UCModif.ComboPere.SelectedItem;
            Perso mere = (Perso)UCModif.ComboMere.SelectedItem;
            string desc = UCModif.txtDescription.Text;
            famille.persos.Add(new Perso(prenom, portrait, desc, pere, mere, sexe));
            Mana.TousPersonnages.Add(new Perso(prenom, portrait, desc, pere, mere, sexe));
            Close();
        }
    }
}
