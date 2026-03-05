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
    public partial class ucEspecialidades : ucGestion
    {
        public ucEspecialidades()
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
            estilo.Aplicar(viewDatosEspecialidades);
        }
        private void CargarDatos()
        {
            viewDatosEspecialidades.DataSource = ReglasNegocio.VerEspecialidades();
        }
        private void LimpiarControles()
        {
            textbIdEspecialidad.Text = string.Empty;
            textbNombre.Text = string.Empty;
            textbSalario.Text = string.Empty;
            ControlUpdate(textbIdEspecialidad.Text);
        }
        private void ControlUpdate(string id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
                BuGuardar.Text = "Actualizar";
                BuGuardar.BackColor = Color.DodgerBlue;
                BuGuardar.IconChar = IconChar.ArrowRotateRight;
            }
            else
            {
                BuGuardar.Text = "Registrar";
                BuGuardar.BackColor = Color.SeaGreen;
                BuGuardar.IconChar = IconChar.Plus;
            }
        }

        private void viewDatosEspecialidades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textbIdEspecialidad.Text = viewDatosEspecialidades.Rows[e.RowIndex].Cells["IdEspecialidad"].Value.ToString();
            textbNombre.Text = viewDatosEspecialidades.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            textbSalario.Text = viewDatosEspecialidades.Rows[e.RowIndex].Cells["Salario"].Value.ToString();

            ControlUpdate(textbIdEspecialidad.Text);
        }

        private void BuGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textbIdEspecialidad.Text))
                {
                    Especialidad especialidad = new Especialidad();
                    especialidad.Nombre = textbNombre.Text;
                    especialidad.Salario = Convert.ToDecimal(textbSalario.Text);

                    var validacion = new EspecialidadValidacion();
                    var resultado = validacion.Validate(especialidad);

                    if (!resultado.IsValid)
                    {
                        string error = string.Join("\n",
                            resultado.Errors.Select(M => M.ErrorMessage));

                        throw new ControlExcepciones(error);
                    }

                    var mensaje = MessageBox.Show("Desea registrar esta especialidad?", "Registro de especialidad",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (mensaje == DialogResult.Yes)
                    {
                        ReglasNegocio.RegistarEspecialidad(especialidad);
                        MessageBox.Show("Especialidad registrada con exito!", "Registro de especialidad",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarControles();
                        CargarDatos();
                    }
                }
                else
                {
                    Especialidad especialidad = new Especialidad();
                    especialidad.IdEspecialidad = Convert.ToInt32(textbIdEspecialidad.Text);
                    especialidad.Nombre = textbNombre.Text;
                    especialidad.Salario = Convert.ToDecimal(textbSalario.Text);

                    var validacion = new EspecialidadValidacion();
                    var resultado = validacion.Validate(especialidad);

                    if (!resultado.IsValid)
                    {
                        string error = string.Join("\n",
                            resultado.Errors.Select(M => M.ErrorMessage));

                        throw new ControlExcepciones(error);
                    }

                    var mensaje = MessageBox.Show("Desea actualizar los datos de esta especialidad?", "Actualización de especialidad",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (mensaje == DialogResult.Yes)
                    {
                        ReglasNegocio.ActualizarEspecialidad(especialidad);
                        MessageBox.Show("Datos de la especialidad actualizados con exito!", "Actualización de especialidad",
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

        private void ucEspecialidades_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible)
            {
                LimpiarControles();
                CargarDatos();
            }
        }
    }
}
