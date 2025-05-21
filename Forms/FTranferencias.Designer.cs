namespace Transacciones_en_.net.Forms
{
    partial class FTranferencias
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
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            btntransferir = new Button();
            btncancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(40, 43);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Monto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(120, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(43, 121);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // btntransferir
            // 
            btntransferir.FlatAppearance.BorderSize = 0;
            btntransferir.FlatStyle = FlatStyle.Flat;
            btntransferir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntransferir.ForeColor = Color.White;
            btntransferir.Location = new Point(40, 169);
            btntransferir.Name = "btntransferir";
            btntransferir.Size = new Size(94, 29);
            btntransferir.TabIndex = 4;
            btntransferir.Text = "Transferir";
            btntransferir.UseVisualStyleBackColor = true;
            btntransferir.Click += btntransferir_Click;
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.Crimson;
            btncancelar.FlatAppearance.BorderSize = 0;
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.ForeColor = Color.White;
            btncancelar.Location = new Point(231, 169);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(81, 29);
            btncancelar.TabIndex = 5;
            btncancelar.Text = "Salir";
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // FTranferencias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(364, 273);
            Controls.Add(btncancelar);
            Controls.Add(btntransferir);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FTranferencias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FTranferencias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Button btntransferir;
        private Button btncancelar;
    }
}