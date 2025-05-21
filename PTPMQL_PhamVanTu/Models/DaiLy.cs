using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTPMQL_PhamVanTu.Models
{
    public class DaiLy
    {
        public string MaDaiLy { get; set; }
        public string TenDaiLy { get; set; }
        public string DiaChi { get; set; }
        public string NguoiDaiDien { get; set; }
        public String MaHTTP { get; set; }
        public HeThongPhanPhoi HeThongPhanPhoi { get; set; }
    }
}