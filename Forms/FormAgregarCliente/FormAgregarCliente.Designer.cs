namespace Transacciones_en_.net
{
    partial class FormAgregarCliente
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
            BtnAgregar = new Button();
            BtnCancelar = new Button();
            TxtIdentificacion = new TextBox();
            label2 = new Label();
            TxtNombre = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.FromArgb(76, 175, 80);
            BtnAgregar.FlatAppearance.BorderSize = 0;
            BtnAgregar.FlatStyle = FlatStyle.Flat;
            BtnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAgregar.ForeColor = Color.White;
            BtnAgregar.Location = new Point(44, 148);
            BtnAgregar.Margin = new Padding(3, 2, 3, 2);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(87, 22);
            BtnAgregar.TabIndex = 13;
            BtnAgregar.Text = "Aceptar";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += btnagregarr_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.FromArgb(244, 67, 54);
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancelar.ForeColor = Color.White;
            BtnCancelar.Location = new Point(137, 148);
            BtnCancelar.Margin = new Padding(3, 2, 3, 2);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(80, 22);
            BtnCancelar.TabIndex = 12;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += btncancelar_Click;
            // 
            // TxtIdentificacion
            // 
            TxtIdentificacion.Location = new Point(108, 106);
            TxtIdentificacion.Margin = new Padding(3, 2, 3, 2);
            TxtIdentificacion.Name = "TxtIdentificacion";
            TxtIdentificacion.Size = new Size(110, 23);
            TxtIdentificacion.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 109);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 10;
            label2.Text = "Identificacion";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(108, 67);
            TxtNombre.Margin = new Padding(3, 2, 3, 2);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(110, 23);
            TxtNombre.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(45, 69);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_usuario_32;
            pictureBox1.Location = new Point(80, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // FormAgregarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 44, 144);
            ClientSize = new Size(248, 198);
            Controls.Add(pictureBox1);
            Controls.Add(BtnAgregar);
            Controls.Add(BtnCancelar);
            Controls.Add(TxtIdentificacion);
            Controls.Add(label2);
            Controls.Add(TxtNombre);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAgregarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddCl";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAgregar;
        private Button BtnCancelar;
        private TextBox TxtIdentificacion;
        private Label label2;
        private TextBox TxtNombre;
        private Label label1;
        private PictureBox pictureBox1;
    }
}