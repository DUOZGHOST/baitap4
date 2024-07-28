using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace baitap4
{
    public partial class ListView : Form
    {
        public ListView()
        {
            InitializeComponent();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            NhanVienForm nvForm = new NhanVienForm();
            if (nvForm.ShowDialog() == DialogResult.OK)
            {
                ListViewItem lvi = new ListViewItem(nvForm.MSNV);
                lvi.SubItems.Add(nvForm.TenNV);
                lvi.SubItems.Add(nvForm.LuongCB);
                listView.Items.Add(lvi);
            }
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView.SelectedItems[0];
                NhanVienForm nvForm = new NhanVienForm
                {
                    MSNV = selectedItem.SubItems[0].Text,
                    TenNV = selectedItem.SubItems[1].Text,
                    LuongCB = selectedItem.SubItems[2].Text
                };

                if (nvForm.ShowDialog() == DialogResult.OK)
                {
                    selectedItem.SubItems[0].Text = nvForm.MSNV;
                    selectedItem.SubItems[1].Text = nvForm.TenNV;
                    selectedItem.SubItems[2].Text = nvForm.LuongCB;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa.");
            }
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                listView.Items.Remove(listView.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa.");
            }
        }

        private void Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
