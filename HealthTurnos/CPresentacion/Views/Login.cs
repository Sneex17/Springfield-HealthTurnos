using CEntidades;
using CNegocio;
using CPresentacion.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Load += (s, e) => CargarComponentes();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void CargarComponentes()
        {
            textbPassword.UseSystemPasswordChar = true;
        }
        private void BuVerPass_Click(object sender, EventArgs e)
        {
            if(BuVerPass.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                BuVerPass.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                textbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                BuVerPass.IconChar = FontAwesome.Sharp.IconChar.Eye;
                textbPassword.UseSystemPasswordChar = true;
            }
        }

        private void BuIngresar_Click(object sender, EventArgs e)
        {
            if(CheckSoyPaciente.Checked == true)
            {
                fmMenuPaciente menuPaciente = new fmMenuPaciente();
                menuPaciente.Show();
                this.Hide();
            }
            else
            {
                var usuario = new Usuario()
                {
                    Username = textbUsuario.Text,
                    Passwords = textbPassword.Text
                };

                int resultado = ReglasNegocio.UsuarioExiste(usuario);

                if (resultado != 0)
                {
                    int rol = ReglasNegocio.RolUsuario(resultado);

                    if (rol != 0)
                    {
                        usuario.IdUsuario = resultado;
                        usuario.IdRol = rol;

                        MenuPrincipal menu = new MenuPrincipal(usuario);
                        menu.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrectas", "Usuario no valido",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }  
        }

        private void CheckSoyPaciente_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckSoyPaciente.Checked == true)
            {
                textbUsuario.Enabled = false;
                textbPassword.Enabled = false;
            }
            else
            {
                textbUsuario.Enabled = true;
                textbPassword.Enabled = true;
            }
        }
    }
}
