using Microsoft.EntityFrameworkCore;
using Transacciones_en_.net.Models;

namespace Transacciones_en_.net
{
    public partial class Form1 : Form
    {
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
        private void Buscar()
        {
            var like = TxtBuscar.Text;
            var clientes = db.Clientes.Where(c => EF.Functions.Like(c.Nombre, $"%{like}%")).ToList();
            DgvClientes.DataSource = clientes;
        }
    }
}
