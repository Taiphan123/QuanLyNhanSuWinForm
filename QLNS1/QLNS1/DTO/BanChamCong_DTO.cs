using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLNS1.DTO
{
    class BanChamCong_DTO
    {
        private String maBcc;
        private String maNd;
        private int thangCC;
        private int soNgayCong;

        public string MaBcc
        {
            get
            {
                return maBcc;
            }

            set
            {
                maBcc = value;
            }
        }

        public string MaNd
        {
            get
            {
                return maNd;
            }

            set
            {
                maNd = value;
            }
        }

        public int ThangCC
        {
            get
            {
                return thangCC;
            }

            set
            {
                thangCC = value;
            }
        }

        public int SoNgayCong
        {
            get
            {
                return soNgayCong;
            }

            set
            {
                soNgayCong = value;
            }
        }
    }
}
