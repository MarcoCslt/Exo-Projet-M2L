using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2L
{
    public class Adherents
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public DateTime dateAdhesion { get; set; }

        public Adherents()
        {

        }

        public Adherents(int id, string nom, string prenom)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.dateAdhesion = DateTime.Now;
        }

        public DateTime getDateAdhesion()
        {
            return dateAdhesion;
        }

        public string getNom()
        {
            return nom;
        }

        public string getPrenom()
        {
            return prenom;
        }
    }
}
