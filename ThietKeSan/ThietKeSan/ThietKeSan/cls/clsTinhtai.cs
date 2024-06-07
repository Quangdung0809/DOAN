using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThietKeSan
{
    public class clsTinhtai
    {
        private string m_tentinhtai;
        private double m_gb = 0;

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
        public double gb
        {
            get
            {
                return m_gb;
            }
            set
            {
                m_gb = value;
            }
        }

        public void New(string name, double taitrong)
        {
            this.m_tentinhtai = name;
            this.m_gb = taitrong;
        }

    }
}
