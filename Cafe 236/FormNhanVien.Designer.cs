
namespace Cafe_236
{
    partial class FormNhanVien
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
            this.tabNhanVien = new System.Windows.Forms.TabControl();
            this.tabQLDH = new System.Windows.Forms.TabPage();
            this.tabQLNH = new System.Windows.Forms.TabPage();
            this.dGVqldh = new System.Windows.Forms.DataGridView();
            this.btnThemQLDH = new System.Windows.Forms.Button();
            this.btnSuaQLDH = new System.Windows.Forms.Button();
            this.btnXoaQLDH = new System.Windows.Forms.Button();
            this.tabNhanVien.SuspendLayout();
            this.tabQLDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVqldh)).BeginInit();
            this.SuspendLayout();
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.Controls.Add(this.tabQLDH);
            this.tabNhanVien.Controls.Add(this.tabQLNH);
            this.tabNhanVien.Location = new System.Drawing.Point(28, 27);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.SelectedIndex = 0;
            this.tabNhanVien.Size = new System.Drawing.Size(502, 309);
            this.tabNhanVien.TabIndex = 0;
            // 
            // tabQLDH
            // 
            this.tabQLDH.Controls.Add(this.btnXoaQLDH);
            this.tabQLDH.Controls.Add(this.btnSuaQLDH);
            this.tabQLDH.Controls.Add(this.btnThemQLDH);
            this.tabQLDH.Controls.Add(this.dGVqldh);
            this.tabQLDH.Location = new System.Drawing.Point(4, 22);
            this.tabQLDH.Name = "tabQLDH";
            this.tabQLDH.Padding = new System.Windows.Forms.Padding(3);
            this.tabQLDH.Size = new System.Drawing.Size(494, 283);
            this.tabQLDH.TabIndex = 0;
            this.tabQLDH.Text = "Quan ly don hang";
            this.tabQLDH.UseVisualStyleBackColor = true;
            // 
            // tabQLNH
            // 
            this.tabQLNH.Location = new System.Drawing.Point(4, 22);
            this.tabQLNH.Name = "tabQLNH";
            this.tabQLNH.Padding = new System.Windows.Forms.Padding(3);
            this.tabQLNH.Size = new System.Drawing.Size(494, 283);
            this.tabQLNH.TabIndex = 1;
            this.tabQLNH.Text = "Quan ly nhap hang";
            this.tabQLNH.UseVisualStyleBackColor = true;
            // 
            // dGVqldh
            // 
            this.dGVqldh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVqldh.Location = new System.Drawing.Point(32, 30);
            this.dGVqldh.Name = "dGVqldh";
            this.dGVqldh.Size = new System.Drawing.Size(240, 150);
            this.dGVqldh.TabIndex = 0;
            // 
            // btnThemQLDH
            // 
            this.btnThemQLDH.Location = new System.Drawing.Point(35, 207);
            this.btnThemQLDH.Name = "btnThemQLDH";
            this.btnThemQLDH.Size = new System.Drawing.Size(75, 23);
            this.btnThemQLDH.TabIndex = 1;
            this.btnThemQLDH.Text = "Them";
            this.btnThemQLDH.UseVisualStyleBackColor = true;
            this.btnThemQLDH.Click += new System.EventHandler(this.btnThemQLDH_Click);
            // 
            // btnSuaQLDH
            // 
            this.btnSuaQLDH.Location = new System.Drawing.Point(140, 210);
            this.btnSuaQLDH.Name = "btnSuaQLDH";
            this.btnSuaQLDH.Size = new System.Drawing.Size(75, 23);
            this.btnSuaQLDH.TabIndex = 2;
            this.btnSuaQLDH.Text = "Sua";
            this.btnSuaQLDH.UseVisualStyleBackColor = true;
            // 
            // btnXoaQLDH
            // 
            this.btnXoaQLDH.Location = new System.Drawing.Point(250, 212);
            this.btnXoaQLDH.Name = "btnXoaQLDH";
            this.btnXoaQLDH.Size = new System.Drawing.Size(75, 23);
            this.btnXoaQLDH.TabIndex = 3;
            this.btnXoaQLDH.Text = "Xoa";
            this.btnXoaQLDH.UseVisualStyleBackColor = true;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 365);
            this.Controls.Add(this.tabNhanVien);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.tabNhanVien.ResumeLayout(false);
            this.tabQLDH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVqldh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabQLDH;
        private System.Windows.Forms.TabPage tabQLNH;
        private System.Windows.Forms.TabControl tabNhanVien;
        private System.Windows.Forms.Button btnXoaQLDH;
        private System.Windows.Forms.Button btnSuaQLDH;
        private System.Windows.Forms.Button btnThemQLDH;
        private System.Windows.Forms.DataGridView dGVqldh;
    }
}

