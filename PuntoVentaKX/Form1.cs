using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoVentaKX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btbSolicitarNombre_Click(object sender, EventArgs e)
        {
            var reservacion = new ServiceReferenceKX.WebServicesKXSoapClient();
            string name = reservacion.DevolverNombre();


            txtNombre.Text = name;
        }


        private void btnSolicitarHoraServidor_Click(object sender, EventArgs e)
        {
            var reservacion = new ServiceReferenceKX.WebServicesKXSoapClient();
            string hora = reservacion.HoraServidor();


            txtHoraServidor.Text = hora;    
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var reservacion = new ServiceReferenceKX.WebServicesKXSoapClient();
            int folio = int.Parse(txtFolio.Text);
            var reserva = reservacion.BuscarReserva(folio);
            
            txtAdultos.Text = reserva[1];
            txtPaquete.Text = reserva[2];
            txtMenores.Text = reserva[3];
            txtPrecio.Text = "$ " + reserva[4];
            txtInfantes.Text = reserva[5];
            txtCliente.Text = reserva[6];
            txtReferencia.Text = reserva[7];
            txtCorreo.Text = reserva[8];
            txtTelefono.Text = reserva[9];

        }

    }
}
