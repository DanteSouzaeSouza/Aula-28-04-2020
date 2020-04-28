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

        }



        private static String GenMega()
        {
            int dz1, dz2, dz3, dz4, dz5, dz6;
            String megaNums = "";

            dz1 = GetRandom(0, 59);
            dz2 = GetRandom(0, 59);
            dz3 = GetRandom(0, 59);
            dz4 = GetRandom(0, 59);
            dz5 = GetRandom(0, 59);
            dz6 = GetRandom(0, 59);

            megaNums = dz1 + " - " + dz2 + " - " + dz3 + " - " + dz4 + " - " + dz5 + " - " + dz6;
            Console.WriteLine(megaNums);
            return megaNums;
        }


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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
