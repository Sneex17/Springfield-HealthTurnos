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
            lbCountEmpleados.Text = ReglasNegocio.verEmpleados().Count.ToString();
            lbCountUsuarios.Text = ReglasNegocio.verUsuarios().Rows.Count.ToString();

            var lista = ReglasNegocio.TotalTurnos();
            lbCountTurnos.Text = lista.Rows.Count.ToString();

            lbCountTurnosPendientes.Text = lista.Select($"IdEstado = {1}").Length.ToString();
            lbCountTurnosEnAtencion.Text = lista.Select($"IdEstado = {2}").Length.ToString();
            lbCountTurnosAtendidos.Text = lista.Select($"IdEstado = {3}").Length.ToString();
            lbCountTurnosCancelados.Text = lista.Select($"IdEstado = {4}").Length.ToString();


            lbCountTurnosNormales.Text = lista.Select($"IdPrioridad = {1}").Length.ToString();
            lbCountTurnosPrioritarios.Text = lista.Select($"IdPrioridad = {2}").Length.ToString();
            lbCountTurnosEmergencia.Text = lista.Select($"IdPrioridad = {3}").Length.ToString();


        }
    }
}
