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
        fListado listado;
        public fListado()
        {
            InitializeComponent();
            frPrincipal.listado = this;
        }

        private void fListado_Activated(object sender, EventArgs e)
        {
            lbListado.Items.Clear();

            foreach (Form v in Application.OpenForms)
            {
                if (v.Text == "Europa")
                {
                    foreach (string pais in frPrincipal.europa.lbEuropa.SelectedItems)
                    {
                        lbListado.Items.Add(pais);

                    }
                    break;
                }
            }

            foreach (Form v in Application.OpenForms)
            {
                if (v.Text == "Asia")
                {
                    foreach (string pais in frPrincipal.asia.lbAsia.SelectedItems)
                    {
                        lbListado.Items.Add(pais);
                    }
                    break;
                }
            }

            foreach (Form v in Application.OpenForms)
            {
                if (v.Text == "America")
                {
                    foreach (string pais in frPrincipal.america.lbAmerica.SelectedItems)
                    {
                        lbListado.Items.Add(pais);
                    }
                    break;
                }
            }
        }
    }
}
