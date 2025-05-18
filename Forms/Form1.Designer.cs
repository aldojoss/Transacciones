namespace Transacciones_en_.net
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnaggclientes = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.WindowText;
            dataGridView1.Location = new Point(30, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(600, 233);
            dataGridView1.TabIndex = 0;
            // 
            // btnaggclientes
            // 
            btnaggclientes.FlatAppearance.BorderSize = 0;
            btnaggclientes.FlatStyle = FlatStyle.Flat;
            btnaggclientes.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnaggclientes.ForeColor = Color.White;
            btnaggclientes.Location = new Point(688, 31);
            btnaggclientes.Name = "btnaggclientes";
            btnaggclientes.Size = new Size(161, 85);
            btnaggclientes.TabIndex = 1;
            btnaggclientes.Text = "Agregar Clientes";
            btnaggclientes.UseVisualStyleBackColor = true;
            btnaggclientes.Click += btnaggclientes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(887, 514);
            Controls.Add(btnaggclientes);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnaggclientes;
    }
}
