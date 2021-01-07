using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_EX7
{
    public class Raices : IRaices
    {
        private double A, B, C;

        public Raices(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public void Calcular()
        {
            if (TieneRaiz()) ObtenerRaiz();
            else if (TieneRaices()) ObtenerRaices();
            else Console.WriteLine("No tiene solución");
        }

        public double GetDiscriminante()
        {
            return Math.Pow(B, 2) - 4 * A * C; 
        }

        public void ObtenerRaices()
        {
            if(!TieneRaices())
            {
                Console.WriteLine("Error: No tiene raíces");
                return;
            }
            double raizDiscriminante = Math.Sqrt(GetDiscriminante());
            double raiz1 = (-B + raizDiscriminante) / (2 * A);
            double raiz2 = (-B - raizDiscriminante) / (2 * A);

            Console.WriteLine("Las raíces son x={0}, x={1}", raiz1, raiz2);
        }

        public void ObtenerRaiz()
        {
            if (!TieneRaiz())
            {
                Console.WriteLine("Error: Tiene más de una raíz");
                return;
            }
            double raiz = (-B) / (2 * A);
            Console.WriteLine("La única raíz es x={0}", raiz);
        }

        public bool TieneRaices()
        {
            return GetDiscriminante() >= 0;
        }

        public bool TieneRaiz()
        {
            return GetDiscriminante() == 0;
        }
    }
}
