
namespace GUI_QLNhaHang
{
    partial class InHoaDon
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
            this.reportInHoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportInHoaDon
            // 
            this.reportInHoaDon.AutoSize = true;
            this.reportInHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportInHoaDon.Location = new System.Drawing.Point(0, 0);
            this.reportInHoaDon.Name = "reportInHoaDon";
            this.reportInHoaDon.ServerReport.BearerToken = null;
            this.reportInHoaDon.Size = new System.Drawing.Size(867, 548);
            this.reportInHoaDon.TabIndex = 0;
            // 
            // InHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(867, 548);
            this.Controls.Add(this.reportInHoaDon);
            this.Name = "InHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InHoaDon";
            this.Load += new System.EventHandler(this.InHoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportInHoaDon;
    }
}