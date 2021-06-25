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
            int valorAtaque, maximoDañoProvocable = 500;

            Random random = new Random();
            Lista[p1].AtaqueDefensa();
            Lista[p2].AtaqueDefensa();

            efectividadDisparo = (random.Next(1,101));
            efectividadDisparo = efectividadDisparo / 100;
            valorAtaque = (int)(Lista[p1].PoderDeDisparo * efectividadDisparo);

            dañoProvocado = (float)(valorAtaque - Lista[p2].PoderDeDefensa);
            dañoProvocado = dañoProvocado / maximoDañoProvocable;
            dañoProvocado = dañoProvocado * 100;
            if (dañoProvocado < 1)
            {
                dañoProvocado = 0;
                Console.WriteLine("El ataque de " + Lista[p1].Nombre + " fallo..."); //Si el daño provocado corresponde a 0
            }                                                                        // se considera ataque fallido
            Lista[p2].Salud = (int)(Lista[p2].Salud - dañoProvocado);

            Console.WriteLine("El personaje "+ Lista[p2].Nombre + " recibio " + Math.Ceiling(dañoProvocado) + " de daño");
            Console.WriteLine("Vida actual de " + Lista[p2].Nombre + " = "+Lista[p2].Salud);
        }

        public void Ganador(List<Personaje>Lista,int p1, int p2)
        {
            Random random = new Random();
            int incremento = 0, nivelActual;
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
                    incremento = random.Next(0,2);
                    nivelActual = ganador.Nivel;
                    ganador.Nivel = ganador.Nivel + incremento;
                    if (ganador.Nivel>nivelActual)
                    {
                        Console.WriteLine(ganador.Nombre + " subió a nivel " + ganador.Nivel); // si el jugador sube de nivel incrementa
                        Console.WriteLine(ganador.Nombre + " salud 100% ");                     //sus estadisticas y recupera salud
                        incremento = random.Next(20, 51);
                        ganador.Salud = 100;
                        ganador.Salud = ganador.Salud + incremento;
                        Console.WriteLine("Salud  " + " (+" + incremento + ")" + ganador.Salud);
                        incremento = random.Next(1, 3);
                        ganador.Nivel = ganador.Fuerza + incremento;
                        Console.WriteLine("Fuerza  " + " (+" + incremento + ")" + ganador.Fuerza);
                        incremento = random.Next(1, 3);
                        ganador.Nivel = ganador.Velocidad + incremento;
                        Console.WriteLine("Velocidad  " + " (+" + incremento + ")" + ganador.Velocidad);
                        incremento = random.Next(1, 3);
                        ganador.Nivel = ganador.Destresa + incremento;
                        Console.WriteLine("Destreza  " + " (+" + incremento + ")" + ganador.Destresa);
                        incremento = random.Next(1, 3);
                        ganador.Nivel = ganador.Armadura + incremento;
                        Console.WriteLine("Armadura  " + " (+" + incremento + ")" + ganador.Armadura);
                    }
                    else
                    {

                        Console.WriteLine(ganador.Nombre + " no subió de nivel");// si el jugador no sube de nivel no incrementa estadisticas
                        Console.WriteLine("Salud: (+0)" + ganador.Salud);       // no recupera salud
                        incremento = random.Next(1, 3);
                        ganador.Nivel = ganador.Fuerza + incremento;
                        Console.WriteLine("Fuerza (+0)" + ganador.Fuerza);
                        incremento = random.Next(1, 3);
                        ganador.Nivel = ganador.Velocidad + incremento;
                        Console.WriteLine("Velocidad (+0)" + ganador.Velocidad);
                        incremento = random.Next(1, 3);
                        ganador.Nivel = ganador.Destresa + incremento;
                        Console.WriteLine("Destreza (+0)" + ganador.Destresa);
                        incremento = random.Next(1, 3);
                        ganador.Nivel = ganador.Armadura + incremento;
                        Console.WriteLine("Armadura (+0)" + ganador.Armadura);
                    }

                }
            }

        }
    }
}
