
namespace Cafe_236
{
    partial class FormQuanLy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabQL = new System.Windows.Forms.TabControl();
            this.QLDU = new System.Windows.Forms.TabPage();
            this.QLNL = new System.Windows.Forms.TabPage();
            this.ThongKe = new System.Windows.Forms.TabPage();
            this.lblID = new System.Windows.Forms.Label();
            this.IDnl = new System.Windows.Forms.TextBox();
            this.lblTenNL = new System.Windows.Forms.Label();
            this.tbTenNL = new System.Windows.Forms.TextBox();
            this.tbSL = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.dGVqlnl = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.tabQL.SuspendLayout();
            this.QLNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVqlnl)).BeginInit();
            this.SuspendLayout();
            // 
            // tabQL
            // 
            this.tabQL.Controls.Add(this.QLDU);
            this.tabQL.Controls.Add(this.QLNL);
            this.tabQL.Controls.Add(this.ThongKe);
            this.tabQL.Location = new System.Drawing.Point(17, 23);
            this.tabQL.Name = "tabQL";
            this.tabQL.SelectedIndex = 0;
            this.tabQL.Size = new System.Drawing.Size(504, 345);
            this.tabQL.TabIndex = 0;
            // 
            // QLDU
            // 
            this.QLDU.Location = new System.Drawing.Point(4, 22);
            this.QLDU.Name = "QLDU";
            this.QLDU.Padding = new System.Windows.Forms.Padding(3);
            this.QLDU.Size = new System.Drawing.Size(327, 203);
            this.QLDU.TabIndex = 0;
            this.QLDU.Text = "Quan Ly Do Uong";
            this.QLDU.UseVisualStyleBackColor = true;
            // 
            // QLNL
            // 
            this.QLNL.Controls.Add(this.btnXoa);
            this.QLNL.Controls.Add(this.btnSua);
            this.QLNL.Controls.Add(this.btnThem);
            this.QLNL.Controls.Add(this.dGVqlnl);
            this.QLNL.Controls.Add(this.tbSL);
            this.QLNL.Controls.Add(this.lblSoLuong);
            this.QLNL.Controls.Add(this.tbGia);
            this.QLNL.Controls.Add(this.lblGia);
            this.QLNL.Controls.Add(this.tbTenNL);
            this.QLNL.Controls.Add(this.lblTenNL);
            this.QLNL.Controls.Add(this.IDnl);
            this.QLNL.Controls.Add(this.lblID);
            this.QLNL.Location = new System.Drawing.Point(4, 22);
            this.QLNL.Name = "QLNL";
            this.QLNL.Padding = new System.Windows.Forms.Padding(3);
            this.QLNL.Size = new System.Drawing.Size(496, 319);
            this.QLNL.TabIndex = 1;
            this.QLNL.Text = "Quan ly nguyen lieu";
            this.QLNL.UseVisualStyleBackColor = true;
            // 
            // ThongKe
            // 
            this.ThongKe.Location = new System.Drawing.Point(4, 22);
            this.ThongKe.Name = "ThongKe";
            this.ThongKe.Size = new System.Drawing.Size(327, 203);
            this.ThongKe.TabIndex = 2;
            this.ThongKe.Text = "Thong ke";
            this.ThongKe.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(15, 24);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(81, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID Nguyen Lieu";
            // 
            // IDnl
            // 
            this.IDnl.Enabled = false;
            this.IDnl.Location = new System.Drawing.Point(106, 25);
            this.IDnl.Name = "IDnl";
            this.IDnl.Size = new System.Drawing.Size(32, 20);
            this.IDnl.TabIndex = 1;
            // 
            // lblTenNL
            // 
            this.lblTenNL.AutoSize = true;
            this.lblTenNL.Location = new System.Drawing.Point(162, 23);
            this.lblTenNL.Name = "lblTenNL";
            this.lblTenNL.Size = new System.Drawing.Size(83, 13);
            this.lblTenNL.TabIndex = 2;
            this.lblTenNL.Text = "Ten nguyen lieu";
            // 
            // tbTenNL
            // 
            this.tbTenNL.Location = new System.Drawing.Point(251, 25);
            this.tbTenNL.Name = "tbTenNL";
            this.tbTenNL.Size = new System.Drawing.Size(100, 20);
            this.tbTenNL.TabIndex = 3;
            // 
            // tbSL
            // 
            this.tbSL.Location = new System.Drawing.Point(251, 68);
            this.tbSL.Name = "tbSL";
            this.tbSL.Size = new System.Drawing.Size(100, 20);
            this.tbSL.TabIndex = 7;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(162, 66);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(49, 13);
            this.lblSoLuong.TabIndex = 6;
            this.lblSoLuong.Text = "So luong";
            // 
            // tbGia
            // 
            this.tbGia.Location = new System.Drawing.Point(106, 68);
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(32, 20);
            this.tbGia.TabIndex = 5;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(15, 67);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(23, 13);
            this.lblGia.TabIndex = 4;
            this.lblGia.Text = "Gia";
            // 
            // dGVqlnl
            // 
            this.dGVqlnl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVqlnl.Location = new System.Drawing.Point(29, 101);
            this.dGVqlnl.Name = "dGVqlnl";
            this.dGVqlnl.Size = new System.Drawing.Size(240, 150);
            this.dGVqlnl.TabIndex = 8;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(34, 272);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(136, 272);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(237, 272);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 380);
            this.Controls.Add(this.tabQL);
            this.Name = "QuanLy";
            this.Text = "QuanLy";
            this.Load += new System.EventHandler(this.QuanLy_Load);
            this.tabQL.ResumeLayout(false);
            this.QLNL.ResumeLayout(false);
            this.QLNL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVqlnl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabQL;
        private System.Windows.Forms.TabPage QLDU;
        private System.Windows.Forms.TabPage QLNL;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dGVqlnl;
        private System.Windows.Forms.TextBox tbSL;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.TextBox tbTenNL;
        private System.Windows.Forms.Label lblTenNL;
        private System.Windows.Forms.TextBox IDnl;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TabPage ThongKe;
    }
}