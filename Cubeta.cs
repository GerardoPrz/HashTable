using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablasHash
{
    class Cubeta 
    {
        private List<Registro> registros;//cada cubeta contiene una lista de registros
        private int direccion;
        private int direccion_siguiente_cubeta;


        public List<Registro> Registros
        {
            get { return this.registros; }
            set { this.registros = value; }
        }
        
        public int Direccion
        {
            get { return this.direccion; }
            set { this.direccion = value; }
        } 
        
        public int Direccion_siguiente_cubeta
        {
            get { return this.direccion_siguiente_cubeta; }
            set { this.direccion_siguiente_cubeta = value; }
        }

        public Cubeta()
        {
            this.registros = new List<Registro>();
            this.direccion = 0;
            this.direccion_siguiente_cubeta = 0;
        }
    }
}
