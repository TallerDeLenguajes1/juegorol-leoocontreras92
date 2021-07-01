using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace juego_roll
{
    class GuardarArchivos
    {
        public void Guardar(string nombreArchivo, string formato, Personaje personaje)
        {
            if (!(File.Exists(nombreArchivo + formato)))
            {
                FileStream crearArchivo = File.Create(nombreArchivo + formato);
                crearArchivo.Close();

            }

            FileInfo archivo = new FileInfo(nombreArchivo + formato);

            FileStream miArchivo = new FileStream(nombreArchivo + formato, FileMode.Open);
            miArchivo.Position = archivo.Length;
            using (StreamWriter writer = new StreamWriter(miArchivo))
            {
                writer.WriteLine(personaje.Nombre + ";" + personaje.Apodo + ";" + personaje.Tipo + ";" + personaje.Edad + ";" + personaje.Salud + ";" + personaje.Nivel + ";" + personaje.Fuerza + ";" + personaje.Armadura + ";" + personaje.Velocidad + ";" + personaje.Destresa + ";");

                writer.Close();

            }

        }
    }
}
