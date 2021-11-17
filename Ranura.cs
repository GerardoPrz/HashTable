using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablasHash
{
    class Ranura
    {
        private List<Cubeta> cubetas;//cada ranura tiene un lista de cubetas

        public List<Cubeta> Cubetas
        {
            get { return this.cubetas; }
            set { this.cubetas = value; }
        }

        public Ranura()
        {
            this.cubetas = new List<Cubeta>();
        }

    }
}
