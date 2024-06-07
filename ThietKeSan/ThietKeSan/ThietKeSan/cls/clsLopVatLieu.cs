using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThietKeSan
{
    public class clsLopVatLieu
    {
        private string m_tentinhtai;
        private string m_lopvl;
        private double m_beday;
        private double m_TrongLuong;
        private double m_HSVT;
        private double m_tttt;

        public string tentinhtai
        {
            get
            {
                return m_tentinhtai;
            }
            set
            {
                m_tentinhtai = value;
            }
        }

        public string lopvl
        {
            get
            {
                return m_lopvl;
            }
            set
            {
                m_lopvl = value;
            }
        }
        public double beday
        {
            get
            {
                return m_beday;
            }
            set
            {
                m_beday = value;
            }
        }

        public double TrongLuong
        {
            get
            {
                return m_TrongLuong;
            }
            set
            {
                m_TrongLuong = value;
            }
        }
        public double HSVT
        {
            get
            {
                return m_HSVT;
            }
            set
            {
                m_HSVT = value;
            }
        }
        public double TTTT
        {
            get
            {
                m_tttt = m_beday * m_TrongLuong * m_HSVT;
                return m_tttt;
            }
        }

        //public void New(double  )
        //    {
}
    }

