using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transacciones_en_.net
{
    public partial class FormAddCl : Form
    {
        public FormAddCl()
        {
            InitializeComponent();
        }

        public void AgregarCliente()
        {
            // Validar campos
            if (string.IsNullOrWhiteSpace(txtnombre.Text) || string.IsNullOrWhiteSpace(txtidentificacion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            // Crear nuevo cliente
            var nuevoCliente = new Transacciones_en_.net.Models.Clientes
            {
                Nombre = txtnombre.Text,
                Identificacion = txtidentificacion.Text
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
