using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgiSistemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = "";
            metin = (TextBox1.Text);
            metin = metin.ToUpper();
            char[] harfler = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            string[] degerler = { "01", "1000", "1010", "100", "0", "0010", "110", "0000", "00", "0111", "101", "0100", "11", "10", "111", "0110", "1101", "010", "000", "1", "001", "0001", "011", "1001", "1011", "1100" };
            char[] girilen = metin.ToCharArray();
            maskedTextBox2.Clear();
            for (int j = 0; j < girilen.Length; j++)
            {
                for (int a = 0; a < harfler.Length; a++)
                {

                    if (girilen[j] == harfler[a])
                    {
                        maskedTextBox2.Text = maskedTextBox2.Text + degerler[a] + "2";



                    }
                    if (girilen[j] == ' ')
                    {
                        maskedTextBox2.Text = maskedTextBox2.Text + "3";
                        break;
                    }
                   

                }


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {


            String[] harfler = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string[] degerler = { "01", "1000", "1010", "100", "0", "0010", "110", "0000", "00", "0111", "101", "0100", "11", "10", "111", "0110", "1101", "010", "000", "1", "001", "0001", "011", "1001", "1011", "1100" };


            TextBox1.Clear();
            string metin = maskedTextBox2.Text;
            metin = metin.ToUpper();
            char[] bol = { '3' };
            char[] bol2 = { '2' };
            String[] kelime = metin.Split(bol);


            for (int j = 0; j < kelime.Length; j++)
            {
                string[] harf = kelime[j].Split(bol2);


                for (int a = 0; a < harf.Length; a++)
                {

                    for (int c = 0; c < degerler.Length; c++)
                    {
                        if (harf[a] == degerler[c])
                        {
                            TextBox1.Text = TextBox1.Text + harfler[c];


                        }
                        
                    }



                }
                TextBox1.Text = TextBox1.Text + " ";


            }

        }
    }
}
