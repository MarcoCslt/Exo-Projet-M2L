using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2L
{
    public class CreationAdherents
    {
        public static List<Adherents> creationListe()
        {
            return new List<Adherents>() { new Adherents() { nom = "Poivey", prenom = "JF", id = 1, dateAdhesion = DateTime.Now},
                                           new Adherents() { nom = "Casalta", prenom = "Marco", id = 2, dateAdhesion = DateTime.Now},
                                           new Adherents() { nom = "Goku", prenom = "San", id = 3, dateAdhesion = DateTime.Now} };
        }
    }
}
