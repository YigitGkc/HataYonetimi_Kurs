using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HataYonetimi_Kurs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHataYonetimsiz_Click(object sender, EventArgs e)
        {
            int telefonNumarasi = Convert.ToInt32(textBox1.Text);
            MessageBox.Show("Tebrikler, telefonNumarasi numaranı sisteme girebildin!");




        }

        private void BtnHataYonetimli_Click(object sender, EventArgs e)
        {
            try
            {
                int telefonNumarasi = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Tebrikler, telefonNumarasi numaranı sisteme girebildin!");

            }
            catch
            {
                MessageBox.Show("Lütfen telefon numaranızı eksikiz ve sadece sayisal verilerden oluşan bir formatta giriniz\nTelefon Formatı : 02123334455");

            }
        }

        private void BtnHataYonetimliMesaj_Click(object sender, EventArgs e)
        {
            try
            {
                int telefonNumarasi = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Tebrikler, telefonNumarasi numaranı sisteme girebildin!");

            }
            catch (Exception ex)


            {
                MessageBox.Show("Lütfen telefon numaranızı eksikiz ve sadece sayisal verilerden oluşan bir formatta giriniz\nTelefon Formatı : 02123334455");

                MessageBox.Show(ex.Message);


            }
        }

        private void BtnHataYonetimliFinally_Click(object sender, EventArgs e)
        {
            try
            {
                int telefonNumarasi = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Tebrikler, telefonNumarasi numaranı sisteme girebildin!");

            }
            catch (Exception ex)


            {
                MessageBox.Show("Lütfen telefon numaranızı eksikiz ve sadece sayisal verilerden oluşan bir formatta giriniz\nTelefon Formatı : 02123334455");

                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Bu alan içerisinde yer alan kod blokları her zaman çalışacaktır.");
            }
        }
    }
}







