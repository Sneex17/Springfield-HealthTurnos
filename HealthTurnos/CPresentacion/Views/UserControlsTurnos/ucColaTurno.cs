using CEntidades;
using CNegocio;
using CPresentacion.Plantillas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPresentacion.Views.UserControlsTurnos
{
    public partial class ucColaTurno : ucGestion
    {
        Usuario user = new Usuario();
        public ucColaTurno(Usuario usuario)
        {
            InitializeComponent();
            user = usuario;
            CargarDatos();
        }
        private void CargarDatos()
        {
            user.IdEmpleado = ReglasNegocio.IdAsistente(user.IdUsuario);
            viewDatosTurnos.DataSource = ReglasNegocio.ListaTurnoPaciente(user.IdEmpleado);
        }

        private void panelContainer_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible)
            {
                CargarDatos();
            }
        }
    }
}
