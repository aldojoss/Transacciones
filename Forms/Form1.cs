using Microsoft.EntityFrameworkCore;
using Transacciones_en_.net.Data;
using Transacciones_en_.net.Forms;
using Transacciones_en_.net.Models;

namespace Transacciones_en_.net
{
    public partial class Form1 : Form
    {
        private BancoSimple2Context db = new BancoSimple2Context();
        public Form1()
        {
            InitializeComponent();
            dgvclientes.DataSource = db.Clientes.ToList();
            dgvcuentas.DataSource = db.Cuentas.ToList();
        }

        private void btnaggclientes_Click(object sender, EventArgs e)
        {
            Form faggc = new FormAgregarCliente();
            if (faggc.ShowDialog() == DialogResult.OK)
            {
                dgvclientes.DataSource = db.Clientes.ToList();

            }


        }



        private void btntransacciones_Click(object sender, EventArgs e)
        {
            if (dgvcuentas.SelectedRows.Count != 2)
            {
                MessageBox.Show("Por favor, seleccione dos cuentas.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            var cuentaorigen = (int)dgvcuentas.SelectedRows[0].Cells["CuentaId"].Value;
            var cuentadestino = (int)dgvcuentas.SelectedRows[1].Cells["CuentaId"].Value;

            var form = new FormTranferencias(cuentaorigen, cuentadestino);
            if (form.ShowDialog() == DialogResult.OK)
            {
                RealizarTranferencia(cuentaorigen, cuentadestino, form.Monto);
                dgvcuentas.DataSource = db.Cuentas.ToList();
            }
        }


        private void RealizarTranferencia(int origenId, int destinoId, decimal monto)
        {
            using var transaccion = db.Database.BeginTransaction(System.Data.IsolationLevel.Serializable);
            {
                try
                {
                    var cuentaOrigen = db.Cuentas.FirstOrDefault(c => c.CuentaId == origenId);
                    var cuentaDestino = db.Cuentas.FirstOrDefault(c => c.CuentaId == destinoId);

                    if (cuentaOrigen.Saldo < monto)
                    {
                        throw new Exception("Saldo insuficiente");
                    }

                    cuentaOrigen.Saldo -= monto;
                    cuentaDestino.Saldo += monto;

                    //registrar la transaccion
                    db.Transacciones.Add(new Transacciones
                    {
                        Monto = monto,
                        Fecha = DateTime.Now,
                        Descripcion = "Transferencia",
                        CuentaOrigenId = origenId,
                        CuentaDestinoId = destinoId
                    });

                    db.SaveChanges();

                    //transaccion completada
                    transaccion.Commit();
                    MessageBox.Show("Transferencia realizada con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    //reversion de transaccion
                    transaccion.Rollback();
                    MessageBox.Show($"Error al realizar la transferencia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnregistrotransacciones_Click(object sender, EventArgs e)
        {
            MostrarTransacciones form = new MostrarTransacciones();
            form.ShowDialog();

        }
        private void Buscar()
        {
            var like = txtbuscar.Text;
            var clientes = db.Clientes.Where(c => EF.Functions.Like(c.Nombre, $"%{like}%")).ToList();
            dgvclientes.DataSource = clientes;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnagregarcuentas_Click(object sender, EventArgs e)
        {
            if (dgvclientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe Seleccionar un Cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var clienteId = (int)dgvclientes.SelectedRows[0].Cells["ClienteId"].Value;

            var form = new FormAgregarCuenta(clienteId);

            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Cuentas.Add(form.NuevaCuenta);

                db.SaveChanges();

                dgvcuentas.DataSource = db.Cuentas.ToList();
                MessageBox.Show($"Cuenta Agregada Exisotsamente", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
