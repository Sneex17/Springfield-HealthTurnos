using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPresentacion.Plantillas;

namespace CPresentacion.Views.UserControlsTurnos
{
    public partial class ucRegistroTurno : ucGestion
    {
        public ucRegistroTurno()
        {
            InitializeComponent();
        }

        private void BuBuscarPaciente_Click(object sender, EventArgs e)
        {
            fmPacientes paciente = new fmPacientes();
            paciente.SeleccionarPaciente += (pacientes) =>
            {
                textbIdPaciente.Text = pacientes.id.ToString();
                textbNombrePaciente.Text = pacientes.name.ToString();
                textbSexoPaciente.Text = pacientes.gender.ToString();
            };
            paciente.ShowDialog();
        }
    }
}
