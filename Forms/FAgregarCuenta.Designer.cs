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
            txtsaldo = new TextBox();
            label2 = new Label();
            btnagregar = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtsaldo
            // 
            txtsaldo.Location = new Point(213, 89);
            txtsaldo.Name = "txtsaldo";
            txtsaldo.Size = new Size(125, 27);
            txtsaldo.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 96);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 9;
            label2.Text = "Saldo Inicial";
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(213, 144);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(125, 29);
            btnagregar.TabIndex = 8;
            btnagregar.Text = "Aceptar";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(213, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 46);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 6;
            label1.Text = "Numero de Cuenta";
            // 
            // FAgregarCuenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 213);
            Controls.Add(txtsaldo);
            Controls.Add(label2);
            Controls.Add(btnagregar);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FAgregarCuenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FAgregarCuenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtsaldo;
        private Label label2;
        private Button btnagregar;
        private TextBox textBox1;
        private Label label1;
    }
}