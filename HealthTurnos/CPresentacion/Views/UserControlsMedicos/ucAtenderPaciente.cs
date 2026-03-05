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
using CNegocio;
using CPresentacion.Plantillas;

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
    }
}
