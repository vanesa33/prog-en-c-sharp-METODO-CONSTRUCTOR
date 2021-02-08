using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace metodo_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            ventana calculadora = new ventana();
            calculadora.mostrar();
            Console.ReadKey();
        }
    }

    class ventana
    {
        private int ancho, altura;

        private string color;

        public ventana()
        {
            ancho = 15;
            altura = 20;
            color = "rojo";
            Console.WriteLine("funciona");
        }
        public void mostrar()
        {
            Console.WriteLine("de la dimención de la ventana es: " + ancho + "x" + altura + "y " +
                "su color es: " + color);
        }
        
    }

    
}
