using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bataille_navale.Models.commons
{
    public interface FabriqueDeBateaux
    {
        PorteAvion CreerPorteAvion();
        Croiseur CreerCroiseur();
        ContreTorpilleur CreerContreTorpilleur();
        Torpilleur CreerTorpilleur();
    }
}
