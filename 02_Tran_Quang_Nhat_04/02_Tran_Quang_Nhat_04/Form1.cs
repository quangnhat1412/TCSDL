using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Tran_Quang_Nhat_04
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
            foreach(Control ctl in this.Controls)
            {
                if(ctl is TextBox && ctl.Name != "txttongdiem")
                {
                    ctl.DataBindings.Add("text", bs, ctl.Name.Substring(3), true);
                }
                else if(ctl is CheckBox)
                {
                    ctl.DataBindings.Add("checked", bs, ctl.Name.Substring(3), true);
                }    
                else if (ctl is DateTimePicker)
                {
                    ctl.DataBindings.Add("value", bs, ctl.Name.Substring(3), true);
                }
                else if(ctl is ComboBox)
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

        private void btntruoc_Click(object sender, EventArgs e)
        {
            if(bs.Position < 1)
            {
                MessageBox.Show("Bạn đang ở mẩu tin đầu tiên");
                return;
            }
            bs.MovePrevious();
        }

        private void btnsau_Click(object sender, EventArgs e)
        {
            if (bs.Position >= bs.Count - 1)
            {
                MessageBox.Show("Bạn đang ở mẩu cuối cùng");
                return;
            }

            bs.MoveNext();
        }

        private void btnkhong_Click(object sender, EventArgs e)
        {
            bs.CancelEdit();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtmasv.ReadOnly = false;
            bs.AddNew();
            txtmasv.Focus();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa sinh viên này? (Y/N)", "Thông báo !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                QLSV.SINHVIENRow rsv = (bs.Current as DataRowView).Row as QLSV.SINHVIENRow;
                if (rsv.GetKETQUARows().Length > 0)
                {
                    MessageBox.Show("không thể xóa được do có dòng liên quan trong KETQUA");
                    return;
                }
                bs.RemoveCurrent();
                int n = dapSinhVien.Update(ds.SINHVIEN);
                if (n > 0)
                {
                    MessageBox.Show("Xóa mẩu tin thành công");
                }
            }
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            if (!txtmasv.ReadOnly) // Ghi sau khi thêm mới ===> kiểm tra khóa chính
            {
                QLSV.SINHVIENRow rsv = ds.SINHVIEN.FindByMaSV(txtmasv.Text);
                if(rsv != null)
                {
                    MessageBox.Show("Trùng Khóa chính, Hãy nhập lại");
                    txtmasv.Focus();
                    return;
                }
            }
            bs.EndEdit();
            int n = dapSinhVien.Update(ds.SINHVIEN);
            if (n > 0)
            {
                MessageBox.Show("Cập nhật thành công");
            }
        }

        private void txthocbong_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự được nhập vào có phải là số không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Nếu không phải số, hủy bỏ sự kiện và không cho nhập ký tự đó
                e.Handled = true;
            }
        }

        private void txttensv_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự được nhập vào có phải là ký tự chữ hoặc khoảng trắng không
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                // Nếu không phải ký tự chữ hoặc khoảng trắng, hủy bỏ sự kiện và không cho nhập ký tự đó
                e.Handled = true;
            }
        }

        private void txtmasv_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự được nhập vào có phải là chữ hoặc số không
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                // Nếu không phải chữ hoặc số, hủy bỏ sự kiện và không cho nhập ký tự đó
                e.Handled = true;
            }
        }

        private void txthosv_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự được nhập vào có phải là ký tự chữ hoặc khoảng trắng không
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                // Nếu không phải ký tự chữ hoặc khoảng trắng, hủy bỏ sự kiện và không cho nhập ký tự đó
                e.Handled = true;
            }   
        }
    }
}
