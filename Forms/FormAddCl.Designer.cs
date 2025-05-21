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
            button1 = new Button();
            txtidentificacion = new TextBox();
            label2 = new Label();
            txtnombre = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnagregarr
            // 
            btnagregarr.Location = new Point(123, 113);
            btnagregarr.Name = "btnagregarr";
            btnagregarr.Size = new Size(125, 29);
            btnagregarr.TabIndex = 13;
            btnagregarr.Text = "Aceptar";
            btnagregarr.UseVisualStyleBackColor = true;
            btnagregarr.Click += btnagregarr_Click;
            // 
            // button1
            // 
            button1.Location = new Point(254, 113);
            button1.Name = "button1";
            button1.Size = new Size(45, 29);
            button1.TabIndex = 12;
            button1.Text = "esc";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtidentificacion
            // 
            txtidentificacion.Location = new Point(123, 69);
            txtidentificacion.Name = "txtidentificacion";
            txtidentificacion.Size = new Size(125, 27);
            txtidentificacion.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 72);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 10;
            label2.Text = "Identificacon";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(123, 27);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(125, 27);
            txtnombre.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 30);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            // 
            // FormAddCl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 187);
            Controls.Add(btnagregarr);
            Controls.Add(button1);
            Controls.Add(txtidentificacion);
            Controls.Add(label2);
            Controls.Add(txtnombre);
            Controls.Add(label1);
            Name = "FormAddCl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddCl";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnagregarr;
        private Button button1;
        private TextBox txtidentificacion;
        private Label label2;
        private TextBox txtnombre;
        private Label label1;
    }
}