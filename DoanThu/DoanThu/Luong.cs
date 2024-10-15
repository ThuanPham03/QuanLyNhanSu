using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoanThu
{
    public partial class Luong : Form
    {
        public Luong()
        {
            InitializeComponent();
        }
        public int Thang { get; set; }
        public int Nam { get; set; }
        //public List<NhanVien> DanhSachNhanVien { get; set; } = new List<NhanVien>();

        public decimal TongLuongCoBan { get; set; }
        public decimal TongPhuCap { get; set; }
        public decimal TongKhấuTru { get; set; }
        public decimal TongLuongThucLinh { get; set; }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            // Tính toán lương
            TinhLuong();

            // Hiển thị kết quả lên giao diện
           // txtTongLuongCoBan.Text = TongLuongCoBan.ToString();
            // ...
        }
        private void TinhLuong()
        {
            // ... logic tính lương
        }
    }
}
