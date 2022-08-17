namespace Project_Template_SM22_Csharp.Views
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
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.cbx_GioiTinh = new System.Windows.Forms.ComboBox();
            this.cbx_hoatDong = new System.Windows.Forms.CheckBox();
            this.cbx_KhongHoatDong = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_Loc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gioi tinh";
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(82, 81);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(230, 27);
            this.txt_ten.TabIndex = 3;
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(82, 35);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(230, 27);
            this.txt_ma.TabIndex = 4;
            // 
            // cbx_GioiTinh
            // 
            this.cbx_GioiTinh.FormattingEnabled = true;
            this.cbx_GioiTinh.Location = new System.Drawing.Point(109, 135);
            this.cbx_GioiTinh.Name = "cbx_GioiTinh";
            this.cbx_GioiTinh.Size = new System.Drawing.Size(203, 28);
            this.cbx_GioiTinh.TabIndex = 5;
            // 
            // cbx_hoatDong
            // 
            this.cbx_hoatDong.AutoSize = true;
            this.cbx_hoatDong.Location = new System.Drawing.Point(557, 53);
            this.cbx_hoatDong.Name = "cbx_hoatDong";
            this.cbx_hoatDong.Size = new System.Drawing.Size(103, 24);
            this.cbx_hoatDong.TabIndex = 6;
            this.cbx_hoatDong.Text = "Hoat dong";
            this.cbx_hoatDong.UseVisualStyleBackColor = true;
            this.cbx_hoatDong.CheckedChanged += new System.EventHandler(this.cbx_hoatDong_CheckedChanged);
            // 
            // cbx_KhongHoatDong
            // 
            this.cbx_KhongHoatDong.AutoSize = true;
            this.cbx_KhongHoatDong.Location = new System.Drawing.Point(557, 83);
            this.cbx_KhongHoatDong.Name = "cbx_KhongHoatDong";
            this.cbx_KhongHoatDong.Size = new System.Drawing.Size(147, 24);
            this.cbx_KhongHoatDong.TabIndex = 7;
            this.cbx_KhongHoatDong.Text = "Khong hoat dong";
            this.cbx_KhongHoatDong.UseVisualStyleBackColor = true;
            this.cbx_KhongHoatDong.CheckedChanged += new System.EventHandler(this.cbx_KhongHoatDong_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(800, 210);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(557, 207);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(193, 27);
            this.txt_TimKiem.TabIndex = 9;
            this.txt_TimKiem.Text = "tìm kiếm...";
            this.txt_TimKiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_TimKiem_MouseClick);
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            this.txt_TimKiem.Leave += new System.EventHandler(this.txt_TimKiem_Leave);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(445, 160);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(94, 29);
            this.btn_them.TabIndex = 10;
            this.btn_them.Text = "Them";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(557, 160);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(94, 29);
            this.btn_Sua.TabIndex = 11;
            this.btn_Sua.Text = "Sua";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(670, 160);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(94, 29);
            this.btn_xoa.TabIndex = 12;
            this.btn_xoa.Text = "Xoa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Trang thai";
            // 
            // cbx_Loc
            // 
            this.cbx_Loc.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbx_Loc.FormattingEnabled = true;
            this.cbx_Loc.Location = new System.Drawing.Point(109, 190);
            this.cbx_Loc.Name = "cbx_Loc";
            this.cbx_Loc.Size = new System.Drawing.Size(203, 28);
            this.cbx_Loc.TabIndex = 14;
            this.cbx_Loc.Text = "Lọc giới tính";
            this.cbx_Loc.SelectedIndexChanged += new System.EventHandler(this.cbx_Loc_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Loc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbx_Loc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbx_KhongHoatDong);
            this.Controls.Add(this.cbx_hoatDong);
            this.Controls.Add(this.cbx_GioiTinh);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.ComboBox cbx_GioiTinh;
        private System.Windows.Forms.CheckBox cbx_hoatDong;
        private System.Windows.Forms.CheckBox cbx_KhongHoatDong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_Loc;
        private System.Windows.Forms.Label label5;
    }
}