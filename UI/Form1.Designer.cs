namespace UI
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
            dgvEmpleados = new DataGridView();
            btnBorrador = new Button();
            btnConfirmar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDNI = new TextBox();
            txtApellido = new TextBox();
            txtSueldo = new TextBox();
            btnListar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(272, 30);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.Size = new Size(478, 359);
            dgvEmpleados.TabIndex = 0;
            // 
            // btnBorrador
            // 
            btnBorrador.Font = new Font("Segoe UI", 12F);
            btnBorrador.Location = new Point(27, 248);
            btnBorrador.Name = "btnBorrador";
            btnBorrador.Size = new Size(164, 42);
            btnBorrador.TabIndex = 1;
            btnBorrador.Text = "Agregar borrador";
            btnBorrador.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Segoe UI", 12F);
            btnConfirmar.Location = new Point(27, 296);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(164, 42);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(27, 30);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 3;
            label1.Text = "Apellido y Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(27, 85);
            label2.Name = "label2";
            label2.Size = new Size(37, 21);
            label2.TabIndex = 4;
            label2.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(27, 155);
            label3.Name = "label3";
            label3.Size = new Size(96, 21);
            label3.TabIndex = 5;
            label3.Text = "SueldoBruto";
            // 
            // txtDNI
            // 
            txtDNI.Font = new Font("Segoe UI", 12F);
            txtDNI.Location = new Point(27, 109);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(164, 29);
            txtDNI.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 12F);
            txtApellido.Location = new Point(27, 53);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(164, 29);
            txtApellido.TabIndex = 7;
            // 
            // txtSueldo
            // 
            txtSueldo.Font = new Font("Segoe UI", 12F);
            txtSueldo.Location = new Point(27, 179);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(164, 29);
            txtSueldo.TabIndex = 8;
            // 
            // btnListar
            // 
            btnListar.Font = new Font("Segoe UI", 12F);
            btnListar.Location = new Point(27, 344);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(164, 42);
            btnListar.TabIndex = 9;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnListar);
            Controls.Add(txtSueldo);
            Controls.Add(txtApellido);
            Controls.Add(txtDNI);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConfirmar);
            Controls.Add(btnBorrador);
            Controls.Add(dgvEmpleados);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmpleados;
        private Button btnBorrador;
        private Button btnConfirmar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDNI;
        private TextBox txtApellido;
        private TextBox txtSueldo;
        private Button btnListar;
    }
}
