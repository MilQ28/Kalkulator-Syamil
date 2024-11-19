using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calcu
{
    public partial class Form1 : Form
    {
        decimal bill1;
        decimal bill2;
        int opr;
        Boolean opr_selesai = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            bill2 = decimal.Parse(txtDisplay1.Text); // Ambil angka kedua dari txtDisplay1

            switch (opr)
            {
                case 1: // Penjumlahan
                    txtDisplay1.Text = (bill1 + bill2).ToString();
                    break;
                case 2: // Pengurangan
                    txtDisplay1.Text = (bill1 - bill2).ToString();
                    break;
                case 3: // Perkalian
                    txtDisplay1.Text = (bill1 * bill2).ToString();
                    break;
                case 4: // Pembagian
                    if (bill2 != 0)
                        txtDisplay1.Text = (bill1 / bill2).ToString();
                    else
                        txtDisplay1.Text = "Error: Tidak Bisa Dibagi 0"; // Tampilkan pesan kesalahan di layar
                    return; // Keluar dari fungsi tanpa mengubah nilai result
                default:
                    txtDisplay1.Text = "Operasi tidak dikenali"; // Jika ada kesalahan operasi
                    return;
            }
            opr_selesai = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "00";
            }
            else
            {
                txtDisplay1.Text += "00";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            bill1 = decimal.Parse(txtDisplay1.Text);
            opr = 1;
            txtDisplay1.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bill1 = decimal.Parse(txtDisplay1.Text);
            opr = 2;
            txtDisplay1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bill1 = decimal.Parse(txtDisplay1.Text);
            opr = 3;
            txtDisplay1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bill1 = decimal.Parse(txtDisplay1.Text);
            opr = 4;
            txtDisplay1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "0";
            }
            else
            {
                txtDisplay1.Text += "0";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "1";
            }
            else
            {
                txtDisplay1.Text += "1";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "2";
            }
            else
            {
                txtDisplay1.Text += "2";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "3";
            }
            else
            {
                txtDisplay1.Text += "3";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "4";
            }
            else
            {
                txtDisplay1.Text += "4";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "5";
            }
            else
            {
                txtDisplay1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "6";
            }
            else
            {
                txtDisplay1.Text += "6";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "7";
            }
            else
            {
                txtDisplay1.Text += "7";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "8";
            }
            else
            {
                txtDisplay1.Text += "8";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "9";
            }
            else
            {
                txtDisplay1.Text += "9";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!txtDisplay1.Text.Contains("."))
            {
                txtDisplay1.Text += ".";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text.Length > 1)
            {
                // Menghapus karakter terakhir dari teks di txtDisplay1
                txtDisplay1.Text = txtDisplay1.Text.Substring(0, txtDisplay1.Text.Length - 1);
            }
            else
            {
                // Jika hanya ada satu karakter atau kosong, set ke "0"
                txtDisplay1.Text = "0";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtDisplay1.Text = "0";
        }
    }
}
