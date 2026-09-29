using ReservaRestaurantesParent.Forms;
using ReservaRestaurantesParent.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaRestaurantesParent
{
    public partial class RestauranteControl : UserControl
    {
        public string NomeRestaurante
        {
            get { return label1.Text; }
        }
        int id;
        Restaurantes r;
        public RestauranteControl()
        {
            InitializeComponent();
        }

        public void PreecherRestaurantes(Restaurantes restaurantes) 
        {
            label1.Text = restaurantes.Nome;

            //pictureBox1.Image = 
            label2.Text = restaurantes.Descricao;
            button1.BackColor = ColorTranslator.FromHtml("#D4A017");
            button1.ForeColor = ColorTranslator.FromHtml("White");
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Montserrat", 10f, FontStyle.Bold);

            var caminhoLong = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"..\\..\\Restaurantes\\{restaurantes.Nome}.jpg");
            var caminho = Path.GetFullPath(caminhoLong);

            pictureBox1.Image = Image.FromFile(caminho);
            id = restaurantes.ID;
            r = restaurantes;
        }

        private void RestauranteControl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrmNovaReserva(id).Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Click(object sender, EventArgs e)
        {
            new FrmDetalhesRestaurante(r).Show();
        }
    }
}
