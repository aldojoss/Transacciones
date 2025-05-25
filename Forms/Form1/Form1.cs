using Transacciones_en_.net.Data;

namespace Transacciones_en_.net
{
    public partial class Form1 : Form
    {
        private BancoSimple2Context db = new();
        public Form1()
        {
            InitializeComponent();
            DgvClientes.DataSource = db.Clientes.ToList();
            DgvCuentas.DataSource = db.Cuentas.ToList();
        }    
    }
}
