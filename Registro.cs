using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablasHash
{
    class Registro
    {
        private int clave;
        private int direccion;
        private int direccion_siguiente_registro;

        public int Clave
        {
            get { return this.clave; }
            set { this.clave = value; }
        }

        public int Direccion
        {
            get { return this.direccion; }
            set { this.direccion = value; }
        }

        /*private int Direccion_siguiente_registro
        {
            get { return this.direccion_siguiente_registro; }
            set { this.direccion_siguiente_registro = value; }
        }*/

        public Registro(int clave, int direccion)
        {
            this.clave = clave;
            this.direccion = direccion;
        }
    }
}
