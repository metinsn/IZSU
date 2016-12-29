using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IZSU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstbAboneler.Items.Add("Abone No");
            lsltbOdenenFatura.Items.Add("Abone No\t" + "Ödenmiş Tutar\t");
            lstbAboneBilgileri.Items.Add("Abone Bilgileri\t");
            rbtnEv.Checked = true;
        }

        private void rbtnIsYeri_MouseClick(object sender, MouseEventArgs e)
        {
            rbtnIsYeri.Checked = true;
            rbtnEv.Checked = false;
        }


        private void rbtnEv_Click(object sender, EventArgs e)
        {
            rbtnIsYeri.Checked = false;
            rbtnEv.Checked = true;
        }


        private void txtbAboneNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtbAboneNo.Text) < 0 || Convert.ToInt32(txtbAboneNo.Text) > 99999999)
                {
                    MessageBox.Show("Abone No giriniz !!!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Abone No giriniz !!!");
            }

        }


        private void txtbOncekiSayac_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtbOncekiSayac.Text) < 0 || Convert.ToInt32(txtbOncekiSayac.Text) > 99999999)
                {
                    MessageBox.Show("Sayaç Değeri giriniz !!!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sayaç Değeri giriniz !!!");
            }
        }


        private void txtbSayac_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtbSayac.Text) < 0 || Convert.ToInt32(txtbSayac.Text) > 99999999)
                {
                    MessageBox.Show("Sayaç Değeri giriniz !!!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sayaç Değeri giriniz !!!");
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtbAboneNo.Text != "" && txtbSayac.Text != "" && txtbOncekiSayac.Text != "")
            {
                Aboneler abnler = new Aboneler();
                abnler.AbnNo = Convert.ToInt32(txtbAboneNo.Text);
                abnler.AbnAdSoyad = txtbAdSoyad.Text.ToString();
                abnler.Abnsayac = Convert.ToInt32(txtbSayac.Text);
                abnler.AbnOncekiSayac = Convert.ToInt32(txtbOncekiSayac.Text);
                string abonetur = rbtnEv.Checked == true ? "Ev" : "IsYeri";
                abnler.AbnTur = abonetur.ToString();
                lstbAboneler.Items.Add(abnler.AbnNo);
            }
            else
            {
                MessageBox.Show("Değerleri Doğru giriniz !!!");
            }
        }

        private void lstbAboneler_DoubleClick(object sender, EventArgs e)
        {
            //string secAbone = lstbAboneler.SelectedItem.ToString();  // 1
            Aboneler secAbone = (Aboneler)lstbAboneler.SelectedItem;

            //MessageBox.Show(lstbAboneler.SelectedItem.ToString());
            lsltbOdenenFatura.Items.Add(secAbone); // 1
            //MessageBox.Show(secAbone);
        }


    }
}
