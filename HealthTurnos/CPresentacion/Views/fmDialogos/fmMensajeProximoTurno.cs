using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPresentacion.Views.fmDialogos
{
    public partial class fmMensajeProximoTurno : Form
    {
        public fmMensajeProximoTurno()
        {
            InitializeComponent();
            ContadorProximoTurno();
        }

        private async void ContadorProximoTurno()
        {
            int count = 3;
            lbCount.Text = count.ToString();

            for (int i = 0; i < count; i++)
            {
                await Task.Delay(1000);
                count--;
                lbCount.Text = count.ToString();
            }
            this.Close();
        }
    }
}
