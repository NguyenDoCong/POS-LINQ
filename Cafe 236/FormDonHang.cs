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
            
        }

        private void reloadData(object sender, EventArgs e)
        {
            var context = new _236DataContext();

            var laydhid = (from donhang in context.DonHangs
                      orderby donhang.DonHangID descending
                      select donhang).FirstOrDefault();
            int iddonhang = laydhid.DonHangID;

            var laytensl = from SLDoUong in context.SLDoUongs
                     join DoUong in context.DoUongs on SLDoUong.DoUongID equals DoUong.DoUongID
                     where SLDoUong.DonHangID == iddonhang
                     select new
                     {
                         DoUong.TenDoUong,
                         SLDoUong.SL
                     };

            // Chuyển kết quả truy vấn thành danh sách
            var dtL = laytensl.ToList();

            // Thiết lập nguồn dữ liệu cho DataGridView
            dGVdh.DataSource = dtL;

            var giatungmon = from sld in context.SLDoUongs
                        join douong in context.DoUongs on sld.DoUongID equals douong.DoUongID
                        where sld.DonHangID == iddonhang
                        select new { Sotien = sld.SL * douong.Gia };

            List<decimal> sotienList = giatungmon.Select(x => x.Sotien.GetValueOrDefault()).ToList();
            decimal tong = sotienList.Sum();
            tBtst.Text = tong.ToString();

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
                reloadData(this, null);

            }
            else
            {
                // Không có entry nào trong bảng "donhang"
            }


        }

        private void btnHT_Click(object sender, EventArgs e)
        {
            using (var dbContext = new _236DataContext()) // Thay YourDataContext bằng lớp DataContext của bạn
            {
                // Lấy giá trị từ TextBox1
                decimal tong = decimal.Parse(tBtst.Text.ToString());

                // Cập nhật cột "tong" trong bảng "donhang" khi có sự trùng khớp với bảng "sldouong"
                var query = from donhang in dbContext.DonHangs
                            join sldouong in dbContext.SLDoUongs on donhang.DonHangID equals sldouong.DonHangID
                            where donhang.DonHangID == sldouong.DonHangID
                            select donhang;

                foreach (var item in query)
                {
                    item.TongSoTien = tong;
                }

                // Lưu các thay đổi vào cơ sở dữ liệu
                dbContext.SubmitChanges();
            }
            // Đóng form hiện tại
            this.Close();

            // Mở lại Form 1
            FormNhanVien formnv = new FormNhanVien();
            formnv.Show();
        }
    }
}
