using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoRobot
{
     public class Escenario
    {

        public int[] recorrido;


        public Escenario(int tam)
        {
            recorrido = new int[tam];

        }

        public Escenario(int[] recorrido)
        {
            this.recorrido = recorrido;
        }
    }
}
