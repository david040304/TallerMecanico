using Datos.Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Entidades;
using Logica;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        TrabajadorModels models = new TrabajadorModels();
        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            models.Cedula = txtCedulaTrabajdor.Text;
            models.Nombre = txtTrabajadorNombre.Text;
            models.FechaNacimiento = Convert.ToString(dateTimePicker2.Value);
            models.Marca = txtCocheMarca.Text;
            models.FechaReparacion = Convert.ToString(dateTimePicker1.Value);
        }
    }
}
