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
using WMPLib;

namespace ReservaRestaurantesParent
{
    public partial class Home : Parent
    {
        WindowsMediaPlayer audio = new WindowsMediaPlayer();
        public Home(Pessoas us)
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            var caminhoLong = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Musica\musica.mp3");
            var caminho = Path.GetFullPath(caminhoLong);

            audio.URL = caminho;
            audio.settings.setMode("loop", true);
            audio.controls.play();
            foreach (var r in ct.Restaurantes.ToList()) 
            {
                var card = new RestauranteControl();
                card.PreecherRestaurantes(r);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = textBox1.Text.Trim().ToLower();

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is RestauranteControl card)
                {
                    bool encontrou = card.NomeRestaurante
                        .ToLower()
                        .Contains(pesquisa);

                    card.Visible = encontrou;
                }
            }
        }
    }
}
