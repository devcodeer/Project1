using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BUS;
namespace KETOANVONBANGTIEN.Funciton
{
    class Funtion
    {
        public static string DecimalToString(decimal number)
        {
            string s = number.ToString("#");
            string[] so = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] hang = new string[] { "", "nghìn", "triệu", "tỷ" };
            int i, j, donvi, chuc, tram;
            string str = "";
            bool booAm = false;
            decimal decS = 0;
            try
            {
                decS = Convert.ToDecimal(s.ToString());
            }
            catch
            {
            }
            if (decS < 0)
            {
                decS = -decS;
                s = decS.ToString();
                booAm = true;
            }
            i = s.Length;
            if (i == 0)
                str = so[0] + str;
            else
            {
                j = 0;
                while (i > 0)
                {
                    donvi = Convert.ToInt32(s.Substring(i - 1, 1));
                    i--;
                    if (i > 0)
                        chuc = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        chuc = -1;
                    i--;
                    if (i > 0)
                        tram = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        tram = -1;
                    i--;
                    if ((donvi > 0) || (chuc > 0) || (tram > 0) || (j == 3))
                        str = hang[j] + str;
                    j++;
                    if (j > 3) j = 1;
                    if ((donvi == 1) && (chuc > 1))
                        str = "một " + str;
                    else
                    {
                        if ((donvi == 5) && (chuc > 0))
                            str = "lăm " + str;
                        else if (donvi > 0)
                            str = so[donvi] + " " + str;
                    }
                    if (chuc < 0)
                        break;
                    else
                    {
                        if ((chuc == 0) && (donvi > 0)) str = "lẻ " + str;
                        if (chuc == 1) str = "mười " + str;
                        if (chuc > 1) str = so[chuc] + " mươi " + str;
                    }
                    if (tram < 0) break;
                    else
                    {
                        if ((tram > 0) || (chuc > 0) || (donvi > 0)) str = so[tram] + " trăm " + str;
                    }
                    str = " " + str;
                }
            }
            if (booAm) str = "Âm " + str;
            string chuoi =  str.Trim();
            
            return char.ToUpper(chuoi[0]) + chuoi.Substring(1);
        }

        public static string TaoSoCt(int loaict)
        {
            string sophieu = "XX00000";
            DataTable dt = ChungTu_BUS.LoadDanhSachCtTheoLoai(loaict);
            
            
            if (dt.Rows.Count > 0)
            {
                sophieu = dt.Rows[0][0].ToString();
            }
                      
            string ChuoiSo = sophieu.Substring(2, 5);
            string Temp = (int.Parse(ChuoiSo) + 1).ToString();
            int dodai = Temp.Length;
            string TienTo = ChuoiSo.Substring(0, 5 - dodai);

            if (loaict == 1)
            {
                return "PT" + TienTo + Temp;
            }
            else if (loaict==2)
            {
                return "PC" + TienTo + Temp; ;
            }
            else if (loaict == 3)
            {
                return "BN" + TienTo + Temp; ;
            }
            else if (loaict == 4)
            {
                return "BC" + TienTo + Temp; ;
            }
            else 
            {
                return "";
            }
        }
        
    }


}
