using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosCap10
{
    public partial class Estudiantes : Form
    {
        EstudiantesEscuela ee = new EstudiantesEscuela();
        public Estudiantes()
        {
            InitializeComponent();
            
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            ee.Nombre = textBoxNombre.Text;
            ee.Apellido = textBoxApellido.Text;
            ee.Edad = Convert.ToInt32(textBoxEdad.Text);
            ee.Curso = Convert.ToInt32(textBoxCurso.Text);

            listBoxDatos.Items.Add(textBoxNombre.Text);
            listBoxDatos.Items.Add(textBoxApellido.Text);
            listBoxDatos.Items.Add(textBoxEdad.Text);
            listBoxDatos.Items.Add(textBoxCurso.Text);

            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxEdad.Clear();
            textBoxCurso.Clear();
        }
    }
}
