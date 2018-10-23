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
    public partial class fEuropa : Form
    {
        public fEuropa()
        {
            InitializeComponent();

            frPrincipal.europa = this;

            lbEuropa.Items.Add("España");
            lbEuropa.Items.Add("Austria");
            lbEuropa.Items.Add("Alemania");
            lbEuropa.Items.Add("Finlandia");
            lbEuropa.Items.Add("Eslovenia");
            lbEuropa.Items.Add("Hungría");
            lbEuropa.Items.Add("Hungría");
            lbEuropa.Items.Add("Portugal");
        }
    }
}
