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
        public Pago(double Pagos , string tip )
        {
            InitializeComponent();
            pagos.Text = Convert.ToString(Pagos);
            tipos.Text = tip;
            f1.Enabled = false;

        }
        Form1 f1 = new Form1();
        private void bnot_Click(object sender, EventArgs e)
        {
            f1.Enabled = true;
            f1.borrar();
            this.Close();
            
            
            
        }

        private void byes_Click(object sender, EventArgs e)
        {
              
        }
    }
}
