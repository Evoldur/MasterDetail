using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Metier
{
    public class Famille
    {
        public ObservableCollection<Perso> persos { get; set; }
        public string Nom { get; set; }
        public string Embleme { get; set; }
        public string Devise { get; set; }

        public Famille( string nom, string embleme, string devise, ObservableCollection<Perso>familly)
        {
            this.Nom = nom;
            this.Embleme = embleme;
            this.Devise = devise;
            this.persos = familly;
        }

       /* public void AddPerso(Perso pelo)
        {
            persos.Add(pelo);
        }*/
        /*
        public override string ToString()
        {
            return Nom;
        }*/
    }
}
