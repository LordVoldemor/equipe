using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuMonstreÉquipe
{
    class MonstreFacile
    {
        private int degat = 5;
        public De deAttaque = new De();
        public bool estVivant { get { return this.estVivant; } set { this.estVivant = false; } }

        public bool Attaque(Joueur player)
        // Retourne true si l'attaque du monstre fonctionne
        {
            int attaqueJoueur = player.deAttaque.LancerLeDe();
            int attaqueMonstre = this.deAttaque.LancerLeDe();
            if (attaqueMonstre > attaqueJoueur) { player.SubitDegats(this.degat); return true; }
            else return false;
            //commentaire 11111
        }
    }
}
