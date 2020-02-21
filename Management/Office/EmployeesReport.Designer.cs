namespace Baran.Ferroalloy.Management.Office
{
    partial class EmployeesReport
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
            this.stvEmployees = new Stimulsoft.Report.Viewer.StiViewerControl();
            this.SuspendLayout();
            // 
            // stvEmployees
            // 
            this.stvEmployees.AllowDrop = true;
            this.stvEmployees.AutoSize = true;
            this.stvEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stvEmployees.Location = new System.Drawing.Point(0, 0);
            this.stvEmployees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stvEmployees.Name = "stvEmployees";
            this.stvEmployees.PageViewMode = Stimulsoft.Report.Viewer.StiPageViewMode.SinglePage;
            this.stvEmployees.Report = null;
            this.stvEmployees.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stvEmployees.ShowBookmarksPanel = false;
            this.stvEmployees.ShowDotMatrixModeButton = false;
            this.stvEmployees.ShowFirstPage = false;
            this.stvEmployees.ShowFullScreen = false;
            this.stvEmployees.ShowLastPage = false;
            this.stvEmployees.ShowNextPage = false;
            this.stvEmployees.ShowOpen = false;
            this.stvEmployees.ShowPageDelete = false;
            this.stvEmployees.ShowPageDesign = false;
            this.stvEmployees.ShowPageNew = false;
            this.stvEmployees.ShowPageSize = false;
            this.stvEmployees.ShowPageViewMode = false;
            this.stvEmployees.ShowParametersButton = false;
            this.stvEmployees.ShowResourcesButton = false;
            this.stvEmployees.ShowSave = false;
            this.stvEmployees.ShowSaveDocumentFile = false;
            this.stvEmployees.ShowThumbsPanel = false;
            this.stvEmployees.ShowViewModeContinuous = false;
            this.stvEmployees.ShowViewModeMultiplePages = false;
            this.stvEmployees.ShowViewModeSinglePage = false;
            this.stvEmployees.ShowZoom = true;
            this.stvEmployees.ShowZoomMultiplePages = false;
            this.stvEmployees.ShowZoomOnePage = false;
            this.stvEmployees.ShowZoomPageWidth = false;
            this.stvEmployees.ShowZoomTwoPages = false;
            this.stvEmployees.Size = new System.Drawing.Size(1350, 729);
            this.stvEmployees.TabIndex = 0;
            this.stvEmployees.ThumbsPanelEnabled = false;
            // 
            // EmployeesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.stvEmployees);
            this.Font = new System.Drawing.Font("B Yekan", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeesReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش کارمندان";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeesReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Stimulsoft.Report.Viewer.StiViewerControl stvEmployees;
    }
}