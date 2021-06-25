using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace juego_roll
{
   /* enum tipoPersonaje
    {
        humano,
        orco,
        elfo,
        enano,
        hobbit
    }*/ 


    public class ListadoRazas
    {
        [JsonPropertyName("index")]
        public string Indice { get; set; }

        [JsonPropertyName("name")]
        public string Nombre { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

    }

    public class Razas
    {
        [JsonPropertyName("count")]
        public int Contar { get; set; }

        [JsonPropertyName("results")]
        public List<ListadoRazas> Resultados { get; set; }
    }
    public class Personaje
    {
        private string tipo;
        private string nombre;
        private string apodo;
        private DateTime fechaNacimiento;
        private int edad;

        private int salud = 100;

        private int velocidad;
        private int destresa;
        private int fuerza;
        private int nivel;
        private int armadura;

        private int poderDeDisparo;
        private int poderDeDefensa;
        
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Salud { get => salud; set => salud = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destresa { get => destresa; set => destresa = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }
        public int PoderDeDisparo { get => poderDeDisparo; set => poderDeDisparo = value; }
        public int PoderDeDefensa { get => poderDeDefensa; set => poderDeDefensa = value; }
        public string Tipo { get => tipo; set => tipo = value; }



        public void AtaqueDefensa()
        {
            PoderDeDisparo = Destresa * Fuerza * Nivel;
            PoderDeDefensa = Armadura * Velocidad;
        }

    }

}
