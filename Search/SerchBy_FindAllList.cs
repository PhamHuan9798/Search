using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public class SerchBy_FindAllList
    {
        public static List<DanhSach> Search_Name(List<DanhSach> Input)
        {
            List<DanhSach> Output = new List<DanhSach>();
            Console.Write("Name =  ");
            string target = Console.ReadLine();
            Console.WriteLine("Thong tin cua HS co Ten la: {0}\n", target);
            Output = Input.FindAll(x => x.Ten.Contains(target));
            InDanhSach(Output);

            return Input;
        }
        public static List<DanhSach> Search_ID(List<DanhSach> Input)
        {
            List<DanhSach> Output = new List<DanhSach>();
            int target, target1;
            Console.WriteLine("1.ID = ");
            Console.WriteLine("2.ID < ");
            Console.WriteLine("3.ID > ");
            Console.WriteLine("4.ID - ID ");

            Console.Write("\nLua Chon: ");
            string lua_chon = Console.ReadLine();
            if (lua_chon == "1")
            {
                Console.Write("ID =  ");
                target = int.Parse(Console.ReadLine());
                Console.WriteLine("Thong tin cua HS co ID = {0}\n", target);
                Output = Input.FindAll(x => x.ID == target);
                InDanhSach(Output);
            }
            else if (lua_chon == "2")
            {
                Console.Write("ID <  ");
                target = int.Parse(Console.ReadLine());
                Console.WriteLine("Thong tin cua HS co ID < {0}\n", target);
                Output = Input.FindAll(x => x.ID < target);
                InDanhSach(Output);
            }
            else if (lua_chon == "3")
            {
                Console.Write("ID >  ");
                target = int.Parse(Console.ReadLine());
                Console.WriteLine("Thong tin cua HS co ID > {0}\n", target);
                Output = Input.FindAll(x => x.ID < target);
                InDanhSach(Output);
            }
            else if (lua_chon == "4")
            {
                Console.Write("Tu");
                target = int.Parse(Console.ReadLine());
                Console.Write("Den");
                target1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Thong tin cua HS co ID trong khoang tu {0} den {1}\n", target, target1);
                Output = Input.FindAll(x => x.ID >= target && x.ID <= target1);
                InDanhSach(Output);
            }
            return Input;
        }
        public static List<DanhSach> Search_Age(List<DanhSach> Input)
        {
            List<DanhSach> Output = new List<DanhSach>();
            int target, target1;
            Console.WriteLine("1.Tuoi = ");
            Console.WriteLine("2.Tuoi < ");
            Console.WriteLine("3.Tuoi > ");
            Console.WriteLine("4.Tuoi - Tuoi ");

            Console.Write("\nLua Chon: ");
            string lua_chon = Console.ReadLine();
            if (lua_chon == "1")
            {
                Console.Write("Tuoi =  ");
                target = int.Parse(Console.ReadLine());
                Console.WriteLine("Thong tin cua HS co Tuoi = {0}\n", target);
                Output = Input.FindAll(x => x.Tuoi == target);
                InDanhSach(Output);
            }
            else if (lua_chon == "2")
            {
                Console.Write("Tuoi <  ");
                target = int.Parse(Console.ReadLine());
                Console.WriteLine("Thong tin cua HS co Tuoi < {0}\n", target);
                Output = Input.FindAll(x => x.Tuoi < target);
                InDanhSach(Output);
            }
            else if (lua_chon == "3")
            {
                Console.Write("Tuoi >  ");
                target = int.Parse(Console.ReadLine());
                Console.WriteLine("Thong tin cua HS co Tuoi > {0}\n", target);
                Output = Input.FindAll(x => x.Tuoi < target);
                InDanhSach(Output);
            }
            else if (lua_chon == "4")
            {
                Console.Write("Tu  ");
                target = int.Parse(Console.ReadLine());
                Console.Write("Den  ");
                target1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Thong tin cua HS co Tuoi trong khoang tu {0} den {1}\n", target, target1);
                Output = Input.FindAll(x => x.Tuoi >= target && x.Tuoi <= target1);
                InDanhSach(Output);
            }
            return Input;
        }
        public static List<DanhSach> Search_GT(List<DanhSach> Input)
        {
            List<DanhSach> Output = new List<DanhSach>();
            Console.Write("GT =  ");
            string target = Console.ReadLine();
            Console.WriteLine("Thong tin cua HS co Gioi Tinh la: {0}\n", target);
            Output = Input.FindAll(x => x.GioiTinh.Contains(target));
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
