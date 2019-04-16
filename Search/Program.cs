using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Search
{
    class Program
    {
        static void Main(string[] args)
        {
            //String Json_data = File.ReadAllText(@"C:\Users\Administrator\Desktop\DanhSach.json");
            //FileDS data = JsonConvert.DeserializeObject<FileDS>(Json_data);
            //Input = data.DanhSachHocSinh;
            //Đọc file XML
            List<DanhSach> Input = new List<DanhSach>();
            string doc = File.ReadAllText(@"C:\Users\Administrator\Desktop\SapXepTheoTuoi.xml");
            XmlSerializer DanhSach = new XmlSerializer(typeof(FileDS));
            FileDS Output = new FileDS();
            using (TextReader read = new StringReader(doc))
            {
                Output = (FileDS)DanhSach.Deserialize(read);
            }
            Input = Output.DanhSachHocSinh;
               
            foreach (DanhSach DS in Input)   // Cắt lấy tên
            {
                string[] cut = DS.HoTen.Split(' ');
                DS.Ten = cut[cut.Length - 1];
            }

            

            Console.WriteLine("\n--------Danh Sach--------\n");
            Console.WriteLine("Chon cach tim kiem: \n");
            Console.WriteLine("1.Theo ID");
            Console.WriteLine("2.Theo Ten");
            Console.WriteLine("3.Theo Tuoi");
            Console.WriteLine("4.Theo Gioi Tinh");

            Console.Write("\nLua Chon: ");
            string lua_chon = Console.ReadLine();

            if (lua_chon == "1")
            {
                SearchByFor.Search_ID(Input);
            }
            else if (lua_chon == "2")
            {
                SearchByFor.Search_Name(Input);
            }
            else if (lua_chon == "3")
            {
                Binary_Search.Search_Age(Input);
            }
            else if (lua_chon == "4")
            {
                SearchByFor.Search_GT(Input);
            }
            else
            {
                Console.WriteLine("Khong hop le !");
            }
            Console.ReadKey();
        }
    }
}
