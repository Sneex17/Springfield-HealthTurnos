using CNegocio;
using CPresentacion.DecoratorPattern;
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
    public partial class fmVerColaTurnos : MaterialForm
    {
        public fmVerColaTurnos()
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
            estilo.Aplicar(viewColaTurnos);
        }

        private void CargarDatos()
        {
            viewColaTurnos.DataSource = ReglasNegocio.ListaTurnoPaciente(9);
        }
        private void BuSalir_Click(object sender, EventArgs e)
        {
            fmInicioPaciente inicioPaciente = new fmInicioPaciente();
            inicioPaciente.Show();
            this.Hide();
        }
    }
}
