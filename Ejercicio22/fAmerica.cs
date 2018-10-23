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
    public partial class fAmerica : Form
    {
        public fAmerica()
        {
            InitializeComponent();

            frPrincipal.america = this;

            lbAmerica.Items.Add("Argentina");
            lbAmerica.Items.Add("Bahamas");
            lbAmerica.Items.Add("Barbados");
            lbAmerica.Items.Add("Bolivia");
            lbAmerica.Items.Add("Brasil");
            lbAmerica.Items.Add("Chile");
            lbAmerica.Items.Add("Cuba");
            lbAmerica.Items.Add("Dominica");
        }

        private void fAmerica_Activated(object sender, EventArgs e)
        {

        }
    }
}
