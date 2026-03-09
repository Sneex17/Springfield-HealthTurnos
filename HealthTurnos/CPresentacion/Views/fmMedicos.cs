using CEntidades;
using CNegocio;
using CPresentacion.DecoratorPattern;
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
    public partial class fmMedicos : Form
    {
        public event Action<Medico> SeleccionarMedico;
        public fmMedicos()
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
            estilo.Aplicar(viewDataMedico);
        }
        private void CargarDatos()
        {
            viewDataMedico.DataSource = ReglasNegocio.verMedicos();
            cbxOpciones.Items.Add("IdEmpleado");
            cbxOpciones.Items.Add("Nombre");
            cbxOpciones.Items.Add("Apellido");
            cbxOpciones.Items.Add("Especialidad");
        }

        private void viewDataPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Medico medico = new Medico()
            {
                IdEmpleado = Convert.ToInt32(viewDataMedico.Rows[e.RowIndex].Cells["IdEmpleado"].Value),
                Nombre = $"{viewDataMedico.Rows[e.RowIndex].Cells["Nombre"].Value.ToString()} {viewDataMedico.Rows[e.RowIndex].Cells["Apellido"].Value.ToString()}",
                
            };
            SeleccionarMedico?.Invoke(medico);
            this.Close();
        }
        private void CargarFiltro(string campo)
        {
            if (string.IsNullOrWhiteSpace(textbFiltro.Text))
            {
                viewDataMedico.DataSource = ReglasNegocio.verMedicos();
            }
            else
            {
                string filtro;

                // Si el campo es numérico (ID)
                if (campo == "IdEmpleado")
                {
                    filtro = $"{campo} = {textbFiltro.Text}";
                }
                else // Si es texto (Nombre, Apellido, Especialidad)
                {
                    filtro = $"{campo} LIKE '%{textbFiltro.Text}%'";
                }

                DataTable dt = ReglasNegocio.verMedicos();
                DataRow[] filas = dt.Select(filtro);

                // Convertir resultado a DataTable para asignarlo al DataSource
                viewDataMedico.DataSource = filas.Length > 0
                    ? filas.CopyToDataTable()
                    : dt.Clone(); // tabla vacía si no hay resultados
            }

        }
        private void textbFiltro_TextChanged(object sender, EventArgs e)
        {

            string opcion = cbxOpciones.Text;

            if (opcion == "IdEmpleado" || opcion == "Nombre" ||
                opcion == "Apellido" || opcion == "Especialidad")
            {
                CargarFiltro(opcion);
            }
        }
    }
}
