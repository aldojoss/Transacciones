using Transacciones_en_.net.Models;

namespace Transacciones_en_.net.Forms
{
    public partial class FormAgregarCuenta
    {
        private void btnagregar_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            if (!decimal.TryParse(TxtSaldo.Text, out precio))
            {
                MessageBox.Show("Por favor,Ingrese un saldo valido.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            NuevaCuenta = new Cuentas
            {
                NumeroCuenta = TxtNumeroCuenta.Text,
                Saldo = Convert.ToDecimal(TxtSaldo.Text),
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
    }
}
