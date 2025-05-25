namespace Transacciones_en_.net
{
    public partial class FormAgregarCliente : Form
    {
        public void AgregarCliente()
        {
            // Validar campos
            if (string.IsNullOrWhiteSpace(TxtNombre.Text) || string.IsNullOrWhiteSpace(TxtIdentificacion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            // Crear nuevo cliente
            var nuevoCliente = new Transacciones_en_.net.Models.Clientes
            {
                Nombre = TxtNombre.Text,
                Identificacion = TxtIdentificacion.Text
            };


            // Guardar cliente en la base de datos
            using (var db = new Transacciones_en_.net.Data.BancoSimple2Context())
            {
                db.Clientes.Add(nuevoCliente);
                db.SaveChanges();
            }
            MessageBox.Show("Cliente agregado exitosamente.");
            DialogResult = DialogResult.OK;
            Close();

        }
    }
}
