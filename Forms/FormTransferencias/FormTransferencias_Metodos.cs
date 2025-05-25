using Microsoft.EntityFrameworkCore;

namespace Transacciones_en_.net.Forms
{
    public partial class FormTranferencias : Form
    {
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
    }
}
