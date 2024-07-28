namespace baitap4
{
    partial class NhanVienForm
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
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelMa = new System.Windows.Forms.Label();
            this.labelTen = new System.Windows.Forms.Label();
            this.labelLuong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(120, 30);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(200, 20);
            this.txtMa.TabIndex = 0;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(120, 70);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(200, 20);
            this.txtTen.TabIndex = 1;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(120, 110);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(200, 20);
            this.txtLuong.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(120, 150);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(245, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelMa
            // 
            this.labelMa.AutoSize = true;
            this.labelMa.Location = new System.Drawing.Point(30, 33);
            this.labelMa.Name = "labelMa";
            this.labelMa.Size = new System.Drawing.Size(74, 13);
            this.labelMa.TabIndex = 5;
            this.labelMa.Text = "Mã số NV:";
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Location = new System.Drawing.Point(30, 73);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(66, 13);
            this.labelTen.TabIndex = 6;
            this.labelTen.Text = "Tên NV:";
            // 
            // labelLuong
            // 
            this.labelLuong.AutoSize = true;
            this.labelLuong.Location = new System.Drawing.Point(30, 113);
            this.labelLuong.Name = "labelLuong";
            this.labelLuong.Size = new System.Drawing.Size(87, 13);
            this.labelLuong.TabIndex = 7;
            this.labelLuong.Text = "Lương cơ bản:";
            // 
            // NhanVienForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.labelLuong);
            this.Controls.Add(this.labelTen);
            this.Controls.Add(this.labelMa);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Name = "NhanVienForm";
            this.Text = "Thông tin Nhân viên";
            this.Load += new System.EventHandler(this.NhanVienForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label labelMa;
        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.Label labelLuong;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}