namespace Transacciones_en_.net.Forms
{
    partial class FormAgregarCuenta
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
            label1 = new Label();
            TxtNumeroCuenta = new TextBox();
            BtnAceptar = new Button();
            label2 = new Label();
            TxtSaldo = new TextBox();
            BtnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(26, 24);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 6;
            label1.Text = "Numero de Cuenta";
            // 
            // TxtNumeroCuenta
            // 
            TxtNumeroCuenta.BackColor = SystemColors.InactiveCaption;
            TxtNumeroCuenta.BorderStyle = BorderStyle.None;
            TxtNumeroCuenta.Location = new Point(192, 24);
            TxtNumeroCuenta.Margin = new Padding(3, 2, 3, 2);
            TxtNumeroCuenta.Name = "TxtNumeroCuenta";
            TxtNumeroCuenta.Size = new Size(109, 16);
            TxtNumeroCuenta.TabIndex = 7;
            // 
            // BtnAceptar
            // 
            BtnAceptar.BackColor = Color.FromArgb(55, 44, 144);
            BtnAceptar.FlatAppearance.BorderSize = 0;
            BtnAceptar.FlatStyle = FlatStyle.Flat;
            BtnAceptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAceptar.ForeColor = Color.White;
            BtnAceptar.Location = new Point(192, 98);
            BtnAceptar.Margin = new Padding(3, 2, 3, 2);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(109, 22);
            BtnAceptar.TabIndex = 8;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = false;
            BtnAceptar.Click += this.btnagregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(26, 62);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 9;
            label2.Text = "Saldo Inicial";
            // 
            // TxtSaldo
            // 
            TxtSaldo.BackColor = SystemColors.InactiveCaption;
            TxtSaldo.BorderStyle = BorderStyle.None;
            TxtSaldo.Location = new Point(192, 62);
            TxtSaldo.Margin = new Padding(3, 2, 3, 2);
            TxtSaldo.Name = "TxtSaldo";
            TxtSaldo.Size = new Size(109, 16);
            TxtSaldo.TabIndex = 10;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.Crimson;
            BtnSalir.FlatAppearance.BorderSize = 0;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.ForeColor = Color.White;
            BtnSalir.Location = new Point(69, 98);
            BtnSalir.Margin = new Padding(3, 2, 3, 2);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(71, 22);
            BtnSalir.TabIndex = 11;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += btnsalir_Click;
            // 
            // FormAgregarCuenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(326, 152);
            Controls.Add(BtnSalir);
            Controls.Add(TxtSaldo);
            Controls.Add(label2);
            Controls.Add(BtnAceptar);
            Controls.Add(TxtNumeroCuenta);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAgregarCuenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FAgregarCuenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtNumeroCuenta;
        private Button BtnAceptar;
        private Label label2;
        private TextBox TxtSaldo;
        private Button BtnSalir;
    }
}