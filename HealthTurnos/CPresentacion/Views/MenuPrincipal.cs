using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPresentacion.Views.UserControls;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CPresentacion.Views
{
    public partial class MenuPrincipal : MaterialForm
    {
        
        public MenuPrincipal(int rol)
        {
            InitializeComponent();
            ControlDeRoles(rol);
            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.ColorScheme = new ColorScheme(
            //    Primary.Blue600,
            //    Primary.Blue700,
            //    Primary.Blue200,
            //    Accent.LightBlue200,
            //    TextShade.WHITE);
        }

        private void ControlDeRoles(int rol)
        {
            switch (rol)
            {
                case 1:
                    {
                        tabRegistrarTurno.Parent = null;
                        tabAtenderPacientes.Parent = null;
                        tabColaTurnos.Parent = null;

                    }
                    break;
                case 2:
                    {
                        tabRegistrarTurno.Parent = null;
                        tabPaciente.Parent = null;
                    }
                    break;
                case 3:
                    {
                        tabAtenderPacientes.Parent = null;
                    }
                    break;
                
                default:
                    break;
            }
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
                
            }

            if(materialTabControl1.SelectedTab == tabPaciente
                && tabPaciente.Controls.Count == 0)
            {
                AbrirFormularioEnTab(new fmPacientes(), tabPaciente);
            }

            if (materialTabControl1.SelectedTab == tabEmpleados
                && tabEmpleados.Controls.Count == 0)
            {
                ucEmpleados empleados = new ucEmpleados();
                empleados.Dock = DockStyle.Fill;
                tabEmpleados.Controls.Add(empleados);
            }

            if (materialTabControl1.SelectedTab == tabMedicos
                && tabMedicos.Controls.Count == 0)
            {
                ucMedicos medicos = new ucMedicos();
                medicos.Dock = DockStyle.Fill;
                tabMedicos.Controls.Add(medicos);
            }

            if (materialTabControl1.SelectedTab == tabAsistente
                && tabAsistente.Controls.Count == 0)
            {
                ucAsistentes asistentes = new ucAsistentes();
                asistentes.Dock = DockStyle.Fill;
                tabAsistente.Controls.Add(asistentes);
            }
        }
    }
}
