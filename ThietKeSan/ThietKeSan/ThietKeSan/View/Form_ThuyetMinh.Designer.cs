
namespace ThietKeSan.View
{
    partial class Form_ThuyetMinh
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
            this.labelID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_San = new System.Windows.Forms.ComboBox();
            this.btn_TaoTm = new System.Windows.Forms.Button();
            this.btn_XuatTm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtb_TM = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbb_San);
            this.panel1.Controls.Add(this.btn_TaoTm);
            this.panel1.Controls.Add(this.btn_XuatTm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 45);
            this.panel1.TabIndex = 0;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(193, 16);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 44;
            this.labelID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Chọn sàn";
            // 
            // cbb_San
            // 
            this.cbb_San.FormattingEnabled = true;
            this.cbb_San.Location = new System.Drawing.Point(66, 11);
            this.cbb_San.Name = "cbb_San";
            this.cbb_San.Size = new System.Drawing.Size(121, 21);
            this.cbb_San.TabIndex = 42;
            this.cbb_San.SelectedIndexChanged += new System.EventHandler(this.cbb_San_SelectedIndexChanged);
            // 
            // btn_TaoTm
            // 
            this.btn_TaoTm.BackColor = System.Drawing.Color.White;
            this.btn_TaoTm.Image = global::ThietKeSan.Properties.Resources.contract;
            this.btn_TaoTm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TaoTm.Location = new System.Drawing.Point(546, 7);
            this.btn_TaoTm.Name = "btn_TaoTm";
            this.btn_TaoTm.Size = new System.Drawing.Size(80, 30);
            this.btn_TaoTm.TabIndex = 41;
            this.btn_TaoTm.Text = "Tạo TM";
            this.btn_TaoTm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TaoTm.UseVisualStyleBackColor = false;
            this.btn_TaoTm.Click += new System.EventHandler(this.btn_TaoTm_Click);
            // 
            // btn_XuatTm
            // 
            this.btn_XuatTm.BackColor = System.Drawing.Color.White;
            this.btn_XuatTm.Image = global::ThietKeSan.Properties.Resources.word;
            this.btn_XuatTm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XuatTm.Location = new System.Drawing.Point(632, 7);
            this.btn_XuatTm.Name = "btn_XuatTm";
            this.btn_XuatTm.Size = new System.Drawing.Size(80, 30);
            this.btn_XuatTm.TabIndex = 40;
            this.btn_XuatTm.Text = "Xuất TM";
            this.btn_XuatTm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XuatTm.UseVisualStyleBackColor = false;
            this.btn_XuatTm.Click += new System.EventHandler(this.btn_XuatTm_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtb_TM);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 316);
            this.panel2.TabIndex = 1;
            // 
            // rtb_TM
            // 
            this.rtb_TM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_TM.Location = new System.Drawing.Point(0, 0);
            this.rtb_TM.Name = "rtb_TM";
            this.rtb_TM.Size = new System.Drawing.Size(724, 316);
            this.rtb_TM.TabIndex = 0;
            this.rtb_TM.Text = "";
            // 
            // Form_ThuyetMinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 361);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_ThuyetMinh";
            this.Text = "Thuyết minh";
            this.Load += new System.EventHandler(this.Form_ThuyetMinh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_San;
        private System.Windows.Forms.Button btn_TaoTm;
        private System.Windows.Forms.Button btn_XuatTm;
        private System.Windows.Forms.RichTextBox rtb_TM;
    }
}