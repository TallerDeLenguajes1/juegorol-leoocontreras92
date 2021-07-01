using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace juego_roll
{
    class MostrarArchivos
    {
        public void Mostrar(string nombreArchivo, string formato)
        {
            if (!(File.Exists(nombreArchivo + formato)))
            {
                Console.WriteLine("\nSin datos...\n");
            }

            //Falto terminar

            FileStream miArchivo = new FileStream(nombreArchivo + formato, FileMode.Open);
            using (StreamReader reader = new StreamReader(miArchivo))
            {
                string strArchivo = reader.ReadLine();
                string[] arrayArchivo = strArchivo.Split(";");
                for (int i = 0; i < arrayArchivo.Length; i++)
                {
                    Console.WriteLine(arrayArchivo[i]);
                }
                reader.Close();

            }

        }
    }
}
