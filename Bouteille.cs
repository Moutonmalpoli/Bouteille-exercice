namespace ClassLibraryBouteille
{
    public class Bouteille
    {
        private decimal contenanceEnLitre;
        private decimal contenuEnLitre;
        private Boolean estOuverte;



        //constructeur par defaut
        public Bouteille() : this(false, 1, 1)
        {

        }

        //constructeur classique
        public Bouteille(bool estOuverte, decimal contenuEnLitre, decimal contenanceEnLitre)
        {
            if (contenuEnLitre <= 0)
            {
                throw new ArgumentException("Le contenuEnLitre d'une bouteille ne peut être que positif", nameof(contenuEnLitre));
            }


            this.estOuverte = estOuverte;
            this.contenuEnLitre = contenuEnLitre;
            this.contenanceEnLitre = contenanceEnLitre;



        }

        //constructeur par clonage
        public Bouteille(Bouteille bouteilleACopier) : this(false, 1, 1)
        {
            //this.estOuverte = bouteilleACopier.estOuverte;
            //this.contenanceEnLitre = bouteilleACopier.contenanceEnLitre;
            //this.contenuEnLitre = bouteilleACopier.contenuEnLitre;
        }



        public override string ToString()
        {
            return base.ToString() + " estOuverte= " + estOuverte + " contenanceEnLitre= " + contenanceEnLitre + " contenuEnLitre= " + contenuEnLitre;
        }

        public bool Ouvrir()
        {
            if (this.estOuverte == false)
            {
                this.estOuverte = true;
                return true;
            }
            else
            {

                return false;
            }

        }
        public bool Remplir(decimal quantiteARemplir)
        {
            if (quantiteARemplir <= 0)
            {
                throw new ArgumentException("La quantiteARemplir d'une bouteille ne peut être que positif", nameof(quantiteARemplir));
            }
            if (this.contenuEnLitre + quantiteARemplir <= this.contenanceEnLitre && this.estOuverte == true)
            {
                this.contenuEnLitre += quantiteARemplir;
                return true;
            }
            else
            {

                return false;
            }
        }
        public bool Vider(decimal quantiteAVider)
        {
            if (quantiteAVider <= 0)
            {
                throw new ArgumentException("La quantiteAVider d'une bouteille ne peut être que positif", nameof(quantiteAVider));
            }
            if (this.contenuEnLitre - quantiteAVider >= 0 && this.estOuverte == true)
            {
                this.contenuEnLitre -= quantiteAVider;
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Transferer(Bouteille bouteilleDestination, decimal quantiteATransferer)
        {
            if (this.estOuverte == true && bouteilleDestination.estOuverte == true && this.contenuEnLitre - quantiteATransferer >= 0
                && bouteilleDestination.contenuEnLitre + quantiteATransferer <= bouteilleDestination.contenanceEnLitre)
            {
                this.contenuEnLitre -= quantiteATransferer;
                bouteilleDestination.contenuEnLitre += quantiteATransferer;
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
