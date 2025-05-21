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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvtransacciones = new DataGridView();
            btnsalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvtransacciones).BeginInit();
            SuspendLayout();
            // 
            // dgvtransacciones
            // 
            dgvtransacciones.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(55, 44, 144);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(55, 44, 144);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvtransacciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvtransacciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvtransacciones.EnableHeadersVisualStyles = false;
            dgvtransacciones.GridColor = Color.FromArgb(55, 44, 144);
            dgvtransacciones.Location = new Point(12, 12);
            dgvtransacciones.Name = "dgvtransacciones";
            dgvtransacciones.RowHeadersWidth = 51;
            dgvtransacciones.Size = new Size(549, 483);
            dgvtransacciones.TabIndex = 0;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = Color.FromArgb(255, 128, 128);
            btnsalir.FlatAppearance.BorderSize = 0;
            btnsalir.FlatStyle = FlatStyle.Flat;
            btnsalir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsalir.ForeColor = Color.White;
            btnsalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnsalir.Location = new Point(111, 501);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(349, 36);
            btnsalir.TabIndex = 6;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // MostrarTransacciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(573, 559);
            Controls.Add(btnsalir);
            Controls.Add(dgvtransacciones);
            Name = "MostrarTransacciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MostrarTransacciones";
            ((System.ComponentModel.ISupportInitialize)dgvtransacciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvtransacciones;
        private Button btnsalir;
    }
}