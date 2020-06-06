using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
			List<OOP_lab_5_6_3.Hour> hours = new List<OOP_lab_5_6_3.Hour>();
			hours.Add(new OOP_lab_5_6_3.Hour("Druzhby Narodiv", 2002, 793, "Kiev"));
			hours.Add(new OOP_lab_5_6_3.Hour("Palats Sportu", 1992, 1475, "Center of Kiev"));
			hours.Add(new OOP_lab_5_6_3.Hour("Arsenalna", 1989, 1284, "Also in Kiev"));
			hours.Add(new OOP_lab_5_6_3.Hour("Poshtova Ploscha", 1997, 944, "Still some Kiev"));
			hours.Add(new OOP_lab_5_6_3.Hour("Dnipro", 1979, 1537, "Some Kiev with Dnipro in it"));

			int sum = OOP_lab_5_6_3.Hour.PassengersSum(ref hours);
			OOP_lab_5_6_3.Hour leastHour = OOP_lab_5_6_3.Hour.LeastPassengers(ref hours);
			OOP_lab_5_6_3.Hour mostWordsHour = OOP_lab_5_6_3.Hour.MostWordsInComment(ref hours);

			Assert.AreEqual(6033, sum);
			Assert.AreEqual(hours[0], leastHour);
			Assert.AreEqual(hours[4], mostWordsHour);
		}
    }
}
