using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuMonstreÉquipe
{
    class De
    {
        public int LancerLeDe()
        {
            Random random = new Random();
            int tirage = random.Next(1, 7);
            return tirage;
        }
    }
}
