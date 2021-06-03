using System;

namespace juego_roll
{
    class Program
    {
        static void Main(string[] args)
        {
            Personaje personaje = new Personaje();

            personaje.Nombre = Console.ReadLine();
            personaje.Apodo = Console.ReadLine();
            string fecha = Console.ReadLine();
            personaje.FechaNacimiento = Convert.ToDateTime(fecha);
            personaje.Salud = Convert.ToInt32(Console.ReadLine());
        }
        public void cargaDatos()
        {

        }
    }
}
