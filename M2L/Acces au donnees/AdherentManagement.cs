using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2L
{
    public class AdherentManagement
    {
        List<Adherents> lesAdherents;

        public AdherentManagement()
        {
            lesAdherents = new List<Adherents>();
        }

        public void ajouterAdherent(Adherents unAdherent)
        {
            lesAdherents.Add(unAdherent);
        }

        public List<Adherents> getLesAdherents()
        {
            return lesAdherents;
        }

        public void supprimerAdherent(Adherents unAdherent)
        {
            lesAdherents.Remove(unAdherent);
        }
    }
}
