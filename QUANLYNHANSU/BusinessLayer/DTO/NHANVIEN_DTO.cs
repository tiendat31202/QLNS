using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer.DTO
{
    public class NHANVIEN_DTO
    {
        public int MANV { get; set; }
        public string HOTEN { get; set; }
        public Nullable<bool> GIOITINH { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public string DIENTHOAI { get; set; }
        public string CCCD { get; set; }
        public string DIACHI { get; set; }
        public byte[] HINHANH { get; set; }
        public Nullable<int> IDPB { get; set; }
        public String TENPB { get; set; }
        public Nullable<int> IDBP { get; set; }
        public String TENBP { get; set; }
        public Nullable<int> IDCV { get; set; }
        public String TENCV { get; set; }
        public Nullable<int> IDTD { get; set; }
        public String TENTD { get; set; }
        public Nullable<int> IDDT { get; set; }
        public String TENDT { get; set; }
        public Nullable<int> IDTG { get; set; }
        public String TENTG { get; set; }
        public Nullable<int> MACTY { get; set; }
    }
}
