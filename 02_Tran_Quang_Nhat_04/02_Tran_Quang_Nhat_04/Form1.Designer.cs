
namespace _02_Tran_Quang_Nhat_04
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.txthosv = new System.Windows.Forms.TextBox();
            this.txtnoisinh = new System.Windows.Forms.TextBox();
            this.chkphai = new System.Windows.Forms.CheckBox();
            this.cbomakh = new System.Windows.Forms.ComboBox();
            this.dtpngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txttongdiem = new System.Windows.Forms.TextBox();
            this.txthocbong = new System.Windows.Forms.TextBox();
            this.txttensv = new System.Windows.Forms.TextBox();
            this.btntruoc = new System.Windows.Forms.Button();
            this.btnsau = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnghi = new System.Windows.Forms.Button();
            this.btnkhong = new System.Windows.Forms.Button();
            this.lblstt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(691, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã SV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ Tên SV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Phái ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày Sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Khoa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tổng Điểm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(378, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 22);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nơi Sinh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(378, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 22);
            this.label9.TabIndex = 1;
            this.label9.Text = "Học Bổng";
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(157, 115);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.ReadOnly = true;
            this.txtmasv.Size = new System.Drawing.Size(518, 28);
            this.txtmasv.TabIndex = 2;
            this.txtmasv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmasv_KeyPress);
            // 
            // txthosv
            // 
            this.txthosv.Location = new System.Drawing.Point(157, 160);
            this.txthosv.Name = "txthosv";
            this.txthosv.Size = new System.Drawing.Size(320, 28);
            this.txthosv.TabIndex = 2;
            this.txthosv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txthosv_KeyPress);
            // 
            // txtnoisinh
            // 
            this.txtnoisinh.Location = new System.Drawing.Point(481, 250);
            this.txtnoisinh.Name = "txtnoisinh";
            this.txtnoisinh.Size = new System.Drawing.Size(194, 28);
            this.txtnoisinh.TabIndex = 2;
            // 
            // chkphai
            // 
            this.chkphai.AutoSize = true;
            this.chkphai.Location = new System.Drawing.Point(157, 206);
            this.chkphai.Name = "chkphai";
            this.chkphai.Size = new System.Drawing.Size(71, 26);
            this.chkphai.TabIndex = 3;
            this.chkphai.Text = "Nam";
            this.chkphai.UseVisualStyleBackColor = true;
            // 
            // cbomakh
            // 
            this.cbomakh.FormattingEnabled = true;
            this.cbomakh.Location = new System.Drawing.Point(157, 295);
            this.cbomakh.Name = "cbomakh";
            this.cbomakh.Size = new System.Drawing.Size(203, 29);
            this.cbomakh.TabIndex = 4;
            // 
            // dtpngaysinh
            // 
            this.dtpngaysinh.CustomFormat = "dd/MM/yyyy";
            this.dtpngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngaysinh.Location = new System.Drawing.Point(157, 250);
            this.dtpngaysinh.Name = "dtpngaysinh";
            this.dtpngaysinh.Size = new System.Drawing.Size(203, 28);
            this.dtpngaysinh.TabIndex = 5;
            // 
            // txttongdiem
            // 
            this.txttongdiem.Location = new System.Drawing.Point(157, 340);
            this.txttongdiem.Name = "txttongdiem";
            this.txttongdiem.ReadOnly = true;
            this.txttongdiem.Size = new System.Drawing.Size(518, 28);
            this.txttongdiem.TabIndex = 2;
            // 
            // txthocbong
            // 
            this.txthocbong.Location = new System.Drawing.Point(481, 295);
            this.txthocbong.Name = "txthocbong";
            this.txthocbong.Size = new System.Drawing.Size(194, 28);
            this.txthocbong.TabIndex = 2;
            this.txthocbong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txthocbong_KeyPress);
            // 
            // txttensv
            // 
            this.txttensv.Location = new System.Drawing.Point(492, 160);
            this.txttensv.Name = "txttensv";
            this.txttensv.Size = new System.Drawing.Size(183, 28);
            this.txttensv.TabIndex = 2;
            this.txttensv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttensv_KeyPress);
            // 
            // btntruoc
            // 
            this.btntruoc.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btntruoc.Location = new System.Drawing.Point(28, 418);
            this.btntruoc.Name = "btntruoc";
            this.btntruoc.Size = new System.Drawing.Size(89, 50);
            this.btntruoc.TabIndex = 6;
            this.btntruoc.Text = "Trước";
            this.btntruoc.UseVisualStyleBackColor = false;
            this.btntruoc.Click += new System.EventHandler(this.btntruoc_Click);
            // 
            // btnsau
            // 
            this.btnsau.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnsau.Location = new System.Drawing.Point(214, 418);
            this.btnsau.Name = "btnsau";
            this.btnsau.Size = new System.Drawing.Size(89, 50);
            this.btnsau.TabIndex = 6;
            this.btnsau.Text = "Sau ";
            this.btnsau.UseVisualStyleBackColor = false;
            this.btnsau.Click += new System.EventHandler(this.btnsau_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnthem.Location = new System.Drawing.Point(307, 418);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(89, 50);
            this.btnthem.TabIndex = 6;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnhuy.Location = new System.Drawing.Point(400, 418);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(89, 50);
            this.btnhuy.TabIndex = 6;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = false;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnghi
            // 
            this.btnghi.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnghi.Location = new System.Drawing.Point(493, 418);
            this.btnghi.Name = "btnghi";
            this.btnghi.Size = new System.Drawing.Size(89, 50);
            this.btnghi.TabIndex = 6;
            this.btnghi.Text = "Ghi ";
            this.btnghi.UseVisualStyleBackColor = false;
            this.btnghi.Click += new System.EventHandler(this.btnghi_Click);
            // 
            // btnkhong
            // 
            this.btnkhong.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnkhong.Location = new System.Drawing.Point(586, 418);
            this.btnkhong.Name = "btnkhong";
            this.btnkhong.Size = new System.Drawing.Size(89, 50);
            this.btnkhong.TabIndex = 6;
            this.btnkhong.Text = "Không";
            this.btnkhong.UseVisualStyleBackColor = false;
            this.btnkhong.Click += new System.EventHandler(this.btnkhong_Click);
            // 
            // lblstt
            // 
            this.lblstt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblstt.Location = new System.Drawing.Point(121, 418);
            this.lblstt.Name = "lblstt";
            this.lblstt.Size = new System.Drawing.Size(89, 50);
            this.lblstt.TabIndex = 1;
            this.lblstt.Text = "STT";
            this.lblstt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(691, 484);
            this.Controls.Add(this.btnkhong);
            this.Controls.Add(this.btnghi);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnsau);
            this.Controls.Add(this.btntruoc);
            this.Controls.Add(this.dtpngaysinh);
            this.Controls.Add(this.cbomakh);
            this.Controls.Add(this.chkphai);
            this.Controls.Add(this.txthocbong);
            this.Controls.Add(this.txtnoisinh);
            this.Controls.Add(this.txttongdiem);
            this.Controls.Add(this.txttensv);
            this.Controls.Add(this.txthosv);
            this.Controls.Add(this.txtmasv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblstt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.TextBox txthosv;
        private System.Windows.Forms.TextBox txtnoisinh;
        private System.Windows.Forms.CheckBox chkphai;
        private System.Windows.Forms.ComboBox cbomakh;
        private System.Windows.Forms.DateTimePicker dtpngaysinh;
        private System.Windows.Forms.TextBox txttongdiem;
        private System.Windows.Forms.TextBox txthocbong;
        private System.Windows.Forms.TextBox txttensv;
        private System.Windows.Forms.Button btntruoc;
        private System.Windows.Forms.Button btnsau;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnghi;
        private System.Windows.Forms.Button btnkhong;
        private System.Windows.Forms.Label lblstt;
    }
}

