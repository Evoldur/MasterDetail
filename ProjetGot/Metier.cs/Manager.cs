using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Manager : ObservableCollection<Famille>
    {
        private ObservableCollection<Perso> tousPersonnages = new ObservableCollection<Perso>();
        public ObservableCollection<Perso> TousPersonnages { get { return tousPersonnages; } set { tousPersonnages = value; } }

       
       /* public List<Perso> getallPersos()
        {
            return tousPersonnages;
        }*/

        public Manager():base()
        {
            ObservableCollection<Perso> stark = new ObservableCollection<Perso>();
            ObservableCollection<Perso> lannister = new ObservableCollection<Perso>();
            ObservableCollection<Perso> targaryen = new ObservableCollection<Perso>();

            Perso inconnuP = new Perso("Inconnu", null, null, null, null, Sexe.Homme);
            Perso inconnuM = new Perso("Inconnue", null, null, null, null, Sexe.Femme);
            Perso eddard = new Perso("Eddard", "Images/EddardStark.jpg", "Eddard Ned Stark est le seigneur du Nord, jusqu'à ce que le Roi Robert Barathéon lui demande de lui venir en aide. Il doit alors rejoindre King's Landind, la capitale du continent, pour devenir son conseiller. A la mort du roi, ce dernier le nomme régent du trône le temps que son fils soit en âge de gouverner, mais il est trahi et suite à un procès sommaire, il est executé en place public", inconnuP, inconnuM, Sexe.Homme);
            Perso bran = new Perso("Bran", "Images/mgid-ao-image-mtv.jpg", "Bran est le dernier enfant né de Ned et Catelyn Stark. Passant une bonne partie de son temps libre à grimper sur les murs, il tombe 'accidentellement' d'une tour, ce qui le rend parapégique. Il decouvre peu de temps après qu'il possède des dons de voyances, ainsi que de controle mental. Suite à divers incidents, il est amené à quitter Winterfell, la ville ou il vit, pour aller encore plus vers le Nord", eddard, inconnuM, Sexe.Homme);
            Perso tyrion = new Perso("Tyrion", "Images/8sUE9d4C.jpg", "Tyrion est le dernier fils de Tywin Lannister. Sa mère mourut en le mettant au monde, ce qui lui vaut le mépris de sa soeur. La nature étant mal faite quand elle le souhaite, Tyrion est également atteint de nainnisme, ce qui est une honte pour sa famille selon mon père. Après avoir été accusé de tentative de meurtre sur Bran, il devient conseiller du jeune roi Joffrey jusqu'à ce que son père prenne sa place. Il est accusé (encore) du meurtre du roi Joffrey, mais s'échappe de la capitale en tuant son père sur le trone au passage.", inconnuP, inconnuM, Sexe.Homme);
            Perso daenerys = new Perso("Daenerys", "Images/game-of-thrones-daenerys-targaryen.jpg", "Daenerys est la fille de Aegon Targaryen, elle est mariée par son frère Vylerys à Khal Drogo, un chef Dothraki, en échange de l'utilisation de ses hommes pour reconquérir le trône de fer et d'oeufs fossilisés de dragons. Cependant, Vylerys est trahi pour Drogo et Daenerys, et se fait tuer. Après la mort de Drogo, Daenerys trouve le moyen de faire éclore les oeufs de dragons et décide de reprendre le contrôle de la baie des serfs, afin d'y abolir l'esclavage, son objectif étant de se constituer une armée pour pouvoir, elle aussi, reconquérir le trône de fer.", inconnuP, inconnuM, Sexe.Femme);
           

            stark.Add(eddard);
            stark.Add(bran);
            lannister.Add(tyrion);
            targaryen.Add(daenerys);

            Add(new Famille("Stark", "Images/game_of_thrones_house_stark_sigil_render_by_titch_ix-d50m12c.png", "Winter is coming", stark));
            Add(new Famille("Lannister", "Images/House_lannister.png", "Hear me roar", lannister));
            Add(new Famille("Targaryen", "Images/sticker-targaryen-game-of-thrones-2187.png", "Fire and Blood", targaryen));
           
            tousPersonnages.Add(eddard);
            tousPersonnages.Add(bran);
            tousPersonnages.Add(tyrion);
            tousPersonnages.Add(daenerys);
            tousPersonnages.Add(inconnuP);
            tousPersonnages.Add(inconnuM);
        }
    }
}
