using CEntidades;
using CEntidades.BuilderPattern;
using CEntidades.StatePattern;
using CNegocio;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CPresentacion.Views
{
    public partial class fmMenuPaciente : MaterialForm
    {
        List<Character> listaPaciente = new List<Character>();
        //List<Character> listaAdulto = new List<Character>();
        string mensajes;

        public fmMenuPaciente()
        {
            InitializeComponent();
            CargarDatos();
            paciente();
            
        }
        private void CargarDatos()
        {
            cbxProridad.DataSource = ReglasNegocio.VerPrioridades();
            cbxProridad.ValueMember = "IdPrioridad";
            cbxProridad.DisplayMember = "Nombre";
        }

        private void rbAdulto_CheckedChanged(object sender)
        {
            if(rbAdulto.Checked == true)
            {
                panelAdulto.Visible = true;
                panelNino.Visible = false;
                panelButton.Visible = true;
                
            }
            else
            {
                panelAdulto.Visible = true;
                panelNino.Visible = true;
                panelButton.Visible = true;
            }
        }
        private async void paciente()
        {
            listaPaciente = await ReglasNegocio.VerPacientes();
        }

        private void BuSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbAdulto.Checked == true)
                {
                    int idAdulto = Convert.ToInt32(textbAldulto.Text);
                    var adulto = from L in listaPaciente where L.id == idAdulto select L;

                    foreach (var adultos in adulto)
                    {
                        textbIdPaciente.Text = adultos.id.ToString();
                        textbNombrePaciente.Text = adultos.name.ToString();
                        textbSexoPaciente.Text = adultos.gender.ToString();
                    }

                    var estado = new EstadoTurno();
                    textbEstado.Text = estado.estado.Estado.ToString();
                }
                else
                {
                    int idAdulto = Convert.ToInt32(textbAldulto.Text);
                    var adulto = from L in listaPaciente where L.id == idAdulto select L;


                    int idNino = Convert.ToInt32(textbNino.Text);
                    var nino = from L in listaPaciente where L.id == idNino select L;

                    foreach (var adultos in adulto)
                    {
                        mensajes = $"El adulto {adultos.name} ha solicitado una consulta para un menor a su cargo.";
                    }


                    foreach (var ninos in nino)
                    {
                        textbIdPaciente.Text = ninos.id.ToString();
                        textbNombrePaciente.Text = ninos.name.ToString();
                        textbSexoPaciente.Text = ninos.gender.ToString();
                    }

                    var estado = new EstadoTurno();
                    textbEstado.Text = estado.estado.Estado.ToString();
                }
            }
            catch (ControlExcepciones error)
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
                    IdEmpleado = 9
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

                if (ReglasNegocio.PacienteConTurnoActivo(asistente.IdEmpleado, paciente.id))
                {
                    throw new ControlExcepciones($"El paciente {paciente.name} ya tiene un turno activo");
                }

                if (rbAdulto.Checked == false)
                {
                    rbObservaciones.Text = $"{mensajes}\n{rbObservaciones.Text}";
                }

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

                if (!resultado.IsValid)
                {
                    string errores = string.Join("\n",
                        resultado.Errors.Select(M => M.ErrorMessage));
                    throw new ControlExcepciones(errores);
                }

                var mensaje = MessageBox.Show("Desea registrar este turno?", "Registro de turno",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(mensaje == DialogResult.Yes)
                {
                    ReglasNegocio.RegistrarTurno(turno);

                    MessageBox.Show($"{turno.Paciente.id}\n, {turno.Medico.IdEmpleado}\n, {turno.Asistente.IdEmpleado},\n, {turno.Fecha},\n, {turno.Prioridad.IdPrioridad},\n, {turno.Estado.estado.Estado},\n", "Error en la operación",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ControlExcepciones error)
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

        private void BuSalir_Click(object sender, EventArgs e)
        {
            fmInicioPaciente inicioPaciente = new fmInicioPaciente();
            inicioPaciente.Show();
            this.Hide();
        }
    }
}
