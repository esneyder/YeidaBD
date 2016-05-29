using DemoYeidaBD.Logica;
using DemoYeidaBD.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YeiBD;

namespace DemoYeidaBD
{
    public partial class FormPersona : Form
    {
        FillGrid gridpersona = new FillGrid(Conexion.Conexion.server, Conexion.Conexion.database, Conexion.Conexion.username, Conexion.Conexion.pass, false);
        Persona persona = new Persona();
        LogicaNegocio logica = new LogicaNegocio();
        public FormPersona()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormPersona_Load(object sender, EventArgs e)
        {
            ListadoPersonas();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            persona.Nombre = tbNombre.Text;
            persona.Apellido = tbApellido.Text;
            persona.Apodo = tbApodo.Text;

            if (logica.NuevaPersona(persona)) {
                ListadoPersonas();
                LimpiarCajas();
                MessageBox.Show(logica.Mensaje, "Mensaje");
            }
          



        }

        private void ListadoPersonas() {
            gridpersona.SQL = "select * from Persona";
            gridpersona.FillGridWD(DGVPersona);
        }

        private void LimpiarCajas() {

            tbNombre.Text = "";
            tbApellido.Text = "";
            tbApodo.Text = "";
        }
    }
}
