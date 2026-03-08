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
using CPresentacion.Plantillas;

namespace CPresentacion.Views.UserControls
{
    public partial class ucMonitoreo : ucGestion
    {
        Usuario user = new Usuario();
        public ucMonitoreo(Usuario usuario)
        {
            InitializeComponent();
            user = usuario;
        }
    }
}
