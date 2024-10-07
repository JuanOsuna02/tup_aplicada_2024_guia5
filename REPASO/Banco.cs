using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO
{
    internal class Banco:PRODUCTO
    {

        public Banco(double Pbase, double largo,int Codigo) : base(Pbase, largo,Codigo)
        {

        }

        public override double Peso()
        {
            double Peso = (largo * 0.25) * 0.42;
            return Peso;
        }

        public override double Precio()
        {
            double aux = Peso();
            double Precio = aux * preciobase * 1.15;
            return Precio;

        }


    }
}
