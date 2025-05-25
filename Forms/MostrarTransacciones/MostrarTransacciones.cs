using Transacciones_en_.net.Data;

namespace Transacciones_en_.net.Forms
{
    public partial class MostrarTransacciones : Form
    {
        BancoSimple2Context db = new BancoSimple2Context();
        public MostrarTransacciones()
        {
            InitializeComponent();
            dgvtransacciones.DataSource = db.Transacciones.ToList();
        }
    }
}
