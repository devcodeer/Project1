using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;
namespace BUS
{
    public class BaoCao_BUS
    {
        // SO QUY
        public static DataTable SoQuy(string matk, DateTime ngaybd, DateTime ngaykt)
        {
            return BaoCao_DAO.SoQuy(matk,ngaybd, ngaykt);

        }
        // SO TIEN GUI
        public static DataTable SoTienGui(string matk, DateTime ngaybd, DateTime ngaykt)
        {
            return BaoCao_DAO.SoTienGui(matk,ngaybd, ngaykt);

        }

        // BACKUP CSDL
        public static void backup(string duongdan)
        {
            BaoCao_DAO.backup(duongdan);
        }

        // RESTORE CSDL
        public static void restore(string duongdan)
        {
            BaoCao_DAO.restore(duongdan);
        }
    }
}
