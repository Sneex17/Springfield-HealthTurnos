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
    public partial class ucRoles : ucGestion
    {
        public ucRoles()
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
            estilo.Aplicar(viewDatosRoles);
        }
        private void CargarDatos()
        {
            viewDatosRoles.DataSource = ReglasNegocio.verRoles();
        }
        private void LimpiarControles()
        {
            textbIdRol.Text = string.Empty;
            textbNombre.Text = string.Empty;
            ControlUpdate(textbIdRol.Text);
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
        private void viewDatosRoles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textbIdRol.Text = viewDatosRoles.Rows[e.RowIndex].Cells["IdRol"].Value.ToString();
            textbNombre.Text = viewDatosRoles.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();

            ControlUpdate(textbIdRol.Text);
        }

        private void BuGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textbIdRol.Text))
                {
                    Rol rol = new Rol();
                    rol.Nombre = textbNombre.Text;

                    var validacion = new RolValidacion();
                    var resultado = validacion.Validate(rol);

                    if (!resultado.IsValid)
                    {
                        string error = string.Join("\n",
                            resultado.Errors.Select(M => M.ErrorMessage));

                        throw new ControlExcepciones(error);
                    }

                    var mensaje = MessageBox.Show("Desea registrar este rol?", "Registro de rol",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (mensaje == DialogResult.Yes)
                    {
                        ReglasNegocio.RegistarRol(rol);
                        MessageBox.Show("Rol registrado con exito!", "Registro de rol",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarControles();
                        CargarDatos();
                    }
                }
                else
                {
                    Rol rol = new Rol();
                    rol.IdRol = Convert.ToInt32(textbIdRol.Text);
                    rol.Nombre = textbNombre.Text;
                   
                    var validacion = new RolValidacion();
                    var resultado = validacion.Validate(rol);

                    if (!resultado.IsValid)
                    {
                        string error = string.Join("\n",
                            resultado.Errors.Select(M => M.ErrorMessage));

                        throw new ControlExcepciones(error);
                    }

                    var mensaje = MessageBox.Show("Desea actualizar los datos de este rol?", "Actualización de rol",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (mensaje == DialogResult.Yes)
                    {
                        ReglasNegocio.ActualizarRol(rol);
                        MessageBox.Show("Datos del rol actualizados con exito!", "Actualización de rol",
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

        private void ucRoles_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible)
            {
                LimpiarControles();
                CargarDatos();
            }
        }
    }
}
