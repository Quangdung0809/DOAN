
namespace ThietKeSan.View
{
    partial class Frm_ThemHT
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
            this.btn_luu = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbb_loaiphong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_HSTC = new System.Windows.Forms.TextBox();
            this.txt_HTTC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_tenHoatTai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_luu
            // 
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_luu.Image = global::ThietKeSan.Properties.Resources.icons8_add_16;
            this.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luu.Location = new System.Drawing.Point(131, 200);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(100, 30);
            this.btn_luu.TabIndex = 29;
            this.btn_luu.Text = "Thêm hoạt tải";
            this.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbb_loaiphong);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_HSTC);
            this.groupBox2.Controls.Add(this.txt_HTTC);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 54);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(384, 142);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // cbb_loaiphong
            // 
            this.cbb_loaiphong.DropDownWidth = 1000;
            this.cbb_loaiphong.FormattingEnabled = true;
            this.cbb_loaiphong.Items.AddRange(new object[] {
            "Phòng ngủ (Khách sạn, bệnh viện, trại giam)",
            "Phòng ngủ (Nhà ở kiểu căn hộ, nhà trẻ, mẫu giáo, trường học nội trú, nhà nghỉ...)" +
                "",
            "Phòng ăn, phòng khách, buồng vệ sinh, phòng tắm, phòng bida (Nhà ở kiểu căn hộ)",
            "Phòng ăn, phòng khách, buồng vệ sinh, phòng tắm, phòng bida (Nhà trẻ, mẫu giáo, t" +
                "rường học, nhà nghỉ, nhà hưu trí, nhà điều dưỡng, khách sạn, bệnh viện, trại gia" +
                "m, nhà máy)",
            "Bếp, phòng giặt (Nhà ở kiểu căn hộ)",
            "Bếp, phòng giặt (Nhà trẻ, mẫu giáo, trường học, nhà nghỉ, nhà hưu trí, nhà điều d" +
                "ưỡng, khách sạn, bệnh viện, trại giam, nhà máy)",
            "Văn phòng, phòng thí nghiệm (Trụ sở cơ quan, trường học, bệnh viện, ngân hàng, cơ" +
                " sở nghiên cứu khoa học)",
            "Phòng nồi hơi, phòng động cơ và quạt… kể cả khối lượng máy (Nhà cao tầng, cơ quan" +
                ", trường học, nhà nghỉ, nhà hưu trí, nhà điều dưỡng, khách sạn, bệnh viện, trại " +
                "giam, cơ sở nghiên cứu khoa học)",
            "Phòng đọc sách (Có đặt giá sách)",
            "Phòng đọc sách (Không đặt giá sách)",
            "Nhà hàng (Ăn uống, giải khát)",
            "Nhà hàng (Triển lãm, trưng bày, cửa hàng)\t",
            "Phòng hội họp, khiêu vũ, phòng đợi, phòng khán giả, phòng hòa nhạc, phòng thể tha" +
                "o, khán đài (Không có ghế gắn cố định)",
            "Sân khấu",
            "Phòng học (Trường học)",
            "Ban công và lôgia (Tải trọng phân bố đều từng dải trên diện tích rộng 0,8m dọc th" +
                "eo lan can, ban công, lôgia)",
            "Sảnh, phòng giải lao, cầu thang, hành lang thông với các phòng (Phòng ngủ, văn ph" +
                "òng, phòng thí nghiệm, phòng bếp, phòng giặt, phòng vệ sinh, phòng kĩ thuật)",
            "Sảnh, phòng giải lao, cầu thang, hành lang thông với các phòng (Phòng đọc, nhà hà" +
                "ng, phòng hội họp, khiêu vũ, phòng đợi, phòng khán giả, phòng hòa nhạc, phòng th" +
                "ể thao, kho, ban công, lôgia)",
            "Sảnh, phòng giải lao, cầu thang, hành lang thông với các phòng (Sân khấu)\t\t"});
            this.cbb_loaiphong.Location = new System.Drawing.Point(168, 22);
            this.cbb_loaiphong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_loaiphong.Name = "cbb_loaiphong";
            this.cbb_loaiphong.Size = new System.Drawing.Size(208, 21);
            this.cbb_loaiphong.TabIndex = 24;
            this.cbb_loaiphong.SelectedIndexChanged += new System.EventHandler(this.cbb_loaiphong_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Loại Phòng";
            // 
            // txt_HSTC
            // 
            this.txt_HSTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HSTC.Location = new System.Drawing.Point(168, 96);
            this.txt_HSTC.Margin = new System.Windows.Forms.Padding(2);
            this.txt_HSTC.Name = "txt_HSTC";
            this.txt_HSTC.Size = new System.Drawing.Size(132, 21);
            this.txt_HSTC.TabIndex = 22;
            this.txt_HSTC.Text = "0";
            // 
            // txt_HTTC
            // 
            this.txt_HTTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HTTC.Location = new System.Drawing.Point(168, 58);
            this.txt_HTTC.Margin = new System.Windows.Forms.Padding(2);
            this.txt_HTTC.Name = "txt_HTTC";
            this.txt_HTTC.ReadOnly = true;
            this.txt_HTTC.Size = new System.Drawing.Size(132, 21);
            this.txt_HTTC.TabIndex = 21;
            this.txt_HTTC.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(309, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "kN/m2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Hệ Số Tin Cậy: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tải Trọng Tiêu Chuẩn:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_tenHoatTai);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(384, 54);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // txt_tenHoatTai
            // 
            this.txt_tenHoatTai.Location = new System.Drawing.Point(168, 21);
            this.txt_tenHoatTai.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tenHoatTai.Name = "txt_tenHoatTai";
            this.txt_tenHoatTai.Size = new System.Drawing.Size(208, 20);
            this.txt_tenHoatTai.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên:";
            // 
            // Frm_ThemHT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 241);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_ThemHT";
            this.Text = "Thêm hoạt tải";
            this.Load += new System.EventHandler(this.Frm_ThemHT_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.ComboBox cbb_loaiphong;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_HSTC;
        private System.Windows.Forms.TextBox txt_HTTC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_tenHoatTai;
        private System.Windows.Forms.Label label1;
    }
}