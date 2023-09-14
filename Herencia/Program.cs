using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publicacion publicacion1 = new Publicacion("Gracias por los saludos de cumpleaños", "Walter Daniel Carrizo", true );
            Console.WriteLine(publicacion1.ToString());

            PublicacionImagen publicacion2 = new PublicacionImagen("Hola, cómo estas?", "Walter Carrizo", "http://imagen.com", true);
            Console.WriteLine(publicacion2.ToString());

            PublicacionVideo publicacion3 = new PublicacionVideo("Mi primer video", "Laura Cabezas", "http://video.com", 15 , true);
            Console.WriteLine( publicacion3.ToString() );
            publicacion3.Play();
            Console.ReadKey();
            publicacion3.Stop();
            Console.WriteLine("Presione cualquier tecla para detener");

            Console.Read();
        }
    }
}
