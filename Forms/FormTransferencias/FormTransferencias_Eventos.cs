namespace Transacciones_en_.net.Forms
{
    public partial class FormTranferencias : Form
    {
        private void btncancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btntransferir_Click(object sender, EventArgs e)
        {
            decimal monto = 0;
            if (!decimal.TryParse(TxtMonto.Text, out monto))
            {
                MessageBox.Show("Por favor,Ingrese un monto valido.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToDecimal(TxtMonto.Text) > 0)
            {
                Monto = Convert.ToDecimal(TxtMonto.Text);
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
