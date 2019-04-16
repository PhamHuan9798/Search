using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public class Binary_Search
    {
        public static List<DanhSach> Search_Age(List<DanhSach> Input)
        {
            List<DanhSach> Output = new List<DanhSach>();
            Console.Write("Tuoi =  ");
            int giatricantim = int.Parse(Console.ReadLine());
            int First = 0;
            int Last = Input.Count - 1;
            while (First <= Last)
            {
                int MID = (First + Last) / 2;
                if (Input[MID].Tuoi == giatricantim)  //Tim thay
                    Output.Add(Input[MID]);
                else if (giatricantim < Input[MID].Tuoi)
                    Last = MID - 1;
                else
                    First = MID + 1;
                return Input;
            }
            Console.WriteLine("Thong tin cua HS co Tuoi = {0}\n", giatricantim);
            InDanhSach(Output);
            
            return Input;
        }
        static void InDanhSach(List<DanhSach> KetQua)
        {
            foreach (DanhSach DS in KetQua)
            {
                Console.WriteLine(DS.ID + " ..... " + DS.HoTen + " ..... " + DS.Tuoi + " ..... " + DS.GioiTinh);
            }
        }
    }
}
