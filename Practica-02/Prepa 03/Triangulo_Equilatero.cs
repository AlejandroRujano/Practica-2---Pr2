using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    internal class Triangulo_Equilatero : Triangulo
    {
        private float _base;
        private float _altura;

        public Triangulo_Equilatero(float base_triangulo, float altura, string color) : base(base_triangulo, altura, color)
        {
            _base = base_triangulo;
            _altura = altura;
        }

        public override double GetArea()
        {
            return (_base * _altura) / 2;
        }
        public override double GetPerimetro()
        {
            return _base * 3;
        }
        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy un Triangulo Escaleno de Color {GetColor()}, Area {GetArea()}, Perimetro {GetPerimetro()}");
        }

    }
}
