namespace ASM_1_NET103_LOITQPH26025.C.GUI.View
{
    partial class QuanLyDiem
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
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_detele = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtg_show = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_diemTb = new System.Windows.Forms.TextBox();
            this.tb_gdtc = new System.Windows.Forms.TextBox();
            this.tb_tin = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.tb_tienganh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_chuyen = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(571, 295);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(94, 29);
            this.btn_update.TabIndex = 15;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_detele
            // 
            this.btn_detele.Location = new System.Drawing.Point(571, 238);
            this.btn_detele.Name = "btn_detele";
            this.btn_detele.Size = new System.Drawing.Size(94, 29);
            this.btn_detele.TabIndex = 14;
            this.btn_detele.Text = "Delete";
            this.btn_detele.UseVisualStyleBackColor = true;
            this.btn_detele.Click += new System.EventHandler(this.btn_detele_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(571, 173);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(94, 29);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "New";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(694, 415);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(94, 29);
            this.btn_new.TabIndex = 12;
            this.btn_new.Text = "Hiển thị";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtg_show);
            this.groupBox3.Location = new System.Drawing.Point(18, 439);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 136);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // dtg_show
            // 
            this.dtg_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_show.Location = new System.Drawing.Point(6, 26);
            this.dtg_show.Name = "dtg_show";
            this.dtg_show.RowHeadersWidth = 51;
            this.dtg_show.RowTemplate.Height = 29;
            this.dtg_show.Size = new System.Drawing.Size(764, 104);
            this.dtg_show.TabIndex = 0;
            this.dtg_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_show_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_diemTb);
            this.groupBox2.Controls.Add(this.tb_gdtc);
            this.groupBox2.Controls.Add(this.tb_tin);
            this.groupBox2.Controls.Add(this.tb_name);
            this.groupBox2.Controls.Add(this.tb_ma);
            this.groupBox2.Controls.Add(this.tb_tienganh);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(18, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 272);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // tb_diemTb
            // 
            this.tb_diemTb.Location = new System.Drawing.Point(338, 134);
            this.tb_diemTb.Name = "tb_diemTb";
            this.tb_diemTb.Size = new System.Drawing.Size(108, 27);
            this.tb_diemTb.TabIndex = 13;
            // 
            // tb_gdtc
            // 
            this.tb_gdtc.Location = new System.Drawing.Point(137, 218);
            this.tb_gdtc.Name = "tb_gdtc";
            this.tb_gdtc.Size = new System.Drawing.Size(154, 27);
            this.tb_gdtc.TabIndex = 12;
            // 
            // tb_tin
            // 
            this.tb_tin.Location = new System.Drawing.Point(137, 173);
            this.tb_tin.Name = "tb_tin";
            this.tb_tin.Size = new System.Drawing.Size(154, 27);
            this.tb_tin.TabIndex = 11;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(137, 31);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(154, 27);
            this.tb_name.TabIndex = 10;
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(137, 79);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(154, 27);
            this.tb_ma.TabIndex = 9;
            // 
            // tb_tienganh
            // 
            this.tb_tienganh.Location = new System.Drawing.Point(137, 127);
            this.tb_tienganh.Name = "tb_tienganh";
            this.tb_tienganh.Size = new System.Drawing.Size(154, 27);
            this.tb_tienganh.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(352, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Điểm TB : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Giáo dục TC : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tin Học : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tiếng Anh : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã SV :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và tên : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quản Lý Điểm Sinh Viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_timkiem);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(120, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 91);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(119, 35);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(296, 27);
            this.tb_timkiem.TabIndex = 4;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(451, 35);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(94, 29);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            this.btn_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn_search_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm : ";
            // 
            // btn_chuyen
            // 
            this.btn_chuyen.Location = new System.Drawing.Point(556, 353);
            this.btn_chuyen.Name = "btn_chuyen";
            this.btn_chuyen.Size = new System.Drawing.Size(123, 29);
            this.btn_chuyen.TabIndex = 16;
            this.btn_chuyen.Text = "Chuyển Form";
            this.btn_chuyen.UseVisualStyleBackColor = true;
            this.btn_chuyen.Click += new System.EventHandler(this.btn_chuyen_Click);
            // 
            // QuanLyDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 584);
            this.Controls.Add(this.btn_chuyen);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_detele);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuanLyDiem";
            this.Text = "QuanLyDiem";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_update;
        private Button btn_detele;
        private Button btn_save;
        private Button btn_new;
        private GroupBox groupBox3;
        private DataGridView dtg_show;
        private GroupBox groupBox2;
        private TextBox tb_diemTb;
        private TextBox tb_gdtc;
        private TextBox tb_tin;
        private TextBox tb_name;
        private TextBox tb_ma;
        private TextBox tb_tienganh;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox tb_timkiem;
        private Button btn_search;
        private Label label2;
        private Button btn_chuyen;
    }
}