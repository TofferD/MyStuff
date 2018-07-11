using System;

using DesignPatternsStuff;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsStuffTests
{
    [TestClass]
    public class SingletonTests
    {
        [TestMethod]
        public void SingletonTest()
        {
            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b4 = LoadBalancer.GetLoadBalancer();

            Assert.IsTrue(b1 == b2);
            Assert.IsTrue(b1 == b3);
            Assert.IsTrue(b1 == b4);
            Assert.IsTrue(b2 == b1);
            Assert.IsTrue(b2 == b3);
            Assert.IsTrue(b2 == b4);
            Assert.IsTrue(b3 == b1);
            Assert.IsTrue(b3 == b2);
            Assert.IsTrue(b3 == b4);
            Assert.IsTrue(b4 == b1);
            Assert.IsTrue(b4 == b2);
            Assert.IsTrue(b4 == b3);

            string serverNames = string.Empty;

            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
            for (int i = 0; i < 15; i++)
            {
                serverNames += balancer.Server;
            }

            Assert.IsTrue(serverNames == "ServerIIServerIServerIIIServerIVServerIVServerIIIServerIIServerVServerIServerIVServerIServerIIServerIIServerVServerIV");
        }
    }
}
