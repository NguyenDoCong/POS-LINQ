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
    public partial class FormDonHang : Form
    {
        public FormDonHang()
        {
            InitializeComponent();
            FormDonHang_Load(this, null);
        }

        private void FormDonHang_Load(object sender, EventArgs e)
        {
            var context = new _236DataContext();

            // Truy vấn dữ liệu từ bảng "nguyên liệu" để lấy tên nguyên liệu
            var query = from record in context.DoUongs
                        select record.TenDoUong;

            // Chuyển kết quả truy vấn thành danh sách
            var dataList = query.ToList();

            string tenDoUong = cbBxTDU.Text;

            // Thiết lập nguồn dữ liệu cho ComboBox
            cbBxTDU.DataSource = dataList;

            var qr = (from donhang in context.DonHangs
                         orderby donhang.DonHangID descending
                         select donhang).FirstOrDefault();
            int iddonhang = qr.DonHangID;

            var tk = from SLDoUong in context.SLDoUongs
                     join DoUong in context.DoUongs on SLDoUong.DoUongID equals DoUong.DoUongID
                     where SLDoUong.DonHangID == iddonhang
                     select new
                     {
                         DoUong.TenDoUong,
                         SLDoUong.SL
                     };

            // Chuyển kết quả truy vấn thành danh sách
            var dtL = tk.ToList();

            // Thiết lập nguồn dữ liệu cho DataGridView
            dGVdh.DataSource = dtL;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var context = new _236DataContext();

            var query = (from donhang in context.DonHangs
                         orderby donhang.DonHangID descending
                         select donhang).FirstOrDefault();

            string tenDoUong = cbBxTDU.Text;
            int sl = Int32.Parse(nUDsl.Text);

            if (query != null)
            {
                // Entry có id lớn nhất được tìm thấy
                // Ví dụ: Lấy giá trị iddonhang từ entry có id lớn nhất
                int iddonhang = query.DonHangID;

                var qr = from record in context.DoUongs
                            where record.TenDoUong == tenDoUong
                         select record.DoUongID;

                // Thực hiện truy vấn và lấy giá trị nguyenlieuid
                int douongid = qr.FirstOrDefault();
                // Sử dụng giá trị iddonhang theo nhu cầu của bạn

                var duMoi = new SLDoUong
                {
                    DonHangID = iddonhang,
                    DoUongID = douongid,
                    SL = sl
                };

                context.SLDoUongs.InsertOnSubmit(duMoi);
                context.SubmitChanges();
                FormDonHang_Load(this, null);

            }
            else
            {
                // Không có entry nào trong bảng "donhang"
            }


        }

        private void btnHT_Click(object sender, EventArgs e)
        {

        }
    }
}
