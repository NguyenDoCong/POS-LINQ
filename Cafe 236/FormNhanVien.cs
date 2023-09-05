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
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void btnThemQLDH_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng Data Context
            var context = new _236DataContext();

            DonHang newDonHang = new DonHang()
            {
                // Gán các giá trị cho các trường trong entry mới
                // Ví dụ: Gán giá trị cho trường "ngay" là ngày hiện tại
                Ngay = DateTime.Now
            };

            // Thêm entry mới vào bảng "donhang"
            context.DonHangs.InsertOnSubmit(newDonHang);
            context.SubmitChanges();

            this.Hide();

            // Tạo và hiển thị Form2
            FormDonHang formdh = new FormDonHang();
            formdh.Show();
        }
    }
}
