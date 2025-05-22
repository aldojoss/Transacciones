namespace Transacciones_en_.net
{
    partial class FormAddCl
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
            btnagregarr = new Button();
            btncancelar = new Button();
            txtidentificacion = new TextBox();
            label2 = new Label();
            txtnombre = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnagregarr
            // 
            btnagregarr.BackColor = Color.FromArgb(76, 175, 80);
            btnagregarr.FlatAppearance.BorderSize = 0;
            btnagregarr.FlatStyle = FlatStyle.Flat;
            btnagregarr.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnagregarr.ForeColor = Color.White;
            btnagregarr.Location = new Point(50, 198);
            btnagregarr.Name = "btnagregarr";
            btnagregarr.Size = new Size(99, 29);
            btnagregarr.TabIndex = 13;
            btnagregarr.Text = "Aceptar";
            btnagregarr.UseVisualStyleBackColor = false;
            btnagregarr.Click += btnagregarr_Click;
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.FromArgb(244, 67, 54);
            btncancelar.FlatAppearance.BorderSize = 0;
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncancelar.ForeColor = Color.White;
            btncancelar.Location = new Point(157, 198);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(91, 29);
            btncancelar.TabIndex = 12;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // txtidentificacion
            // 
            txtidentificacion.Location = new Point(123, 142);
            txtidentificacion.Name = "txtidentificacion";
            txtidentificacion.Size = new Size(125, 27);
            txtidentificacion.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 145);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 10;
            label2.Text = "Identificacion";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(123, 89);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(125, 27);
            txtnombre.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(51, 92);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_usuario_32;
            pictureBox1.Location = new Point(91, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // FormAddCl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 44, 144);
            ClientSize = new Size(284, 264);
            Controls.Add(pictureBox1);
            Controls.Add(btnagregarr);
            Controls.Add(btncancelar);
            Controls.Add(txtidentificacion);
            Controls.Add(label2);
            Controls.Add(txtnombre);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddCl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddCl";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnagregarr;
        private Button btncancelar;
        private TextBox txtidentificacion;
        private Label label2;
        private TextBox txtnombre;
        private Label label1;
        private PictureBox pictureBox1;
    }
}