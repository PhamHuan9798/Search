using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public class SearchByFor
    {
        public static List<DanhSach> Search_Age(List<DanhSach> Input)
        {
            List<DanhSach> Output = new List<DanhSach>();
            Console.WriteLine("1.Tuoi = ");
            Console.WriteLine("2.Tuoi < ");
            Console.WriteLine("3.Tuoi > ");
            Console.WriteLine("4.Tuoi - Tuoi ");

            Console.Write("\nLua Chon: ");
            string lua_chon = Console.ReadLine();
            if (lua_chon == "1")
            {
                Console.Write("Tuoi =  ");
                int giatricantim = int.Parse(Console.ReadLine());
                for (int i = 0; i < Input.Count; i++)
                {
                    if (Input[i].Tuoi == giatricantim)
                    {
                        Output.Add(Input[i]);
                    }
                }
                if (Output.Count == 0)
                    Console.WriteLine("Khong tim duoc");
                Console.WriteLine("Thong tin cua HS co Tuoi = {0}\n", giatricantim);
                InDanhSach(Output);
            }
            else if (lua_chon == "2")
            {
                Console.Write("Tuoi <  ");
                int giatricantim = int.Parse(Console.ReadLine());
                for (int i = 0; i < Input.Count; i++)
                {
                    if (Input[i].Tuoi < giatricantim)
                    {
                        Output.Add(Input[i]);
                    }
                }
                if (Output.Count == 0)
                    Console.WriteLine("Khong tim duoc");
                Console.WriteLine("Thong tin cua HS co Tuoi < {0}\n", giatricantim);
                InDanhSach(Output);

            }
            else if (lua_chon == "3")
            {
                Console.Write("Tuoi >  ");
                int giatricantim = int.Parse(Console.ReadLine());
                for (int i = 0; i < Input.Count; i++)
                {
                    if (Input[i].Tuoi > giatricantim)
                    {
                        Output.Add(Input[i]);
                    }
                }
                if (Output.Count == 0)
                    Console.WriteLine("Khong tim duoc");
                Console.WriteLine("Thong tin cua HS co Tuoi > {0}\n", giatricantim);
                InDanhSach(Output);
            }
            else if (lua_chon == "4")
            {
                Console.Write("Tu:  ");
                int giatricantim_1 = int.Parse(Console.ReadLine());
                Console.Write("Den:  ");
                int giatricantim_2 = int.Parse(Console.ReadLine());
                for (int i = 0; i < Input.Count; i++)
                {
                    if (giatricantim_1 <= Input[i].Tuoi && Input[i].Tuoi <= giatricantim_2)
                    {
                        Output.Add(Input[i]);
                    }
                }
                if (Output.Count == 0)
                    Console.WriteLine("Khong tim duoc");
                Console.WriteLine("Thong tin cua HS co Tuoi trong khoang tu {0} den {1}\n", giatricantim_1, giatricantim_2);
                InDanhSach(Output);
            }

            return Input;
        }
        public static List<DanhSach> Search_ID(List<DanhSach> Input)
        {
            List<DanhSach> Output = new List<DanhSach>();
            Console.WriteLine("1.ID = ");
            Console.WriteLine("2.ID < ");
            Console.WriteLine("3.ID > ");
            Console.WriteLine("4.ID - ID ");

            Console.Write("\nLua Chon: ");
            string lua_chon = Console.ReadLine();
            if (lua_chon == "1")
            {
                Console.Write("ID =  ");
                int giatricantim = int.Parse(Console.ReadLine());
                for (int i = 0; i < Input.Count; i++)
                {
                    if (Input[i].ID == giatricantim)
                    {
                        Output.Add(Input[i]);
                    }
                }
                if (Output.Count == 0)
                    Console.WriteLine("Khong tim duoc");
                Console.WriteLine("Thong tin cua HS co ID = {0}\n", giatricantim);
                InDanhSach(Output);
            }
            else if (lua_chon == "2")
            {
                Console.Write("ID <  ");
                int giatricantim = int.Parse(Console.ReadLine());
                for (int i = 0; i < Input.Count; i++)
                {
                    if (Input[i].ID < giatricantim)
                    {
                        Output.Add(Input[i]);
                    }
                }
                if (Output.Count == 0)
                    Console.WriteLine("Khong tim duoc");
                Console.WriteLine("Thong tin cua HS co ID < {0}\n", giatricantim);
                InDanhSach(Output);

            }
            else if (lua_chon == "3")
            {
                Console.Write("ID >  ");
                int giatricantim = int.Parse(Console.ReadLine());
                for (int i = 0; i < Input.Count; i++)
                {
                    if (Input[i].ID > giatricantim)
                    {
                        Output.Add(Input[i]);
                    }
                }
                if (Output.Count == 0)
                    Console.WriteLine("Khong tim duoc");
                Console.WriteLine("Thong tin cua HS co ID > {0}\n", giatricantim);
                InDanhSach(Output);
            }
            else if (lua_chon == "4")
            {
                Console.Write("Tu:  ");
                int giatricantim_1 = int.Parse(Console.ReadLine());
                Console.Write("Den:  ");
                int giatricantim_2 = int.Parse(Console.ReadLine());
                for (int i = 0; i < Input.Count; i++)
                {
                    if (giatricantim_1 <= Input[i].ID && Input[i].ID <= giatricantim_2)
                    {
                        Output.Add(Input[i]);
                    }
                }
                if (Output.Count == 0)
                    Console.WriteLine("Khong tim duoc");
                Console.WriteLine("Thong tin cua HS co ID trong khoang tu {0} den {1}\n", giatricantim_1, giatricantim_2);
                InDanhSach(Output);
            }

            return Input;
        }
        public static List<DanhSach> Search_Name(List<DanhSach> Input)
        {
            List<DanhSach> Output = new List<DanhSach>();
            Console.Write("Name =  ");
            string name = Console.ReadLine();
            for (int i = 0; i < Input.Count; i++)
            {
                if (Input[i].Ten == name)
                {
                    Output.Add(Input[i]);
                }
            }
            if (Output.Count == 0)
                Console.WriteLine("Khong tim duoc");
            Console.WriteLine("Thong tin cua HS co Ten la: {0}\n", name);
            InDanhSach(Output);

            return Input;
        }
        public static List<DanhSach> Search_GT(List<DanhSach> Input)
        {
            List<DanhSach> Output = new List<DanhSach>();
            Console.Write("GT =  ");
            string GT = Console.ReadLine();
            for (int i = 0; i < Input.Count; i++)
            {
                if (Input[i].GioiTinh == GT)
                {
                    Output.Add(Input[i]);
                }
            }
            if (Output.Count == 0)
                Console.WriteLine("Khong tim duoc");
            Console.WriteLine("Thong tin cua HS co Ten la: {0}\n", GT);
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
