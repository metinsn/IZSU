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

        List <Aboneler> Abone = new List<Aboneler>();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Aboneler abnler = new Aboneler();
            abnler.AboneAdSoyad = txtbAdSoyad.Text.ToString();
            abnler.AboneNo = Convert.ToInt32(txtbAboneNo.Text);
            abnler.Abonesayac = Convert.ToInt32(txtbiSayac.Text);
            abnler.AboneOncekiSayac = Convert.ToInt32(txtbOncekiSayac.Text);
            string abonetur = rbtnEv.Checked == true ? "Ev" : "IsYeri";
            abnler.AboneTur = abonetur.ToString();
            Abone.Add(abnler);
            lstbAboneler.Items.Add(abnler);
        }
    }
}
