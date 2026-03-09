using CEntidades;
using CNegocio;
using CPresentacion.DecoratorPattern;
using Microsoft.VisualBasic;
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
    public partial class fmPacientes : Form
    {
        public event Action<Character> SeleccionarPaciente;
        List<Character> lista = new List<Character>();
        public fmPacientes()
        {
            InitializeComponent();
            DecorarDatagrid();
            Cargar();
            CagarComponentes();
        }
        private void DecorarDatagrid()
        {
            IDataGridDecorator estilo = new BordeDecorator(
                            new SeleccionDecorator(
                            new FilasAlternasDecorator(
                            new HeaderDecorator(
                            new DataGridBase()))));
            estilo.Aplicar(viewDataPacientes);
        }
        private void CagarComponentes()
        {
            cbxOpciones.Items.Add("IdPaciente");
            cbxOpciones.Items.Add("Nombre");
            cbxOpciones.Items.Add("Sexo");
        }
        public async void Cargar()
        {
            lista = await ReglasNegocio.VerPacientes();
            DatosFiltros(lista);  
        }
        private void DatosFiltros(List<Character> lista)
        {
            viewDataPacientes.Rows.Clear();
            foreach (var lm in lista)
            {
                if (lm.status == "Alive")
                {
                    viewDataPacientes.Rows.Add(new object[]
                    {
                        Convert.ToString(lm.id), lm.name, lm.gender,
                        Convert.ToString(lm.age), lm.birthdate, lm.occupation, lm.status
                    });
                }
            }
        }
        private void textbFiltro_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textbFiltro.Text))
            {
                DatosFiltros(lista);
                return; 
            }

            switch (cbxOpciones.Text)
            {
                case "IdPaciente":
                    if (int.TryParse(textbFiltro.Text, out int idBuscado))
                    {
                        var resultado = lista.Where(L => L.id == idBuscado).ToList();
                        DatosFiltros(resultado);
                    }
                    break;

                case "Nombre":
                    var porNombre = lista.Where(L =>
                        L.name.ToLower().Contains(textbFiltro.Text.ToLower())).ToList();
                    DatosFiltros(porNombre);
                    break;

                case "Sexo":
                    var porSexo = lista.Where(L =>
                        L.gender.ToLower().Contains(textbFiltro.Text.ToLower())).ToList();
                    DatosFiltros(porSexo);
                    break;
            }
        }

        private void viewDataPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Character pacientes = new Character()
                {
                    id = Convert.ToInt32(viewDataPacientes.Rows[e.RowIndex].Cells["Id"].Value.ToString()),
                    name = viewDataPacientes.Rows[e.RowIndex].Cells["Name"].Value.ToString(),
                    gender = viewDataPacientes.Rows[e.RowIndex].Cells["Gender"].Value.ToString()
                };
                SeleccionarPaciente?.Invoke(pacientes);
                this.Close();
            }
        }
    }
}
