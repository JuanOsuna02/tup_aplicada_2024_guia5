using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO
{
    internal class Presupuesto
    {

        public double Precio { get; set; }

        public ArrayList LISTA=new ArrayList();
        Cliente solicitante;

        public Presupuesto(string nombre, string direccion) { 

            solicitante=new Cliente(nombre,direccion);
        
        
        
        }

        public void AgregarProducto(PRODUCTO producto)
        {
            LISTA.Add(producto);

            Precio+=producto.Precio();



        }

        public PRODUCTO BuscarProducto(int codigo)
        {
            foreach(PRODUCTO p in LISTA)
            {
                if(p.Codigo == codigo)
                {
                    return p;
                }
            }
            return null;
        }


        public bool QuitarProducto(int codigo)
        {
            PRODUCTO buscado= BuscarProducto(codigo);
            if (buscado != null)
            {
                
                LISTA.Remove(buscado);
                
                Precio -= buscado.Precio();
                return true; 
            }

            return false; 
        }

        public string[] MostrarPresupuesto()
        {
            
            string[] resultadoTemp = new string[LISTA.Count+2];
            int cont = 0;

            
            foreach (PRODUCTO producto in LISTA)
            {
                resultadoTemp[cont++]=($"Código: {producto.Codigo}, Precio: {producto.Precio():C2}");
                
            }


            resultadoTemp[cont++]=($"Precio Total: {Precio:C2}");

           
            return resultadoTemp;
        }




    }
}
