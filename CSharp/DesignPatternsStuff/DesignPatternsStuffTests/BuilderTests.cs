using System;

using DesignPatternsStuff;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsStuffTests
{
    [TestClass]
    public class BuilderTests
    {
        [TestMethod]
        public void BuilderTest()
        {
            VehicleBuilder builder;

            // Create shop with vehicle builders

            Shop shop = new Shop();

            // Construct and display vehicles

            builder = new ScooterBuilder();
            shop.Construct(builder);
            Assert.IsTrue(builder.Vehicle.VehicleType == "Scooter");
            Assert.IsTrue(builder.Vehicle.Parts["frame"] == "Scooter Frame");
            Assert.IsTrue(builder.Vehicle.Parts["engine"] == "50 cc");
            Assert.IsTrue(builder.Vehicle.Parts["wheels"] == "2");
            Assert.IsTrue(builder.Vehicle.Parts["doors"] == "0");

            builder = new CarBuilder();
            shop.Construct(builder);
            Assert.IsTrue(builder.Vehicle.VehicleType == "Car");
            Assert.IsTrue(builder.Vehicle.Parts["frame"] == "Car Frame");
            Assert.IsTrue(builder.Vehicle.Parts["engine"] == "2500 cc");
            Assert.IsTrue(builder.Vehicle.Parts["wheels"] == "4");
            Assert.IsTrue(builder.Vehicle.Parts["doors"] == "4");

            builder = new MotorcycleBuilder();
            shop.Construct(builder);
            Assert.IsTrue(builder.Vehicle.VehicleType == "Motorcycle");
            Assert.IsTrue(builder.Vehicle.Parts["frame"] == "Motorcycle Frame");
            Assert.IsTrue(builder.Vehicle.Parts["engine"] == "500 cc");
            Assert.IsTrue(builder.Vehicle.Parts["wheels"] == "2");
            Assert.IsTrue(builder.Vehicle.Parts["doors"] == "0");
        }
    }
}
