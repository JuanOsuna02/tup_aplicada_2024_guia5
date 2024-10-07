using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REPASO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Presupuesto p;
       
        
      

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string nombre=tbNombre.Text;
            string direccion=tbDireccion.Text;
            p=new Presupuesto(nombre,direccion);
            

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double PrecioB=Convert.ToDouble(tbPrecio.Text);
            double Largo=Convert.ToDouble(tbLargo.Text);
            int Codigo=Convert.ToInt32(tbCodigo.Text);
            PRODUCTO L;
            if (rbBanco.Checked)
            {
                L =new Banco(PrecioB, Largo,Codigo);
                p.AgregarProducto(L);
                
            }

            else if (rbMesa.Checked)
            {
                double grosor=Convert.ToDouble(tbGrosor.Text);
                double ancho=Convert.ToDouble(tbAncho.Text);
                 L=new MESA(ancho, grosor,PrecioB,Largo,Codigo);
                p.AgregarProducto(L);
               
            }
            cbMostrar.Items.Add(Codigo);

            tbPrecio.Clear();
            tbLargo.Clear();
            tbAncho.Clear();
            tbGrosor.Clear();
           tbCodigo.Clear();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (cbMostrar.SelectedItem !=null) {

                int codigo = Convert.ToInt32(cbMostrar.SelectedItem);
                
                bool aux=p.QuitarProducto(codigo);
                if (aux) {
                    cbMostrar.Items.Remove(cbMostrar.SelectedItem);
                    cbMostrar.Text = "";
                }
               






            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto");
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (p != null)
            {
               
                string[] lista = p.MostrarPresupuesto();

                VerPresupuesto fVer = new VerPresupuesto();

               
                fVer.lbMotrar.Items.AddRange(lista);

                

                fVer.ShowDialog();

                cbMostrar.Items.Clear();
                p = null;
            }
            else
            {
                MessageBox.Show("cree el presupuesto");
            }





        }
    }
}
