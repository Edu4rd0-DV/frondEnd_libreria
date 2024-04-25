
using LibreriaG.EN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibreriaG
{   
    public partial class Pago : Form
    {
        
        public Pago(double Pagos , string tip , int ttpagi)
        {
            InitializeComponent();
            pagos.Text = Convert.ToString(Pagos);
            tipos.Text = tip;
            f1.Enabled = false;
            totalpaginas.Text = Convert.ToString(ttpagi);

            //fecha
            DateTime fecha = DateTime.Today;
            string fc = fecha.ToString("yyyy-MM-dd");
            date.Text = fc;


        }
        Form1 f1 = new Form1();
        private void bnot_Click(object sender, EventArgs e)
        {
            f1.Enabled = true;
            f1.borrar();
            this.Close();
            
            
            
        }

          
         ServiceReference1.Service1Client  _client = new ServiceReference1.Service1Client();
         ServiceReference1.copias copias = new ServiceReference1.copias();
         DATOS _N = new DATOS();
        private void byes_Click(object sender, EventArgs e)
        { 

            DateTime fecha = DateTime.Today;
            string f2 = fecha.ToString("yyyy-MM-dd");

     
            //guardar datos

            copias.pago = Convert.ToDouble(pagos.Text);
            copias.tipo = tipos.Text;
            copias.cantidad = Convert.ToInt32(totalpaginas.Text);
            copias.fecha = f2;

            int resultado = _client.agregar_venta(copias);
            if (resultado > 0)
            {
                MessageBox.Show("Pago Efectuado");
               
            }
            else
            {
                MessageBox.Show("error ");
            }
               
               f1.Enabled = true;
               f1.borrar();
               f1.bloqueo();
               this.Close();
              

        }
    }
}
