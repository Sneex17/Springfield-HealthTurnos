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
using CPresentacion.Views.fmDialogos;

namespace CPresentacion.Views.UserControlsMedicos
{
    public partial class ucAtenderPaciente : ucGestion
    {
        Usuario user = new Usuario();
        public ucAtenderPaciente(Usuario usuario)
        {
            InitializeComponent();
            user = usuario;
            CargarComponentes();
            
        }
        private void CargarComponentes()
        {
            cbxProximoEstado.Items.Clear();
            cbxProximoEstado.Text = "Seleccionar estado";
            cbxProximoEstado.Items.Add("Atendido");
            cbxProximoEstado.Items.Add("Cancelado");
        }

        private void panelContainer_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible)
            {
                CargarComponentes();
            }
        }

        private void LimpiarTextbox()
        {
            texbIdTurno.Text = string.Empty;
            textbFecha.Text = string.Empty;
            textbIdPaciente.Text = string.Empty;
            textbNombrePaciente.Text = string.Empty;
            textbSexoPaciente.Text = string.Empty;
            textbPrioridadPaciente.Text = string.Empty;
            rbObservaciones.Text = string.Empty;
            textbEstado.Text = string.Empty;
            cbxProximoEstado.Text = "Seleccionar estado";
        }
        private void BuCargarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = ReglasNegocio.ProximoPaciente(user.IdEmpleado);

                if (lista.Rows.Count == 0)
                {
                    throw new ControlExcepciones("No hay paciente en espera para atender");
                }

                int id = Convert.ToInt32(lista.Rows[0]["IdTurno"].ToString());
                rbObservaciones.Text = lista.Rows[0]["Observaciones"].ToString();

                if (lista.Rows[0]["Estado"].ToString() == "Pendiente")
                {
                    EstadoTurno estado = new EstadoTurno();
                    estado.CambioEstado(new EstadoEnAtencion());

                    CambioEstado(id, rbObservaciones.Text, estado);
                    var listaActual = ReglasNegocio.ProximoPaciente(user.IdEmpleado);

                    texbIdTurno.Text = listaActual.Rows[0]["IdTurno"].ToString();
                    textbFecha.Text = listaActual.Rows[0]["Fecha"].ToString();
                    textbIdPaciente.Text = listaActual.Rows[0]["IdPaciente"].ToString();
                    textbNombrePaciente.Text = listaActual.Rows[0]["Paciente"].ToString();
                    textbSexoPaciente.Text = listaActual.Rows[0]["Sexo"].ToString();
                    textbPrioridadPaciente.Text = listaActual.Rows[0]["Prioridad"].ToString();
                    rbObservaciones.Text = listaActual.Rows[0]["Observaciones"].ToString();
                    textbEstado.Text = listaActual.Rows[0]["Estado"].ToString();
                }
                else
                {
                    texbIdTurno.Text = lista.Rows[0]["IdTurno"].ToString();
                    textbFecha.Text = lista.Rows[0]["Fecha"].ToString();
                    textbIdPaciente.Text = lista.Rows[0]["IdPaciente"].ToString();
                    textbNombrePaciente.Text = lista.Rows[0]["Paciente"].ToString();
                    textbSexoPaciente.Text = lista.Rows[0]["Sexo"].ToString();
                    textbPrioridadPaciente.Text = lista.Rows[0]["Prioridad"].ToString();
                    rbObservaciones.Text = lista.Rows[0]["Observaciones"].ToString();
                    textbEstado.Text = lista.Rows[0]["Estado"].ToString();
                }

                if(!string.IsNullOrWhiteSpace(texbIdTurno.Text))
                {
                    BuCargarPaciente.Enabled = false;
                    BuFinalizar.Enabled = true;
                }
            }
            catch (ControlExcepciones error)
            {
                MessageBox.Show($"{error.Message}", "Atención de pacientes", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception error)
            {
                MessageBox.Show($"{error.Message}", "Atención de pacientes",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private async void CargarProximo()
        {
            await Task.Delay(2200);
            BuCargarPaciente_Click(null, EventArgs.Empty);
        }
        private void CambioEstado(int id, string observaciones, EstadoTurno estado)
        {
            ITurnoBuilder turnoBuilder = new TurnoBuilder();
            Turno turno = turnoBuilder
                .conIdTurno(id)
                .conObservaciones(observaciones)
                .conEstado(estado)
                .CrearTurno();

            ReglasNegocio.CambiosDeTurno(turno);
        }

        private void BuFinalizar_Click(object sender, EventArgs e)
        {
            var mensaje = MessageBox.Show($"Desea finalizar esta consulta como: {cbxProximoEstado.Text}?", 
                "Terminar consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(mensaje == DialogResult.Yes)
            {
                switch (cbxProximoEstado.Text)
                {
                    case "Atendido":
                        {
                            int id = Convert.ToInt32(texbIdTurno.Text);
                            EstadoTurno estado = new EstadoTurno();
                            estado.CambioEstado(new EstadoAtendido());

                            CambioEstado(id, rbObservaciones.Text, estado);
                        }
                        break;

                    case "Cancelado":
                        {
                            int id = Convert.ToInt32(texbIdTurno.Text);
                            EstadoTurno estado = new EstadoTurno();
                            estado.CambioEstado(new EstadoCancelado());

                            CambioEstado(id, rbObservaciones.Text, estado);
                        }
                        break;
                }

                var mensajeFinal = MessageBox.Show($"Consulta finalizada\nDesea cargar y llamar al siguiente paciente en turno?",
                "Consulta finalizada", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


                if(mensajeFinal == DialogResult.Yes)
                {
                    LimpiarTextbox();
                    fmMensajeProximoTurno mensajeProximoTurno = new fmMensajeProximoTurno();
                    mensajeProximoTurno.ShowDialog();

                    CargarProximo();
                }
                else
                {
                    LimpiarTextbox();
                    BuCargarPaciente.Enabled = true;
                    BuFinalizar.Enabled = false;
                }

            }
            
        }
    }
}
