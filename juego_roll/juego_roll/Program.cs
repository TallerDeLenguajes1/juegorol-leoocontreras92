using System;
using System.Collections.Generic;

namespace juego_roll
{
    class Program
    {

        static void Main(string[] args)
        {

            CreadorDePersonajes creador = new CreadorDePersonajes();
            List<Personaje> ListaPersonajes = new List<Personaje>();
            Combate batalla = new Combate();
            Metodos funcion = new Metodos();
            string lista;
            int ataques = 3;
            char opcion;

            do
            {
                Console.WriteLine("Ingrese un personaje");
                Personaje nuevoPersonaje = creador.CrearPersonaje();
                ListaPersonajes.Add(nuevoPersonaje);
                Console.WriteLine("Desea ingresar otro personaje? s/n");
                Console.WriteLine("\n");
                opcion = Convert.ToChar(Console.Read());
                Console.ReadLine();

            } while (opcion != 'n');

            foreach (Personaje personaje in ListaPersonajes)
            {
                
                funcion.MostrarDatosDePersonaje(personaje);
                funcion.MostrarCaracteristicasDePersonaje(personaje);
            }

            // pelea de personajes (Falta construir metodo)

            lista = funcion.listarNombres(ListaPersonajes);
            while (ListaPersonajes.Count > 1)
            {
                lista = funcion.listarNombres(ListaPersonajes);
                Console.WriteLine("\n--------------------------");
                Console.WriteLine("Elija 2 personajes a pelear: " + lista);

                int personaje01, personaje02;
                string personaje1, personaje2;

                do
                {
                    personaje1 = Console.ReadLine();
                    personaje2 = Console.ReadLine();
                    personaje01 = funcion.ControlInt(personaje1) - 1;
                    personaje02 = funcion.ControlInt(personaje2) - 1;

                } while (personaje01 < 0 || personaje02 < 0);

                Console.WriteLine("Eligio a: ");
                Console.WriteLine(ListaPersonajes[personaje01].Nombre);
                Console.WriteLine(ListaPersonajes[personaje02].Nombre);

                Console.WriteLine("¡ Batalla !");

                for (int i = 0; i < ataques; i++)
                {
                    Console.WriteLine("Ronda " + i + 1 + "...");
                    if (ListaPersonajes[personaje01].Salud > 0 && ListaPersonajes[personaje02].Salud > 0)
                    {
                        batalla.Batalla(ListaPersonajes, personaje01, personaje02);
                        Console.WriteLine("\n");
                        if (ListaPersonajes[personaje02].Salud > 0)
                        {
                            batalla.Batalla(ListaPersonajes, personaje02, personaje01);
                            Console.WriteLine("\n");
                        }
                    }
                }
                Console.WriteLine("\n-------------------------------------\n");
                batalla.Ganador(ListaPersonajes, personaje01, personaje02);
            }


            Console.WriteLine("\n-------------------------------------\n");
            Console.WriteLine("El ganador del juego es: " + ListaPersonajes[0].Nombre);
            Console.WriteLine("\n-------------------------------------\n");

        }





    }
}
