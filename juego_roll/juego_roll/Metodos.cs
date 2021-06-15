using System;
using System.Collections.Generic;
using System.Text;

namespace juego_roll
{
    public class Metodos
    {
        public void MostrarDatosDePersonaje(Personaje personaje)
        {
            Console.WriteLine("------Datos de personaje------");
            Console.WriteLine("Nombre del personaje: " + personaje.Nombre);
            Console.WriteLine("Apodo: " + personaje.Apodo);
            Console.WriteLine("Fecha de nacimiento: " + personaje.FechaNacimiento);
            Console.WriteLine("Tipo/Raza " + personaje.Tipo);
            Console.WriteLine("Edad: " + personaje.Edad + " años");
            Console.WriteLine("Salud: " + personaje.Salud);
            Console.WriteLine("\n");
        }
        ///-----------------------------------------------------------///
        public void MostrarCaracteristicasDePersonaje(Personaje personaje)
        {
            Console.WriteLine("------Caracteristicas de personaje------");
            Console.WriteLine("Nivel: " + personaje.Nivel);
            Console.WriteLine("Fuerza: " + personaje.Fuerza);
            Console.WriteLine("Armadura: " + personaje.Armadura);
            Console.WriteLine("Velocidad: " + personaje.Velocidad);
            Console.WriteLine("Destreza: " + personaje.Destresa);
            Console.WriteLine("------------------------------------------------");

        }

        ///-----------------------------------------------------------///
        public string listarNombres(List<Personaje> ListaPersonajes)
        {
            int i = 0;
            string lista = "";
            foreach (Personaje personaje1 in ListaPersonajes)
            {
                if (i == 0)
                {
                    lista = string.Concat(i + 1, ").", personaje1.Nombre, " ");
                }
                else
                {
                    lista = string.Concat(lista, i + 1, ").", personaje1.Nombre, " ");
                }
                i++;
            }
            return lista;
        }
        ///-----------------------------------------------------------///
        public int ControlInt(string personaje)
        {

            int personaje1;
            if (int.TryParse(personaje, out personaje1))
            {

            }
            else
            {
                Console.WriteLine("Error de tipeo");
                personaje1 = -51;
            }
            return personaje1;
        }
        ///-----------------------------------------------------------///
    }
}
