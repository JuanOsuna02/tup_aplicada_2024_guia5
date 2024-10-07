using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO
{
    internal class MESA:PRODUCTO

    {
        public double ancho {  get; private set; }
        public double grosor {  get; private set; }

        public MESA(double ancho, double grosor, double preciobase, double largo, int codigo1) :base(preciobase, largo, codigo1)
        {
            this.ancho = ancho;
            this.grosor = grosor;
        }

        public override double Peso()
        {
            double peso = (largo * ancho * grosor) * 0.3;
            return peso;
        }

        public override double Precio()
        {
            double aux=Peso();
            double Precio = aux * preciobase * 1.25;
            return Precio;
        }
    }
}
