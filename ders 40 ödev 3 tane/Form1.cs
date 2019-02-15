using System;
using System.Windows.Forms;

namespace ders_40_ödev_3_tane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
       
                {
                    int sayac = 0;
                    int toplam = 0;
                    int[] sayilar = { 10, 20, 5, 12, 32 };
                    foreach (int k in sayilar)
                    {
                        listBox1.Items.Add(k);
                        if (k % 4 == 0)
                {
                    listBox2.Items.Add(k);
                    toplam = toplam + k;
                    sayac++;
                }
                            

                    }
                    label1.Text = sayac.ToString();
                    label2.Text = toplam.ToString();


                }
        }
    }

