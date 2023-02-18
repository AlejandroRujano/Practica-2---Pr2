using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    public abstract class Triangulo : Figura
    {
        private float _base;
        private float _altura;
 

        public Triangulo(float base_triangulo, float altura, string color) : base(color)
        {
            _base = base_triangulo;
            _altura = altura;
        }

    }
}
