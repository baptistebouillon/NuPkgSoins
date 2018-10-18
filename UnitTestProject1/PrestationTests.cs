using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassesMetier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassesMetier.Tests
{
    [TestClass()]
    public class PrestationTests
    {
       

        [TestMethod()]
        public void CompareToTestegal()
        {
            Prestation unePrestation = new Prestation("XX", new DateTime(2015, 9, 9, 11, 0, 0), new Intervenant("Dupont", "Jean"));
            Prestation uneAutrePrestation = new Prestation("YY", new DateTime(2015, 9, 9, 11, 0, 0), new Intervenant("Dutronc", "Jaque"));
            Assert.AreEqual(0, unePrestation.compareTo(uneAutrePrestation));
        }

        [TestMethod()]
        public void CompareToTestpost()
        {
            Prestation unePrestation = new Prestation("XX", new DateTime(2015, 10, 9, 11, 0, 0), new Intervenant("Dupont", "Jean"));
            Prestation uneAutrePrestation = new Prestation("YY", new DateTime(2015, 9, 9, 11, 0, 0), new Intervenant("Dutronc", "Jaque"));
            Assert.AreEqual(1, unePrestation.compareTo(uneAutrePrestation));
        }

        [TestMethod()]
        public void CompareToTestante()
        {
            Prestation unePrestation = new Prestation("XX", new DateTime(2015, 9, 9, 11, 0, 0), new Intervenant("Dupont", "Jean"));
            Prestation uneAutrePrestation = new Prestation("YY", new DateTime(2015, 10, 9, 11, 0, 0), new Intervenant("Dutronc", "Jaque"));
            Assert.AreEqual(-1, unePrestation.compareTo(uneAutrePrestation));
        }
    }
}