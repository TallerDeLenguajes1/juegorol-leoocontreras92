using System;
using System.Collections.Generic;
using System.Text;

namespace juego_roll
{
    public class Combate
    {
        public void Batalla(List<Personaje>Lista,int p1, int p2)
        {
            float efectividadDisparo = 0, dañoProvocado;
            int valorAtaque, maximoDañoProvocable = 5000;

            Random random = new Random();
            Lista[p1].AtaqueDefensa();
            Lista[p2].AtaqueDefensa();

            efectividadDisparo = (random.Next(1,101));
            efectividadDisparo = efectividadDisparo / 100;
            valorAtaque = (int)(Lista[p1].PoderDeDisparo * efectividadDisparo);

            dañoProvocado = (float)(valorAtaque - Lista[p2].PoderDeDefensa);
            dañoProvocado = dañoProvocado / maximoDañoProvocable;
            dañoProvocado = dañoProvocado * 100;
            if (dañoProvocado < 0)
            {
                dañoProvocado = 0;
                Console.WriteLine("El ataque de " + Lista[p1].Nombre + " fallo...");
            }
            Lista[p2].Salud = (int)(Lista[p2].Salud - dañoProvocado);

            Console.WriteLine("El personaje "+ Lista[p2].Nombre + " recibio " + Math.Ceiling(dañoProvocado) + " de daño");
            Console.WriteLine("Vida actual de " + Lista[p2].Nombre + " = "+Lista[p2].Salud);
        }

        public void Ganador(List<Personaje>Lista,int p1, int p2)
        {
            Random random = new Random();
            int incremento;
            string nombreGanador ="";
            if(Lista[p1].Salud > Lista[p2].Salud)
            {
                nombreGanador = Lista[p1].Nombre;
                Lista.Remove(Lista[p2]);
            }
            else if (Lista[p2].Salud > Lista[p1].Salud)
            {
                nombreGanador = Lista[p2].Nombre;
                Lista.Remove(Lista[p1]);
            }
            else
            {
                Console.WriteLine("La batalla acabo en empate");
            }

            foreach(Personaje ganador in Lista)
            {
                if (nombreGanador == ganador.Nombre)
                {
                    Console.WriteLine("El ganador del combate es: " + ganador.Nombre);
                    Console.WriteLine("\n");
                    incremento = random.Next(1, 3);
                    ganador.Nivel = ganador.Nivel + incremento;
                    Console.WriteLine(ganador.Nombre + " subiió a nivel " + ganador.Nivel);
                    incremento = random.Next(20, 51);
                    ganador.Salud = 100;
                    ganador.Salud = ganador.Salud + incremento;
                    Console.WriteLine("Salud  " + ganador.Salud + " (+" + incremento + ")");
                    incremento = random.Next(1, 3);
                    ganador.Nivel = ganador.Fuerza + incremento;
                    Console.WriteLine("Fuerza  " + ganador.Fuerza + " (+" + incremento + ")");
                    incremento = random.Next(1, 3);
                    ganador.Nivel = ganador.Velocidad + incremento;
                    Console.WriteLine("Velocidad  " + ganador.Velocidad + " (+" + incremento + ")");
                    incremento = random.Next(1, 3);
                    ganador.Nivel = ganador.Destresa + incremento;
                    Console.WriteLine("Destreza  " + ganador.Destresa + " (+" + incremento + ")");
                    incremento = random.Next(1, 3);
                    ganador.Nivel = ganador.Armadura + incremento;
                    Console.WriteLine("Armadura  " + ganador.Armadura + " (+" + incremento + ")");
                }
            }

        }
    }
}
