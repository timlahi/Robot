using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoRobot
{
    public partial class Form1 : Form
    {

        List<Robot> poblacion;
        Dictionary<Robot,int> diccionario;
        public int numeropoblacion;
        public int tamrecorrido;
        public int evaluacion;
        public int numerodemutaciones;
        public int numerodegeneraciones;
        public int cotaevaluacion;
        public Escenario esc;

        public Form1()
        {
            InitializeComponent();
            poblacion = new List<Robot>();

            diccionario = new Dictionary<Robot, int>();
                       

                  }

        private List<Robot> CruzarPoblacion(List<Robot> seleccionados)
        {
            List<Robot> resultado = new List<Robot>();
            //Por cada dos individuos salen dos hijos, cada uno con los genes invertidos padre e hijo
            while (seleccionados.Count != 0)
            {
                resultado.AddRange(Cruzar(seleccionados.Take(2)));

                seleccionados.RemoveAt(0);
                seleccionados.RemoveAt(0);

            }

            return resultado;
        }

        private IEnumerable<Robot> Cruzar(IEnumerable<Robot> enumerable)
        { Robot hijo1 = new Robot();
            Robot hijo2 = new Robot();

            
            List<Robot> robots=enumerable.ToList<Robot>();
            SubArray(robots.First().adn, 0, 3).CopyTo(hijo1.adn,0);
            SubArray(robots.Last().adn, 3, 4).CopyTo(hijo1.adn,3);
            SubArray(robots.Last().adn, 0, 3).CopyTo(hijo2.adn, 0);
            SubArray(robots.First().adn,3, 4).CopyTo(hijo2.adn, 3);

            // Introducimos una mutación aleatoria para los hijos

            Random rand = new Random();

            if (rand.Next(0, 100) < 50) ;
            {
                int posicion = rand.Next(0, 6);
                System.Threading.Thread.Sleep(1);
                int valor = rand.Next(1, 8);

                hijo1.adn[posicion] = valor;
                hijo2.adn[posicion] = valor;

                //Si se da la mutacion hay que reflejarla
                numerodemutaciones ++;

            }

            robots.Add(hijo1);
            robots.Add(hijo2);

            




            return robots;
        }

        private int[] SubArray(int[] data, int index, int length)
        { 
            
                int[] result = new int[length];
                Array.Copy(data, index, result, 0, length);
                return result;
            
        }

        private void CrearPoblacion(int tam)
        {

           for(int i = 0; i < tam; i++)
            {

                poblacion.Add(CrearRobotAleatorio());
               

            }
        }



        private Robot CrearRobotAleatorio()
        {
            Robot robot = new Robot();
            for(int i=0; i < robot.adn.Length; i++)
            {
                Random rand = new Random();
                robot.adn[i] = rand.Next(1, 8);
                System.Threading.Thread.Sleep(2);

            }

            return robot;
        }

        private void botonEmpezar_Click(object sender, EventArgs e)
        {

            //this.tamrecorrido = Int32.Parse(txtRecorrido.Text);
            this.numeropoblacion = Int32.Parse(txtPI.Text);
            this.evaluacion = Int32.Parse(txtEvaluacion.Text);
            CrearPoblacion(numeropoblacion);

            foreach (Robot v in poblacion)
            {

                generacion1.Items.Add(v.ToString());
            }

            int[] recorrido = new int[10] { 1, 1, 2, 3, 4, 5, 6, 1, 1, 7 };

            esc = new Escenario(recorrido);

            foreach (Robot v in poblacion)
            {
                Partida partida = new Partida(v, esc);
                diccionario.Add(v, partida.puntos);
            }

            var top = diccionario.OrderByDescending(pair => pair.Value);

            int index = 0;
            foreach (var r in top)
            {
                diccionario1.Items.Add("Sujeto" + index + ": " + r.Key.ToString() + "-----> " + r.Value.ToString());
                index++;
            }


            var mejores = diccionario.OrderByDescending(pair => pair.Value).Take(250);

            List<Robot> seleccionados = new List<Robot>();

            foreach (var n in mejores)
            {
                seleccionados = mejores.Select(kvp => kvp.Key).ToList();
            }

            List<Robot> generacion2 = CruzarPoblacion(seleccionados);

            foreach (Robot r in generacion2)
            {
                listageneracion2.Items.Add(r.ToString());
                txtMutaciones.Text = numerodemutaciones.ToString();
            }


            

                 MetodoRecursivo(generacion2);
                



            



        }

                

        private void MetodoRecursivo(List<Robot> generacion2)
        {
            numerodegeneraciones++;
            List<Robot> aux = generacion2;
            List<Robot> seleccionados;
            Dictionary<Robot, int> dict = new Dictionary<Robot, int>();


            foreach (Robot v in aux)
            {
                Partida partida = new Partida(v, esc);
                dict.Add(v, partida.puntos);
            }

            var mejores = dict.OrderByDescending(pair => pair.Value).Take(250);

            if (mejores.First().Value < evaluacion)

            { 
                seleccionados = new List<Robot>();

                foreach (var n in mejores)
                {
                    seleccionados = mejores.Select(kvp => kvp.Key).ToList();
                }

                List<Robot> generacionsiguiente = CruzarPoblacion(seleccionados);
                MetodoRecursivo(generacionsiguiente);
            }

            var top = dict.OrderByDescending(pair => pair.Value);

            int index = 0;
            foreach (var r in top)
            {
                generacionX.Items.Add("Sujeto" + index + ": " + r.Key.ToString() + "-----> " + r.Value.ToString());
                index++;
            }
            numberGenerations.Text = numerodegeneraciones.ToString();


        }
    }
}
