using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsStuff
{
    public class LoadBalancer
    {
        protected LoadBalancer()
        {
            Servers = new List<string>();
            Random = new Random(1); // a known seed is used to produce predictable results

            Servers.Add("ServerI");
            Servers.Add("ServerII");
            Servers.Add("ServerIII");
            Servers.Add("ServerIV");
            Servers.Add("ServerV");
        }

        public string Server
        {
            get
            {
                int r = Random.Next(Servers.Count);
                return Servers[r].ToString();
            }
        }

        private static LoadBalancer Instance { get; set; }
        private List<string> Servers { get; set; }
        private Random Random { get; set; }

        public static LoadBalancer GetLoadBalancer()
        {
            if (Instance == null)
            {
                lock (SyncLock)
                {
                    if (Instance == null)
                    {
                        Instance = new LoadBalancer();
                    }
                }
            }

            return Instance;
        }

        private static object SyncLock = new object();
    }
}
