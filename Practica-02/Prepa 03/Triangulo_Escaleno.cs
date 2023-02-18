using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    internal class Triangulo_Escaleno : Triangulo
    {
        private float _base;
        private float _altura;
        private float _lado1;
        private float _lado2;


        public Triangulo_Escaleno(float base_triangulo, float altura, float lado1, float lado2, string color) : base(base_triangulo, altura, color)
        {
            _base = base_triangulo;
            _altura = altura;
            _lado1 = lado1;
            _lado2 = lado2;
        }

        public override double GetArea()
        {
            return (_base * _altura) / 2;
        }
        public override double GetPerimetro()
        {
            return _base + _lado1 + _lado2;
        }
        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy un Triangulo Escaleno de Color {GetColor()}, Area {GetArea()}, Perimetro {GetPerimetro()}");
        }

    }
}
