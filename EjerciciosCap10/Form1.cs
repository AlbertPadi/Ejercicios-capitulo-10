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
    public partial class FormEjercap10 : Form
    {
        public FormEjercap10()
        {
            InitializeComponent();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventarioTienda it = new InventarioTienda();
            it.Show();
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estudiantes es = new Estudiantes();
            es.Show();
        }
    }
}
