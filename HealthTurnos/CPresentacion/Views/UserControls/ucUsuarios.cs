using CEntidades;
using CNegocio;
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
    public partial class ucUsuarios : ucGestion
    {
        public ucUsuarios()
        {
            InitializeComponent();
            CargarComponentes();
            CargarDatos();
        }

        private void CargarComponentes()
        {
            cbxRoles.DataSource = ReglasNegocio.verRoles();
            cbxRoles.ValueMember = "IdRol";
            cbxRoles.DisplayMember = "Nombre";
        }

        private void LimpiarControles()
        {
            textbIdUsuario.Text = string.Empty;
            textbUsuario.Text = string.Empty;
            textbPass.Text = string.Empty;
            textbIdEmpleado.Text = string.Empty;
            texbNombre.Text = string.Empty;
            textIdBuscar.Text = string.Empty;
            viewDatosUsuarios.DataSource = null;
            ControlUpdate(textbIdUsuario.Text);
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
        private void CargarDatos()
        {
            viewDatosUsuarios.DataSource = ReglasNegocio.verUsuarios();
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
                    texbNombre.Text = $"{emp.Nombre} {emp.Apellido}";
                    textbUsuario.Text = $"{emp.Nombre.ToLower()}.{emp.Apellido.ToLower()}";
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

        private void viewDatosUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textbIdUsuario.Text = viewDatosUsuarios.Rows[e.RowIndex].Cells["IdUsuario"].Value.ToString();
            textbIdEmpleado.Text = viewDatosUsuarios.Rows[e.RowIndex].Cells["IdEmpleado"].Value.ToString();
            textbUsuario.Text = viewDatosUsuarios.Rows[e.RowIndex].Cells["Usuario"].Value.ToString();
            textbPass.Text = viewDatosUsuarios.Rows[e.RowIndex].Cells["Contraseña"].Value.ToString();
            texbNombre.Text = $"{viewDatosUsuarios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString()} {viewDatosUsuarios.Rows[e.RowIndex].Cells["Apellido"].Value.ToString()}";
            cbxRoles.Text = viewDatosUsuarios.Rows[e.RowIndex].Cells["Rol"].Value.ToString();

            ControlUpdate(textbIdUsuario.Text);
        }

        private void ucUsuarios_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible)
            {
                LimpiarControles();
                CargarComponentes();
                CargarDatos();
            }
        }

        private void BuGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textbIdUsuario.Text))
                {
                    DataRow[] usuarioExiste = ReglasNegocio.verUsuarios().Select($"IdEmpleado = {textbIdEmpleado.Text}");

                    if (usuarioExiste.Length > 0)
                    {
                        LimpiarControles();
                        throw new ControlExcepciones("Este empleado ya tiene un usuario creado");
                    }


                    Usuario usuario = new Usuario();
                    usuario.IdEmpleado = Convert.ToInt32(textbIdEmpleado.Text);
                    usuario.IdRol = Convert.ToInt32(cbxRoles.SelectedValue);
                    usuario.Username = textbUsuario.Text;
                    usuario.Passwords = textbPass.Text;

                    var validacion = new UsuarioValidacion();
                    var resultado = validacion.Validate(usuario);

                    if (!resultado.IsValid)
                    {
                        string error = string.Join("\n",
                            resultado.Errors.Select(M => M.ErrorMessage));

                        throw new ControlExcepciones(error);
                    }

                    var mensaje = MessageBox.Show("Desea crear un usuario a este empleado?", "Registro de usuario",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (mensaje == DialogResult.Yes)
                    {
                        ReglasNegocio.RegistarUsuario(usuario);
                        MessageBox.Show("Usuario registrado con exito!", "Registro de usuario",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarControles();
                        CargarComponentes();
                        CargarDatos();
                    }
                }
                else
                {
                    Usuario usuario = new Usuario();
                    usuario.IdUsuario = Convert.ToInt32(textbIdUsuario.Text);
                    usuario.IdEmpleado = Convert.ToInt32(textbIdEmpleado.Text);
                    usuario.IdRol = Convert.ToInt32(cbxRoles.SelectedValue);
                    usuario.Username = textbUsuario.Text;
                    usuario.Passwords = textbPass.Text;

                    var validacion = new UsuarioValidacion();
                    var resultado = validacion.Validate(usuario);

                    if (!resultado.IsValid)
                    {
                        string error = string.Join("\n",
                            resultado.Errors.Select(M => M.ErrorMessage));

                        throw new ControlExcepciones(error);
                    }

                    var mensaje = MessageBox.Show("Desea actualizar los datos de este usuario?", "Actualización de usuario",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (mensaje == DialogResult.Yes)
                    {
                        ReglasNegocio.ActualizarUsuario(usuario);
                        MessageBox.Show("Datos del usuario actualizados con exito!", "Actualización de usuario",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarControles();
                        CargarComponentes();
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
