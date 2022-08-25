using Kernel.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kernel
{
    public partial class Inicio : Form
    {
       
        public Inicio()
        {
            InitializeComponent();
        }
        
        private void btnProductos_Click(object sender, EventArgs e)
        {

            new Productos().ShowDialog();
                
        }
        
        private void btnVentas_Click(object sender, EventArgs e)
        {
            
            new Ventas().ShowDialog();
            
        }

        

        private void btnClientes_Click(object sender, EventArgs e)
        {
           
            new Clientes().ShowDialog();
            
        }
        

        private void btnInformes_Click(object sender, EventArgs e)
        {
            
            new Informes().ShowDialog();
            
        }
       
    }
}
