using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLNhaHang;
using OfficeOpenXml;

namespace GUI_QLNhaHang
{
    public partial class ThongKe : Form
    {
        BUS_HoaDon busHD = new BUS_HoaDon();
        public ThongKe()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            dvThongKe.DataSource = busHD.ThongKe();
            dvThongKe.Columns[0].HeaderText = "Mã Hóa Đơn";
            dvThongKe.Columns[1].HeaderText = "Mã Nhân Viên";
            dvThongKe.Columns[2].HeaderText = "Mã Khách Hàng";
            dvThongKe.Columns[3].HeaderText = "Mã Bàn Ăn";
            dvThongKe.Columns[4].HeaderText = "Trạng Thái";
            dvThongKe.Columns[5].HeaderText = "Tổng Tiền";
        }
        private void ThongKe_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void ExportToExcel(DataGridView dataGridView)
        {
            if (dataGridView == null)
            {
                MessageBox.Show("Bảng trống.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                FileName = "Thống kê hóa đơn đã in",
                Filter = "Excel Files|*.xlsx",
                Title = "Save as Excel File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (ExcelPackage package = new ExcelPackage(new FileInfo(saveFileDialog.FileName)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Data");

                    // Header row
                    for (int i = 1; i <= dataGridView.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i].Value = dataGridView.Columns[i - 1].HeaderText;
                        worksheet.Cells[1, i].Style.Font.Bold = true;
                    }

                    // Data rows
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView.Columns.Count; j++)
                        {
                            var value = dataGridView[j, i].Value;
                            worksheet.Cells[i + 2, j + 1].Value = value?.ToString() ?? string.Empty;
                        }
                    }

                    // Auto fit columns
                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                    package.Save();
                }

                MessageBox.Show("Dữ liệu đã được xuất thành công!");
            }
        }
        private void btnXuatThongKe_Click(object sender, EventArgs e)
        {
            ExportToExcel(dvThongKe);
        }
    }
}
