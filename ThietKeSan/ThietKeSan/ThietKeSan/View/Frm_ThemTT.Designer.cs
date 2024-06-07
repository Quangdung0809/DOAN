
namespace ThietKeSan.View
{
    partial class Frm_ThemTT
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
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.Btn_import = new System.Windows.Forms.Button();
            this.txt_tenTinhTai = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_LopVatLieu = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LopVatLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_them);
            this.panel1.Controls.Add(this.btn_remove);
            this.panel1.Controls.Add(this.Btn_import);
            this.panel1.Controls.Add(this.txt_tenTinhTai);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.btn_ok);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 60);
            this.panel1.TabIndex = 0;
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_them.Image = global::ThietKeSan.Properties.Resources.icons8_add_16;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(305, 13);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(70, 30);
            this.btn_them.TabIndex = 34;
            this.btn_them.Text = "Thêm ";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_remove.Image = global::ThietKeSan.Properties.Resources.icons8_remove_16;
            this.btn_remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_remove.Location = new System.Drawing.Point(381, 13);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(80, 30);
            this.btn_remove.TabIndex = 33;
            this.btn_remove.Text = "Xóa hàng";
            this.btn_remove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // Btn_import
            // 
            this.Btn_import.Image = global::ThietKeSan.Properties.Resources.icons8_document_16;
            this.Btn_import.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_import.Location = new System.Drawing.Point(14, 12);
            this.Btn_import.Name = "Btn_import";
            this.Btn_import.Size = new System.Drawing.Size(92, 30);
            this.Btn_import.TabIndex = 29;
            this.Btn_import.Text = "Dữ liệu mẫu";
            this.Btn_import.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_import.UseVisualStyleBackColor = true;
            this.Btn_import.Click += new System.EventHandler(this.Btn_import_Click);
            // 
            // txt_tenTinhTai
            // 
            this.txt_tenTinhTai.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txt_tenTinhTai.Location = new System.Drawing.Point(150, 18);
            this.txt_tenTinhTai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenTinhTai.Name = "txt_tenTinhTai";
            this.txt_tenTinhTai.Size = new System.Drawing.Size(70, 20);
            this.txt_tenTinhTai.TabIndex = 31;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(118, 21);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(26, 13);
            this.Label2.TabIndex = 32;
            this.Label2.Text = "Tên";
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_ok.Image = global::ThietKeSan.Properties.Resources.icons8_add_16;
            this.btn_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ok.Location = new System.Drawing.Point(467, 13);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(95, 30);
            this.btn_ok.TabIndex = 30;
            this.btn_ok.Text = "Thêm tĩnh tải";
            this.btn_ok.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_LopVatLieu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 201);
            this.panel2.TabIndex = 1;
            // 
            // dgv_LopVatLieu
            // 
            this.dgv_LopVatLieu.AllowUserToAddRows = false;
            this.dgv_LopVatLieu.AllowUserToDeleteRows = false;
            this.dgv_LopVatLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_LopVatLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LopVatLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgv_LopVatLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_LopVatLieu.Location = new System.Drawing.Point(0, 0);
            this.dgv_LopVatLieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_LopVatLieu.Name = "dgv_LopVatLieu";
            this.dgv_LopVatLieu.ReadOnly = true;
            this.dgv_LopVatLieu.RowHeadersVisible = false;
            this.dgv_LopVatLieu.RowHeadersWidth = 51;
            this.dgv_LopVatLieu.RowTemplate.Height = 24;
            this.dgv_LopVatLieu.Size = new System.Drawing.Size(574, 201);
            this.dgv_LopVatLieu.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "1";
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Các lớp vật liệu";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Bề dày (m)";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Trọng lượng riêng (KN/m3)";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = " Hệ số vượt tải n";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Giá trị tính toán(KN/m2)";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Các lớp vật liệu";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Bề dày (m)";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Trọng lượng riêng (KN/m3)";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = " Hệ số vượt tải n";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Giá trị tính toán(KN/m2)";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "1";
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Frm_ThemTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 261);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_ThemTT";
            this.Text = "Thêm tĩnh tải";
            this.Load += new System.EventHandler(this.Frm_ThemTT_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LopVatLieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_import;
        internal System.Windows.Forms.TextBox txt_tenTinhTai;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.DataGridView dgv_LopVatLieu;
        internal System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        internal System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        internal System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        internal System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        internal System.Windows.Forms.Button btn_remove;
        internal System.Windows.Forms.Button btn_them;
    }
}