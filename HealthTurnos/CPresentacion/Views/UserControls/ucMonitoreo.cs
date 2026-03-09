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
    public partial class ucMonitoreo : ucGestion
    {
        Usuario user = new Usuario();
        public ucMonitoreo(Usuario usuario)
        {
            InitializeComponent();
            user = usuario;
            CargarDatos();
        }

        private void CargarDatos()
        {
            var lista = ReglasNegocio.TotalTurnos();
            lbCountTurnos.Text = lista.Rows.Count.ToString();


            int pendientes = lista.Select("IdEstado = 1").Length;
            int enAtencion = lista.Select("IdEstado = 2").Length;
            int atendidos = lista.Select("IdEstado = 3").Length;
            int cancelados = lista.Select("IdEstado = 4").Length;
            int normales = lista.Select("IdPrioridad = 1").Length;
            int prioritarios = lista.Select("IdPrioridad = 2").Length;
            int emergencia = lista.Select("IdPrioridad = 3").Length;

            // Labels
            lbCountEmpleados.Text = ReglasNegocio.verEmpleados().Count.ToString();
            lbCountUsuarios.Text = ReglasNegocio.verUsuarios().Rows.Count.ToString();
            lbCountTurnos.Text = lista.Rows.Count.ToString();
            lbCountTurnosPendientes.Text = pendientes.ToString();
            lbCountTurnosEnAtencion.Text = enAtencion.ToString();
            lbCountTurnosAtendidos.Text = atendidos.ToString();
            lbCountTurnosCancelados.Text = cancelados.ToString();
            lbCountTurnosNormales.Text = normales.ToString();
            lbCountTurnosPrioritarios.Text = prioritarios.ToString();
            lbCountTurnosEmergencia.Text = emergencia.ToString();

            // Gráfica — pasar int, no string
            GraficaTurnos.Series[0].Points.AddXY($"Pendientes {pendientes}", pendientes);
            GraficaTurnos.Series[0].Points.AddXY($"En Atención {enAtencion}", enAtencion);
            GraficaTurnos.Series[0].Points.AddXY($"Atendidos {atendidos}", atendidos);
            GraficaTurnos.Series[0].Points.AddXY($"Cancelados {cancelados}", cancelados);
        }
    }
}
