using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZSU
{
    class Aboneler
    {
        public int AbnNo = 0;
        public string AbnAdSoyad = "";
        public string AbnTur = "";
        public int Abnsayac = 0;
        public int AbnOncekiSayac = 0;
        public double odenen()
        {
            if (this.AbnTur == "IsYeri")
            {
                return Convert.ToDouble(this.AbnOncekiSayac) * 0.5;
            }
            else
            {
                return Convert.ToDouble(this.AbnOncekiSayac) * 0.3;
            }
        }

        public double borc()
        {
            if (this.AbnTur == "IsYeri")
            {
                return (Convert.ToDouble(this.AbnOncekiSayac) - Convert.ToDouble(this.Abnsayac)) * 0.5;
            }
            else
            {
                return (Convert.ToDouble(this.AbnOncekiSayac) - Convert.ToDouble(this.Abnsayac)) * 0.3;
            }
        }
        public Aboneler()
        {

        }

        //public Aboneler(int AboneNo, string AboneAdSoyad, int Abonesayac, int AboneOncekiSayac, string AboneTur)
        //{
        //    this.AbnNo = AboneNo;
        //    this.AbnAdSoyad = AboneAdSoyad;
        //    this.Abnsayac = Abonesayac;
        //    this.AbnOncekiSayac = AboneOncekiSayac;
        //    this.AbnTur = AboneTur;
        //}

        public override string ToString()
        {
            return this.AbnNo.ToString();
        }
    }
}
