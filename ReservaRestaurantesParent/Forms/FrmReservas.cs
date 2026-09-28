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
    public partial class FrmReservas : Parent
    {
        Restaurantes r;
        public FrmReservas(int id)
        {
            InitializeComponent();
            var res = ct.Restaurantes.Where(o=>o.ID == id).FirstOrDefault();
            r = res;
        }

        private void ReservasPage_Load(object sender, EventArgs e)
        {

            comboBox1.DisplayMember = "Nome";
            comboBox1.ValueMember = "ID";


            comboBox1.DataSource = ct.Restaurantes.ToList();
            comboBox1.SelectedItem = r;

            var caminhoLong = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"..\\..\\Restaurantes\\{r.Nome}.jpg");
            var caminho = Path.GetFullPath(caminhoLong);

            pictureBox2.Image = Image.FromFile(caminho);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reservas reserva = new Reservas();

            reserva.Data = dateTimePicker1.Value;
            reserva.QuantidadePessoas = (int?)numericUpDown1.Value;
            reserva.IdRestaurante = r.ID;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Restaurantes res)
            {
                var caminhoLong = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"..\\..\\Restaurantes\\{res.Nome}.jpg");
            var caminho = Path.GetFullPath(caminhoLong);

            pictureBox2.Image = Image.FromFile(caminho);
            }
        }
    }
}
