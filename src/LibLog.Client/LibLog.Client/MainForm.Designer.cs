namespace LibLog.Client
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.webControl = new Awesomium.Windows.Forms.WebControl(this.components);
            this.loadingOverlay = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // webControl
            // 
            this.webControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webControl.Location = new System.Drawing.Point(0, 64);
            this.webControl.NavigationInfo = Awesomium.Core.NavigationInfo.None;
            this.webControl.Size = new System.Drawing.Size(640, 416);
            this.webControl.Source = new System.Uri("http://toyenyouthlibrary.github.io/client/tests/rfid/", System.UriKind.Absolute);
            this.webControl.Source = new System.Uri("http://127.0.0.1:5000", System.UriKind.Absolute);
            this.webControl.TabIndex = 0;
            // 
            // loadingOverlay
            // 
            this.loadingOverlay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadingOverlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.loadingOverlay.Location = new System.Drawing.Point(0, 64);
            this.loadingOverlay.Name = "loadingOverlay";
            this.loadingOverlay.Size = new System.Drawing.Size(640, 416);
            this.loadingOverlay.TabIndex = 1;
            this.loadingOverlay.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.loadingOverlay);
            this.Controls.Add(this.webControl);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibLog";
            this.ResumeLayout(false);

        }

        #endregion

        private Awesomium.Windows.Forms.WebControl webControl;
        private System.Windows.Forms.Panel loadingOverlay;
    }
}