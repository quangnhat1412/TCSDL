using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuyenTap2
{
    public partial class Form1 : Form
    {
        QLSV ds = new QLSV();
        QLSVTableAdapters.KHOATableAdapter dapKhoa = new QLSVTableAdapters.KHOATableAdapter();
        QLSVTableAdapters.SINHVIENTableAdapter dapSinhVien = new QLSVTableAdapters.SINHVIENTableAdapter();
        QLSVTableAdapters.KETQUATableAdapter dapKetQua = new QLSVTableAdapters.KETQUATableAdapter();

        BindingSource bs = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            bs.CurrentChanged += Bs_CurrentChanged;
        }

        private void Bs_CurrentChanged(object sender, EventArgs e)
        {
            lblstt.Text = bs.Position + 1 + " / " + bs.Count;
            txttongdiem.Text = TongDiem(txtmasv.Text).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            khoi_tao_du_lieu();
            Khoi_Tao_cbokhoa();
            Lieu_Ket_Dieu_Khien();
            txttongdiem.Text = TongDiem(txtmasv.Text).ToString();
        }

        public double TongDiem(string msv)
        {
            double kq = 0;
            object td = ds.KETQUA.Compute("sum(Diem)", "MaSV = '" + msv + "'");
            if (td == DBNull.Value)
                kq = 0;
            else
                kq = Convert.ToDouble(td);

            return kq;
        }

        private void Lieu_Ket_Dieu_Khien()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox && ctl.Name != "txttongdiem")
                {
                    ctl.DataBindings.Add("text", bs, ctl.Name.Substring(3), true);
                }
                else if (ctl is CheckBox)
                {
                    ctl.DataBindings.Add("checked", bs, ctl.Name.Substring(3), true);
                }
                else if (ctl is DateTimePicker)
                {
                    ctl.DataBindings.Add("value", bs, ctl.Name.Substring(3), true);
                }
                else if (ctl is ComboBox)
                {
                    ctl.DataBindings.Add("selectedvalue", bs, ctl.Name.Substring(3), true);
                }
            }

            txthocbong.DataBindings[0].FormatString = "#,##0 VNĐ";
        }

        private void Khoi_Tao_cbokhoa()
        {
            cbomakh.DisplayMember = "TenKH";
            cbomakh.ValueMember = "MaKH";
            cbomakh.DataSource = ds.KHOA;
        }

        private void khoi_tao_du_lieu()
        {
            dapKhoa.Fill(ds.KHOA);
            dapSinhVien.Fill(ds.SINHVIEN);
            dapKetQua.Fill(ds.KETQUA);

            bs.DataSource = ds;
            bs.DataMember = ds.SINHVIEN.TableName;
        }

    }
}
