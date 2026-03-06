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

namespace CPresentacion.Views.UserControlsReportes
{
    public partial class ucReportes : ucGestion
    {
        Usuario user = new Usuario();
        public ucReportes(Usuario usuario)
        {
            InitializeComponent();
            user = usuario;
        }
        private void ControlPanelFechas()
        {
            if(panelRangoFecha.Visible == false)
            {
                panelRangoFecha.Visible = true;
            }
            else
            {
                panelRangoFecha.Visible = false;
            }
        }
        private void BuReportesFechas_Click(object sender, EventArgs e)
        {
            ControlPanelFechas();
        }

        private void BuAplicarReportes_Click(object sender, EventArgs e)
        {
            try
            {
                if ((dateTimeFrom.Value.Date > dateTimeTo.Value.Date) 
                    || (dateTimeFrom.Value.Date == dateTimeTo.Value.Date))
                {
                    string mensaje = $"La fecha de inicio debe ser menor a la fehca de fin\n" +
                        $"Fecha ingresadas:\nInicio: {dateTimeFrom.Value}\nFin: {dateTimeTo.Value}";
                    throw new ControlExcepciones(mensaje);
                }
                

            }
            catch (ControlExcepciones error)
            {
                MessageBox.Show($"{error.Message}", "Error en el reporte",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show($"{error.Message}", "Error en el reporte",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
