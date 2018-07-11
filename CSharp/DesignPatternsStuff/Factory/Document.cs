using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsStuff
{
    public abstract class Document
    {
        public Document()
        {
            Pages = new List<Page>();
            this.CreatePages();
        }

        public List<Page> Pages { get; private set; }

        public abstract void CreatePages();
    }
}
