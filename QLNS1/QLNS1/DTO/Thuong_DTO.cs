using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLNS1.DTO
{
    class Thuong_DTO
    {
        private String maThuong;
        private String maNd;
        private int thang;
        private String noiDung;
        private double soTien;

        public string MaThuong
        {
            get
            {
                return maThuong;
            }

            set
            {
                maThuong = value;
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

        public int Thang
        {
            get
            {
                return thang;
            }

            set
            {
                thang = value;
            }
        }

        public string NoiDung
        {
            get
            {
                return noiDung;
            }

            set
            {
                noiDung = value;
            }
        }

        public double SoTien
        {
            get
            {
                return soTien;
            }

            set
            {
                soTien = value;
            }
        }
    }
}
