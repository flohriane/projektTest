using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using projektTest;

namespace testsFürProjektTest
{
    [TestFixture]
    public class Tests1
    {
        [Test, Category ("Akzeptanztest")]
        public void Zahlen_zwischen_UG_OG()
        {
            var ergebnis = ProjektClass.Start_Zahlen_testen(3, 5);
            Assert.AreEqual(new[] { 3, 4, 5 }, ergebnis.ToArray());
        }
        [Test, Category("Gerüsttest")]
        public void Test_Zahlen_testen()
        {
            var ergebnis = ProjektClass.Zahlen_testen(0, 23);
            Assert.AreEqual(24, ergebnis.Count());
        }
    }
}
