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
    public partial class ucMedicos : ucGestion
    {
        public ucMedicos()
        {
            InitializeComponent();
            DatosEspecialidad();
            CargarComponentes();
        }

        private void DatosEspecialidad()
        {
            var lista = ReglasNegocio.VerEspecialidades();
            cbxEspecialidad.DataSource = lista;
            cbxEspecialidad.ValueMember = "IdEspecialidad";
            cbxEspecialidad.DisplayMember = "Nombre";
        }

        private void CargarComponentes()
        {
            viewDatosMedicos.DataSource = null;
            viewDatosMedicos.DataSource = ReglasNegocio.verMedicos();
        }

        private void viewDatosMedicos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textbIdEmpleado.Text = viewDatosMedicos.Rows[e.RowIndex].Cells["IdEmpleado"].Value.ToString();
            textbNombre.Text = viewDatosMedicos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            textbApellido.Text = viewDatosMedicos.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
            textbEmail.Text = viewDatosMedicos.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            texbTelefono.Text = viewDatosMedicos.Rows[e.RowIndex].Cells["NroLicencia"].Value.ToString();
            cbxEspecialidad.Text = viewDatosMedicos.Rows[e.RowIndex].Cells["Especialidad"].Value.ToString();

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

        private void BuBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(textIdBuscar.Text))
                {
                    throw new ControlExcepciones("Debe de ingresar un id para buscar");
                }
                int id = Convert.ToInt32(textIdBuscar.Text);
                var lista = ReglasNegocio.verEmpleados();
                var dato = from L in lista.Where(L => L.IdEmpleado == id) select L;

                if(dato == null)
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

        }
    }
}
