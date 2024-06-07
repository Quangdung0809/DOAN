using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThietKeSan
{
    public class clsdanhsachVL
    {
        public clsLopVatLieu[] m_vatlieu;
        public int m_soluong;

        public int SoLuong
        {
            get
            {
                return m_soluong;
            }
        }
        public void Them_VL(clsLopVatLieu vl)
        {
            m_soluong += 1;
            // thay đổi số lượng vật liệu 
            Array.Resize(ref m_vatlieu, m_soluong + 1);
            m_vatlieu[m_soluong - 1] = vl;
        }

        public void Sua_VL(int i, clsLopVatLieu vl)
        {
            m_vatlieu[i].lopvl = vl.lopvl;
            m_vatlieu[i].beday = vl.beday;
            m_vatlieu[i].TrongLuong = vl.TrongLuong;
            m_vatlieu[i].HSVT = vl.HSVT;
            m_vatlieu[i].tentinhtai = vl.tentinhtai;
        }

        public void xoa_VL(int index)
        {
            for (int i = index; i <= m_soluong - 1; i++)
                m_vatlieu[i] = m_vatlieu[i + 1];
            m_soluong -= 1;
        }

        public clsLopVatLieu LaythongtinVL(int index)
        {
            clsLopVatLieu vl = m_vatlieu[index];
            return vl;
        }
    }
}
