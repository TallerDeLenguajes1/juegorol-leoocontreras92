using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;

namespace juego_roll
{
    class CreadorDePersonajes
    {
        public Personaje CrearPersonaje(List<string>lista)
        {
            int control = 1;
            Random random = new Random();
            Personaje personaje = new Personaje();
            personaje.Apodo = "jugador"; // apodo predeterminado para verificar funcionamiento
            //personaje.FechaNacimiento = DateTime.Now; //utlilizo fecha actual para verificar funcionamiento

            Console.WriteLine("Ingrese Nombre");
            personaje.Nombre = Console.ReadLine();

            //Console.WriteLine("Ingrese Apodo");
            //personaje.Apodo = Console.ReadLine(); // carga de apodo por teclado

            do //control de fechas
            {
                Console.WriteLine("Ingrese Fecha");
                string fecha = Console.ReadLine(); // carga fecha por teclado
                if (DateTime.TryParse(fecha, out DateTime fechaNac))
                {
                    personaje.FechaNacimiento = fechaNac;
                    control = 1;
                }
                else
                {
                    Console.Write("Error de tipeo");
                    control = 0;

                }
            } while (control == 0);

            TimeSpan horas = DateTime.Now - personaje.FechaNacimiento;
  
            personaje.Edad = Convert.ToInt32(horas.TotalDays / 365); //calcula años de edad, calcula incorrectamente los meses.
            personaje.Tipo = lista[random.Next(lista.Count)];
            personaje.Velocidad = random.Next(1,11);
            personaje.Destresa = random.Next(1,11);
            personaje.Fuerza = random.Next(1,11);
            personaje.Nivel = random.Next(1,11);
            personaje.Armadura = random.Next(1,11);

            return personaje;
        }


    }
    
}
