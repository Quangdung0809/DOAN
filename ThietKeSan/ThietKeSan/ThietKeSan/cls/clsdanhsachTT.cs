using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThietKeSan
{
   public class clsdanhsachTT
    {
        public clsTinhtai[] m_tt;
        public int m_soluong;

        public int SoLuong
        {
            get
            {
                return m_soluong;
            }
        }

        public void Them_TT(clsTinhtai tt)
        {
            m_soluong += 1;
            Array.Resize(ref m_tt, m_soluong);
            m_tt[m_soluong - 1] = tt;
        }

        public void Sua_TT(int i, clsTinhtai tt)
        {
            m_tt[i].tentinhtai = tt.tentinhtai;
            m_tt[i].gb = tt.gb;
        }
        public void xoa_TT(int index)
        {
            for (int i = index; i <= m_soluong - 1; i++)
                m_tt[i] = m_tt[i + 1];
            m_soluong -= 1;
        }
        public clsTinhtai LaythongtinTT(int index)
        {
            clsTinhtai tt = m_tt[index];
            return tt;
        }
    }
}
