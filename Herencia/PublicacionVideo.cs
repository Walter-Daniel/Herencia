using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Herencia
{
    internal class PublicacionVideo:Publicacion
    {
        //Variables
        protected bool seReproduce = false;
        protected double duracionActual = 0;
        Timer reloj;

        //Propiedades exclusicas
        protected string URLVideo { get; set; }
        protected double Duracion { get; set; }

        //Constructor por defecto
        public PublicacionVideo() { }

        //Constructor parametrizado
        public PublicacionVideo(string titulo, string autor, string urlVideo, double duracion, bool esPublico)
        {
            this.ID = CrearID();
            this.Titulo = titulo;
            this.Autor = autor;
            this.URLVideo = urlVideo;
            this.Duracion = duracion;
            this.EsPublico = esPublico;
        }

        //Métodos
        public void Play()
        {
            if(!seReproduce)
            {
                seReproduce = true;
                Console.WriteLine("Se esta reproduciendo");
                reloj = new Timer(Reproduccion, null, 0, 1000);
            }
        }

        public void Stop()
        {
            if(seReproduce)
            {
                seReproduce = false;
                Console.WriteLine("\nDetenido en {0}", duracionActual);
                duracionActual = 0;
                reloj.Dispose();
            }
        }

        private void Reproduccion(object o)
        {
            if (duracionActual < Duracion)
            {
                duracionActual++;
                Console.WriteLine( "Video en {0}s", duracionActual );
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - Duración: {3} - Creado por {4} .", this.ID, this.Titulo, this.URLVideo, this.Duracion, this.Autor);
        }
    }
}
