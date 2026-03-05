using CEntidades;
using CNegocio;
using CPresentacion.DecoratorPattern;
using CPresentacion.Plantillas;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPresentacion.Views.UserControls
{
    public partial class ucAsistentes : ucGestion
    {
        public ucAsistentes()
        {
            InitializeComponent();
            DecorarDatagrid();
            CargarDatos();
        }
        private void DecorarDatagrid()
        {
            IDataGridDecorator estilo = new BordeDecorator(
                            new SeleccionDecorator(
                            new FilasAlternasDecorator(
                            new HeaderDecorator(
                            new DataGridBase()))));
            estilo.Aplicar(viewDatosAsistentes);
        }
        private void CargarDatos()
        {
            cbxTurnos.DataSource = Asistente.listaTurnos;
            cbxArea.DataSource = Asistente.listaAreas;
            viewDatosAsistentes.DataSource = ReglasNegocio.verAsistentes();
        }
        private void LimpiarControles()
        {
            viewDatosAsistentes.DataSource = null;
            textbIdEmpleado.Text = string.Empty;
            textbNombre.Text = string.Empty;
            textbApellido.Text = string.Empty;
            textbEmail.Text = string.Empty;
            textIdBuscar.Text = string.Empty;
            BuGuardar.BackColor = Color.SeaGreen;
            BuGuardar.IconChar = IconChar.Plus;
        }
        private void panelContainer_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible)
            {
                LimpiarControles();
                CargarDatos();
            }
        }

        private void viewDatosAsistentes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textbIdEmpleado.Text = viewDatosAsistentes.Rows[e.RowIndex].Cells["IdEmpleado"].Value.ToString();
            textbNombre.Text = viewDatosAsistentes.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            textbApellido.Text = viewDatosAsistentes.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
            textbEmail.Text = viewDatosAsistentes.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            cbxTurnos.Text = viewDatosAsistentes.Rows[e.RowIndex].Cells["Turno"].Value.ToString();
            cbxArea.Text = viewDatosAsistentes.Rows[e.RowIndex].Cells["Area"].Value.ToString();
        }

        private void BuBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textIdBuscar.Text))
                {
                    throw new ControlExcepciones("Debe de ingresar un id para buscar");
                }
                int id = Convert.ToInt32(textIdBuscar.Text);
                var lista = ReglasNegocio.verEmpleados();
                var dato = from L in lista.Where(L => L.IdEmpleado == id) select L;

                if (dato == null)
                {
                    throw new ControlExcepciones($"No se encontro ningun empleado con el id {id}");
                }

                foreach (var emp in dato)
                {
                    textbIdEmpleado.Text = emp.IdEmpleado.ToString();
                    textbNombre.Text = emp.Nombre;
                    textbApellido.Text = emp.Apellido;
                    textbEmail.Text = emp.Email;
                }
            }
            catch (ControlExcepciones ex)
            {
                MessageBox.Show($"{ex.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow[] empleadoAsistente = ReglasNegocio.verAsistentes().Select($"IdEmpleado = {textbIdEmpleado.Text}");

                if (empleadoAsistente.Length > 0)
                {
                    LimpiarControles();
                    CargarDatos();
                    throw new ControlExcepciones("Este empleado ya esta registrado como asistente");
                }

                DataRow[] empleadoMedico = ReglasNegocio.verMedicos().Select($"IdEmpleado = {textbIdEmpleado.Text}");

                if (empleadoMedico.Length > 0)
                {
                    LimpiarControles();
                    CargarDatos();
                    throw new ControlExcepciones("Este empleado ya esta registrado como médico");
                }

                if (materialSwitchActualizar.Checked == false)
                {
                    Asistente asistente = new Asistente();
                    asistente.IdEmpleado = Convert.ToInt32(textbIdEmpleado.Text);
                    asistente.Turno = cbxTurnos.Text;
                    asistente.Area = cbxArea.Text;

                    var validacion = new AsistenteValidacion();
                    var resultado = validacion.Validate(asistente);

                    if (!resultado.IsValid)
                    {
                        string error = string.Join("\n",
                            resultado.Errors.Select(M => M.ErrorMessage));

                        throw new ControlExcepciones(error);
                    }

                    var mensaje = MessageBox.Show("Desea registrar este empleado como asistente?", "Registro de asistente",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (mensaje == DialogResult.Yes)
                    {
                        ReglasNegocio.RegistarAsistente(asistente);
                        MessageBox.Show("Asistente registrado con exito!", "Registro de asistente",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarControles();
                        CargarDatos();
                    }
                }
                else
                {
                    Asistente asistente = new Asistente();
                    asistente.IdEmpleado = Convert.ToInt32(textbIdEmpleado.Text);
                    asistente.Turno = cbxTurnos.Text;
                    asistente.Area = cbxArea.Text;

                    var validacion = new AsistenteValidacion();
                    var resultado = validacion.Validate(asistente);

                    if (!resultado.IsValid)
                    {
                        string error = string.Join("\n",
                            resultado.Errors.Select(M => M.ErrorMessage));

                        throw new ControlExcepciones(error);
                    }

                    var mensaje = MessageBox.Show("Desea actualizar los datos de este asistente?", "Actualización de asistente",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (mensaje == DialogResult.Yes)
                    {
                        ReglasNegocio.ActualizarAsistente(asistente);
                        MessageBox.Show("Datos del asistente actualizados con exito!", "Actualización de asistente",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarControles();
                        CargarDatos();
                    }
                }
            }
            catch (ControlExcepciones ex)
            {
                MessageBox.Show($"{ex.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    
}
