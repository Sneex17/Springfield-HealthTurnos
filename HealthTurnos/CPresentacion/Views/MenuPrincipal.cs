using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CPresentacion.Views
{
    public partial class MenuPrincipal : MaterialForm
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.ColorScheme = new ColorScheme(
            //    Primary.Blue600,
            //    Primary.Blue700,
            //    Primary.Blue200,
            //    Accent.LightBlue200,
            //    TextShade.WHITE);
        }

        private void AbrirFormularioEnTab(Form formulario, TabPage tabPage)
        {
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            tabPage.Controls.Clear();
            tabPage.Controls.Add(formulario);

            formulario.Show();
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedTab == tabRegistrarTurno
                && tabRegistrarTurno.Controls.Count == 0)
            {
                AbrirFormularioEnTab(new FrmClientes(), tabRegistrarTurno);
                
            }

            if(materialTabControl1.SelectedTab == tabPaciente
                && tabPaciente.Controls.Count == 0)
            {
                UserControl1 userControl1 = new UserControl1();
                userControl1.Dock = DockStyle.Fill;
                tabPaciente.Controls.Add(userControl1);
            }
        }
    }
}
