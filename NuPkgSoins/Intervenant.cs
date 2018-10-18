using System.Collections.ObjectModel;

namespace ClassesMetier
{
    public class Intervenant
    {
        private string _nom;

        public string Nom
        {
          get { return _nom; }
        }
        private string _prenom;

        public string Prenom
        {
          get { return _prenom; }
        }
        protected Collection<Prestation> _lesPrestations;

        public Collection<Prestation> LesPrestations
        {
          get { return _lesPrestations; }
          set { _lesPrestations = value; }
        }

        public Intervenant(string nom, string prenom){
            this._nom=nom;
            this._prenom=prenom;
            _lesPrestations=new Collection<Prestation>();
        }

        public override string ToString()
        {
            return "Intervenant : " + this.Nom + " - " + this.Prenom;
        }
        public virtual string AfficheIntervenantComplet()
        {
            return this.ToString() + this.SesInterventions();

        }
        protected string SesInterventions()
        {
            string chaine = "";
            foreach (Prestation unePrestation in this._lesPrestations)
            {
                chaine += "\n\t" + unePrestation;
            }
            return chaine;
        }

        ///////
        public void ajoutePrestation(Prestation prestation){
            this._lesPrestations.Add(prestation);
        }



    }
}
