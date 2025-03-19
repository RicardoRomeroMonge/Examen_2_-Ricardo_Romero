namespace Examen1
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            dgvPacientes = new DataGridView();
            panel1 = new Panel();
            txtMedico = new TextBox();
            txtEdad = new TextBox();
            txtEspecialidad = new TextBox();
            txtTelefono = new TextBox();
            dtpHoraAtencion = new DateTimePicker();
            dtpFechaAtencion = new DateTimePicker();
            dtpFechaNacimiento = new DateTimePicker();
            txtConsultorio = new TextBox();
            txtNombre = new TextBox();
            txtPrimerApellido = new TextBox();
            txtNumeroConsulta = new TextBox();
            txtCedula = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            button1 = new Button();
            button2 = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPacientes
            // 
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(251, 115);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.Size = new Size(798, 281);
            dgvPacientes.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(txtMedico);
            panel1.Controls.Add(txtEdad);
            panel1.Controls.Add(txtEspecialidad);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(dtpHoraAtencion);
            panel1.Controls.Add(dtpFechaAtencion);
            panel1.Controls.Add(dtpFechaNacimiento);
            panel1.Controls.Add(txtConsultorio);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtPrimerApellido);
            panel1.Controls.Add(txtNumeroConsulta);
            panel1.Controls.Add(txtCedula);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(251, 432);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 161);
            panel1.TabIndex = 1;
            // 
            // txtMedico
            // 
            txtMedico.Location = new Point(621, 57);
            txtMedico.Name = "txtMedico";
            txtMedico.Size = new Size(100, 23);
            txtMedico.TabIndex = 29;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(495, 57);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 28;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(152, 119);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(100, 23);
            txtEspecialidad.TabIndex = 27;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(30, 119);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 26;
            // 
            // dtpHoraAtencion
            // 
            dtpHoraAtencion.Location = new Point(486, 116);
            dtpHoraAtencion.Name = "dtpHoraAtencion";
            dtpHoraAtencion.Size = new Size(105, 23);
            dtpHoraAtencion.TabIndex = 25;
            // 
            // dtpFechaAtencion
            // 
            dtpFechaAtencion.Location = new Point(375, 116);
            dtpFechaAtencion.Name = "dtpFechaAtencion";
            dtpFechaAtencion.Size = new Size(105, 23);
            dtpFechaAtencion.TabIndex = 24;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(375, 61);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(105, 23);
            dtpFechaNacimiento.TabIndex = 23;
            // 
            // txtConsultorio
            // 
            txtConsultorio.Location = new Point(620, 116);
            txtConsultorio.Name = "txtConsultorio";
            txtConsultorio.Size = new Size(100, 23);
            txtConsultorio.TabIndex = 20;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(144, 57);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 17;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(264, 57);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(100, 23);
            txtPrimerApellido.TabIndex = 16;
            // 
            // txtNumeroConsulta
            // 
            txtNumeroConsulta.Location = new Point(264, 116);
            txtNumeroConsulta.Name = "txtNumeroConsulta";
            txtNumeroConsulta.Size = new Size(100, 23);
            txtNumeroConsulta.TabIndex = 14;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(20, 57);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(100, 23);
            txtCedula.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.LightSkyBlue;
            label12.Font = new Font("Segoe UI", 12F);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(157, 23);
            label12.Name = "label12";
            label12.Size = new Size(68, 21);
            label12.TabIndex = 11;
            label12.Text = "Nombre";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.LightSkyBlue;
            label11.Font = new Font("Segoe UI", 12F);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(279, 23);
            label11.Name = "label11";
            label11.Size = new Size(80, 21);
            label11.TabIndex = 10;
            label11.Text = "1 Apellido";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.LightSkyBlue;
            label10.Font = new Font("Segoe UI", 12F);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(365, 23);
            label10.Name = "label10";
            label10.Size = new Size(134, 21);
            label10.TabIndex = 9;
            label10.Text = "Fecha Nacimiento";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.LightSkyBlue;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(486, 92);
            label9.Name = "label9";
            label9.Size = new Size(109, 21);
            label9.TabIndex = 8;
            label9.Text = "Hora Atencion";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.LightSkyBlue;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(621, 92);
            label8.Name = "label8";
            label8.Size = new Size(91, 21);
            label8.TabIndex = 7;
            label8.Text = "Consultorio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightSkyBlue;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(365, 92);
            label7.Name = "label7";
            label7.Size = new Size(115, 21);
            label7.TabIndex = 6;
            label7.Text = "Fecha Atencion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightSkyBlue;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(632, 23);
            label6.Name = "label6";
            label6.Size = new Size(61, 21);
            label6.TabIndex = 5;
            label6.Text = "Medico";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightSkyBlue;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(264, 92);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 4;
            label5.Text = "#Consulta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightSkyBlue;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(41, 92);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 3;
            label4.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSkyBlue;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(513, 23);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 2;
            label3.Text = "Edad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSkyBlue;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(157, 92);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 1;
            label2.Text = "Especialidad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSkyBlue;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(41, 23);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 0;
            label1.Text = "Cedula";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // button1
            // 
            button1.Location = new Point(2, 175);
            button1.Name = "button1";
            button1.Size = new Size(103, 24);
            button1.TabIndex = 2;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(2, 248);
            button2.Name = "button2";
            button2.Size = new Size(103, 24);
            button2.TabIndex = 3;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(2, 338);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(103, 24);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 605);
            Controls.Add(btnAgregar);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(dgvPacientes);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPacientes;
        private Panel panel1;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox txtConsultorio;
        private TextBox textBox9;
        private TextBox textBox7;
        private TextBox txtNombre;
        private TextBox txtPrimerApellido;
        private TextBox textBox4;
        private TextBox txtNumeroConsulta;
        private TextBox textBox2;
        private TextBox txtCedula;
        private DateTimePicker dtpFechaAtencion;
        private DateTimePicker dtpFechaNacimiento;
        private DateTimePicker dtpHoraAtencion;
        private TextBox txtEdad;
        private TextBox txtEspecialidad;
        private TextBox txtTelefono;
        private TextBox txtMedico;
        private Button button1;
        private Button button2;
        private Button btnAgregar;
    }
}