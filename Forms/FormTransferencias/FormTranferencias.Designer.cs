namespace Transacciones_en_.net.Forms
{
    partial class FormTranferencias
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
            TxtMonto = new TextBox();
            label3 = new Label();
            btntransferir = new Button();
            BtnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(35, 7);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 32);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Monto";
            // 
            // TxtMonto
            // 
            TxtMonto.Location = new Point(105, 56);
            TxtMonto.Margin = new Padding(3, 2, 3, 2);
            TxtMonto.Name = "TxtMonto";
            TxtMonto.Size = new Size(110, 23);
            TxtMonto.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(38, 91);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // btntransferir
            // 
            btntransferir.FlatAppearance.BorderSize = 0;
            btntransferir.FlatStyle = FlatStyle.Flat;
            btntransferir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntransferir.ForeColor = Color.White;
            btntransferir.Location = new Point(35, 127);
            btntransferir.Margin = new Padding(3, 2, 3, 2);
            btntransferir.Name = "btntransferir";
            btntransferir.Size = new Size(82, 22);
            btntransferir.TabIndex = 4;
            btntransferir.Text = "Transferir";
            btntransferir.UseVisualStyleBackColor = true;
            btntransferir.Click += btntransferir_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.Crimson;
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.ForeColor = Color.White;
            BtnCancelar.Location = new Point(202, 127);
            BtnCancelar.Margin = new Padding(3, 2, 3, 2);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(71, 22);
            BtnCancelar.TabIndex = 5;
            BtnCancelar.Text = "Salir";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += btncancelar_Click;
            // 
            // FormTranferencias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(318, 205);
            Controls.Add(BtnCancelar);
            Controls.Add(btntransferir);
            Controls.Add(label3);
            Controls.Add(TxtMonto);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormTranferencias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FTranferencias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtMonto;
        private Label label3;
        private Button btntransferir;
        private Button BtnCancelar;
    }
}