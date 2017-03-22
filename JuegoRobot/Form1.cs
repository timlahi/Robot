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
        public Form1()
        {
            InitializeComponent();
            poblacion = new List<Robot>();
            diccionario = new Dictionary<Robot, int>();
            CrearPoblacion(500);
            foreach(Robot v in poblacion)
            {

                generacion1.Items.Add(v.ToString());
            }

            int[] recorrido = new int[10] { 1, 1, 2, 3, 4, 5, 6, 1, 1, 7 };
            Escenario esc = new Escenario(recorrido);

            foreach(Robot v in poblacion)
            {
                Partida partida = new Partida(v, esc);
                diccionario.Add(v, partida.puntos);
            }

            var top = diccionario.OrderByDescending(pair => pair.Value);

            int index = 0;
            foreach (var r in top) {
                diccionario1.Items.Add("Sujeto"+index+": "+r.Key.ToString() + "-----> " + r.Value.ToString());
                index++;
            }


            var mejores= diccionario.OrderByDescending(pair => pair.Value).Take(250);

            List<Robot> seleccionados= new List<Robot>();

            foreach(var n in mejores)
            {
                seleccionados = mejores.Select(kvp => kvp.Key).ToList();
            }

            List<Robot> generacion2 = CruzarPoblacion(seleccionados);

            foreach(Robot r in generacion2)
            {
                listageneracion2.Items.Add(r.ToString());
            }



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
            SubArray(robots.Last().adn, 0, 3).CopyTo(hijo2
                .adn, 0);
            SubArray(robots.First().adn, 3, 4).CopyTo(hijo1.adn, 3);
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
                robot.adn[i] = rand.Next(1, 7);
                System.Threading.Thread.Sleep(1);

            }

            return robot;
        }

       
    }
}
