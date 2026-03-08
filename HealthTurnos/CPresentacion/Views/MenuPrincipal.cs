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
using CPresentacion.Views.UserControls;
using CPresentacion.Views.UserControlsMedicos;
using CPresentacion.Views.UserControlsReportes;
using CPresentacion.Views.UserControlsTurnos;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CPresentacion.Views
{
    public partial class MenuPrincipal : MaterialForm
    {
        
        Usuario user = new Usuario();
        
        public MenuPrincipal(Usuario usuario)
        {
            InitializeComponent();
            user = usuario;
            user.IdEmpleado = ReglasNegocio.IdAsistente(user.IdUsuario);
            ControlDeRoles(user.IdRol);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Color.FromArgb(0x4F, 0x52, 0xBA),  // Primary       #4F52BA
                Color.FromArgb(0x3D, 0x3D, 0x8F),  // Dark Primary  #3D3D8F
                Color.FromArgb(0xF4, 0xF6, 0xFB),  // Light Primary #F4F6FB
                Color.FromArgb(0x42, 0xA5, 0xF5),  // Accent        #42A5F5
                TextShade.WHITE
            );
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
                        tabEmpleados.Parent = null;
                        tabMedicos.Parent = null;
                        tabAsistente.Parent = null;
                        tabEspecialidades.Parent = null;
                        tabRoles.Parent = null;
                        tabUsuarios.Parent = null;

                    }
                    break;
                case 3:
                    {
                        tabAtenderPacientes.Parent = null;
                        tabEmpleados.Parent = null;
                        tabMedicos.Parent = null;
                        tabAsistente.Parent = null;
                        tabEspecialidades.Parent = null;
                        tabRoles.Parent = null;
                        tabUsuarios.Parent = null;
                        
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
            if (materialTabControl1.SelectedTab == tabReportes
                && tabReportes.Controls.Count == 0)
            {
                ucReportes reportes = new ucReportes(user);
                reportes.Dock = DockStyle.Fill;
                tabReportes.Controls.Add(reportes);
            }

            if (materialTabControl1.SelectedTab == tabPaciente
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

            if (materialTabControl1.SelectedTab == tabEspecialidades
                && tabEspecialidades.Controls.Count == 0)
            {
                ucEspecialidades especialidades = new ucEspecialidades();
                especialidades.Dock = DockStyle.Fill;
                tabEspecialidades.Controls.Add(especialidades);
            }

            if (materialTabControl1.SelectedTab == tabRoles
                && tabRoles.Controls.Count == 0)
            {
                ucRoles roles = new ucRoles();
                roles.Dock = DockStyle.Fill;
                tabRoles.Controls.Add(roles);
            }

            if (materialTabControl1.SelectedTab == tabUsuarios
                && tabUsuarios.Controls.Count == 0)
            {
                ucUsuarios usuarios = new ucUsuarios();
                usuarios.Dock = DockStyle.Fill;
                tabUsuarios.Controls.Add(usuarios);
            }

            if (materialTabControl1.SelectedTab == tabRegistrarTurno
                && tabRegistrarTurno.Controls.Count == 0)
            {
                ucRegistroTurno turno = new ucRegistroTurno(user);
                turno.Dock = DockStyle.Fill;
                tabRegistrarTurno.Controls.Add(turno);
            }

            if (materialTabControl1.SelectedTab == tabColaTurnos
                && tabColaTurnos.Controls.Count == 0)
            {
                ucColaTurno colaTurno = new ucColaTurno(user);
                colaTurno.Dock = DockStyle.Fill;
                tabColaTurnos.Controls.Add(colaTurno);
            }

            if (materialTabControl1.SelectedTab == tabAtenderPacientes
                && tabAtenderPacientes.Controls.Count == 0)
            {
                ucAtenderPaciente atenderPaciente = new ucAtenderPaciente(user);
                atenderPaciente.Dock = DockStyle.Fill;
                tabAtenderPacientes.Controls.Add(atenderPaciente);
            }

        }

        private void BuCerrar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
