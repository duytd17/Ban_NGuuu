using Project_Template_SM22_Csharp.DomainClass;
using Project_Template_SM22_Csharp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_Template_SM22_Csharp.Views
{
    public partial class Form1 : Form
    {
        BanService _banService;

        public Form1()
        {
            InitializeComponent();
            _banService = new BanService();
            LoadData(null);
            LoadGioiTinh();
            LoadLocGioiTinh();
        }

        public void LoadGioiTinh()
        {
            List<string> _lst = new List<string>() { "Nữ" , "Nam" };
            foreach (var x in _lst)
            {
                cbx_GioiTinh.Items.Add(x);
            }
            cbx_GioiTinh.SelectedIndex = 0;
        }

        public void LoadLocGioiTinh()
        {
            List<string> _lst = new List<string>() { "Nam", "Nữ" };
            foreach (var x in _lst)
            {
                cbx_Loc.Items.Add(x);
            }
        }

        /* public void LoadSoTrang()
         {
             for (int i = 0; i <= 200; i++)
             {
                 cmb_SoTrang.Items.Add(i);
             }
             cmb_SoTrang.SelectedIndex = 0;
         }*/
        /* public void LoadSoTrangLoc()
         {
             foreach (var x in _banService.GetBan())
             {
                 cbx_Loc.Items.Add(x.SoTrang);
             }
             cbx_Loc.SelectedIndex = 0;
         }*/

        /*public void LoadMQH()
         {
             foreach(var x in _banService.GetAllMQH())
             {
                 cmb_Mqh.Items.Add(x.Ma + '-' + x.ten);
             }
             cmb_Mqh.SelectedIndex = 0;
         }*/
        public void LoadData(string obj)
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Mã";
            dataGridView1.Columns[1].Name = "Tên";
            dataGridView1.Columns[2].Name = "Giới tính";
            dataGridView1.Columns[3].Name = "Trạng thái";
            dataGridView1.Rows.Clear();
            foreach (var x in _banService.GetBan(obj))
            {
                //var mql = _banService.GetAllMQH().FirstOrDefault(c => c.Id == x.IdMqh);
                dataGridView1.Rows.Add(x.Ma, x.Ten, /*mql.Ma*/(x.GioiTinh == 1 ? "Nam" : "Nữ"), (x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động"));
            }
        }

        
        public Ban GetDataFromGui()
        {
           // MoiQuanHe mqh = _banService.GetAllMQH().FirstOrDefault(c => c.Ma == cmb_MQH.Text);

            return new Ban()
            {
                Ma = txt_ma.Text,
                Ten = txt_ten.Text,
               /* MoiQuanHes = mqh,
                IdMqh = mqh.Id*/
                GioiTinh = cbx_GioiTinh.SelectedIndex,
                TrangThai = (cbx_hoatDong.Checked == true ? 1 : 0)
            };
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_banService.AddBan(GetDataFromGui()));
            LoadData(null);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            MessageBox.Show(_banService.UpdateBan(temp));
            LoadData(null);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_banService.DeleteBan(GetDataFromGui()));
            LoadData(null);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1) return;
            txt_ma.Text = Convert.ToString(dataGridView1.Rows[rd].Cells[0].Value);
            txt_ten.Text = Convert.ToString(dataGridView1.Rows[rd].Cells[1].Value);
            //cmb_MQH.SelectedIndex = cmb_MQH.FindStringExact(_banService.GetAllMQH().FirstOrDefault(c => c.Id == phim.IdMqh).Ma.ToString());

            cbx_GioiTinh.Text = Convert.ToString(dataGridView1.Rows[rd].Cells[2].Value);
            cbx_hoatDong.Checked = Convert.ToString(dataGridView1.Rows[rd].Cells[3].Value) == "Hoạt động";
            cbx_KhongHoatDong.Checked = Convert.ToString(dataGridView1.Rows[rd].Cells[3].Value) == "Không hoạt động";
        }

        private void cbx_hoatDong_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_hoatDong.Checked == true)
            {
                cbx_KhongHoatDong.Checked = false;
            }
        }

        private void cbx_KhongHoatDong_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_KhongHoatDong.Checked == true)
            {
                cbx_hoatDong.Checked = false;
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadData(txt_TimKiem.Text);

        }

        
        private void txt_TimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txt_TimKiem.Text = "";

        }

        private void txt_TimKiem_Leave(object sender, EventArgs e)
        {
            txt_TimKiem.Text = "Tìm kiếm...";
            LoadData(null);
        }

        public void LocNam()
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Ma";
            dataGridView1.Columns[1].Name = "Ten";
            dataGridView1.Columns[2].Name = "Gia";
            dataGridView1.Columns[3].Name = "Trang thai";
            dataGridView1.Rows.Clear();
            foreach (var x in _banService.GetBan().Where(c => c.GioiTinh == 1 ? true : false))
            {
                dataGridView1.Rows.Add(x.Ma, x.Ten, (x.GioiTinh == 1 ? "Nam" :"Nữ"), (x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động"));
            }
        }

        public void LocNu()
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Ma";
            dataGridView1.Columns[1].Name = "Ten";
            dataGridView1.Columns[2].Name = "Gia";
            dataGridView1.Columns[3].Name = "Trang thai";
            dataGridView1.Rows.Clear();
            foreach (var x in _banService.GetBan().Where(c => c.GioiTinh == 0 ? true : false))
            {
                dataGridView1.Rows.Add(x.Ma, x.Ten, (x.GioiTinh == 1 ? "Nam" : "Nữ"), (x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động"));
            }
        }

        private void cbx_Loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Loc.Text == "Nam")
            {
                LocNam();
            }
            if (cbx_Loc.Text == "Nữ")
            {
                LocNu();
            }
        }

        
    }
}
