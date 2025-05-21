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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnaggclientes = new Button();
            button1 = new Button();
            panel1 = new Panel();
            btntransacciones = new Button();
            pictureBox1 = new PictureBox();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            pnsup = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            btnregistrotransacciones = new Button();
            panel3 = new Panel();
            dgvcuentas = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            dgvclientes = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnsup.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvcuentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvclientes).BeginInit();
            SuspendLayout();
            // 
            // btnaggclientes
            // 
            btnaggclientes.FlatAppearance.BorderSize = 0;
            btnaggclientes.FlatStyle = FlatStyle.Flat;
            btnaggclientes.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnaggclientes.ForeColor = Color.White;
            btnaggclientes.Image = Properties.Resources.icons8_agregar_usuario_50;
            btnaggclientes.Location = new Point(3, 122);
            btnaggclientes.Name = "btnaggclientes";
            btnaggclientes.Size = new Size(167, 83);
            btnaggclientes.TabIndex = 1;
            btnaggclientes.UseVisualStyleBackColor = true;
            btnaggclientes.Click += btnaggclientes_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.icons8_cuenta_comercial_50;
            button1.Location = new Point(3, 228);
            button1.Name = "button1";
            button1.Size = new Size(169, 89);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 44, 144);
            panel1.Controls.Add(btntransacciones);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnaggclientes);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 607);
            panel1.TabIndex = 3;
            // 
            // btntransacciones
            // 
            btntransacciones.FlatAppearance.BorderSize = 0;
            btntransacciones.FlatStyle = FlatStyle.Flat;
            btntransacciones.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntransacciones.ForeColor = Color.White;
            btntransacciones.Image = Properties.Resources.icons8_parte_trasera_de_tarjeta_bancaria_50;
            btntransacciones.Location = new Point(12, 352);
            btntransacciones.Name = "btntransacciones";
            btntransacciones.Size = new Size(158, 87);
            btntransacciones.TabIndex = 4;
            btntransacciones.UseVisualStyleBackColor = true;
            btntransacciones.Click += btntransacciones_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_banco_64;
            pictureBox1.Location = new Point(53, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pnsup
            // 
            pnsup.BackColor = Color.White;
            pnsup.Controls.Add(label3);
            pnsup.Dock = DockStyle.Top;
            pnsup.Location = new Point(175, 0);
            pnsup.Name = "pnsup";
            pnsup.Size = new Size(712, 41);
            pnsup.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(279, 9);
            label3.Name = "label3";
            label3.Size = new Size(143, 25);
            label3.TabIndex = 0;
            label3.Text = "BancoNet 2M5";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnregistrotransacciones);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(175, 561);
            panel2.Name = "panel2";
            panel2.Size = new Size(712, 46);
            panel2.TabIndex = 8;
            // 
            // btnregistrotransacciones
            // 
            btnregistrotransacciones.FlatAppearance.BorderSize = 0;
            btnregistrotransacciones.FlatStyle = FlatStyle.Flat;
            btnregistrotransacciones.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnregistrotransacciones.ForeColor = Color.White;
            btnregistrotransacciones.Image = Properties.Resources.icons8_ojo_50;
            btnregistrotransacciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnregistrotransacciones.Location = new Point(3, 3);
            btnregistrotransacciones.Name = "btnregistrotransacciones";
            btnregistrotransacciones.Size = new Size(349, 36);
            btnregistrotransacciones.TabIndex = 5;
            btnregistrotransacciones.Text = "Registro de Transacciones";
            btnregistrotransacciones.UseVisualStyleBackColor = true;
            btnregistrotransacciones.Click += btnregistrotransacciones_Click;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Controls.Add(dgvcuentas);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(dgvclientes);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(175, 41);
            panel3.Name = "panel3";
            panel3.Size = new Size(712, 520);
            panel3.TabIndex = 9;
            // 
            // dgvcuentas
            // 
            dgvcuentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvcuentas.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(55, 44, 144);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(55, 44, 144);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvcuentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvcuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcuentas.EnableHeadersVisualStyles = false;
            dgvcuentas.GridColor = Color.FromArgb(252, 196, 25);
            dgvcuentas.Location = new Point(213, 293);
            dgvcuentas.Name = "dgvcuentas";
            dgvcuentas.RowHeadersWidth = 51;
            dgvcuentas.Size = new Size(450, 176);
            dgvcuentas.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(213, 247);
            label2.Name = "label2";
            label2.Size = new Size(97, 33);
            label2.TabIndex = 10;
            label2.Text = "Cuentas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 13);
            label1.Name = "label1";
            label1.Size = new Size(99, 33);
            label1.TabIndex = 9;
            label1.Text = "Clientes";
            // 
            // dgvclientes
            // 
            dgvclientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvclientes.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(55, 44, 144);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(55, 44, 144);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvclientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvclientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvclientes.EnableHeadersVisualStyles = false;
            dgvclientes.GridColor = Color.FromArgb(252, 196, 25);
            dgvclientes.Location = new Point(27, 49);
            dgvclientes.Name = "dgvclientes";
            dgvclientes.RowHeadersWidth = 51;
            dgvclientes.Size = new Size(450, 176);
            dgvclientes.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(887, 607);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pnsup);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnsup.ResumeLayout(false);
            pnsup.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvcuentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvclientes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnaggclientes;
        private Button button1;
        private Panel panel1;
        private Button btntransacciones;
        private PictureBox pictureBox1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Panel pnsup;
        private Label label3;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private DataGridView dgvclientes;
        private Button btnregistrotransacciones;
        private DataGridView dgvcuentas;
    }
}
