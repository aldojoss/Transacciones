namespace Transacciones_en_.net
{
    public partial class FormAgregarCliente:Form
    {
        private void btnagregarr_Click(object sender, EventArgs e)
        {
            AgregarCliente();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
