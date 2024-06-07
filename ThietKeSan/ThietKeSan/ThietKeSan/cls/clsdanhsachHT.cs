using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThietKeSan
{
    public class clsdanhsachHT
    {
        public clsHoattai[] m_ht;
        public int m_soluong;

        public int SoLuong
        {
            get
            {
                return m_soluong;
            }
        }

        public void Them_HT(clsHoattai vl)
        {
            m_soluong += 1;
            Array.Resize(ref m_ht, m_soluong + 1);
            m_ht[m_soluong - 1] = vl;
        }

        public void Sua_HT(int i, clsHoattai ht)
        {
            m_ht[i].tenhoattai = ht.tenhoattai;
            m_ht[i].HTTC = ht.HTTC;
            m_ht[i].HSTC = ht.HSTC;
        }
        public void xoa_HT(int index)
        {
            for (int i = index; i <= m_soluong - 1; i++)
                m_ht[i] = m_ht[i + 1];
            m_soluong -= 1;
        }
        public clsHoattai LaythongtinHT(int index)
        {
            clsHoattai ht = m_ht[index];
            return ht;
        }
    }
}
