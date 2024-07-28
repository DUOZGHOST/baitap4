namespace baitap4
{
    partial class ListView
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
            this.listView = new System.Windows.Forms.ListView();
            this.MSNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LuongCB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Them = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Dong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MSNV,
            this.TenNV,
            this.LuongCB});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(26, 25);
            this.listView.Margin = new System.Windows.Forms.Padding(2);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(415, 310);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // MSNV
            // 
            this.MSNV.Text = "MSNV";
            // 
            // TenNV
            // 
            this.TenNV.Text = "TênNV";
            // 
            // LuongCB
            // 
            this.LuongCB.Text = "LươngCB";
            // 
            // Them
            // 
            this.Them.Location = new System.Drawing.Point(492, 25);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(75, 23);
            this.Them.TabIndex = 1;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // Sua
            // 
            this.Sua.Location = new System.Drawing.Point(492, 79);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(75, 23);
            this.Sua.TabIndex = 2;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(492, 135);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(75, 23);
            this.Xoa.TabIndex = 3;
            this.Xoa.Text = "Xoá";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Đong
            // 
            this.Dong.Location = new System.Drawing.Point(492, 195);
            this.Dong.Name = "Dong";
            this.Dong.Size = new System.Drawing.Size(75, 23);
            this.Dong.TabIndex = 4;
            this.Dong.Text = "Đóng";
            this.Dong.UseVisualStyleBackColor = true;
            this.Dong.Click += new System.EventHandler(this.Dong_Click);
            // 
            // ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Dong);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.listView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListView";
            this.Text = "Quản lý Nhân viên";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader MSNV;
        private System.Windows.Forms.ColumnHeader TenNV;
        private System.Windows.Forms.ColumnHeader LuongCB;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Dong;
    }
}

