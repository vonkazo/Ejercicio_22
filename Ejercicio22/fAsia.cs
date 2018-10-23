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
    public partial class fAsia : Form
    {
        public fAsia()
        {
            InitializeComponent();

            frPrincipal.asia = this;

            lbAsia.Items.Add("China");
            lbAsia.Items.Add("Armenia");
            lbAsia.Items.Add("Camboya");
            lbAsia.Items.Add("Chipre");
            lbAsia.Items.Add("Corea del Norte");
            lbAsia.Items.Add("Filipinas");
            lbAsia.Items.Add("Georgia");
            lbAsia.Items.Add("Japón");
        }
    }
}
