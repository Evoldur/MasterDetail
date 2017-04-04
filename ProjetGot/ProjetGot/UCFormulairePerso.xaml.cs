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
using Microsoft.Win32;

namespace ProjetGot
{
    /// <summary>
    /// Logique d'interaction pour UCFormulairePerso.xaml
    /// </summary>
    public partial class UCFormulairePerso : UserControl
    {
        public UCFormulairePerso()
        {
            InitializeComponent();
        }

        private void Parcourir(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string filename = dlg.FileName;
                txtPortrait.Text = filename;
            }
        }

        private void FiltrePapa(object sender, FilterEventArgs e)
        {
            Perso perso = e.Item as Perso;

            if (perso.sexe == Sexe.Homme)
            {
                e.Accepted = true;
            }

            if (perso.sexe == Sexe.Femme)
            {
                e.Accepted = false;
            }
        }

        private void FiltreMama(object sender, FilterEventArgs e)
        {
            Perso perso = e.Item as Perso;

            if (perso.sexe == Sexe.Homme)
            {
                e.Accepted = false;
            }

            if (perso.sexe == Sexe.Femme)
            {
                e.Accepted = true;
            }
        }
    }
}
