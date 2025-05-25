using Transacciones_en_.net.Forms;

namespace Transacciones_en_.net
{
    public partial class Form1:Form
    {
        private void btnaggclientes_Click(object sender, EventArgs e)
        {
            Form faggc = new FormAgregarCliente();
            if (faggc.ShowDialog() == DialogResult.OK)
            {
                DgvClientes.DataSource = db.Clientes.ToList();
            }
        }

        private void btntransacciones_Click(object sender, EventArgs e)
        {
            if (DgvCuentas.SelectedRows.Count != 2)
            {
                MessageBox.Show("Por favor, seleccione dos cuentas.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var cuentaorigen = (int)DgvCuentas.SelectedRows[0].Cells["CuentaId"].Value;
            var cuentadestino = (int)DgvCuentas.SelectedRows[1].Cells["CuentaId"].Value;

            var form = new FormTranferencias(cuentaorigen, cuentadestino);
            if (form.ShowDialog() == DialogResult.OK)
            {
                RealizarTranferencia(cuentaorigen, cuentadestino, form.Monto);
                DgvCuentas.DataSource = db.Cuentas.ToList();
            }
        }

        private void btnregistrotransacciones_Click(object sender, EventArgs e)
        {
            MostrarTransacciones form = new MostrarTransacciones();
            form.ShowDialog();

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnagregarcuentas_Click(object sender, EventArgs e)
        {
            if (DgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe Seleccionar un Cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var clienteId = (int)DgvClientes.SelectedRows[0].Cells["ClienteId"].Value;

            var form = new FormAgregarCuenta(clienteId);

            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Cuentas.Add(form.NuevaCuenta);

                db.SaveChanges();

                DgvCuentas.DataSource = db.Cuentas.ToList();
                MessageBox.Show($"Cuenta Agregada Exisotsamente", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
