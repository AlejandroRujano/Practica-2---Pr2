using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo_cuadrado = new Cuadrado(5, "azul");
            Rectangulo rectangulo = new Rectangulo(2,3, "blanco");
            Figura figura3 = new Circulo(2, "negro");
            Triangulo_Escaleno triangulo_escaleno = new Triangulo_Escaleno(7, 2, 5, 3, "rojo");
            Triangulo_Isosceles triangulo_isosceles = new Triangulo_Isosceles(3, 5, 6, "amarillo");
            Triangulo_Equilatero triangulo_equilatero = new Triangulo_Equilatero(5, 5, "verde");

            Figura figura1 = rectangulo_cuadrado;
            Figura figura2 = rectangulo;

            Figura figura4 = triangulo_escaleno;
            Figura figura5 = triangulo_isosceles;
            Figura figura6 = triangulo_equilatero;

            figura1.MostrarDatos();
          
            figura2.MostrarDatos();

            figura3.MostrarDatos();

            Console.WriteLine($" Area {figura3.GetArea()}, Perimetro {figura3.GetPerimetro()}");

            figura4.MostrarDatos();

            figura5.MostrarDatos();

            figura6.MostrarDatos();

            Console.ReadLine();
           
            
        }
    }
}
