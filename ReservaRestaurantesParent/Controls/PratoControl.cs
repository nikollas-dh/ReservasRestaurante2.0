using ReservaRestaurantesParent.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaRestaurantesParent.Controls
{
    public partial class PratoControl : UserControl
    {
        public PratoControl()
        {
            InitializeComponent();
        }
        public void PreecherDados(Comidas comidas) 
        {
            label1.Text = comidas.Nome;
            label2.Text= comidas.
        }

        private void PratoControl_Load(object sender, EventArgs e)
        {

        }
    }
}
