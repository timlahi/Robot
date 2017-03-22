using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoRobot
{
   public class Robot
    {
        public int[] adn;

        //Este Robot tiene un array de 7 posiciones , Qué hace cuando encuentra SUELO, AGUJERO, RAMA, SUBIDA, BAJADA, DINERO, FIN


        public Robot()
        {
            adn = new int[7];

        }

        public override string ToString()
        {

            string cadena = "";
            foreach(int i in adn)
            {
                cadena += i.ToString();
            }
            return cadena;
        }

    }
}
