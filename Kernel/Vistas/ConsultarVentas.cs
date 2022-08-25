using Kernel.Controladores;
using Kernel.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kernel.Vistas
{
    public partial class ConsultarVentas : Form
    {
        private ControladorVentas _cv;
        private Ventas _vista;
        public ConsultarVentas(Ventas vistaVentas)
        {
            InitializeComponent();
            _vista = vistaVentas;
            _cv = new ControladorVentas(this);
            GrillaConsultarVentas.DataSource = _cv.ListarVentas();
        }

        private void btnModificarVenta_Click(object sender, EventArgs e)
        {
            try
            {

                _cv.CargarVentaAModificar(_vista, int.Parse(GrillaConsultarVentas.Rows[GrillaConsultarVentas.CurrentRow.Index].Cells[0].Value.ToString()), this, new ControladorImpresion());
                
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar una venta");
            }

        }

        public void ActualizarGrillaVentas(List<Venta> ventas)
        {
            GrillaConsultarVentas.DataSource = ventas;
        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Realmente desea borrar?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                 new ControladorVentas(int.Parse(GrillaConsultarVentas.Rows[GrillaConsultarVentas.CurrentRow.Index].Cells[0].Value.ToString()), this);
                }
               
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar una venta");
            }
        }

        private void tboxClienteID_TextChanged(object sender, EventArgs e)
        {
             new ControladorVentas(this).FiltrarVentas(tboxClienteID.Text);
            
        }

        public void FiltrarVentas(IEnumerable<Venta> lista)
        {
            GrillaConsultarVentas.DataSource = "";
            GrillaConsultarVentas.DataSource = lista.ToList();
        }

        private void CalendarConsultarVentas_DateChanged(object sender, DateRangeEventArgs e)
        {
            new ControladorVentas(this).FiltrarVentasPorFecha(CalendarConsultarVentas.SelectionStart);
            
        }

        private void btnActualizarLista_Click(object sender, EventArgs e)
        {
            CalendarConsultarVentas.SelectionStart = DateTime.Now;
            GrillaConsultarVentas.DataSource = _cv.ListarVentas();
            
            tboxClienteID.Clear();
            
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            try
            {

                Venta venta = _cv.ObtenerVenta(int.Parse(GrillaConsultarVentas.Rows[GrillaConsultarVentas.CurrentRow.Index].Cells[0].Value.ToString()));
                new ImprimirFactura(venta).ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar una venta");
            }
        }
    }
}
