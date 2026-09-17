using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaRestaurantesParent
{
    public partial class Cadastro : Parent
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {




            Pessoas us = new Pessoas();

            us.Nome = textBox1.Text;
            us.Telefone= textBox2.Text;
            us.Email=textBox3.Text;
            new Home().Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Seja bem-vindo ao LyonCooking Reserve! Antes de utilizar nosso sistema de reservas de restaurantes, pedimos que leia atentamente os seguintes Termos de Uso. Ao utilizar o sistema, você concorda com os termos aqui estabelecidos. Caso não concorde, recomendamos que não utilize o sistema.\r\n\r\n1. Aceitação dos Termos\r\nAo acessar ou utilizar o sistema LyonCooking Reserve, você aceita e concorda em cumprir estes Termos de Uso. Estes termos poderão ser atualizados periodicamente, e é sua responsabilidade verificá-los regularmente.\r\n\r\n2. Cadastro e Informações do Usuário\r\nPara utilizar o sistema e realizar reservas, pode ser necessário fornecer informações pessoais, como nome, e-mail e número de telefone. Você concorda em fornecer informações verdadeiras, precisas e completas, e em mantê-las atualizadas.\r\n\r\n3. Funcionamento do Sistema\r\nO LyonCooking Reserve permite que você pesquise e faça reservas em restaurantes. As informações sobre disponibilidade, horários e preços são fornecidas pelos próprios restaurantes e podem estar sujeitas a alterações. O sistema não se responsabiliza por eventuais divergências ou alterações feitas diretamente pelos restaurantes.\r\n\r\n4. Responsabilidades do Usuário\r\nAo utilizar o LyonCooking Reserve, você concorda em:\r\n\r\nUtilizar o sistema apenas para fins pessoais e lícitos.\r\nNão utilizar o sistema para atividades fraudulentas ou ilegais.\r\nRespeitar as políticas de cada restaurante, incluindo horários de funcionamento e normas de reserva.\r\n5. Cancelamento de Reservas\r\nCada restaurante tem sua própria política de cancelamento. Recomendamos que você entre em contato diretamente com o restaurante para confirmar as condições de cancelamento de sua reserva.\r\n\r\n6. Privacidade\r\nO LyonCooking Reserve respeita sua privacidade e se compromete a proteger seus dados pessoais. Todas as informações fornecidas são tratadas de acordo com a nossa Política de Privacidade, que você pode acessar [aqui].\r\n\r\n7. Limitação de Responsabilidade\r\nO LyonCooking Reserve é uma plataforma intermediária entre os usuários e os restaurantes. Não nos responsabilizamos por cancelamentos, indisponibilidades, erros nas informações fornecidas pelos restaurantes ou quaisquer outros problemas relacionados à reserva ou ao serviço prestado pelos estabelecimentos.\r\n\r\n8. Modificações no Sistema\r\nReservamos o direito de modificar, suspender ou descontinuar, temporária ou permanentemente, o sistema LyonCooking Reserve, com ou sem aviso prévio.\r\n\r\n9. Propriedade Intelectual\r\nTodo o conteúdo disponibilizado no LyonCooking Reserve, incluindo logotipos, textos, imagens e design, é protegido por direitos autorais. É proibido copiar, distribuir ou utilizar qualquer material sem autorização prévia.\r\n\r\n10. Contato\r\nSe tiver dúvidas ou precisar de assistência, entre em contato conosco pelo e-mail:lyoncookingreserve@mail.com");
        }
    }
}
