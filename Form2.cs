using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTDatagridview
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void CapNhatDongDaChon(string MSNV, string HoTen, string LuongCB)
        {
            if (dgvNV.SelectedRows.Count > 0)
            {
                dgvNV.SelectedRows[0].Cells[0].Value = MSNV;
                dgvNV.SelectedRows[0].Cells[1].Value = HoTen;
                dgvNV.SelectedRows[0].Cells[2].Value = LuongCB;
            }
        }

        public void AddRowToDataGridView(string MSNV, string HoTen, string LuongCB)
        {
            dgvNV.Rows.Add(MSNV, HoTen, LuongCB);
        }

        private void ptnThem_Click(object sender, EventArgs e)
        {
      
                Form1  nhanVienForm = new Form1(this);
                nhanVienForm.ShowDialog();
            
        }

        private void ptnSua_Click(object sender, EventArgs e)
        {
            if (dgvNV.SelectedRows.Count > 0)
            {
                var selectedRow = dgvNV.SelectedRows[0];

                // Lấy thông tin từ dòng đã chọn
                string MSNV = selectedRow.Cells[0].Value.ToString();
                string HoTen = selectedRow.Cells[1].Value.ToString();
                string LuongCB = selectedRow.Cells[2].Value.ToString();

                // Khởi tạo Form NhanVien và truyền dữ liệu
                Form1 nhanVienForm = new Form1(MSNV, HoTen, LuongCB, this);
                if (nhanVienForm.ShowDialog() == DialogResult.OK) // Sử dụng ShowDialog để chờ người dùng hoàn tất
                {
                    // Cập nhật dòng đã chọn
                    selectedRow.Cells[0].Value = nhanVienForm.MSNV;
                    selectedRow.Cells[1].Value = nhanVienForm.HoTen;
                    selectedRow.Cells[2].Value = nhanVienForm.LuongCB;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ptnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNV.SelectedRows.Count > 0)
            {
                // Xác nhận trước khi xóa
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dgvNV.Rows.Remove(dgvNV.SelectedRows[0]); // Xóa hàng đã chọn
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void ptnDong_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đóng form này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
    }

