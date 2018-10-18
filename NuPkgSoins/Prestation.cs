using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetier
{
    public class Prestation
    {
        private string _libelle;
        /// <summary>
        /// property du libelle de la prestation
        ///(lecture seule)
        /// </summary>
        public string Libelle
        {
            get { return _libelle; }
            //test commit
           
        }
        private DateTime _dateHeureSoin;

        /// <summary>
        /// property de la date des soins
        /// (lecture seule)
        /// </summary>
        public DateTime DateHeureSoin
        {
            get { return _dateHeureSoin; }
        }

        public string  HeureSoin()
        {
            return this.DateHeureSoin.Hour + "h"+ this.DateHeureSoin.Minute  +" - " +this.DateHeureSoin.ToShortTimeString();
        }

        private Intervenant _unIntervenant;

        /// <summary>
        /// property de l'objet intervenant ayant réalisé la prestation
        /// (lecture seule)
        /// </summary>
        public Intervenant UnIntervenant
        {
            get { return _unIntervenant; }
        }
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="libelle"></param>
        /// <param name="uneDateHeure"></param>
        /// <param name="unIntervenant"></param>
        public Prestation(string libelle, DateTime uneDateHeure, Intervenant unIntervenant){
            this._libelle = libelle;
            this._dateHeureSoin = uneDateHeure;
            this._unIntervenant = unIntervenant;

        }
        /// <summary>
        /// fonction qui compare 2 dates au format DateHeure
        /// Attention ici, on ne compare que les dates.
        /// 2 dates seront égales si leur JJ/MM/AAAA  sont égaux, quelle que soit l'heure
        /// </summary>
        /// <param name="unePrestation"></param>
        /// <returns>
        ///     0 les dates sont égales
        ///     1 si la date de la prestation courante est postérieure à la date de la prestation unePrestation
        ///     -1 si la date de la prestation courante est antérieure à la date de la prestation unePrestation
        /// 
        /// </returns>
        public int compareTo(Prestation unePrestation)
        {
            //if(this.DateHeureSoin.Date > unePrestation.DateHeureSoin.Date) {
            //    return 1;
            //}
            //else
            //{
            //    if (this.DateHeureSoin.Date == unePrestation.DateHeureSoin.Date)
            //    {
            //        return 0;
            //    }
            //    else
            //    {
            //        return -1;
            //    }
            //}
            // bien mieux
            return this.DateHeureSoin.Date.CompareTo(unePrestation.DateHeureSoin.Date);
        }

        public override string ToString()
        {
            return this._libelle + " - " + this._dateHeureSoin.ToString();
        }

    }
}
