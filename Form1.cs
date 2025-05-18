using Transacciones_en_.net.Data;

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
    }
}
