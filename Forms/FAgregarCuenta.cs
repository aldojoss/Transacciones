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
            NuevaCuenta = new Cuentas
            {
                NumeroCuenta = textBox1.Text,
                Saldo = Convert.ToDecimal(txtsaldo.Text),
                ClienteId = clienteId,
                Activa = true
            };
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
