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

namespace CPresentacion.Views.UserControls
{
    public partial class ucHome : ucGestion
    {
        Usuario user = new Usuario();
        public ucHome(Usuario usuario)
        {
            InitializeComponent();
            user = usuario;
            CargarComponentes();
        }
        private void CargarComponentes()
        {
            lbUsername.Text = ReglasNegocio.Username(user.IdUsuario);
;        }
        private void BuCerrar_Click(object sender, EventArgs e)
        {
            Form menu = this.FindForm();
            if (menu != null)
            {
                menu.Hide();
            }
            Login login = new Login();
            login.Show();
        }
    }
}
