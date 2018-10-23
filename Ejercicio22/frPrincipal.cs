using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio22
{
    public partial class frPrincipal : Form
    {
        public static fAmerica america;
        public static fAsia asia;
        public static fEuropa europa;
        public static fListado listado;

        public frPrincipal()
        {
            InitializeComponent();
        }
        bool pasa = false;
        private void americaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirAmerica();
        }

        private void asiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirEuropa();
        }

        private void europaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirAsia();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirListado();
        }

        private void horizontakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            abrirAmerica();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            abrirAsia();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            abrirEuropa();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            abrirListado();
        }

        public void abrirListado()
        {
            foreach (Form v in Application.OpenForms)
            {
                if (v.Text == "Listado")
                {
                    pasa = true;
                    break;
                }
            }

            if (!pasa)
            {
                // Se abre la ventana hija empleados
                // Instanciamos la ventana
                listado = new fListado();
                // Indicamos de que form hereda
                listado.MdiParent = this;
                // La mostramos
                listado.Show();
                toolStripStatusLabel1.Text = "Listado";
            }
            else
            {
                pasa = false;
            }
        }

        public void abrirEuropa()
        {
            foreach (Form v in Application.OpenForms)
            {
                if (v.Text == "Europa")
                {
                    pasa = true;
                    break;
                }
            }

            if (!pasa)
            {
                // Se abre la ventana hija empleados
                // Instanciamos la ventana
                europa = new fEuropa();
                // Indicamos de que form hereda
                europa.MdiParent = this;
                // La mostramos
                europa.Show();
                toolStripStatusLabel1.Text = "Europa";
            }
            else
            {
                pasa = false;
            }
        }

        public void abrirAsia()
        {
            foreach (Form v in Application.OpenForms)
            {
                if (v.Text == "Asia")
                {
                    pasa = true;
                    break;
                }
            }

            if (!pasa)
            {
                // Se abre la ventana hija empleados
                // Instanciamos la ventana
                asia = new fAsia();
                // Indicamos de que form hereda
                asia.MdiParent = this;
                // La mostramos
                asia.Show();
                toolStripStatusLabel1.Text = "Asia";
            }
            else
            {
                pasa = false;
            }
        }

        public void abrirAmerica()
        {
            foreach (Form v in Application.OpenForms)
            {
                if (v.Text == "America")
                {
                    pasa = true;
                    break;
                }
            }

            if (!pasa)
            {
                // Se abre la ventana hija empleados
                // Instanciamos la ventana
                america = new fAmerica();
                // Indicamos de que form hereda
                america.MdiParent = this;
                // La mostramos
                america.Show();
                toolStripStatusLabel1.Text = "America";
            }
            else
            {
                pasa = false;
            }
        }
    }
}
