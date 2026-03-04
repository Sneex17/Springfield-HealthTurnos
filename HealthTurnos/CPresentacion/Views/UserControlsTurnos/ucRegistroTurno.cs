using CEntidades;
using CEntidades.BuilderPattern;
using CEntidades.StatePattern;
using CNegocio;
using CPresentacion.Plantillas;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPresentacion.Views.UserControlsTurnos
{
    public partial class ucRegistroTurno : ucGestion
    {
        Usuario user = new Usuario();
        public ucRegistroTurno(Usuario usuario)
        {
            InitializeComponent();
            CargarDatos();
            user = usuario;
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

                var estado = new EstadoTurno();
                textbEstado.Text = estado.estado.Estado.ToString();
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
                var asistente = new Asistente()
                {
                    IdEmpleado = ReglasNegocio.IdAsistente(user.IdUsuario)
                };

                var medico = new Medico()
                {
                    IdEmpleado = Convert.ToInt32(textbIdMedico.Text),
                    Nombre = textbNombreMedico.Text,
                    IdEspecialidad = Convert.ToInt32(ReglasNegocio.VerEspecialidades()
                                .Where(L => L.Nombre == textbEspecialidadMedico.Text)
                                .Select(M => M.IdEspecialidad).FirstOrDefault())
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
                    .conAsistente(asistente)
                    .conMedico(medico)
                    .conObservaciones(rbObservaciones.Text)
                    .conPrioridad(prioridad)
                    .conEstado(estado)
                    .CrearTurno();


                var validar = new TurnoValidacion();
                var resultado = validar.Validate(turno);

                if(!resultado.IsValid)
                {
                    string errores = string.Join("\n", 
                        resultado.Errors.Select(M => M.ErrorMessage));
                    throw new ControlExcepciones(errores);
                }

                MessageBox.Show($"{turno.Paciente.id}\n, {turno.Medico.IdEmpleado}\n, {turno.Asistente.IdEmpleado},\n, {turno.Fecha},\n, {turno.Prioridad.IdPrioridad},\n, {turno.Estado.estado.Estado},\n", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(ControlExcepciones error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuBuscarMedico_Click(object sender, EventArgs e)
        {
            fmMedicos medicos = new fmMedicos();
            medicos.SeleccionarMedico += (medico) =>
            {
                textbIdMedico.Text = medico.IdEmpleado.ToString();
                textbNombreMedico.Text = medico.Nombre.ToString();
                textbEspecialidadMedico.Text = ReglasNegocio.EspecialidadMedico(medico.IdEmpleado);
                
            };
            medicos.ShowDialog();
        }
    }
}
