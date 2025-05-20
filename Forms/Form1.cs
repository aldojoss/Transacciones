using Transacciones_en_.net.Data;
using Transacciones_en_.net.Forms;

namespace Transacciones_en_.net
{
    public partial class Form1 : Form
    {
        private BancoSimple2M5Context db = new BancoSimple2M5Context();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.Clientes.ToList();
        }

        private void btnaggclientes_Click(object sender, EventArgs e)
        {
            Form faggc = new FormAddCl();
            if (faggc.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = db.Clientes.ToList();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
          
                var clienteId = (int)dataGridView1.SelectedRows[0].Cells["ClienteId"].Value;

                var form = new FAgregarCuenta(clienteId);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    db.Cuentas.Add(form.NuevaCuenta);

                    db.SaveChanges();

                    dgvcuentas.DataSource = db.Cuentas.ToList();

                }
            
           


        }
    }
}
