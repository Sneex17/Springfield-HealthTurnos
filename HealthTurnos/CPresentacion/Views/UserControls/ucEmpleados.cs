using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPresentacion.Plantillas;
using CNegocio;
using FontAwesome.Sharp;
using CEntidades;
using FluentValidation;

namespace CPresentacion.Views.UserControls
{
    public partial class ucEmpleados : ucGestion
    {
        
        public ucEmpleados()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            var lista = ReglasNegocio.verEmpleados();
            viewDatosEmpleados.DataSource = new BindingList<Empleado>(lista);
        }

        private void viewDatosEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textbIdEmpleado.Text = viewDatosEmpleados.Rows[e.RowIndex].Cells["IdEmpleado"].Value.ToString();
            textbNombre.Text = viewDatosEmpleados.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            textbApellido.Text = viewDatosEmpleados.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
            textbEmail.Text = viewDatosEmpleados.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            texbTelefono.Text = viewDatosEmpleados.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
            dateFechaIngerso.Value = Convert.ToDateTime(viewDatosEmpleados.Rows[e.RowIndex].Cells["FechaIngreso"].Value);

            ControlUpdate(textbIdEmpleado.Text);
        }

        private void ControlUpdate(string id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
                textbNombre.Enabled = false;
                textbApellido.Enabled = false;
                BuGuardar.BackColor = Color.DodgerBlue;
                BuGuardar.IconChar = IconChar.ArrowRotateRight;
            }
            else
            {
                textbNombre.Enabled = true;
                textbApellido.Enabled = true;
                BuGuardar.BackColor = Color.SeaGreen;
                BuGuardar.IconChar = IconChar.Plus;
            }
        }


        private void LimpiarControles()
        {
            textbIdEmpleado.Text = string.Empty;
            textbNombre.Text = string.Empty;
            textbApellido.Text = string.Empty;
            textbEmail.Text = string.Empty;
            texbTelefono.Text = string.Empty;
            dateFechaIngerso.Value = DateTime.Today;
            ControlUpdate(textbIdEmpleado.Text);
        }
        private void BuGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textbIdEmpleado.Text))
                {
                    Empleado empleado = new Empleado();
                    empleado.Nombre = textbNombre.Text;
                    empleado.Apellido = textbApellido.Text;
                    empleado.Email = ReglasNegocio.GeneralEmail(textbNombre.Text, 
                        textbApellido.Text);
                    empleado.Telefono = texbTelefono.Text;
                    empleado.FechaIngreso = dateFechaIngerso.Value;

                    var validacion = new EmpleadoValidacion();
                    var resultado = validacion.Validate(empleado);

                    if (!resultado.IsValid)
                    {
                        string error = string.Join("\n", 
                            resultado.Errors.Select(M => M.ErrorMessage));

                        throw new ControlExcepciones(error);
                    }

                    var mensaje = MessageBox.Show("Desea registrar este empleado?", "Registro de empleado",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(mensaje == DialogResult.Yes)
                    {
                        ReglasNegocio.RegistarEmpleado(empleado);
                        MessageBox.Show("Empleado registrado con exito!", "Registro de empleado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarControles();
                        CargarDatos();
                    }
                }
                else
                {
                    Empleado empleado = new Empleado();
                    empleado.IdEmpleado = Convert.ToInt32(textbIdEmpleado.Text);
                    empleado.Nombre = textbNombre.Text;
                    empleado.Apellido = textbApellido.Text;
                    empleado.Email = textbEmail.Text;
                    empleado.Telefono = texbTelefono.Text;
                    empleado.FechaIngreso = dateFechaIngerso.Value;

                    var validacion = new EmpleadoValidacion();
                    var resultado = validacion.Validate(empleado);

                    if (!resultado.IsValid)
                    {
                        string error = string.Join("\n",
                            resultado.Errors.Select(M => M.ErrorMessage));

                        throw new ControlExcepciones(error);
                    }

                    var mensaje = MessageBox.Show("Desea actualizar los datos de este empleado?", "Actualización de empleado",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (mensaje == DialogResult.Yes)
                    {
                        ReglasNegocio.ActualizarEmpleado(empleado);
                        MessageBox.Show("Datos del empleado actualizados con exito!", "Actualización de empleado",
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
                MessageBox.Show($"{ex.Message}","Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
    }
}
