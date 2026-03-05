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
    }
}
