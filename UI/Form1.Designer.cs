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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(6, 22);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.Size = new Size(492, 386);
            dgvEmpleados.TabIndex = 0;
            // 
            // btnBorrador
            // 
            btnBorrador.Font = new Font("Segoe UI", 12F);
            btnBorrador.Location = new Point(36, 251);
            btnBorrador.Name = "btnBorrador";
            btnBorrador.Size = new Size(164, 42);
            btnBorrador.TabIndex = 3;
            btnBorrador.Text = "Agregar borrador";
            btnBorrador.UseVisualStyleBackColor = true;
            btnBorrador.Click += btnBorrador_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Segoe UI", 12F);
            btnConfirmar.Location = new Point(36, 299);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(164, 42);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(36, 33);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 3;
            label1.Text = "Apellido y Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(36, 88);
            label2.Name = "label2";
            label2.Size = new Size(37, 21);
            label2.TabIndex = 4;
            label2.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(36, 158);
            label3.Name = "label3";
            label3.Size = new Size(96, 21);
            label3.TabIndex = 5;
            label3.Text = "SueldoBruto";
            // 
            // txtDNI
            // 
            txtDNI.Font = new Font("Segoe UI", 12F);
            txtDNI.Location = new Point(36, 112);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(164, 29);
            txtDNI.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 12F);
            txtApellido.Location = new Point(36, 56);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(164, 29);
            txtApellido.TabIndex = 0;
            txtApellido.Tag = "0";
            // 
            // txtSueldo
            // 
            txtSueldo.Font = new Font("Segoe UI", 12F);
            txtSueldo.Location = new Point(36, 182);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(164, 29);
            txtSueldo.TabIndex = 2;
            // 
            // btnListar
            // 
            btnListar.Font = new Font("Segoe UI", 12F);
            btnListar.Location = new Point(36, 347);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(164, 42);
            btnListar.TabIndex = 5;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSueldo);
            groupBox1.Controls.Add(btnListar);
            groupBox1.Controls.Add(btnBorrador);
            groupBox1.Controls.Add(btnConfirmar);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDNI);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(22, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(229, 414);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alta Empleados";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvEmpleados);
            groupBox2.Location = new Point(269, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(504, 414);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Empleados";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
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
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
