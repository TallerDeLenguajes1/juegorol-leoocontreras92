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

            } while (opcion !='n');

           foreach (Personaje personaje in ListaPersonajes)
            {
                MostrarDatosDePersonaje(personaje);
                MostrarCaracteristicasDePersonaje(personaje);
            }
        }

        public static void MostrarDatosDePersonaje(Personaje personaje)
        {
            Console.WriteLine("------Datos de personaje------");
           // foreach (Personaje personaje in Lista)
            //{
                Console.WriteLine("Nombre del personaje: "+ personaje.Nombre);
                Console.WriteLine("Apodo: " + personaje.Apodo);
                Console.WriteLine("Fecha de nacimiento: " + personaje.FechaNacimiento);
                Console.WriteLine("Tipo/Raza " + personaje.Tipo);
                Console.WriteLine("Edad: " + personaje.Edad + " años");
                Console.WriteLine("Salud: " + personaje.Salud);
                Console.WriteLine("------------------------------------------------");
            //}
        }
        public static void MostrarCaracteristicasDePersonaje(Personaje personaje)
        {
            Console.WriteLine("------Caracteristicas de personaje------");
            //foreach (Personaje personaje in Lista)
            //{
                Console.WriteLine("Nivel: " + personaje.Nivel);
                Console.WriteLine("Fuerza: " + personaje.Fuerza);
                Console.WriteLine("Armadura: " + personaje.Armadura);
                Console.WriteLine("Velocidad: " + personaje.Velocidad);
                Console.WriteLine("Destreza: " + personaje.Destresa);
                Console.WriteLine("------------------------------------------------");
            //}
        }
    }
}
