using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektTest
{
    public class ProjektClass
    {
        public static List<int> Start_Zahlen_testen(int untergrenze, int obergrenze)
        {
            var zahlen = Zahlen_testen(untergrenze, obergrenze);
            return zahlen;
        }
        internal static List<int> Zahlen_testen(int ug, int og)
        {
            var zahlen = new List<int>();
            for (int z = ug; z <= og; z++)
            {
                zahlen.Add(z);
            }
            return zahlen;
        }
    }
}
