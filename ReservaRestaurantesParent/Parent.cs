using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaRestaurantesParent
{
    public partial class Parent : Form
    {
        public dbReservaRestauranteEntities ct = new dbReservaRestauranteEntities();
        public Parent()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            panel1.BackColor = ColorTranslator.FromHtml("White");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void EstilizarTela(Control control)
        {
            foreach (Control child in control.Controls) 
            {
                if (child is LinkLabel link)
                {
                    link.LinkColor = ColorTranslator.FromHtml("#D4A017");
                    link.Font = new Font("Montserrat", 12f, FontStyle.Bold);
                }
                else if (child is System.Windows.Forms.Label label) 
                { 
                    if (label.AccessibleName == "") 
                    {
                        label.Font = new Font("OpenSans", 10f, FontStyle.Regular);
                    }
                    if (label.AccessibleName == "credencial") 
                    {
                        label.Font = new Font("OpenSans", 10f, FontStyle.Bold);
                    }
                    if(label.AccessibleName == "titulo") 
                    {
                        label.Font = new Font("Montserrat", 20f, FontStyle.Bold);

                    }
                }


                if(child is Button btn) 
                {
                    btn.BackColor = ColorTranslator.FromHtml("#D4A017");
                    btn.ForeColor = ColorTranslator.FromHtml("White");
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Font = new Font("Montserrat", 10f, FontStyle.Bold);

                    if (btn.AccessibleName == "e") 
                    {
                        btn.BackColor = ColorTranslator.FromHtml("#C75D4D");

                    }

                }

                if(child is TextBox txt)
                {

                    txt.Font = new Font("OpenSans", 12f, FontStyle.Regular);
                    txt.BorderStyle = BorderStyle.FixedSingle;
                }
                if (child.HasChildren) 
                {
                    EstilizarTela(child);
                }
            }
        }

        private void Parent_Load(object sender, EventArgs e)
        {
            EstilizarTela(panel1);
        }
    }
}
