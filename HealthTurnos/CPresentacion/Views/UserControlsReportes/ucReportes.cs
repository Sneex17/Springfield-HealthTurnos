using CEntidades;
using CNegocio;
using CPresentacion.DataSets;
using CPresentacion.DataSets.DsTurnosAtendidosTableAdapters;
using CPresentacion.DataSets.DsTurnosCanceladosTableAdapters;
using CPresentacion.DataSets.DsTurnosRangoFechaTableAdapters;
using CPresentacion.Plantillas;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

                Ruta ruta = new Ruta("ReporteTurnosFecha.rdlc");
                reportViewerGeneral.LocalReport.ReportPath = ruta.GetRuta();

                DsTurnosRangoFecha dsTurnosRango = new DsTurnosRangoFecha();
                spVerReporteTurnosRangoFechaTableAdapter turnosFechas = new spVerReporteTurnosRangoFechaTableAdapter();
                turnosFechas.Fill(dsTurnosRango.spVerReporteTurnosRangoFecha, user.IdEmpleado, dateTimeFrom.Value.Date, dateTimeTo.Value.Date);

                ReportDataSource reporte = new ReportDataSource("DataSet1", dsTurnosRango.spVerReporteTurnosRangoFecha.DefaultView);

                reportViewerGeneral.LocalReport.DataSources.Clear();
                reportViewerGeneral.LocalReport.DataSources.Add(reporte);
                reportViewerGeneral.RefreshReport();

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

        private void BuRTurnosAtendidos_Click(object sender, EventArgs e)
        {
            Ruta ruta = new Ruta("ReporteTurnosAtendidos.rdlc");
            reportViewerGeneral.LocalReport.ReportPath = ruta.GetRuta();

            DsTurnosAtendidos dsTurnosAtendidos = new DsTurnosAtendidos();
            spVerReporteTurnosAtentidosTableAdapter turnosAtentidos = new spVerReporteTurnosAtentidosTableAdapter();
            turnosAtentidos.Fill(dsTurnosAtendidos.spVerReporteTurnosAtentidos, user.IdEmpleado);

            ReportDataSource reporte = new ReportDataSource("DataSet1", dsTurnosAtendidos.spVerReporteTurnosAtentidos.DefaultView);

            reportViewerGeneral.LocalReport.DataSources.Clear();
            reportViewerGeneral.LocalReport.DataSources.Add(reporte);
            reportViewerGeneral.RefreshReport();
        }

        private void BuRTurnosCancelados_Click(object sender, EventArgs e)
        {
            Ruta ruta = new Ruta("ReporteTurnosCancelados.rdlc");
            reportViewerGeneral.LocalReport.ReportPath = ruta.GetRuta();

            DsTurnosCancelados dsTurnosCancelados = new DsTurnosCancelados();
            spVerReporteTurnosCanceladosTableAdapter turnosCancelados = new spVerReporteTurnosCanceladosTableAdapter();
            turnosCancelados.Fill(dsTurnosCancelados.spVerReporteTurnosCancelados, user.IdEmpleado);

            ReportDataSource reporte = new ReportDataSource("DataSet1", dsTurnosCancelados.spVerReporteTurnosCancelados.DefaultView);

            reportViewerGeneral.LocalReport.DataSources.Clear();
            reportViewerGeneral.LocalReport.DataSources.Add(reporte);
            reportViewerGeneral.RefreshReport();
        }
    }
}
