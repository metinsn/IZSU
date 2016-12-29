using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZSU
{
    class Aboneler
    {
        public int AbnNo;
        public string AbnAdSoyad;
        public string AbnTur;
        public int Abnsayac;
        public int AbnOncekiSayac;

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

        public Aboneler (int AboneNo, string AboneAdSoyad, int Abonesayac, int AboneOncekiSayac, string AboneTur)
        {
            this.AbnNo = AboneNo;
            this.AbnAdSoyad = AboneAdSoyad;
            this.AbnTur = AboneTur;
            this.Abnsayac = Abonesayac;
            this.AbnOncekiSayac = AboneOncekiSayac;
        }

        public override string ToString()
        {
            return this.AbnNo + "\n" + this.AbnAdSoyad + "\n" + this.AbnTur + "\n" + this.AbnOncekiSayac + this.Abnsayac + "\n";
        }
    }
}
