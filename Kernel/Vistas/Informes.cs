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
    public partial class Informes : Form
    {
        private ControladorInforme _ci;
        public Informes()
        {
            InitializeComponent();
            _ci = new ControladorInforme(this);
        }

       public void CargarInforme(List<Informe> lista)
        {
            try
            {
                if (lista.Single(p => p.Unidades > 0).Unidades > 0)
                {
                    GrillaInforme.DataSource = "";
                    GrillaInforme.DataSource = lista;
                }
            }
            catch (Exception)
            {
                MostrarMensaje("Ingrese un rango de fechas valido. Recuerde que se consideran las ventas hasta 00:00 hs del dia ingresado");
            }
            
        }

        public void CargarProducto(Producto pro)
        {
            tboxDescripcion.Text = pro.Descripcion;
        }

        private void btnIngresarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                _ci.CargarProducto(int.Parse(tboxCodigo.Text));
            }
            catch(Exception)
            {
                MessageBox.Show("Olvido ingresar el codigo");
                tboxCodigo.Select();
            }
        }

        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
           
            _ci.GenerarInforme(CalendarDesde.SelectionStart, CalendarHasta.SelectionStart); //setearle la hora a HASTA para q abarque todo el dia
        }

        public void MostrarMensaje(string msje)
        {
            MessageBox.Show(msje);
        }

        private void Informes_FormClosing(object sender, FormClosingEventArgs e)
        {
            _ci.Dipose();
        }

        public void LimpiarProducto()
        {
            tboxCodigo.Clear();
            tboxDescripcion.Clear();
        }

        public void LimpiarGrilla()
        {
            GrillaInforme.DataSource = "";
        }

        private void Informes_Load(object sender, EventArgs e)
        {
            tboxCodigo.Select();
        }
    }
}
