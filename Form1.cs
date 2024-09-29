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
    public partial class Form1 : Form
    {
     
        private Form2 form2; // Khai báo biến form2
        private bool isEditing = false;
        public string MSNV { get; private set; }
        public string HoTen { get; private set; }
        public string LuongCB { get; private set; }
        // Khai báo biến isEditing
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
        }
        public Form1(Form2 form2)
        {
            InitializeComponent();
            this.form2 = form2;

        }
        public Form1 (string MSNV, string HoTen, string LuongCB, Form2 form2)
        {
            InitializeComponent();
            this.form2 = form2;


            // Điền thông tin vào form
            txtMSNV.Text = MSNV;
            txtHoTen.Text = HoTen;
            txtLuongCB.Text = LuongCB;
            isEditing = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
                MSNV = txtMSNV.Text;
                HoTen = txtHoTen.Text;
                LuongCB = txtLuongCB.Text;

                // Kiểm tra HoTen để đảm bảo không chứa số
                if (System.Text.RegularExpressions.Regex.IsMatch(HoTen, @"\d"))
                {
                    MessageBox.Show("Tên không được chứa số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra LuongCB để đảm bảo chỉ chứa ký tự số
                if (!System.Text.RegularExpressions.Regex.IsMatch(LuongCB, @"^\d+$"))
                {
                    MessageBox.Show("Lương chỉ được chứa ký tự số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (isEditing)
                {
                    // Chỉ cần đặt kết quả là OK và đóng form
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    // Thêm dòng mới vào Form2 với thông tin từ form1
                    form2.AddRowToDataGridView(MSNV, HoTen, LuongCB);
                    this.DialogResult = DialogResult.OK; // Trả lại OK khi đóng form
                }
                form2.Show();
            }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

