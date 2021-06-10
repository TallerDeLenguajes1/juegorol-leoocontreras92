using System;
using System.Collections.Generic;
using System.Text;

namespace juego_roll
{
    class CreadorDePersonajes
    {
        public Personaje CrearPersonaje()
        {


            Random random = new Random();
            Personaje personaje = new Personaje();
            Console.WriteLine("Ingrese Nombre");
            personaje.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Apodo");
            personaje.Apodo = Console.ReadLine();
            Console.WriteLine("Ingrese Fecha");
            string fecha = Console.ReadLine();
            personaje.FechaNacimiento = DateTime.Parse(fecha);
            TimeSpan horas = DateTime.Now - personaje.FechaNacimiento;
            //Console.WriteLine(horas.TotalDays); 
            personaje.Edad = Convert.ToInt32(horas.TotalDays / 365); //calcula años redpmdps
            personaje.Tipo = (tipoPersonaje) random.Next(1,5);
            //personaje.Edad = random.Next(1,301);
            personaje.Velocidad = random.Next(1,11);
            personaje.Destresa = random.Next(1,11);
            personaje.Fuerza = random.Next(1,11);
            personaje.Nivel = random.Next(1,11);
            personaje.Armadura = random.Next(1,11);

            return personaje;
        }
    }
}
