
namespace ThietKeSan.View
{
    partial class Frm_TaiTrong
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.grb_hoattai = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_Hoattai = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_xoaht = new System.Windows.Forms.Button();
            this.btn_themht = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.grb_tinhtai = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgv_Tinhtai = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_xoatt = new System.Windows.Forms.Button();
            this.btn_Themtt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grb_hoattai.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hoattai)).BeginInit();
            this.panel5.SuspendLayout();
            this.grb_tinhtai.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tinhtai)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 205);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grb_hoattai);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(298, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 205);
            this.panel3.TabIndex = 3;
            // 
            // grb_hoattai
            // 
            this.grb_hoattai.Controls.Add(this.panel4);
            this.grb_hoattai.Controls.Add(this.btn_xoaht);
            this.grb_hoattai.Controls.Add(this.btn_themht);
            this.grb_hoattai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_hoattai.Location = new System.Drawing.Point(0, 0);
            this.grb_hoattai.Name = "grb_hoattai";
            this.grb_hoattai.Size = new System.Drawing.Size(299, 205);
            this.grb_hoattai.TabIndex = 1;
            this.grb_hoattai.TabStop = false;
            this.grb_hoattai.Text = "Hoạt Tải ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv_Hoattai);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(3, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 186);
            this.panel4.TabIndex = 17;
            // 
            // dgv_Hoattai
            // 
            this.dgv_Hoattai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Hoattai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Hoattai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgv_Hoattai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Hoattai.Location = new System.Drawing.Point(0, 0);
            this.dgv_Hoattai.Name = "dgv_Hoattai";
            this.dgv_Hoattai.RowHeadersVisible = false;
            this.dgv_Hoattai.RowHeadersWidth = 51;
            this.dgv_Hoattai.Size = new System.Drawing.Size(209, 186);
            this.dgv_Hoattai.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên tĩnh tải ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "gb (kN/m2)";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // btn_xoaht
            // 
            this.btn_xoaht.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoaht.Image = global::ThietKeSan.Properties.Resources.icons8_remove_16;
            this.btn_xoaht.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoaht.Location = new System.Drawing.Point(218, 99);
            this.btn_xoaht.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoaht.Name = "btn_xoaht";
            this.btn_xoaht.Size = new System.Drawing.Size(70, 30);
            this.btn_xoaht.TabIndex = 16;
            this.btn_xoaht.Text = "Xóa";
            this.btn_xoaht.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoaht.UseVisualStyleBackColor = true;
            this.btn_xoaht.Click += new System.EventHandler(this.btn_xoaht_Click);
            // 
            // btn_themht
            // 
            this.btn_themht.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themht.Image = global::ThietKeSan.Properties.Resources.icons8_add_16;
            this.btn_themht.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themht.Location = new System.Drawing.Point(218, 59);
            this.btn_themht.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_themht.Name = "btn_themht";
            this.btn_themht.Size = new System.Drawing.Size(70, 30);
            this.btn_themht.TabIndex = 14;
            this.btn_themht.Text = "Thêm";
            this.btn_themht.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_themht.UseVisualStyleBackColor = true;
            this.btn_themht.Click += new System.EventHandler(this.btn_themht_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.grb_tinhtai);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(298, 205);
            this.panel5.TabIndex = 2;
            // 
            // grb_tinhtai
            // 
            this.grb_tinhtai.Controls.Add(this.panel6);
            this.grb_tinhtai.Controls.Add(this.btn_xoatt);
            this.grb_tinhtai.Controls.Add(this.btn_Themtt);
            this.grb_tinhtai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_tinhtai.Location = new System.Drawing.Point(0, 0);
            this.grb_tinhtai.Name = "grb_tinhtai";
            this.grb_tinhtai.Size = new System.Drawing.Size(298, 205);
            this.grb_tinhtai.TabIndex = 1;
            this.grb_tinhtai.TabStop = false;
            this.grb_tinhtai.Text = "Tĩnh tải";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgv_Tinhtai);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(3, 16);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(209, 186);
            this.panel6.TabIndex = 17;
            // 
            // dgv_Tinhtai
            // 
            this.dgv_Tinhtai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Tinhtai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tinhtai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv_Tinhtai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Tinhtai.Location = new System.Drawing.Point(0, 0);
            this.dgv_Tinhtai.Name = "dgv_Tinhtai";
            this.dgv_Tinhtai.RowHeadersVisible = false;
            this.dgv_Tinhtai.RowHeadersWidth = 51;
            this.dgv_Tinhtai.Size = new System.Drawing.Size(209, 186);
            this.dgv_Tinhtai.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên tĩnh tải ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "gb (kN/m2)";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // btn_xoatt
            // 
            this.btn_xoatt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoatt.Image = global::ThietKeSan.Properties.Resources.icons8_remove_16;
            this.btn_xoatt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoatt.Location = new System.Drawing.Point(218, 99);
            this.btn_xoatt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoatt.Name = "btn_xoatt";
            this.btn_xoatt.Size = new System.Drawing.Size(70, 30);
            this.btn_xoatt.TabIndex = 16;
            this.btn_xoatt.Text = "Xóa";
            this.btn_xoatt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoatt.UseVisualStyleBackColor = true;
            this.btn_xoatt.Click += new System.EventHandler(this.btn_xoatt_Click);
            // 
            // btn_Themtt
            // 
            this.btn_Themtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Themtt.Image = global::ThietKeSan.Properties.Resources.icons8_add_16;
            this.btn_Themtt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Themtt.Location = new System.Drawing.Point(218, 59);
            this.btn_Themtt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Themtt.Name = "btn_Themtt";
            this.btn_Themtt.Size = new System.Drawing.Size(70, 30);
            this.btn_Themtt.TabIndex = 14;
            this.btn_Themtt.Text = "Thêm";
            this.btn_Themtt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Themtt.UseVisualStyleBackColor = true;
            this.btn_Themtt.Click += new System.EventHandler(this.btn_Themtt_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Huy);
            this.panel2.Controls.Add(this.btn_Luu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 41);
            this.panel2.TabIndex = 1;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Image = global::ThietKeSan.Properties.Resources.icons8_cancel_16;
            this.btn_Huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Huy.Location = new System.Drawing.Point(310, 5);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(70, 30);
            this.btn_Huy.TabIndex = 19;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Image = global::ThietKeSan.Properties.Resources.icons8_save_16;
            this.btn_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Luu.Location = new System.Drawing.Point(218, 5);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(70, 30);
            this.btn_Luu.TabIndex = 18;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // Frm_TaiTrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 246);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_TaiTrong";
            this.Text = "Thêm tải trọng";
            this.Load += new System.EventHandler(this.Frm_TaiTrong_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.grb_hoattai.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hoattai)).EndInit();
            this.panel5.ResumeLayout(false);
            this.grb_tinhtai.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tinhtai)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.GroupBox grb_hoattai;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.DataGridView dgv_Hoattai;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        internal System.Windows.Forms.Button btn_xoaht;
        internal System.Windows.Forms.Button btn_themht;
        public System.Windows.Forms.GroupBox grb_tinhtai;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.DataGridView dgv_Tinhtai;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        internal System.Windows.Forms.Button btn_xoatt;
        internal System.Windows.Forms.Button btn_Themtt;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Button btn_Huy;
        internal System.Windows.Forms.Button btn_Luu;
    }
}