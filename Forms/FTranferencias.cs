using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transacciones_en_.net.Data;

namespace Transacciones_en_.net.Forms
{ 
    public partial class FTranferencias : Form
    {
        public int cuentaDestinoId;
        public int cuentaOrigenId;
        BancoSimple2Context db = new BancoSimple2Context();
        public decimal Monto;
        public FTranferencias(int _cuentadestinoid, int cuentaorigenid)
        {
            cuentaDestinoId = _cuentadestinoid;
            cuentaOrigenId = cuentaorigenid;

            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            var cuentaOrigen = db.Cuentas.Include(c => c.Cliente).
               First(c => c.CuentaId == cuentaOrigenId);

            var cuentaDestino = db.Cuentas.Include(c => c.Cliente).
               First(c => c.CuentaId == cuentaDestinoId);

            label1.Text = $"Cuenta Destino {cuentaOrigen.Cliente.Nombre}--{cuentaOrigen.NumeroCuenta}";
            label3.Text = $"Mi Cuenta {cuentaDestino.Cliente.Nombre}--{cuentaDestino.NumeroCuenta}";
            label2.Text = $"Saldo disponible: {cuentaDestino.Saldo}";

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btntransferir_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(textBox1.Text) > 0)
            {
                Monto = Convert.ToDecimal(textBox1.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Ingrese un monto valido mayor a 0");
            }
        }
    }
}
