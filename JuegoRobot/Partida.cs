using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoRobot
{
    public class Partida
    {
        public Robot robot;
        public Escenario escenario;
        public int puntos;

        public Partida(Robot robot, Escenario escenario)
        {
            this.robot = robot;
            this.escenario = escenario;
            this.puntos = CalcularPuntos();

        }

        private int CalcularPuntos()
        {
            int puntos = 0;
            for(int i=0; i < escenario.recorrido.Length; i++)
            {
                int numero = escenario.recorrido[i];
                if (numero.Equals(1)) {
                    if (robot.adn[0].Equals(1)) { puntos++; }
                     }
                if (numero.Equals(2))
                {
                    if (robot.adn[1].Equals(2)) { puntos++; }
                    
                }
                if (numero.Equals(3))
                {
                    if (robot.adn[2].Equals(3)) { puntos++; }
                    
                }
                if (numero.Equals(4))
                {
                    if (robot.adn[3].Equals(4)) { puntos++; }
                    
                }
                if (numero.Equals(5))
                {
                    if (robot.adn[4].Equals(5)) { puntos++; }
                   
                }
                if (numero.Equals(6))
                {
                    if (robot.adn[5].Equals(6)) { puntos++; }
                    
                }
                if (numero.Equals(7))
                {
                    if (robot.adn[6].Equals(7)) { puntos++; }
                    
                }



            }

            return puntos;
        }
    }
}
