using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Apdung4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // seed dữ liệu bên trái
            lstMatHang.Items.AddRange(new object[]
            {
                "CPU", "MainBoard", "RAM", "Keyboard", "Mouse", "NIC", "FAN", "SSD", "HDD", "VGA"
            });

            // gán sự kiện nút
            btnRight.Click += (_, __) => MoveSelected(lstMatHang, lstDaChon);
            btnRightAll.Click += (_, __) => MoveAll(lstMatHang, lstDaChon);
            btnLeft.Click += (_, __) => MoveSelected(lstDaChon, lstMatHang);
            btnLeftAll.Click += (_, __) => MoveAll(lstDaChon, lstMatHang);

            // double-click để chuyển nhanh
            lstMatHang.DoubleClick += (_, __) => MoveSelected(lstMatHang, lstDaChon);
            lstDaChon.DoubleClick += (_, __) => MoveSelected(lstDaChon, lstMatHang);
        }

        private void MoveSelected(ListBox from, ListBox to)
        {
            if (from.SelectedItems.Count == 0) return;

            // copy danh sách chọn (tránh sửa collection khi đang duyệt)
            List<object> picked = from.SelectedItems.Cast<object>().ToList();

            foreach (var item in picked)
            {
                to.Items.Add(item);
                from.Items.Remove(item);
            }
        }

        private void MoveAll(ListBox from, ListBox to)
        {
            if (from.Items.Count == 0) return;

            to.Items.AddRange(from.Items.Cast<object>().ToArray());
            from.Items.Clear();
        }
    }
}
