using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLNS1.DTO
{
    class PhongBan_DTO
    {
        private String maPb;
        private String tenPb;

        public string MaPb
        {
            get
            {
                return maPb;
            }

            set
            {
                maPb = value;
            }
        }

        public string TenPb
        {
            get
            {
                return tenPb;
            }

            set
            {
                tenPb = value;
            }
        }
    }
}
