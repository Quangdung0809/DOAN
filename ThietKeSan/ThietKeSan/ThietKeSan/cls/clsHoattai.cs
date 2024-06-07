using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThietKeSan
{
   public class clsHoattai
    {
        private string m_tenhoattai;
        private double m_HTTC;
        private double m_HSTC;

        public string tenhoattai
        {
            get
            {
                return m_tenhoattai;
            }
            set
            {
                m_tenhoattai = value;
            }
        }
        public double HTTC
        {
            get
            {
                return m_HTTC;
            }
            set
            {
                m_HTTC = value;
            }
        }
        public double HSTC
        {
            get
            {
                return m_HSTC;
            }
            set
            {
                m_HSTC = value;
            }
        }
        public double Pb
        {
            get
            {
                return m_HTTC * m_HSTC;
            }
        }

        public void New(string name, double hstc, double httc)
        {
            this.m_tenhoattai = name;
            this.m_HSTC = hstc;
            this.m_HTTC = httc;
        }
    }
}
