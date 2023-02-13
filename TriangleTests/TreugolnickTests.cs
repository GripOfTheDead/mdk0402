using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle.Tests
{
    [TestClass()]
    public class TreugolnickTests
    {
        [TestMethod()]
        public void CheckingForNegativeNumbers()
        {
            Treugolnick triangle = new Treugolnick();
            triangle.TreugMet(-10, -5, -50, -50, -1, -1);
        }

        public void CheckingForPositiveNumbers()
        {
            Treugolnick triangle = new Treugolnick();
            triangle.TreugMet(10,5, 50,50, 1,1);
        }
        
    }
}