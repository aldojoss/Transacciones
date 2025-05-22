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
            textBox1 = new TextBox();
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
            // textBox1
            // 
            textBox1.Location = new Point(219, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(219, 130);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(125, 29);
            btnagregar.TabIndex = 8;
            btnagregar.Text = "Aceptar";
            btnagregar.UseVisualStyleBackColor = true;
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
            txtsaldo.Location = new Point(219, 75);
            txtsaldo.Name = "txtsaldo";
            txtsaldo.Size = new Size(125, 27);
            txtsaldo.TabIndex = 10;
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
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Button btnagregar;
        private Label label2;
        private TextBox txtsaldo;
        private Button btnsalir;
    }
}