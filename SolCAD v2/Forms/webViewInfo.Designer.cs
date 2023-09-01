namespace SolCAD_v2.Forms
{
    partial class webViewInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(webViewInfo));
            wvInfo = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)wvInfo).BeginInit();
            SuspendLayout();
            // 
            // wvInfo
            // 
            wvInfo.AllowExternalDrop = true;
            wvInfo.CreationProperties = null;
            wvInfo.DefaultBackgroundColor = Color.White;
            wvInfo.Dock = DockStyle.Fill;
            wvInfo.Location = new Point(0, 0);
            wvInfo.Name = "wvInfo";
            wvInfo.Size = new Size(800, 450);
            wvInfo.TabIndex = 0;
            wvInfo.ZoomFactor = 1D;
            // 
            // webViewInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(wvInfo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "webViewInfo";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosed += webViewInfo_FormClosed;
            Load += webViewInfo_Load;
            ((System.ComponentModel.ISupportInitialize)wvInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 wvInfo;
    }
}