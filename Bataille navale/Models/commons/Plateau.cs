using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bataille_navale.Models.commons
{
    public class Plateau : FabriqueDeCases
    {
        public Plateau FabriquerCase()
        {
            return new Plateau();
        }
    }
}
