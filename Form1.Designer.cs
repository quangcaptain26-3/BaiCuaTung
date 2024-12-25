namespace NguyenBaTung98880
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
            this.components = new System.ComponentModel.Container();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.MaNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguoiDaiDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDauHopTac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_NguoiDaiDien = new System.Windows.Forms.TextBox();
            this.txt_EMAIL = new System.Windows.Forms.TextBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.txt_TenNCC = new System.Windows.Forms.TextBox();
            this.txt_MaNCC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chb4 = new System.Windows.Forms.CheckBox();
            this.chb3 = new System.Windows.Forms.CheckBox();
            this.chb2 = new System.Windows.Forms.CheckBox();
            this.chb1 = new System.Windows.Forms.CheckBox();
            this.btTK = new System.Windows.Forms.Button();
            this.tb_nguoidaidien = new System.Windows.Forms.TextBox();
            this.tbTKTSP = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbTKMSP = new System.Windows.Forms.TextBox();
            this.dtk_Hoptac = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhaCungCap,
            this.TenNhaCungCap,
            this.Email,
            this.NguoiDaiDien,
            this.NgayBatDauHopTac});
            this.dgv.Location = new System.Drawing.Point(8, 284);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 82;
            this.dgv.RowTemplate.Height = 33;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1171, 365);
            this.dgv.TabIndex = 0;
            this.dgv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_RowEnter);
            // 
            // MaNhaCungCap
            // 
            this.MaNhaCungCap.DataPropertyName = "MaNhaCungCap";
            this.MaNhaCungCap.HeaderText = "Mã Nhà Cung Cấp";
            this.MaNhaCungCap.MinimumWidth = 6;
            this.MaNhaCungCap.Name = "MaNhaCungCap";
            this.MaNhaCungCap.Width = 125;
            // 
            // TenNhaCungCap
            // 
            this.TenNhaCungCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNhaCungCap.DataPropertyName = "TenNhaCungCap";
            this.TenNhaCungCap.HeaderText = "Tên Nhà Cung Cấp";
            this.TenNhaCungCap.MinimumWidth = 6;
            this.TenNhaCungCap.Name = "TenNhaCungCap";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 200;
            // 
            // NguoiDaiDien
            // 
            this.NguoiDaiDien.DataPropertyName = "NguoiDaiDien";
            this.NguoiDaiDien.HeaderText = "Người đại diện";
            this.NguoiDaiDien.MinimumWidth = 6;
            this.NguoiDaiDien.Name = "NguoiDaiDien";
            this.NguoiDaiDien.Width = 200;
            // 
            // NgayBatDauHopTac
            // 
            this.NgayBatDauHopTac.DataPropertyName = "NgayBatDauHopTac";
            this.NgayBatDauHopTac.HeaderText = "Ngày bắt đầu hợp tác";
            this.NgayBatDauHopTac.MinimumWidth = 6;
            this.NgayBatDauHopTac.Name = "NgayBatDauHopTac";
            this.NgayBatDauHopTac.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtk_Hoptac);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_NguoiDaiDien);
            this.groupBox1.Controls.Add(this.txt_EMAIL);
            this.groupBox1.Controls.Add(this.btXoa);
            this.groupBox1.Controls.Add(this.btSua);
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Controls.Add(this.txt_TenNCC);
            this.groupBox1.Controls.Add(this.txt_MaNCC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(607, 272);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày bắt đầu hợp tác";
            // 
            // txt_NguoiDaiDien
            // 
            this.txt_NguoiDaiDien.Location = new System.Drawing.Point(165, 138);
            this.txt_NguoiDaiDien.Margin = new System.Windows.Forms.Padding(2);
            this.txt_NguoiDaiDien.Name = "txt_NguoiDaiDien";
            this.txt_NguoiDaiDien.Size = new System.Drawing.Size(222, 22);
            this.txt_NguoiDaiDien.TabIndex = 5;
            // 
            // txt_EMAIL
            // 
            this.txt_EMAIL.Location = new System.Drawing.Point(165, 106);
            this.txt_EMAIL.Margin = new System.Windows.Forms.Padding(2);
            this.txt_EMAIL.Name = "txt_EMAIL";
            this.txt_EMAIL.Size = new System.Drawing.Size(222, 22);
            this.txt_EMAIL.TabIndex = 4;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(280, 211);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(73, 38);
            this.btXoa.TabIndex = 2;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(190, 211);
            this.btSua.Margin = new System.Windows.Forms.Padding(2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(73, 38);
            this.btSua.TabIndex = 2;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(92, 211);
            this.btThem.Margin = new System.Windows.Forms.Padding(2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(73, 38);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // txt_TenNCC
            // 
            this.txt_TenNCC.Location = new System.Drawing.Point(165, 68);
            this.txt_TenNCC.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TenNCC.Name = "txt_TenNCC";
            this.txt_TenNCC.Size = new System.Drawing.Size(222, 22);
            this.txt_TenNCC.TabIndex = 1;
            // 
            // txt_MaNCC
            // 
            this.txt_MaNCC.Location = new System.Drawing.Point(165, 36);
            this.txt_MaNCC.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MaNCC.Name = "txt_MaNCC";
            this.txt_MaNCC.Size = new System.Drawing.Size(222, 22);
            this.txt_MaNCC.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Người đại diện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhà cung cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhà cung cấp";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chb4);
            this.groupBox2.Controls.Add(this.chb3);
            this.groupBox2.Controls.Add(this.chb2);
            this.groupBox2.Controls.Add(this.chb1);
            this.groupBox2.Controls.Add(this.btTK);
            this.groupBox2.Controls.Add(this.tb_nguoidaidien);
            this.groupBox2.Controls.Add(this.tbTKTSP);
            this.groupBox2.Controls.Add(this.tbemail);
            this.groupBox2.Controls.Add(this.tbTKMSP);
            this.groupBox2.Location = new System.Drawing.Point(619, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(560, 272);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // chb4
            // 
            this.chb4.AutoSize = true;
            this.chb4.Location = new System.Drawing.Point(17, 144);
            this.chb4.Margin = new System.Windows.Forms.Padding(2);
            this.chb4.Name = "chb4";
            this.chb4.Size = new System.Drawing.Size(116, 20);
            this.chb4.TabIndex = 2;
            this.chb4.Text = "Người đại diện";
            this.chb4.UseVisualStyleBackColor = true;
            // 
            // chb3
            // 
            this.chb3.AutoSize = true;
            this.chb3.Location = new System.Drawing.Point(17, 109);
            this.chb3.Margin = new System.Windows.Forms.Padding(2);
            this.chb3.Name = "chb3";
            this.chb3.Size = new System.Drawing.Size(63, 20);
            this.chb3.TabIndex = 2;
            this.chb3.Text = "Email";
            this.chb3.UseVisualStyleBackColor = true;
            // 
            // chb2
            // 
            this.chb2.AutoSize = true;
            this.chb2.Location = new System.Drawing.Point(17, 71);
            this.chb2.Margin = new System.Windows.Forms.Padding(2);
            this.chb2.Name = "chb2";
            this.chb2.Size = new System.Drawing.Size(136, 20);
            this.chb2.TabIndex = 2;
            this.chb2.Text = "Tên nhà cung cấp";
            this.chb2.UseVisualStyleBackColor = true;
            // 
            // chb1
            // 
            this.chb1.AutoSize = true;
            this.chb1.Location = new System.Drawing.Point(17, 40);
            this.chb1.Margin = new System.Windows.Forms.Padding(2);
            this.chb1.Name = "chb1";
            this.chb1.Size = new System.Drawing.Size(131, 20);
            this.chb1.TabIndex = 2;
            this.chb1.Text = "Mã nhà cung cấp";
            this.chb1.UseVisualStyleBackColor = true;
            // 
            // btTK
            // 
            this.btTK.Location = new System.Drawing.Point(209, 216);
            this.btTK.Margin = new System.Windows.Forms.Padding(2);
            this.btTK.Name = "btTK";
            this.btTK.Size = new System.Drawing.Size(114, 33);
            this.btTK.TabIndex = 0;
            this.btTK.Text = "Tìm kiếm";
            this.btTK.UseVisualStyleBackColor = true;
            this.btTK.Click += new System.EventHandler(this.btTK_Click);
            // 
            // tb_nguoidaidien
            // 
            this.tb_nguoidaidien.Location = new System.Drawing.Point(183, 138);
            this.tb_nguoidaidien.Margin = new System.Windows.Forms.Padding(2);
            this.tb_nguoidaidien.Name = "tb_nguoidaidien";
            this.tb_nguoidaidien.Size = new System.Drawing.Size(222, 22);
            this.tb_nguoidaidien.TabIndex = 1;
            // 
            // tbTKTSP
            // 
            this.tbTKTSP.Location = new System.Drawing.Point(183, 71);
            this.tbTKTSP.Margin = new System.Windows.Forms.Padding(2);
            this.tbTKTSP.Name = "tbTKTSP";
            this.tbTKTSP.Size = new System.Drawing.Size(222, 22);
            this.tbTKTSP.TabIndex = 1;
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(183, 106);
            this.tbemail.Margin = new System.Windows.Forms.Padding(2);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(222, 22);
            this.tbemail.TabIndex = 1;
            // 
            // tbTKMSP
            // 
            this.tbTKMSP.Location = new System.Drawing.Point(183, 34);
            this.tbTKMSP.Margin = new System.Windows.Forms.Padding(2);
            this.tbTKMSP.Name = "tbTKMSP";
            this.tbTKMSP.Size = new System.Drawing.Size(222, 22);
            this.tbTKMSP.TabIndex = 1;
            // 
            // dtk_Hoptac
            // 
            this.dtk_Hoptac.Location = new System.Drawing.Point(165, 171);
            this.dtk_Hoptac.Name = "dtk_Hoptac";
            this.dtk_Hoptac.Size = new System.Drawing.Size(200, 22);
            this.dtk_Hoptac.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 657);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txt_MaNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btTK;
        private System.Windows.Forms.TextBox txt_TenNCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chb4;
        private System.Windows.Forms.CheckBox chb3;
        private System.Windows.Forms.CheckBox chb2;
        private System.Windows.Forms.CheckBox chb1;
        private System.Windows.Forms.TextBox tb_nguoidaidien;
        private System.Windows.Forms.TextBox tbTKTSP;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbTKMSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_NguoiDaiDien;
        private System.Windows.Forms.TextBox txt_EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguoiDaiDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDauHopTac;
        private System.Windows.Forms.DateTimePicker dtk_Hoptac;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

