using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLNS1.DTO
{
    class ChucVu_DTO
    {
        private String maCv;
        private String tenCv;
        private int heSoLuong;
        private double PhuCap;

        public string MaCv
        {
            get
            {
                return maCv;
            }

            set
            {
                maCv = value;
            }
        }

        public string TenCv
        {
            get
            {
                return tenCv;
            }

            set
            {
                tenCv = value;
            }
        }

        public int HeSoLuong
        {
            get
            {
                return heSoLuong;
            }

            set
            {
                heSoLuong = value;
            }
        }

        public double PhuCap1
        {
            get
            {
                return PhuCap;
            }

            set
            {
                PhuCap = value;
            }
        }
    }
}
