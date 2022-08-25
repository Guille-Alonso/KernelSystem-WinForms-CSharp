using Kernel.Controladores;
using Kernel.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kernel.Vistas
{
    public partial class ImprimirFactura : Form
    {
      //  private Button printButton = new Button();
        private PrintDocument printDocument1 = new PrintDocument();
        private Venta _venta;
        private ControladorImpresion _ci;
        public ImprimirFactura(Venta venta)
        {
            InitializeComponent();
            _venta = venta;
            _ci = new ControladorImpresion(this, _venta);
           // printButton.Text = "KERNEL";
           btnImprimir.Click += new EventHandler(printButton_Click);
          //  printButton.Click += new EventHandler(printButton_Click);
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            //   this.Controls.Add(printButton);
            this.Controls.Add(btnImprimir);
            
        }
       
        void printButton_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
        }

        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(System.Object sender,
               System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        public void CargarVentaEnFactura(List<LineaFactura> lista)
        {
            lblFecha.Text = _venta.Fecha.ToString();
            lblTotal.Text = _venta.Total.ToString();
            lblCliente.Text = _venta.Cliente.Nombre;

            GrillaFactura.DataSource = lista;
        }
    }
}
