namespace Transacciones_en_.net.Forms
{
    partial class MostrarTransacciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvtransacciones = new DataGridView();
            BtnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvtransacciones).BeginInit();
            SuspendLayout();
            // 
            // dgvtransacciones
            // 
            dgvtransacciones.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(55, 44, 144);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(55, 44, 144);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvtransacciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvtransacciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvtransacciones.EnableHeadersVisualStyles = false;
            dgvtransacciones.GridColor = Color.FromArgb(55, 44, 144);
            dgvtransacciones.Location = new Point(10, 9);
            dgvtransacciones.Margin = new Padding(3, 2, 3, 2);
            dgvtransacciones.Name = "dgvtransacciones";
            dgvtransacciones.RowHeadersWidth = 51;
            dgvtransacciones.Size = new Size(480, 362);
            dgvtransacciones.TabIndex = 0;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.FromArgb(255, 128, 128);
            BtnSalir.FlatAppearance.BorderSize = 0;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalir.ForeColor = Color.White;
            BtnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSalir.Location = new Point(97, 376);
            BtnSalir.Margin = new Padding(3, 2, 3, 2);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(305, 27);
            BtnSalir.TabIndex = 6;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += btnsalir_Click;
            // 
            // MostrarTransacciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(501, 419);
            Controls.Add(BtnSalir);
            Controls.Add(dgvtransacciones);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MostrarTransacciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MostrarTransacciones";
            ((System.ComponentModel.ISupportInitialize)dgvtransacciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvtransacciones;
        private Button BtnSalir;
    }
}