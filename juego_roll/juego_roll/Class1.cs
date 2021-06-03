using System;
using System.Collections.Generic;
using System.Text;

namespace juego_roll
{
    class Datos
    {
        private string tipo;
        private string nombre;
        private string apodo;
        private DateTime fechaNacimiento;
        private int edad;
        private int salud;

        public string Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Salud { get => salud; set => salud = value; }
    }

    class Caracteristicas
    {
        private int velocidad;
        private int destresa;
        private int fuerza;
        private int nivel;
        private int armadura;

        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destresa { get => destresa; set => destresa = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }

        public void caracteristicasPersonaje()
        {
            
        }
    }
}
