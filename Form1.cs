using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace NguyenBaTung98880
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            load();
        
        }
        Boolean checkNULL()
        {
            errorProvider1.Clear();
            if (txt_MaNCC.Text.Trim(' ') == "")
            {
                errorProvider1.SetError(txt_MaNCC, "Chưa điền mã");
                return false;
            }
            if (txt_TenNCC.Text.Trim(' ') == "")
            {
                errorProvider1.SetError(txt_TenNCC, "Chưa điền mã");
                return false;
            }
            if (txt_EMAIL.Text.Trim(' ') == "")
            {
                errorProvider1.SetError(txt_EMAIL, "Chưa điền mã");
                return false;
            }
            if (txt_NguoiDaiDien.Text.Trim(' ') == "")
            {
                errorProvider1.SetError(txt_NguoiDaiDien, "Chưa điền mã");
                return false;
            }
            if (dtk_Hoptac.Text.Trim(' ') == "")
            {
                errorProvider1.SetError(dtk_Hoptac, "Chưa điền mã");
                return false;
            }
            return true;
        }
        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNCC.Text = dgv.Rows[e.RowIndex].Cells["MaNhaCungCap"].Value.ToString();
            txt_TenNCC.Text = dgv.Rows[e.RowIndex].Cells["TenNhaCungCap"].Value.ToString();
            txt_EMAIL.Text = dgv.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            txt_NguoiDaiDien.Text = dgv.Rows[e.RowIndex].Cells["NguoiDaiDien"].Value.ToString();
            dtk_Hoptac.Text = dgv.Rows[e.RowIndex].Cells["NgayBatDauHopTac"].Value.ToString();
        }
        private void load()
        {
            dgv.DataSource = Database.Query("SELECT MaNhaCungCap, TenNhaCungCap, Email, NguoiDaiDien, NgayBatDauHopTac FROM NhaCungCap_8");
            btSua.Enabled = btXoa.Enabled = dgv.Rows.Count > 0;
        }


        private void btThem_Click(object sender, EventArgs e)
        {
            if (checkNULL())
            {
                string sql = "EXEC ThemNCC @MaNhaCungCap, @TenNhaCungCap, @Email, @NguoiDaiDien, @NgayBatDauHopTac";
                Dictionary<string, object> dic = new Dictionary<string, object>();
                dic.Add("@MaNhaCungCap", txt_MaNCC.Text);
                dic.Add("@TenNhaCungCap", txt_TenNCC.Text);
                dic.Add("@Email", txt_EMAIL.Text);
                dic.Add("@NguoiDaiDien", txt_NguoiDaiDien.Text);
                dic.Add("@NgayBatDauHopTac", dtk_Hoptac.Value);

                try
                {
                    Database.Execute(sql, dic);
                    load();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            if (checkNULL())
            {
                try 
                {
                Dictionary<string, object> dic = new Dictionary<string, object>();
                dic.Add("@MaNhaCungCap", (dgv.CurrentRow.Cells["MaNhaCungCap"].Value));
                dic.Add("@TenNhaCungCap", txt_TenNCC.Text);
                dic.Add("@Email", txt_EMAIL.Text);
                dic.Add("@NguoiDaiDien", txt_NguoiDaiDien.Text);
                dic.Add("@NgayBatDauHopTac", dtk_Hoptac.Value);
                string sql = "EXEC SuaNCC @MaNhaCungCap, @TenNhaCungCap, @Email, @NguoiDaiDien, @NgayBatDauHopTac";
               
                    Database.Execute(sql, dic);
                    load();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string sql = "EXEC XoaNCC @MaNhaCungCap";
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("@MaNhaCungCap", (dgv.CurrentRow.Cells["MaNhaCungCap"].Value));
            try
            {
                Database.Execute(sql, dic);
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btTK_Click(object sender, EventArgs e)
        {
            string sql = "select * from TimKiemNCC(@MaNhaCungCap, @TenNhaCungCap, @Email, @NguoiDaiDien)";
            Dictionary<string,object> dic = new Dictionary<string,object>();
            if (chb1.Checked)
            {
                dic.Add("@MaNhaCungCap", tbTKMSP.Text);
            } else
            {
                dic.Add("@MaNhaCungCap", DBNull.Value);
            }
            if (chb2.Checked)
            {
                dic.Add("@TenNhaCungCap", tbTKTSP.Text);
            }
            else
            {
                dic.Add("@TenNhaCungCap", DBNull.Value);
            }
            if (chb3.Checked)
            {
                dic.Add("@Email", tbemail.Text);
            }
            else
            {
                dic.Add("@Email", DBNull.Value);
            }
            if (chb4.Checked)
            {
                dic.Add("@NguoiDaiDien", tb_nguoidaidien.Text);
            }
            else
            {
                dic.Add("@NguoiDaiDien", DBNull.Value);
            }
            dgv.DataSource = Database.Query(sql, dic);
            btSua.Enabled = btXoa.Enabled = dgv.Rows.Count > 0;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
