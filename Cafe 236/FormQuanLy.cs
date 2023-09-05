using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_236
{
    public partial class FormQuanLy : Form
    {
        public FormQuanLy()
        {
            InitializeComponent();
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {

            // Tạo đối tượng Data Context
            var context = new _236DataContext();

            // Truy vấn dữ liệu từ bảng "nl"
            var query = from record in context.NguyenLieus
                        select record;

            // Chuyển kết quả truy vấn thành danh sách
            var dataList = query.ToList();

            // Thiết lập nguồn dữ liệu cho DataGridView
            dGVqlnl.DataSource = dataList;

            // Giải phóng tài nguyên
            context.Dispose();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            // Tạo đối tượng Data Context
            var context = new _236DataContext();

            // Lấy dữ liệu từ TextBoxes
            string tenNL = tbTenNL.Text;
            int gia = Int32.Parse(tbGia.Text);
            int sl = Int32.Parse(tbSL.Text);

            // Tạo đối tượng mới từ dữ liệu TextBoxes
            var newRecord = new NguyenLieu
            {
                TenNguyenLieu = tenNL,
                GiaNguyenLieu = gia,
                SLNguyenLieu = sl
            };

            // Thêm bản ghi mới vào bảng "nl"
            context.NguyenLieus.InsertOnSubmit(newRecord);
            context.SubmitChanges();

            QuanLy_Load(this,null);
            // Giải phóng tài nguyên
            context.Dispose();
        }
    }
}
