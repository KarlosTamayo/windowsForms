using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            ventana Venta = new ventana();
            Venta.mensaje();
            Console.ReadKey();
        }
    }


    class ventana
    {
        //atributos
        private int ancho, alto;
        private string color;
        
        //contructor , se ejectau priero que todos.
        public ventana()
        {
            ancho = 15;
            alto = 15;
            color = "rojo";
            Console.WriteLine("se ejecuto primero");
            Console.ReadKey();
        }

        public void mensaje() => Console.WriteLine("el acho es : " + ancho + "alto:" + alto + "color" + color);
        
        //metodo destrutor 
        ~ventana()
        {
            System.Diagnostics.Trace.WriteLine("se destruyo los recursos");

        }
    }
}
