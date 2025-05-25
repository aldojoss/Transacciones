namespace Transacciones_en_.net
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            BtnAgregarClientes = new Button();
            panel1 = new Panel();
            BtnAgregarCuentas = new Button();
            BtnTransacciones = new Button();
            pictureBox1 = new PictureBox();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            pnsup = new Panel();
            BtnBuscar = new Button();
            TxtBuscar = new TextBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            BtnRegistroTransacciones = new Button();
            panel3 = new Panel();
            DgvCuentas = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            DgvClientes = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnsup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCuentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvClientes).BeginInit();
            SuspendLayout();
            // 
            // BtnAgregarClientes
            // 
            BtnAgregarClientes.FlatAppearance.BorderSize = 0;
            BtnAgregarClientes.FlatStyle = FlatStyle.Flat;
            BtnAgregarClientes.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAgregarClientes.ForeColor = Color.White;
            BtnAgregarClientes.Image = Properties.Resources.icons8_agregar_usuario_50;
            BtnAgregarClientes.Location = new Point(7, 92);
            BtnAgregarClientes.Margin = new Padding(3, 2, 3, 2);
            BtnAgregarClientes.Name = "BtnAgregarClientes";
            BtnAgregarClientes.Size = new Size(144, 62);
            BtnAgregarClientes.TabIndex = 1;
            BtnAgregarClientes.UseVisualStyleBackColor = true;
            BtnAgregarClientes.Click += btnaggclientes_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 44, 144);
            panel1.Controls.Add(BtnAgregarCuentas);
            panel1.Controls.Add(BtnTransacciones);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(BtnAgregarClientes);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(153, 455);
            panel1.TabIndex = 3;
            // 
            // BtnAgregarCuentas
            // 
            BtnAgregarCuentas.FlatAppearance.BorderSize = 0;
            BtnAgregarCuentas.FlatStyle = FlatStyle.Flat;
            BtnAgregarCuentas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAgregarCuentas.ForeColor = Color.White;
            BtnAgregarCuentas.Image = Properties.Resources.icons8_cuenta_comercial_50;
            BtnAgregarCuentas.Location = new Point(5, 174);
            BtnAgregarCuentas.Margin = new Padding(3, 2, 3, 2);
            BtnAgregarCuentas.Name = "BtnAgregarCuentas";
            BtnAgregarCuentas.Size = new Size(143, 67);
            BtnAgregarCuentas.TabIndex = 12;
            BtnAgregarCuentas.UseVisualStyleBackColor = true;
            BtnAgregarCuentas.Click += btnagregarcuentas_Click;
            // 
            // BtnTransacciones
            // 
            BtnTransacciones.FlatAppearance.BorderSize = 0;
            BtnTransacciones.FlatStyle = FlatStyle.Flat;
            BtnTransacciones.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnTransacciones.ForeColor = Color.White;
            BtnTransacciones.Image = Properties.Resources.icons8_parte_trasera_de_tarjeta_bancaria_50;
            BtnTransacciones.Location = new Point(10, 259);
            BtnTransacciones.Margin = new Padding(3, 2, 3, 2);
            BtnTransacciones.Name = "BtnTransacciones";
            BtnTransacciones.Size = new Size(133, 65);
            BtnTransacciones.TabIndex = 4;
            BtnTransacciones.UseVisualStyleBackColor = true;
            BtnTransacciones.Click += btntransacciones_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_banco_64;
            pictureBox1.Location = new Point(46, 16);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pnsup
            // 
            pnsup.BackColor = SystemColors.ButtonShadow;
            pnsup.Controls.Add(BtnBuscar);
            pnsup.Controls.Add(TxtBuscar);
            pnsup.Controls.Add(label3);
            pnsup.Controls.Add(pictureBox2);
            pnsup.Dock = DockStyle.Top;
            pnsup.Location = new Point(153, 0);
            pnsup.Margin = new Padding(3, 2, 3, 2);
            pnsup.Name = "pnsup";
            pnsup.Size = new Size(623, 31);
            pnsup.TabIndex = 7;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Top;
            BtnBuscar.FlatAppearance.BorderSize = 0;
            BtnBuscar.FlatStyle = FlatStyle.Flat;
            BtnBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBuscar.ForeColor = Color.White;
            BtnBuscar.Image = Properties.Resources.icons8_buscar_50__1_1;
            BtnBuscar.Location = new Point(511, 4);
            BtnBuscar.Margin = new Padding(3, 2, 3, 2);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(29, 20);
            BtnBuscar.TabIndex = 12;
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += btnbuscar_Click;
            // 
            // TxtBuscar
            // 
            TxtBuscar.Anchor = AnchorStyles.Top;
            TxtBuscar.BorderStyle = BorderStyle.None;
            TxtBuscar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtBuscar.Location = new Point(227, 7);
            TxtBuscar.Margin = new Padding(3, 2, 3, 2);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.PlaceholderText = "Buscar, Clientes";
            TxtBuscar.Size = new Size(265, 16);
            TxtBuscar.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 7);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 0;
            label3.Text = "BancoNet 2M5";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.Image = Properties.Resources.texbox;
            pictureBox2.Location = new Point(212, 0);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(294, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(BtnRegistroTransacciones);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(153, 419);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(623, 36);
            panel2.TabIndex = 8;
            // 
            // BtnRegistroTransacciones
            // 
            BtnRegistroTransacciones.FlatAppearance.BorderSize = 0;
            BtnRegistroTransacciones.FlatStyle = FlatStyle.Flat;
            BtnRegistroTransacciones.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRegistroTransacciones.ForeColor = Color.White;
            BtnRegistroTransacciones.Image = Properties.Resources.icons8_ojo_50;
            BtnRegistroTransacciones.ImageAlign = ContentAlignment.MiddleLeft;
            BtnRegistroTransacciones.Location = new Point(3, 3);
            BtnRegistroTransacciones.Margin = new Padding(3, 2, 3, 2);
            BtnRegistroTransacciones.Name = "BtnRegistroTransacciones";
            BtnRegistroTransacciones.Size = new Size(305, 26);
            BtnRegistroTransacciones.TabIndex = 5;
            BtnRegistroTransacciones.Text = "Registro de Transacciones";
            BtnRegistroTransacciones.UseVisualStyleBackColor = true;
            BtnRegistroTransacciones.Click += btnregistrotransacciones_Click;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Controls.Add(DgvCuentas);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(DgvClientes);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(153, 31);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(623, 388);
            panel3.TabIndex = 9;
            // 
            // DgvCuentas
            // 
            DgvCuentas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgvCuentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvCuentas.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(55, 44, 144);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(55, 44, 144);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DgvCuentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DgvCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCuentas.EnableHeadersVisualStyles = false;
            DgvCuentas.GridColor = Color.FromArgb(252, 196, 25);
            DgvCuentas.Location = new Point(24, 218);
            DgvCuentas.Margin = new Padding(3, 2, 3, 2);
            DgvCuentas.Name = "DgvCuentas";
            DgvCuentas.RowHeadersWidth = 51;
            DgvCuentas.Size = new Size(482, 132);
            DgvCuentas.TabIndex = 11;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 183);
            label2.Name = "label2";
            label2.Size = new Size(78, 27);
            label2.TabIndex = 10;
            label2.Text = "Cuentas";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 10);
            label1.Name = "label1";
            label1.Size = new Size(78, 27);
            label1.TabIndex = 9;
            label1.Text = "Clientes";
            // 
            // DgvClientes
            // 
            DgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvClientes.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(55, 44, 144);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(55, 44, 144);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvClientes.EnableHeadersVisualStyles = false;
            DgvClientes.GridColor = Color.FromArgb(252, 196, 25);
            DgvClientes.Location = new Point(24, 37);
            DgvClientes.Margin = new Padding(3, 2, 3, 2);
            DgvClientes.Name = "DgvClientes";
            DgvClientes.RowHeadersWidth = 51;
            DgvClientes.Size = new Size(482, 132);
            DgvClientes.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(776, 455);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pnsup);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnsup.ResumeLayout(false);
            pnsup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCuentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button BtnAgregarClientes;
        private Panel panel1;
        private Button BtnTransacciones;
        private PictureBox pictureBox1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Panel pnsup;
        private Label label3;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private DataGridView DgvClientes;
        private Button BtnRegistroTransacciones;
        private DataGridView DgvCuentas;
        private TextBox TxtBuscar;
        private PictureBox pictureBox2;
        private Button BtnBuscar;
        private Button BtnAgregarCuentas;
    }
}
