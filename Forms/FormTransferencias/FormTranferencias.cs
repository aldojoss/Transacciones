using Transacciones_en_.net.Data;

namespace Transacciones_en_.net.Forms
{ 
    public partial class FormTranferencias : Form
    {
        public int cuentaDestinoId;
        public int cuentaOrigenId;
        BancoSimple2Context db = new BancoSimple2Context();
        public decimal Monto;
        public FormTranferencias(int _cuentadestinoid, int cuentaorigenid)
        {
            cuentaDestinoId = _cuentadestinoid;
            cuentaOrigenId = cuentaorigenid;

            InitializeComponent();
            CargarDatos();
        }
    }
}
