using System;

using DesignPatternsStuff;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsStuffTests
{
    [TestClass]
    public class PrototypeTests
    {
        [TestMethod]
        public void PrototypeTest()
        {
            ColorManager colormanager = new ColorManager();

            // Initialize with standard colors

            colormanager["red"] = new Color(255, 0, 0);
            colormanager["green"] = new Color(0, 255, 0);
            colormanager["blue"] = new Color(0, 0, 255);

            // User adds personalized colors

            colormanager["angry"] = new Color(255, 54, 0);
            colormanager["peace"] = new Color(128, 211, 128);
            colormanager["flame"] = new Color(211, 34, 20);

            // User clones selected colors

            Color color1 = colormanager["red"].Clone() as Color;
            Color color2 = colormanager["peace"].Clone() as Color;
            Color color3 = colormanager["flame"].Clone() as Color;

            Assert.IsTrue(color1.Red == 255);
            Assert.IsTrue(color1.Green == 0);
            Assert.IsTrue(color1.Blue == 0);

            Assert.IsTrue(color2.Red == 128);
            Assert.IsTrue(color2.Green == 211);
            Assert.IsTrue(color2.Blue == 128);

            Assert.IsTrue(color3.Red == 211);
            Assert.IsTrue(color3.Green == 34);
            Assert.IsTrue(color3.Blue == 20);
        }
    }
}
