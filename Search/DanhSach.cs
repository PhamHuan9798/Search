using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Search
{
    [XmlRoot(ElementName = "DanhSachHocSinh")]
    public class FileDS
    {
        [XmlElement(ElementName = "HocSinh")]
        public List<DanhSach> DanhSachHocSinh { get; set; }
    }
    [XmlRoot(ElementName = "HocSinh")]
    public class DanhSach
    {
        [XmlElement(ElementName = "ID")]
        public int ID { get; set; }
        [XmlElement(ElementName = "HoTen")]
        public string HoTen { get; set; }
        [XmlElement(ElementName = "GioiTinh")]
        public string GioiTinh { get; set; }
        [XmlElement(ElementName = "Tuoi")]
        public int Tuoi { get; set; }
        public string Ten { get; set; }

    }
}
