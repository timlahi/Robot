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

            int[] recorrido = new int[10]{1,1,2,3,4,5,6,1,1,7};
            esc = new Escenario(recorrido);
                       

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

            if (mutacionparcial.Checked.Equals(true))
            {

                if (rand.Next(0, 100) < 50)
                {
                    int posicion = rand.Next(0, 6);
                    System.Threading.Thread.Sleep(1);
                    int valor = rand.Next(1, 8);

                    hijo1.adn[posicion] = valor;
                    hijo2.adn[posicion] = valor;

                    //Si se da la mutacion hay que reflejarla
                    numerodemutaciones++;

                }
            }
            else
            {
                int posicion = rand.Next(0, 6);
                System.Threading.Thread.Sleep(1);
                int valor = rand.Next(1, 8);

                hijo1.adn[posicion] = valor;
                hijo2.adn[posicion] = valor;

                //Si se da la mutacion hay que reflejarla
                numerodemutaciones++;
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
            poblacion.Clear();
            generacion1.Items.Clear();
            diccionario.Clear();
            diccionario1.Items.Clear();
            listageneracion2.Items.Clear();
            listaGX.Items.Clear();
            generacionX.Items.Clear();
            numerodemutaciones = 0;
            numerodegeneraciones = 0;


           
            this.numeropoblacion = Int32.Parse(txtPI.Text);
            this.evaluacion = Int32.Parse(txtEvaluacion.Text);

            CrearPoblacion(numeropoblacion);

            foreach (Robot v in poblacion)
            {

                generacion1.Items.Add(v);
            }

            //GenerarRecorrido();

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
                listaGX.Items.Add(r.Key);
                generacionX.Items.Add("Sujeto" + index + ": " + r.Key.ToString() + "-----> " + r.Value.ToString());
                index++;
            }
            numberGenerations.Text = numerodegeneraciones.ToString();
            txtMutaciones.Text = numerodemutaciones.ToString();


        }

        private void generacion1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerarRecorrido();



        }

        private void GenerarRecorrido()
        {
            int[] recorrido = new int[10];
            Random rand = new Random();
            for (int i = 0; i < recorrido.Length; i++)
            {

                recorrido[i] = rand.Next(1, 8);
                System.Threading.Thread.Sleep(2);
            }

            esc = new Escenario(recorrido);

            RE1.Text = esc.recorrido[0].ToString();
            RE2.Text = esc.recorrido[1].ToString();
            RE3.Text = esc.recorrido[2].ToString();
            RE4.Text = esc.recorrido[3].ToString();
            RE5.Text = esc.recorrido[4].ToString();
            RE6.Text = esc.recorrido[5].ToString();
            RE7.Text = esc.recorrido[6].ToString();
            RE8.Text = esc.recorrido[7].ToString();
            RE9.Text = esc.recorrido[8].ToString();
            RE10.Text = esc.recorrido[9].ToString();
        }

        private void generacion1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Robot robot = (Robot)generacion1.SelectedItem;

            RG1.Text = robot.adn[0].ToString();
            RG2.Text = robot.adn[1].ToString();
            RG3.Text = robot.adn[2].ToString();
            RG4.Text = robot.adn[3].ToString();
            RG5.Text = robot.adn[4].ToString();
            RG6.Text = robot.adn[5].ToString();
            RG7.Text = robot.adn[6].ToString();

            Partida nueva = new Partida(robot, esc);
            textpuntos.Text = nueva.puntos.ToString();


            SimularRobotEscenario(robot);
        }

        private void SimularRobotEscenario(Robot robot)
        {
            for(int i=1; i < 11; i++)
            {
                string nombre = "RE" + i;
                var matches = this.Controls.Find(nombre, true).First();
                for (int j = 1; j < 8; j++)
                {
                    if (matches.Text.Equals(j.ToString()))
                    {
                        if (robot.adn[j - 1].Equals(j))
                        {
                            
                            matches.BackColor = System.Drawing.Color.Green;
                        }
                        else
                        {
                            matches.BackColor = System.Drawing.Color.Red;
                            
                        }

                        }
                }


               


            }
        }

        private void listaGX_SelectedIndexChanged(object sender, EventArgs e)
        {
            Robot robot = (Robot)listaGX.SelectedItem;
            RG1.Text = robot.adn[0].ToString();
            RG2.Text = robot.adn[1].ToString();
            RG3.Text = robot.adn[2].ToString();
            RG4.Text = robot.adn[3].ToString();
            RG5.Text = robot.adn[4].ToString();
            RG6.Text = robot.adn[5].ToString();
            RG7.Text = robot.adn[6].ToString();
            Partida nueva = new Partida(robot, esc);
            textpuntos.Text = nueva.puntos.ToString();


            SimularRobotEscenario(robot);

        }
    }
}
