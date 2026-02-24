using CEntidades;
using CNegocio;
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
        public fmPacientes()
        {
            InitializeComponent();
            Cargar();

        }
        public async void Cargar()
        {
            var lista = await ReglasNegocio.VerPacientes();
            foreach (var lm in lista)
            {
                if(lm.status == "Alive")
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                        Convert.ToString(lm.id), lm.name, lm.gender,
                        Convert.ToString(lm.age), lm.birthdate, lm.occupation, lm.status
                    });
                }
            }
        }
    }
}
