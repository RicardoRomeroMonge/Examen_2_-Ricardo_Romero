using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.Design.AxImporter;

namespace Examen1
{

    public partial class Form1 : Form
    {
        private List<Paciente> pacientes = new List<Paciente>();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DiseñarFormulario();
        }

        private void ActualizarGrid()
        {
            dgvPacientes.DataSource = null;
            dgvPacientes.DataSource = pacientes;
        }

        private void DiseñarFormulario()
        {
            this.Text = "Consulta de Pacientes";
            this.BackColor = Color.LightBlue;
            this.Size = new Size(800, 600);

            Label lblTitulo = new Label()
            {
                Text = "Consulta de Pacientes",
                Font = new Font("Arial", 20, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.Blue,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 50
            };
            this.Controls.Add(lblTitulo);

            Panel menuPanel = new Panel()
            {
                BackColor = Color.DarkBlue,
                Width = 200,
                Dock = DockStyle.Left
            };
            this.Controls.Add(menuPanel);

            btnAgregar.Text = "Agregar";
            btnAgregar.ForeColor = Color.White;
            btnAgregar.BackColor = Color.DarkBlue;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Arial", 12, FontStyle.Bold);
            btnAgregar.Width = 180;
            btnAgregar.Height = 40;

            button2.Text = "Borrar";
            button2.ForeColor = Color.White;
            button2.BackColor = Color.DarkBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 12, FontStyle.Bold);
            button2.Width = 180;
            button2.Height = 40;

            button1.Text = "Borrar";
            button1.ForeColor = Color.White;
            button1.BackColor = Color.DarkBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 12, FontStyle.Bold);
            button1.Width = 180;
            button1.Height = 40;



            string[] opciones = { "Agregar", "Modificar", "Borrar" };
            int y = 20;
            //foreach (string opcion in opciones)
            //{
            //    Button btn = new Button()
            //    {
            //        Text = opcion,
            //        ForeColor = Color.White,
            //        BackColor = Color.DarkBlue,
            //        FlatStyle = FlatStyle.Flat,
            //        Font = new Font("Arial", 12, FontStyle.Bold),
            //        Width = 180,
            //        Height = 40,
            //        Location = new Point(10, y)
            //    };
            //    menuPanel.Controls.Add(btn);
            //    y += 50;
            //}
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente()
            {
                Cedula = txtCedula.Text,
                Nombre = txtNombre.Text,
                PrimerApellido = txtPrimerApellido.Text,
                FechaNacimiento = dtpFechaNacimiento.Value,
                Edad = int.Parse(txtEdad.Text),
                Medico = txtMedico.Text,
                Telefono = txtTelefono.Text,
                Especialidad = txtEspecialidad.Text,
                NumeroConsulta = txtNumeroConsulta.Text,
                FechaAtencion = dtpFechaAtencion.Value,
                HoraAtencion = dtpHoraAtencion.Value,
                Consultorio = txtConsultorio.Text
            };

            pacientes.Add(paciente);
            ActualizarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {
                int index = dgvPacientes.SelectedRows[0].Index;
                pacientes[index].Nombre = txtNombre.Text;
                pacientes[index].PrimerApellido = txtPrimerApellido.Text;
                pacientes[index].FechaNacimiento = dtpFechaNacimiento.Value;
                pacientes[index].Edad = int.Parse(txtEdad.Text);
                pacientes[index].Medico = txtMedico.Text;
                pacientes[index].Telefono = txtTelefono.Text;
                pacientes[index].Especialidad = txtEspecialidad.Text;
                pacientes[index].NumeroConsulta = txtNumeroConsulta.Text;
                pacientes[index].FechaAtencion = dtpFechaAtencion.Value;
                pacientes[index].HoraAtencion = dtpHoraAtencion.Value;
                pacientes[index].Consultorio = txtConsultorio.Text;
                ActualizarGrid();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {
                int index = dgvPacientes.SelectedRows[0].Index;
                pacientes.RemoveAt(index);
                ActualizarGrid();
            }
        }
    }

    public class Paciente
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public string Medico { get; set; }
        public string Telefono { get; set; }
        public string Especialidad { get; set; }
        public string NumeroConsulta { get; set; }
        public DateTime FechaAtencion { get; set; }
        public DateTime HoraAtencion { get; set; }
        public string Consultorio { get; set; }
    }
}
