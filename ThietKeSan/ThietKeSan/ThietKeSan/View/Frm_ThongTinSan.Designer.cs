
namespace ThietKeSan.View
{
    partial class Frm_ThongTinSan
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_osan = new System.Windows.Forms.DataGridView();
            this.IDSan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbb_hoattai = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbb_tinhtai = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Hs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_L2 = new System.Windows.Forms.TextBox();
            this.txt_L1 = new System.Windows.Forms.TextBox();
            this.txt_tenosan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_chonsan = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_osan)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 450);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv_osan);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 204);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(539, 246);
            this.panel4.TabIndex = 1;
            // 
            // dgv_osan
            // 
            this.dgv_osan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_osan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_osan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSan,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgv_osan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_osan.Location = new System.Drawing.Point(0, 0);
            this.dgv_osan.Name = "dgv_osan";
            this.dgv_osan.RowHeadersVisible = false;
            this.dgv_osan.RowHeadersWidth = 51;
            this.dgv_osan.Size = new System.Drawing.Size(539, 246);
            this.dgv_osan.TabIndex = 45;
            // 
            // IDSan
            // 
            this.IDSan.HeaderText = "ID Sàn";
            this.IDSan.Name = "IDSan";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên ô sàn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Sơ đồ tính";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "L1 (m)";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "L2 (m)";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "L2/L1";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Hs (m)";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ho (m)";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "qb (KN/m2)";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txt_a);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.cbb_hoattai);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.cbb_tinhtai);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txt_Hs);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_L2);
            this.panel3.Controls.Add(this.txt_L1);
            this.panel3.Controls.Add(this.txt_tenosan);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(539, 204);
            this.panel3.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(486, 161);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 15);
            this.label13.TabIndex = 63;
            this.label13.Text = "m";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(486, 115);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 15);
            this.label12.TabIndex = 62;
            this.label12.Text = "kN/m2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(486, 70);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 15);
            this.label11.TabIndex = 61;
            this.label11.Text = "kN/m2";
            // 
            // txt_a
            // 
            this.txt_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_a.Location = new System.Drawing.Point(358, 159);
            this.txt_a.Margin = new System.Windows.Forms.Padding(2);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(120, 21);
            this.txt_a.TabIndex = 59;
            this.txt_a.Text = "0.15";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(276, 161);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 15);
            this.label10.TabIndex = 60;
            this.label10.Text = "a:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(276, 115);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 57;
            this.label9.Text = "Hoạt Tải:";
            // 
            // cbb_hoattai
            // 
            this.cbb_hoattai.FormattingEnabled = true;
            this.cbb_hoattai.Location = new System.Drawing.Point(358, 113);
            this.cbb_hoattai.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_hoattai.Name = "cbb_hoattai";
            this.cbb_hoattai.Size = new System.Drawing.Size(120, 21);
            this.cbb_hoattai.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(276, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 46;
            this.label8.Text = "Tĩnh Tải:";
            // 
            // cbb_tinhtai
            // 
            this.cbb_tinhtai.FormattingEnabled = true;
            this.cbb_tinhtai.Location = new System.Drawing.Point(358, 69);
            this.cbb_tinhtai.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_tinhtai.Name = "cbb_tinhtai";
            this.cbb_tinhtai.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbb_tinhtai.Size = new System.Drawing.Size(120, 21);
            this.cbb_tinhtai.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(230, 161);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 15);
            this.label7.TabIndex = 56;
            this.label7.Text = "m";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(230, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 15);
            this.label6.TabIndex = 55;
            this.label6.Text = "m";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(230, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 15);
            this.label5.TabIndex = 54;
            this.label5.Text = "m";
            // 
            // txt_Hs
            // 
            this.txt_Hs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Hs.Location = new System.Drawing.Point(108, 159);
            this.txt_Hs.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Hs.Name = "txt_Hs";
            this.txt_Hs.Size = new System.Drawing.Size(120, 21);
            this.txt_Hs.TabIndex = 53;
            this.txt_Hs.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 52;
            this.label1.Text = "Hs:";
            // 
            // txt_L2
            // 
            this.txt_L2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_L2.Location = new System.Drawing.Point(108, 113);
            this.txt_L2.Margin = new System.Windows.Forms.Padding(2);
            this.txt_L2.Name = "txt_L2";
            this.txt_L2.Size = new System.Drawing.Size(120, 21);
            this.txt_L2.TabIndex = 51;
            this.txt_L2.Text = "0";
            // 
            // txt_L1
            // 
            this.txt_L1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_L1.Location = new System.Drawing.Point(108, 69);
            this.txt_L1.Margin = new System.Windows.Forms.Padding(2);
            this.txt_L1.Name = "txt_L1";
            this.txt_L1.Size = new System.Drawing.Size(120, 21);
            this.txt_L1.TabIndex = 50;
            this.txt_L1.Text = "0";
            // 
            // txt_tenosan
            // 
            this.txt_tenosan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenosan.Location = new System.Drawing.Point(108, 19);
            this.txt_tenosan.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tenosan.Name = "txt_tenosan";
            this.txt_tenosan.Size = new System.Drawing.Size(120, 21);
            this.txt_tenosan.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 48;
            this.label4.Text = "Cạnh dài:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 49;
            this.label3.Text = "Cạnh ngắn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tên sàn:";
            // 
            // btn_chonsan
            // 
            this.btn_chonsan.BackColor = System.Drawing.Color.White;
            this.btn_chonsan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_chonsan.Image = global::ThietKeSan.Properties.Resources.icons8_select_16;
            this.btn_chonsan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_chonsan.Location = new System.Drawing.Point(12, 12);
            this.btn_chonsan.Name = "btn_chonsan";
            this.btn_chonsan.Size = new System.Drawing.Size(90, 30);
            this.btn_chonsan.TabIndex = 64;
            this.btn_chonsan.Text = "Chọn sàn";
            this.btn_chonsan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_chonsan.UseVisualStyleBackColor = false;
            this.btn_chonsan.Click += new System.EventHandler(this.btn_chonsan_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(107, 20);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(19, 15);
            this.label14.TabIndex = 65;
            this.label14.Text = "ID";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.btn_Remove);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_luu);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.btn_chonsan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 450);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 54);
            this.panel1.TabIndex = 2;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.White;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_refresh.Image = global::ThietKeSan.Properties.Resources.icons8_refresh_16;
            this.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_refresh.Location = new System.Drawing.Point(201, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(80, 30);
            this.btn_refresh.TabIndex = 69;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.White;
            this.btn_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Remove.Image = global::ThietKeSan.Properties.Resources.icons8_remove_16;
            this.btn_Remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Remove.Location = new System.Drawing.Point(287, 12);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(80, 30);
            this.btn_Remove.TabIndex = 68;
            this.btn_Remove.Text = "Xóa sàn";
            this.btn_Remove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Image = global::ThietKeSan.Properties.Resources.icons8_cancel_16;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(459, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 30);
            this.button1.TabIndex = 67;
            this.button1.Text = "Đóng";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.White;
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_luu.Image = global::ThietKeSan.Properties.Resources.icons8_save_16;
            this.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luu.Location = new System.Drawing.Point(373, 12);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(80, 30);
            this.btn_luu.TabIndex = 66;
            this.btn_luu.Text = "Lưu sàn";
            this.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // Frm_ThongTinSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 504);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Frm_ThongTinSan";
            this.Text = "Thông tin sàn";
            this.Load += new System.EventHandler(this.Frm_ThongTinSan_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_osan)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.DataGridView dgv_osan;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txt_a;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox cbb_hoattai;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cbb_tinhtai;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_Hs;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_L2;
        public System.Windows.Forms.TextBox txt_L1;
        public System.Windows.Forms.TextBox txt_tenosan;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btn_chonsan;
        public System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btn_refresh;
    }
}