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
    public partial class fListado : Form
    {
        fAmerica america;
        fAsia asia;
        fEuropa europa;
        public fListado()
        {
            InitializeComponent();
            frPrincipal.listado = this;
            america = frPrincipal.america;
            asia = frPrincipal.asia;
            europa = frPrincipal.europa;
        }

        private void fListado_Activated(object sender, EventArgs e)
        {
            lbListado.Items.Clear();

            foreach (string pais in america.lbAmerica.SelectedItems)
            {
                lbListado.Items.Add(pais);
            }

            foreach (string pais in asia.lbAsia.SelectedItems)
            {
                lbListado.Items.Add(pais);
            }

            foreach (string pais in europa.lbEuropa.SelectedItems)
            {
                lbListado.Items.Add(pais);
                
            }
        }
    }
}
