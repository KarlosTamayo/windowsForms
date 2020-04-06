using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enfriar
{
    class Program
    {
        static void Main(string[] args)
        {
            nevera Nev = new nevera();
            Nev.Mensaje();
            Console.ReadKey();
        }


    }

    class nevera
    {
        // atributos
        private int ancho, largo;
        private string color;
        private string nevecon, antiescarcha;
        //metood contructo ctor
        public nevera()
        {
             ancho = 40;
             largo = 70;
             color = "gris";
            nevecon = antiescarcha;
            Console.WriteLine("se ejecuto primero");
            Console.ReadKey();
        }
        //metodos 

        

        public void Mensaje() => Console.WriteLine(" ancho  : " + ancho + "largo:" + largo+ "color:" + color + "nevecon:"+ nevecon + "antiescarcha:" + antiescarcha);




        //metodo destrutor 

        ~nevera()
        {
            System.Diagnostics.Trace.WriteLine("se destruyo los recursos");

        }
    }
}
