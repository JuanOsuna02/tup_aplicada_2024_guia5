using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO
{
    internal class Cliente
    {

        private string Nombre;
        private string Direccion;

        public Cliente(string nombre,string direccion) { 

            Nombre = nombre;
            Direccion = direccion;
        
        
        }

        public string ToString() { return $"Nombre: {Nombre}, Direccion: {Direccion}"; }
    }
}
