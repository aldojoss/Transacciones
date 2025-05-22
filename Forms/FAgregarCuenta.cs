using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transacciones_en_.net.Models;

namespace Transacciones_en_.net.Forms
{
    public partial class FAgregarCuenta : Form
    {
        public Cuentas NuevaCuenta;

        private int clienteId;
        public FAgregarCuenta(int cliente)
        {
            InitializeComponent();
            clienteId = cliente;
        }


        //public Cuentas GetNuevacuenta()
        //{
        //    return NuevaCuenta;
        //}

        private void btnagregar_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            if (!decimal.TryParse(txtsaldo.Text, out precio))
            {
                MessageBox.Show("Por favor,Ingrese un saldo valido.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            NuevaCuenta = new Cuentas
            {
                NumeroCuenta = txtnumeroCuenta.Text,
                Saldo = Convert.ToDecimal(txtsaldo.Text),
                ClienteId = clienteId,
                Activa = true
            };
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }










        private void txtsaldo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
