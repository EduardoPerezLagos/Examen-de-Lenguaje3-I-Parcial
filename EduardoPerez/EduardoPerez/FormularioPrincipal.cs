using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduardoPerez
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void formularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 formulario1=new Form1();
            formulario1.Show();
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio2 formulario2= new Ejercicio2();
            formulario2.Show();
        }

        private void formulario3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio3 formulario3= new Ejercicio3();
            formulario3.Show();
        }
    }
}
