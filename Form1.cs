using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TablasHash
{
    public partial class Form1 : Form
    {
        List<int> ingresados = new List<int>();
        int direccionAcumulador;
        IndicePrincipal tablaHash;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)//inicializar tabla hash
        {
            int numeroRegistrosPorCubeta = int.Parse(textBox_numeroRegistrosPorCubeta.Text);
            int numeroRanuras = int.Parse(textBox_numeroRanuras.Text);
            int tamañoRegistro = int.Parse(textBox_tamañoRegistro.Text);
            int direccionInicial = int.Parse(textBox_direccionInicial.Text);

            inicializaTablaHash(numeroRegistrosPorCubeta, numeroRanuras, tamañoRegistro, direccionInicial);
        }

        private void inicializaTablaHash(int numeroRegistrosPorCubeta, int numeroRanuras, int tamañoRegistro, int direccionInicial)
        {
            this.tablaHash = new IndicePrincipal(numeroRegistrosPorCubeta, numeroRanuras, tamañoRegistro, direccionInicial);
            this.direccionAcumulador = tablaHash.DireccionInicial;

            //creo las ranuras que especifico el usuario
            for (int i = 0; i < numeroRanuras; i++)
            {
                Ranura nuevaRanura = new Ranura();
                tablaHash.Add(nuevaRanura);
            }
            //creo cubetas de manera anticipada en la lista para no tener exceptions 
            foreach (Ranura ranura in tablaHash)
            {
                for (int i = 0; i < numeroRanuras; i++)
                {
                    Cubeta nuevaCubeta = new Cubeta();
                    ranura.Cubetas.Add(nuevaCubeta);
                }
            }
        }


        private void button_Insertar_Click(object sender, EventArgs e)
        {
            try
            {
                int clave_a_insertar = int.Parse(textBox_insertar.Text);
                int indice_de_ranura = funcionHash(clave_a_insertar);

                if (ingresados.Contains(clave_a_insertar))
                {
                    MessageBox.Show("Esta clave ya fue ingresada");
                }
                else
                {
                    insertar(clave_a_insertar, indice_de_ranura);
                    ingresados.Add(clave_a_insertar);
                }
                textBox_insertar.Text = "";
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Ingresa un dato valido");
            }

        }

        private void insertar(int clave_a_insertar, int indice_de_ranura)
        {
            //primero debo crear el registro con la clave que voy a insertar y aumento la direccion acumulada
            Registro nuevoRegistro = new Registro(clave_a_insertar, direccionAcumulador);
            direccionAcumulador += tablaHash.Tamaño_registro;

            Cubeta primerCubeta_de_la_ranura = tablaHash.ElementAt(indice_de_ranura).Cubetas.First();

            if (primerCubeta_de_la_ranura.Registros.Count == tablaHash.Numero_registros_por_cubeta)//si la primer cubeta de la ranura ya esta llena
            {
                //busca la cubeta que le corresponde
                Cubeta cubetaParaInsertar = buscaCubetaParaInsertar(clave_a_insertar, indice_de_ranura);

                cubetaParaInsertar.Registros.Add(nuevoRegistro);

                //si es el primer registro que se va a insertar en la cubeta entonces a la cubeta le asigno la direccion de ese  registro
                if (cubetaParaInsertar.Registros.Count == 1)
                {
                    cubetaParaInsertar.Direccion = nuevoRegistro.Direccion;
                }

                //ordeno la cubeta
                IEnumerable<Registro> cubetaOrdenada = cubetaParaInsertar.Registros.OrderBy(x => x.Clave);
                cubetaParaInsertar.Registros = cubetaOrdenada.ToList();

                //reviso si la cubeta donde inserte esta llena
                if (cubetaParaInsertar.Registros.Count > tablaHash.Numero_registros_por_cubeta)
                {
                    int indice_cubeta_actual = tablaHash.ElementAt(indice_de_ranura).Cubetas.IndexOf(cubetaParaInsertar);

                    Registro ultimoRegistro_cubetaActual = cubetaParaInsertar.Registros.Last();
                    recorrerRegistrosaSiguienteCubeta(indice_de_ranura, indice_cubeta_actual, cubetaParaInsertar);

                    //elimino el ultimo registro (el que recorrí)
                    cubetaParaInsertar.Registros.Remove(ultimoRegistro_cubetaActual);
                }
            }
            else if (primerCubeta_de_la_ranura.Registros.Count < tablaHash.Numero_registros_por_cubeta)//si la primer cubeta de la ranura aun no esta llena
            {
                //si es el primer registro que se va a insertar en la cubeta entonces a la cubeta le asigno la direccion de ese  registro
                if (primerCubeta_de_la_ranura.Registros.Count == 0)
                {
                    primerCubeta_de_la_ranura.Direccion = nuevoRegistro.Direccion;
                }
                //inserto en la primer cubeta de la ranura
                primerCubeta_de_la_ranura.Registros.Add(nuevoRegistro);

                //ordeno la cubeta
                IEnumerable<Registro> cubetaOrdenada = primerCubeta_de_la_ranura.Registros.OrderBy(x => x.Clave);
                primerCubeta_de_la_ranura.Registros = cubetaOrdenada.ToList();
            }
        }

        private void recorrerRegistrosaSiguienteCubeta(int indice_de_ranura, int indice_cubeta_actual, Cubeta cubetaActual)
        {
            Registro ultimoRegistro_cubetaActual = cubetaActual.Registros.Last();

            Cubeta cubetaSiguiente = tablaHash.ElementAt(indice_de_ranura).Cubetas.ElementAt(indice_cubeta_actual + 1);
            cubetaSiguiente.Registros.Add(ultimoRegistro_cubetaActual);

            if (cubetaSiguiente.Direccion == 0)
            {
                cubetaSiguiente.Direccion = cubetaSiguiente.Registros.ElementAt(0).Direccion;
            }

            cubetaActual.Direccion_siguiente_cubeta = cubetaSiguiente.Direccion;

            //ordeno la cubeta
            IEnumerable<Registro> cubetaOrdenada = cubetaSiguiente.Registros.OrderBy(x => x.Clave);
            cubetaSiguiente.Registros = cubetaOrdenada.ToList();
        }

        private void eliminar(int clave_a_eliminar, int indice_de_ranura)
        {
            //encunetro la cubeta donde debo eliminar
            Cubeta cubetaParaEliminar = buscaCubetaParaInsertar(clave_a_eliminar, indice_de_ranura);

            foreach (Registro registro in cubetaParaEliminar.Registros)
            {
                if (registro.Clave == clave_a_eliminar)
                {
                    cubetaParaEliminar.Registros.Remove(registro);
                    break;
                }
            }

            if (cubetaParaEliminar.Registros.Count == 0)// reviso si la pagina se quedo vacía
            {
                //debo enlazarla al puntero de cubeta vacias de la tabla hash
                tablaHash.Cubetas_vacias.Add(cubetaParaEliminar);
                tablaHash.Direccion_cubetas_vacias = tablaHash.Cubetas_vacias.First().Direccion;

                if (cubetaParaEliminar != tablaHash.ElementAt(indice_de_ranura).Cubetas.First())//si la cubeta no es la primera de la lista
                {
                    //el apuntador de la cubeta anterior a la que elimine lo pongo en 0
                    int indiceCubetaAnterior = tablaHash.ElementAt(indice_de_ranura).Cubetas.IndexOf(cubetaParaEliminar) - 1;
                    tablaHash.ElementAt(indice_de_ranura).Cubetas.ElementAt(indiceCubetaAnterior).Direccion_siguiente_cubeta = 0;
                }

                //la elimino del la ranura actual
                tablaHash.ElementAt(indice_de_ranura).Cubetas.Remove(cubetaParaEliminar);

            }
        }

        private void enlazaCubetasVacias()
        {
            foreach (Cubeta cubeta in tablaHash.Cubetas_vacias)
            {
                for (int i = 0; i < tablaHash.Cubetas_vacias.Count - 1; i++)
                {
                    tablaHash.Cubetas_vacias.ElementAt(i).Direccion_siguiente_cubeta = tablaHash.Cubetas_vacias.ElementAt(i + 1).Direccion;
                }
            }
        }

        private Cubeta buscaCubetaParaInsertar(int clave, int indice_de_ranura)
        {
            //si es necesario buscar una pagina para insertar significa que la ranura tiene mas de una cubeta
            Cubeta cubetaParaInsertar = null;

            bool encontrado = false;//esta bandera servira para saber si lo encontro y si no entrar a otra accion

            //primero debo recorrer todas las cubetas de la ranura
            for (int i = 0; i + 1 < tablaHash.ElementAt(indice_de_ranura).Cubetas.Count; i++)
            {
                if (tablaHash.ElementAt(indice_de_ranura).Cubetas.ElementAt(i + 1).Direccion != 0)
                {
                    Registro registroAdelantado = tablaHash.ElementAt(indice_de_ranura).Cubetas.ElementAt(i + 1).Registros.ElementAt(0);//tomo el primer registro de la cubeta que sigue
                                                                                                                                        //3
                                                                                                                                        //1 2 4 5  ]]]]]]   6 7 8 9
                    MessageBox.Show("Clave del registro adelntado: " + registroAdelantado.Clave);
                    if (registroAdelantado != null)
                    {
                        if (clave < registroAdelantado.Clave)//si la clave del primer registro de la cubeta de adelante es mayor quiere decir la cubeta actual es la que debemos regresar
                        {
                            MessageBox.Show("" + clave + " < " + registroAdelantado.Clave);
                            cubetaParaInsertar = tablaHash.ElementAt(indice_de_ranura).Cubetas.ElementAt(i);
                            encontrado = true;
                            break;
                        }
                    }
                }
            }

            //si durante el recorrido no encontro la pagina quiere decir que la que debemos devolver es la ultima pagina
            if (encontrado == false)
            {
                foreach (Cubeta cubeta in tablaHash.ElementAt(indice_de_ranura).Cubetas)
                {
                    if (cubeta.Direccion != 0)
                    {
                        cubetaParaInsertar = cubeta;//aqui hasta que encuentre la utlima cubeta
                    }
                }
            }

            return cubetaParaInsertar;
        }
        private int funcionHash(int clave_a_insertar)
        {
            int numeroModulo = tablaHash.Numero_ranuras;

            int indice_cubetaAsignada = clave_a_insertar % numeroModulo;

            return indice_cubetaAsignada;
        }

        private void button2_Click(object sender, EventArgs e)//escribir y poner en pantalla 
        {

            enlazaCubetasVacias();

            File.WriteAllText("tablaHash.txt", "");//limpio el archivo
            //ESCRIBIR EN U ARCHIVO
            StreamWriter escribir = File.AppendText("tablaHash.txt");

            escribir.WriteLine(tablaHash.Numero_ranuras + " " + tablaHash.Numero_registros_por_cubeta + " " + tablaHash.Tamaño_registro + " " + tablaHash.Direccion_cubetas_vacias + " " + direccionAcumulador + "\n");

            foreach (Ranura ranura in tablaHash)
            {
                escribir.WriteLine(tablaHash.IndexOf(ranura) + ", " + ranura.Cubetas.ElementAt(0).Direccion + "\n");
            }

            foreach (Cubeta cubeta in tablaHash.Cubetas_vacias)
            {
                escribir.WriteLine(cubeta.Direccion + " " + cubeta.Registros.Count + " " + cubeta.Direccion_siguiente_cubeta + "\n");
            }

            foreach (Ranura ranura in tablaHash)
            {
                foreach (Cubeta cubeta in ranura.Cubetas)
                {
                    if (cubeta.Direccion != 0)
                    {
                        escribir.WriteLine(cubeta.Direccion + " " + cubeta.Registros.Count + " " + cubeta.Direccion_siguiente_cubeta);
                        foreach (Registro registro in cubeta.Registros)
                        {
                            escribir.WriteLine(registro.Clave);
                        }
                        escribir.WriteLine("\n");
                    }
                }
                escribir.WriteLine("\n");
            }
            escribir.Close();

            //LECTURA DE UUN ARCHIVO
            StreamReader lectura;
            string cadena;
            richTextBox_escribir_leer_archivo.Text = "";
            try
            {
                lectura = File.OpenText("tablaHash.txt");
                //Lectura Adelantada

                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    richTextBox_escribir_leer_archivo.Text += cadena + "\n";
                    cadena = lectura.ReadLine();
                }
                lectura.Close();

            }
            catch (FileNotFoundException fe)
            {
                Console.WriteLine("Error" + fe);
            }
            catch (IOException fe)
            {
                Console.WriteLine("Error" + fe);
            }
        }

        private void button_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int clavePorEliminar = int.Parse(textBox_insertar.Text);
                int indice_de_ranura = funcionHash(clavePorEliminar);

                if (!ingresados.Contains(clavePorEliminar))
                {
                    MessageBox.Show("Esta clave no existe");
                }
                else
                {
                    eliminar(clavePorEliminar, indice_de_ranura);
                    ingresados.Remove(clavePorEliminar);
                }
                textBox_insertar.Text = "";
            }
            catch (FormatException fe)
            {

                MessageBox.Show("Ingresa un dato valido");
            }
        }

        private void button_LeerArchivo_Click(object sender, EventArgs e)
        {
            StreamReader lectura2;
            string cadena;
            List<string> campos = new List<string>();
            char[] separador = { ',' };

            try
            {
                lectura2 = File.OpenText("tablaHashLectura.txt");

                cadena = lectura2.ReadLine();

                campos = cadena.Split(',').ToList();

                lectura2.Close();

                foreach (string item in campos)
                {
                    int indice_de_ranura = funcionHash(int.Parse(item));
                    if (ingresados.Contains(int.Parse(item)))
                    {
                        MessageBox.Show("Esta clave ya fue ingresada");
                    }
                    else
                    {
                        insertar(int.Parse(item), indice_de_ranura);
                        ingresados.Add(int.Parse(item));
                    }
                }

            }
            catch (FileNotFoundException fe)
            {
                Console.WriteLine("Erro" + fe);
            }
            catch (Exception fe)
            {
                Console.WriteLine("error" + fe.Message);
            }
        }

        private void button_LeerEstructuraHash_Click(object sender, EventArgs e)
        {
            int numero_registros_por_cubeta;
            int numero_ranuras;
            int tamaño_registro;
            int direccion_cubetas_vacias;
            int direccionInicial;

            StreamReader lectura2;
            string cadena;
            List<string> encabezadoHash = new List<string>();
            char[] separador = { ',' };
            List<string> campos = new List<string>();

            try
            {

                lectura2 = File.OpenText("estructuraHash.txt");

                //recuperar solo las claves de las cubetas para volverlas a insertar
                cadena = lectura2.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(',').ToList();
                    if (campos[0] == "E")
                    {
                        MessageBox.Show("Test");
                        numero_registros_por_cubeta = int.Parse(campos[1]);
                        numero_ranuras = int.Parse(campos[2]);
                        tamaño_registro = int.Parse(campos[3]);
                        direccion_cubetas_vacias = int.Parse(campos[4]);
                        direccionInicial = int.Parse(campos[5]);

                        //inicializar arbol con lo elementos que tengo del encabezado
                        inicializaTablaHash( numero_ranuras, numero_registros_por_cubeta, tamaño_registro, direccionInicial);
                    }
                    if (campos[0].ToString() == "CV")
                    {
                        //es una cubeta vacia

                    }
                    if (campos[0] == ";")
                    {
                        int claveParaInsertar = int.Parse(campos[1]);
                        //es una clave
                        int indice_de_ranura = funcionHash(claveParaInsertar);
                        if (ingresados.Contains(claveParaInsertar))
                        {
                            MessageBox.Show("Esta clave ya fue ingresada");
                        }
                        else
                        {
                            insertar(claveParaInsertar, indice_de_ranura);
                            ingresados.Add(claveParaInsertar);
                        }
                    }
                    cadena = lectura2.ReadLine();
                }
                lectura2.Close();
            }
            catch (FileNotFoundException fe)
            {
                Console.WriteLine("Erro" + fe);
            }
            catch (Exception fe)
            {
                Console.WriteLine("error" + fe.Message);

            }
        }
    }
}
