using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablasHash
{
    class IndicePrincipal : List<Ranura>//el indice principal es una lista de ranuras
    {
        private int numero_registros_por_cubeta;
        private int numero_ranuras;
        private int tamaño_registro;
        private int direccion_cubetas_vacias;//creo que esto tambien debe ser una lista de cubetas
        private List<Cubeta> cubetas_vacias;
        private int direccionInicial;

        
        public int Numero_registros_por_cubeta
        {
            get { return this.numero_registros_por_cubeta; }
            set { this.numero_registros_por_cubeta = value; }
        }

        public int Numero_ranuras
        {
            get { return this.numero_ranuras; }
            set { this.numero_ranuras = value; }
        }

        public int Tamaño_registro
        {
            get { return this.tamaño_registro; }
            set { this.tamaño_registro = value; }
        }
        
        public int Direccion_cubetas_vacias
        {
            get { return this.direccion_cubetas_vacias; }
            set { this.direccion_cubetas_vacias = value; }
        }
        
        public List<Cubeta> Cubetas_vacias
        {
            get { return this.cubetas_vacias; }
            set { this.cubetas_vacias = value; }
        }

        public int DireccionInicial
        {
            get { return this.direccionInicial; }
            set { this.direccionInicial = value; }
        }

        public IndicePrincipal(int numero_registros_por_cubeta, int numero_ranuras, int tamaño_registro, int direccionInicial)
        {
            this.numero_registros_por_cubeta = numero_registros_por_cubeta;
            this.numero_ranuras = numero_ranuras;
            this.tamaño_registro = tamaño_registro;
            this.direccionInicial = direccionInicial;
            this.direccion_cubetas_vacias = 0;
            this.cubetas_vacias = new List<Cubeta>();
        }
    }
}
