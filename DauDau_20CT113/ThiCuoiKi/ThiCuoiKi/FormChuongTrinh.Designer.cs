namespace pj3
{
    partial class FormChuongTrinh
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnQuanLyTaiKhoan = new System.Windows.Forms.Button();
            this.txtLoaiTk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbtensinhvien = new System.Windows.Forms.TextBox();
            this.txbdiachi = new System.Windows.Forms.TextBox();
            this.txbmasinhvien = new System.Windows.Forms.TextBox();
            this.txbnoisinh = new System.Windows.Forms.TextBox();
            this.dtgvPhoneBook = new System.Windows.Forms.DataGridView();
            this.btnluu = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txbTimkiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhoneBook)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(687, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Đăng Xuất";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(211, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(113, 46);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Gainsboro;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(368, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 46);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Gainsboro;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(46, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 46);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnQuanLyTaiKhoan
            // 
            this.btnQuanLyTaiKhoan.BackColor = System.Drawing.Color.Gainsboro;
            this.btnQuanLyTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnQuanLyTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuanLyTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyTaiKhoan.Location = new System.Drawing.Point(444, 530);
            this.btnQuanLyTaiKhoan.Name = "btnQuanLyTaiKhoan";
            this.btnQuanLyTaiKhoan.Size = new System.Drawing.Size(225, 46);
            this.btnQuanLyTaiKhoan.TabIndex = 6;
            this.btnQuanLyTaiKhoan.Text = "Thông Tin Tài Khoản";
            this.btnQuanLyTaiKhoan.UseVisualStyleBackColor = false;
            this.btnQuanLyTaiKhoan.Click += new System.EventHandler(this.btnQuanLyTaiKhoan_Click);
            // 
            // txtLoaiTk
            // 
            this.txtLoaiTk.BackColor = System.Drawing.Color.Gray;
            this.txtLoaiTk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoaiTk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiTk.ForeColor = System.Drawing.Color.White;
            this.txtLoaiTk.Location = new System.Drawing.Point(542, 19);
            this.txtLoaiTk.Name = "txtLoaiTk";
            this.txtLoaiTk.Size = new System.Drawing.Size(248, 30);
            this.txtLoaiTk.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(453, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(453, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nơi Sinh";
            // 
            // txbtensinhvien
            // 
            this.txbtensinhvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbtensinhvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtensinhvien.Location = new System.Drawing.Point(146, 456);
            this.txbtensinhvien.Name = "txbtensinhvien";
            this.txbtensinhvien.Size = new System.Drawing.Size(267, 27);
            this.txbtensinhvien.TabIndex = 12;
            this.txbtensinhvien.TextChanged += new System.EventHandler(this.txbtensinhvien_TextChanged);
            // 
            // txbdiachi
            // 
            this.txbdiachi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbdiachi.Location = new System.Drawing.Point(531, 487);
            this.txbdiachi.Name = "txbdiachi";
            this.txbdiachi.Size = new System.Drawing.Size(267, 27);
            this.txbdiachi.TabIndex = 13;
            // 
            // txbmasinhvien
            // 
            this.txbmasinhvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbmasinhvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbmasinhvien.Location = new System.Drawing.Point(146, 489);
            this.txbmasinhvien.Name = "txbmasinhvien";
            this.txbmasinhvien.Size = new System.Drawing.Size(267, 27);
            this.txbmasinhvien.TabIndex = 14;
            this.txbmasinhvien.TextChanged += new System.EventHandler(this.txbmasinhvien_TextChanged);
            // 
            // txbnoisinh
            // 
            this.txbnoisinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbnoisinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbnoisinh.Location = new System.Drawing.Point(531, 454);
            this.txbnoisinh.Name = "txbnoisinh";
            this.txbnoisinh.Size = new System.Drawing.Size(267, 27);
            this.txbnoisinh.TabIndex = 15;
            // 
            // dtgvPhoneBook
            // 
            this.dtgvPhoneBook.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvPhoneBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhoneBook.Location = new System.Drawing.Point(20, 130);
            this.dtgvPhoneBook.Name = "dtgvPhoneBook";
            this.dtgvPhoneBook.RowHeadersWidth = 51;
            this.dtgvPhoneBook.RowTemplate.Height = 24;
            this.dtgvPhoneBook.Size = new System.Drawing.Size(778, 294);
            this.dtgvPhoneBook.TabIndex = 16;
            this.dtgvPhoneBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPhoneBook_CellClick);
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.Color.Yellow;
            this.btnluu.FlatAppearance.BorderSize = 0;
            this.btnluu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Location = new System.Drawing.Point(20, 530);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(113, 46);
            this.btnluu.TabIndex = 18;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.White;
            this.btntimkiem.FlatAppearance.BorderSize = 0;
            this.btntimkiem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Location = new System.Drawing.Point(185, 64);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(94, 37);
            this.btntimkiem.TabIndex = 20;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txbTimkiem
            // 
            this.txbTimkiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTimkiem.Location = new System.Drawing.Point(286, 65);
            this.txbTimkiem.Name = "txbTimkiem";
            this.txbTimkiem.Size = new System.Drawing.Size(273, 36);
            this.txbTimkiem.TabIndex = 21;
            this.txbTimkiem.TextChanged += new System.EventHandler(this.txbTimkiem_TextChanged);
            // 
            // FormChuongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(810, 617);
            this.Controls.Add(this.txbTimkiem);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.dtgvPhoneBook);
            this.Controls.Add(this.txbnoisinh);
            this.Controls.Add(this.txbmasinhvien);
            this.Controls.Add(this.txbdiachi);
            this.Controls.Add(this.txbtensinhvien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLoaiTk);
            this.Controls.Add(this.btnQuanLyTaiKhoan);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChuongTrinh";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChuongTrinh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChuongTrinh_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormChuongTrinh_FormClosed);
            this.Load += new System.EventHandler(this.FormChuongTrinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhoneBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnQuanLyTaiKhoan;
        private System.Windows.Forms.TextBox txtLoaiTk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbtensinhvien;
        private System.Windows.Forms.TextBox txbdiachi;
        private System.Windows.Forms.TextBox txbmasinhvien;
        private System.Windows.Forms.TextBox txbnoisinh;
        private System.Windows.Forms.DataGridView dtgvPhoneBook;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txbTimkiem;
    }
}