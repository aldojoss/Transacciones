namespace Transacciones_en_.net.Forms
{
    partial class FAgregarCuenta
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
            txtnumeroCuenta = new TextBox();
            btnagregar = new Button();
            label2 = new Label();
            txtsaldo = new TextBox();
            btnsalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(30, 32);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 6;
            label1.Text = "Numero de Cuenta";
            // 
            // txtnumeroCuenta
            // 
            txtnumeroCuenta.BackColor = SystemColors.InactiveCaption;
            txtnumeroCuenta.BorderStyle = BorderStyle.None;
            txtnumeroCuenta.Location = new Point(219, 32);
            txtnumeroCuenta.Name = "txtnumeroCuenta";
            txtnumeroCuenta.Size = new Size(125, 20);
            txtnumeroCuenta.TabIndex = 7;
            // 
            // btnagregar
            // 
            btnagregar.BackColor = Color.FromArgb(55, 44, 144);
            btnagregar.FlatAppearance.BorderSize = 0;
            btnagregar.FlatStyle = FlatStyle.Flat;
            btnagregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnagregar.ForeColor = Color.White;
            btnagregar.Location = new Point(219, 130);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(125, 29);
            btnagregar.TabIndex = 8;
            btnagregar.Text = "Aceptar";
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(30, 82);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 9;
            label2.Text = "Saldo Inicial";
            // 
            // txtsaldo
            // 
            txtsaldo.BackColor = SystemColors.InactiveCaption;
            txtsaldo.BorderStyle = BorderStyle.None;
            txtsaldo.Location = new Point(219, 82);
            txtsaldo.Name = "txtsaldo";
            txtsaldo.Size = new Size(125, 20);
            txtsaldo.TabIndex = 10;
            txtsaldo.TextChanged += txtsaldo_TextChanged;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = Color.Crimson;
            btnsalir.FlatAppearance.BorderSize = 0;
            btnsalir.FlatStyle = FlatStyle.Flat;
            btnsalir.ForeColor = Color.White;
            btnsalir.Location = new Point(79, 130);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(81, 29);
            btnsalir.TabIndex = 11;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // FAgregarCuenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(372, 203);
            Controls.Add(btnsalir);
            Controls.Add(txtsaldo);
            Controls.Add(label2);
            Controls.Add(btnagregar);
            Controls.Add(txtnumeroCuenta);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FAgregarCuenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FAgregarCuenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtnumeroCuenta;
        private Button btnagregar;
        private Label label2;
        private TextBox txtsaldo;
        private Button btnsalir;
    }
}