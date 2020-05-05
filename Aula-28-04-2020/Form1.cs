using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_28_04_2020
{
    public partial class FrmPredictor : Form
    {
        public FrmPredictor()
        {
            InitializeComponent();
        }

        private void FrmPredictor_Load(object sender, EventArgs e)
        {
            // Funções executadas quando o formulário é carregado

            // chamando a função que formata o DateTimePicker
            SetDiaMesData();            

            // Tornando visível o pnlNome
            pnlNome.Visible = true;
            // Ativando esse painel
            pnlNome.Enabled = true;

            // Escondendo os outros dois Panels
            pnlNumSorte.Visible = false;
            pnlHoroscopo.Visible = false;
        }

        // formata o uso do DateTimePicker 
        public void SetDiaMesData()
        {
            // determina que o dtpNiver terá um formato customizado
            dtpNiver.Format = DateTimePickerFormat.Custom;

            // infoma qual é esse formato customizado
            dtpNiver.CustomFormat = "dd/MM";

            // Bloqueia selecionar a data manualmente, obrigando a digitação
            dtpNiver.ShowUpDown = true;
        }
        
        // gera o valor dos 6 números para a pessoa
        private static String GenMega() 
        {
            // definindo 6 variáveis int
            int dz1, dz2, dz3, dz4, dz5, dz6;

            // definindo variável pra receber o texto dos 6 números
            String megaNums = "";

            dz1 = GetRandom(01, 60);
            dz2 = GetRandom(01, 60);
            dz3 = GetRandom(01, 60);
            dz4 = GetRandom(01, 60);
            dz5 = GetRandom(01, 60);
            dz6 = GetRandom(01, 60);

            megaNums = dz1 + " - " + dz2 + " - " + dz3 + " - " + dz4 + " - " + dz5 + " - " + dz6;
            Console.WriteLine(megaNums);
            return megaNums;
        }

        // função que cria números de 2 dígitos aleatórios dentro de um intervalo
        private static int GetRandom(int min, int max) 
        {
            using (System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider())
            {
                byte[] randomNumber = new byte[4];
                rng.GetBytes(randomNumber);
                int value = BitConverter.ToInt32(randomNumber, 0);
                return Math.Abs(value % max + min);
            }
        }


        private void btnPrever_Click(object sender, EventArgs e)
        {
            /* Captando o valor do DateTimePicker (data de aniversário) e
             * jogando numa variável do tipo DateTime */ 
            DateTime niver = dtpNiver.Value;
            // testando se estamos captando o valor
            Console.WriteLine(niver.ToString());

            // Definindo datas iniciais de cada signo
            DateTime aries = new DateTime(2020, 03, 21);
            DateTime touro = new DateTime(2020, 04, 21);
            DateTime gemeos = new DateTime(2020, 05, 21);
            DateTime cancer = new DateTime(2020, 06, 21);
            DateTime leao = new DateTime(2020, 07, 23);
            DateTime virgem = new DateTime(2020, 08, 23);
            DateTime libra = new DateTime(2020, 09, 23);
            DateTime escorpiao = new DateTime(2020, 10, 23);
            DateTime sagitario = new DateTime(2020, 11, 22);
            DateTime capricornio = new DateTime(2020, 12, 22);
            DateTime aquario = new DateTime(2021, 01, 20);
            DateTime peixes = new DateTime(2021, 02, 19);
            DateTime ariesNext = new DateTime(2021, 03, 21);

            // Desativando o Panel pnlNome
            pnlNome.Enabled = false;

            // Tornando o pnlHoroscopo visível
            pnlHoroscopo.Visible = true;
            // Escondendo o pnlNumSorte
            pnlNumSorte.Visible = false;

            // comparando os valores do aniversário com as datas de cada signo
            if (niver >= aries && niver < touro)
            {
                lblSigno.Text += "Áries";
                lblSignoDesc.Text = "Impulsivo, o ariano não pensa muito sobre seus atos. É aquele que primeiro age, depois reflete. Agitado, precisa de muita atividade para gastar a energia, senão pode ficar agressivo e explosivo.";
            }
            else if (niver >= touro && niver < gemeos)
            {
                lblSigno.Text += "Touro";
                lblSignoDesc.Text = "Teimoso, o taurino é determinado e protetor. Precisa de segurança e estabilidade para ser feliz, e conquista isso com muito trabalho e concentração. Carinhoso, o taurino pode ser ciumento com quem ama.";
            }
            else if (niver >= gemeos && niver < cancer)
            {
                lblSigno.Text += "Gemeos";
                lblSignoDesc.Text = "Espontâneo e um pouco instável, o geminiano é uma verdadeira caixinha de surpresas. Como é volátil, muitas vezes nem mesmo o geminiano se entende, mas o importante é que ele está sempre de bom humor e em busca de aventuras.";
            }
            else if (niver >= cancer && niver < leao)
            {
                lblSigno.Text += "Cancer";
                lblSignoDesc.Text = "Família é a palavra-chave para o canceriano. Tranquilo e emotivo, gosta de ficar em casa, fazer programas com quem ama e curtir momentos com os parentes. Curioso, faz amizade com facilidade, mas pode ser um pouco sensível.";
            }
            else if (niver >= leao && niver < virgem)
            {
                lblSigno.Text += "Leão";
                lblSignoDesc.Text = "Este é signo que veio para brilhar. O leonino gosta de chamar a atenção e ser o centro do mundo, mas também é muito amável e leal. Simpático e comunicativo, o nativo de leão pode ser um pouco ciumento e inseguro.";
            }
            else if (niver >= virgem && niver < libra)
            {
                lblSigno.Text += "Virgem";
                lblSignoDesc.Text = "Perspicaz e inteligente, o virginiano está acostumado com o sucesso, por isso se cobra muito, assim como aos demais. Por isso, pode ser um pouco rígido e magoar quem ama. Tímido, prefere programas tranquilos a grandes eventos.";
            }
            else if (niver >= libra && niver < escorpiao)
            {
                lblSigno.Text += "Libra";
                lblSignoDesc.Text = "O libriano gosta do que é belo e harmonioso. Não gosta de conflitos e por isso tenta ser imparcial em debates e brigas. Indeciso, pode demorar muito para escolher coisas simples, como o que comer ou vestir. Bom gosto define este signo.";
            }
            else if (niver >= escorpiao && niver < sagitario)
            {
                lblSigno.Text += "Escorpiao";
                lblSignoDesc.Text = "Determinado, o escorpiano vai até o fim para conquistar os seus objetivos. Sensual e romântico, gosta de estar em relacionamentos, mas pode ser desconfiado enquanto não se sentir seguro com a pessoa.";
            }
            else if (niver >= sagitario && niver < capricornio)
            {
                lblSigno.Text += "Sagitário";
                lblSignoDesc.Text = "Um signo de bem com a vida, que está sempre em busca de ação e que vive rodeado de amigos. Este é o signo de sagitário, que é sonhador e adora conhecer pessoas e lugares novos.";
            }
            else if (niver >= capricornio && niver < aquario)
            {
                lblSigno.Text += "Capricórnio";
                lblSignoDesc.Text = "Trabalhador, tímido e educado, o capricórnio pode passar uma imagem de fechado e até mesmo antipático, mas é que ele eprecisa confiar em quem está ao seu lado para se abrir totalmente. Com paciência, ele se mostra um amigo leal e um companheiro fiel.";
            }
            else if (niver >= aquario && niver < peixes)
            {
                lblSigno.Text += "Aquário";
                lblSignoDesc.Text = "Independente, o aquariano preza muito por sua liberdade. Gosta de viajar, sair e conhecer pessoas novas. Tem uma mente aberta e gosta de tudo o que é inovador e moderno, desde roupas e tecnologia, até mesmo atitudes comportamentais.";
            }
            else if (niver >= peixes && niver < ariesNext)
            {
                lblSigno.Text += "Peixes";
                lblSignoDesc.Text = "Este é o signo mais romântico do zodíaco. Sonhador e carinhoso, ele está sempre preocupado com o bem estar dos outros. Sensível e carinhoso, acredita em contos de fadas e acha que todos merecem um final feliz.";
            }
        }


        private void btnNumeros_Click(object sender, EventArgs e)
        {
            // deixando panels visíveis
            pnlHoroscopo.Visible = true;
            pnlNumSorte.Visible = true;

            // desativando panels já usados
            pnlNome.Enabled = false;
            pnlHoroscopo.Enabled = false;

            // ativando pnlNumSorte
            pnlNumSorte.Enabled = true;

            // passando os 6 números para o label exibido no form
            lblMega.Text = GenMega();
        }

    }
}
