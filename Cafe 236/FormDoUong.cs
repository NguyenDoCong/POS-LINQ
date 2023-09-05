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
    public partial class FormDoUong : Form
    {
        public FormDoUong()
        {
            InitializeComponent();
            DoUong_Load(this, null);

        }

        private void DoUong_Load(object sender, EventArgs e)
        {

            // Tạo đối tượng Data Context
            var context = new _236DataContext();

            string tenDoUong = tBtdu.Text;

            var timID = from douong in context.DoUongs
                        where douong.TenDoUong == tenDoUong
                        select douong.DoUongID;

            // Thực hiện truy vấn và lấy giá trị iddouong
            int iddouong = timID.FirstOrDefault();

            int index = Int32.Parse(iddouong.ToString());


            // Truy vấn dữ liệu từ bảng "nguyên liệu" để lấy tên nguyên liệu
            var query = from record in context.NguyenLieus
                        select record.TenNguyenLieu;

            // Chuyển kết quả truy vấn thành danh sách
            var dataList = query.ToList();

            // Thiết lập nguồn dữ liệu cho ComboBox
            cbBtnl.DataSource = dataList;

            // Truy vấn dữ liệu từ bảng "nl"
            var tk = from CongThuc in context.CongThucs
                     join NguyenLieu in context.NguyenLieus on CongThuc.NguyenLieuID equals NguyenLieu.NguyenLieuID
                     where CongThuc.DoUongID==index
                     select new
                     {
                         CongThuc.NguyenLieuID,
                         NguyenLieu.TenNguyenLieu,
                         CongThuc.SL
                     };

            // Chuyển kết quả truy vấn thành danh sách
            var dtL = tk.ToList();

            // Thiết lập nguồn dữ liệu cho DataGridView
            dGVctdu.DataSource = dtL;

            // Giải phóng tài nguyên
            context.Dispose();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            // Tạo đối tượng Data Context
            var context = new _236DataContext();

            // Lấy dữ liệu từ TextBoxes và ComboBox
            string tenDoUong = tBtdu.Text;
            int gia = Int32.Parse(tBgia.Text);
            string loai = tBloai.Text;

            string tenNguyenLieu = cbBtnl.Text;
            int soLuong = Int32.Parse(tBsl.Text);

            var query = from record in context.NguyenLieus
                        where record.TenNguyenLieu == tenNguyenLieu
                        select record.NguyenLieuID;

            // Thực hiện truy vấn và lấy giá trị nguyenlieuid
            int nguyenlieuid = query.SingleOrDefault();

            bool exists = context.DoUongs.Any(d => d.TenDoUong == tenDoUong);

            // Nếu giá trị không trùng, thêm một bản ghi mới vào bảng "douong"
            if (!exists)
            {
                var newDrink = new QLDoUong
                {
                    TenDoUong = tenDoUong,
                    Gia = gia,
                    Loai = loai
                };

                context.DoUongs.InsertOnSubmit(newDrink);
                context.SubmitChanges();
                
            }

            // Truy vấn dữ liệu từ bảng "douong" để lấy giá trị iddouong
            var timID = from douong in context.DoUongs
                        where douong.TenDoUong==tenDoUong
                        select douong.DoUongID;

            // Thực hiện truy vấn và lấy giá trị iddouong
            int iddouong = timID.FirstOrDefault();

            // Gán giá trị iddouong cho TextBox1
            tBIDdu.Text = iddouong.ToString();
            // Thêm thông tin vào bảng "đồ uống"


            // Lấy giá trị douongid mới được tạo
            int id = Int32.Parse(tBIDdu.Text);
            int douongid = id;

            // Thêm thông tin vào bảng "công thức"
            var newFormula = new CongThuc
            {
                DoUongID = douongid,
                NguyenLieuID = nguyenlieuid,
                SL = soLuong
            };

            context.CongThucs.InsertOnSubmit(newFormula);
            context.SubmitChanges();

            DoUong_Load(this, null);

            // Giải phóng tài nguyên
            context.Dispose();
        }
    }
}
