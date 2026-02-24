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

        private void BuAcceder_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal(3);
            menu.Show();
            this.Hide();
        }
    }
}
