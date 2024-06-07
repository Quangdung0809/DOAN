
namespace ThietKeSan.View
{
    partial class Frm_ThemLopVatLieu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.txt_hs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tlr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_beday = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_huy);
            this.panel1.Controls.Add(this.btn_Luu);
            this.panel1.Controls.Add(this.txt_hs);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_tlr);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_beday);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_ten);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 161);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "(kN/m3)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "(m)";
            // 
            // btn_huy
            // 
            this.btn_huy.Image = global::ThietKeSan.Properties.Resources.icons8_cancel_16;
            this.btn_huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_huy.Location = new System.Drawing.Point(158, 119);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(60, 30);
            this.btn_huy.TabIndex = 19;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Image = global::ThietKeSan.Properties.Resources.icons8_save_16;
            this.btn_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Luu.Location = new System.Drawing.Point(81, 119);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(60, 30);
            this.btn_Luu.TabIndex = 18;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // txt_hs
            // 
            this.txt_hs.Location = new System.Drawing.Point(108, 86);
            this.txt_hs.Name = "txt_hs";
            this.txt_hs.Size = new System.Drawing.Size(139, 20);
            this.txt_hs.TabIndex = 17;
            this.txt_hs.Text = "1.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Hệ số vượt tải";
            // 
            // txt_tlr
            // 
            this.txt_tlr.Location = new System.Drawing.Point(108, 60);
            this.txt_tlr.Name = "txt_tlr";
            this.txt_tlr.Size = new System.Drawing.Size(139, 20);
            this.txt_tlr.TabIndex = 15;
            this.txt_tlr.Text = "20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Trọng lượng riêng";
            // 
            // txt_beday
            // 
            this.txt_beday.Location = new System.Drawing.Point(108, 34);
            this.txt_beday.Name = "txt_beday";
            this.txt_beday.Size = new System.Drawing.Size(139, 20);
            this.txt_beday.TabIndex = 13;
            this.txt_beday.Text = "0.01";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bề dày";
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(108, 8);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(139, 20);
            this.txt_ten.TabIndex = 11;
            this.txt_ten.Text = "Lớp gạch lát nền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên VL";
            // 
            // Frm_ThemLopVatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 161);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_ThemLopVatLieu";
            this.Text = "Thêm vật liệu";
            this.Load += new System.EventHandler(this.Frm_ThemLopVatLieu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.TextBox txt_hs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tlr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_beday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label label1;
    }
}