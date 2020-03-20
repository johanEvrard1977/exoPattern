using Bataille_navale.Models.commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bataille_navale.Models
{
    public class Rouge : FabriqueDeBateaux
    {
        public ContreTorpilleur CreerContreTorpilleur()
        {
            return new ContreTorpilleur();
        }

        public Croiseur CreerCroiseur()
        {
            return new Croiseur();
        }

        public PorteAvion CreerPorteAvion()
        {
            return new PorteAvion();
        }

        public Torpilleur CreerTorpilleur()
        {
            return new Torpilleur();
        }
    }
}
