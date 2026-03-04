using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEntidades;
using CEntidades.BuilderPattern;
using CEntidades.StatePattern;
using CNegocio;
using CPresentacion.Plantillas;

namespace CPresentacion.Views.UserControlsTurnos
{
    public partial class ucRegistroTurno : ucGestion
    {
        public ucRegistroTurno()
        {
            InitializeComponent();
            CargarDatos();
        }
        private void CargarDatos()
        {
            cbxProridad.DataSource = ReglasNegocio.VerPrioridades();
            cbxProridad.ValueMember = "IdPrioridad";
            cbxProridad.DisplayMember = "Nombre";
        }
        private void BuBuscarPaciente_Click(object sender, EventArgs e)
        {
            fmPacientes paciente = new fmPacientes();
            paciente.SeleccionarPaciente += (pacientes) =>
            {
                textbIdPaciente.Text = pacientes.id.ToString();
                textbNombrePaciente.Text = pacientes.name.ToString();
                textbSexoPaciente.Text = pacientes.gender.ToString();
            };
            paciente.ShowDialog();
        }

        private void BuGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var paciente = new Character()
                {
                    id = Convert.ToInt32(textbIdPaciente.Text),
                    name = textbNombrePaciente.Text,
                    gender = textbSexoPaciente.Text
                };

                var medico = new Medico()
                {
                    IdEmpleado = Convert.ToInt32(textbIdMedico.Text),
                    Nombre = textbNombreMedico.Text,
                    IdEspecialidad = Convert.ToInt32(from L in ReglasNegocio.VerEspecialidades() 
                                                     where L.Nombre == textbEspecialidadMedico.Text 
                                                     select L.IdEspecialidad)
                };

                var prioridad = new Prioridad()
                {
                    IdPrioridad = Convert.ToInt32(cbxProridad.SelectedValue),
                    Nombre = cbxProridad.Text
                };

                var estado = new EstadoTurno();

                ITurnoBuilder turnoBuilder = new TurnoBuilder();
                Turno turno = turnoBuilder
                    .conPaciente(paciente)
                    .conFecha(DateTime.Now)
                    .conMedico(medico)
                    .conObservaciones(rbObservaciones.Text)
                    .conPrioridad(prioridad)
                    .conEstado(estado)
                    .CrearTurno();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
