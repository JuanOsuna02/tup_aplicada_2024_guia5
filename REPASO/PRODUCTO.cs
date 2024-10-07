using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO
{
     internal abstract  class PRODUCTO
    {
        protected double preciobase;
        protected double largo;
        private int codigo;
        public int Codigo {  get { return codigo; } set {  codigo = value; } }

        public PRODUCTO(double preciobase, double largo,int Codigo)
        {
            this.preciobase = preciobase;
            this.largo = largo;
            codigo = Codigo;
            
            
        }
        abstract public double Precio();
        public abstract double Peso();
    }
}
