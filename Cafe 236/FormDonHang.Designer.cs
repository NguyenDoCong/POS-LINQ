
namespace Cafe_236
{
    partial class FormDonHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBxTDU = new System.Windows.Forms.ComboBox();
            this.nUDsl = new System.Windows.Forms.NumericUpDown();
            this.dGVdh = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tBtst = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUDsl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVdh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đồ uống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng";
            // 
            // cbBxTDU
            // 
            this.cbBxTDU.FormattingEnabled = true;
            this.cbBxTDU.Location = new System.Drawing.Point(133, 37);
            this.cbBxTDU.Name = "cbBxTDU";
            this.cbBxTDU.Size = new System.Drawing.Size(121, 21);
            this.cbBxTDU.TabIndex = 2;
            // 
            // nUDsl
            // 
            this.nUDsl.Location = new System.Drawing.Point(381, 36);
            this.nUDsl.Name = "nUDsl";
            this.nUDsl.Size = new System.Drawing.Size(120, 20);
            this.nUDsl.TabIndex = 3;
            // 
            // dGVdh
            // 
            this.dGVdh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVdh.Location = new System.Drawing.Point(59, 114);
            this.dGVdh.Name = "dGVdh";
            this.dGVdh.Size = new System.Drawing.Size(240, 150);
            this.dGVdh.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tổng số tiền";
            // 
            // tBtst
            // 
            this.tBtst.Location = new System.Drawing.Point(145, 283);
            this.tBtst.Name = "tBtst";
            this.tBtst.Size = new System.Drawing.Size(100, 20);
            this.tBtst.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(80, 78);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(221, 78);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(372, 78);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnHT
            // 
            this.btnHT.Location = new System.Drawing.Point(384, 148);
            this.btnHT.Name = "btnHT";
            this.btnHT.Size = new System.Drawing.Size(75, 23);
            this.btnHT.TabIndex = 13;
            this.btnHT.Text = "Hoàn thành";
            this.btnHT.UseVisualStyleBackColor = true;
            this.btnHT.Click += new System.EventHandler(this.btnHT_Click);
            // 
            // FormDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 311);
            this.Controls.Add(this.btnHT);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tBtst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dGVdh);
            this.Controls.Add(this.nUDsl);
            this.Controls.Add(this.cbBxTDU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDonHang";
            this.Text = "FormDonHang";
            ((System.ComponentModel.ISupportInitialize)(this.nUDsl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVdh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBxTDU;
        private System.Windows.Forms.NumericUpDown nUDsl;
        private System.Windows.Forms.DataGridView dGVdh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBtst;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHT;
    }
}