using System;
using MaterialSkin;
using MaterialSkin.Controls;

namespace LibLog.Client
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            this.InitializeComponent();
            this.InitializeMaterialSkin();
            this.InitializeWebControl();

            Utilities.MaximizeMaterialForm(this, true);
        }

        private void InitializeMaterialSkin()
        {
            this.SkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,
                                                           Primary.BlueGrey900,
                                                           Primary.BlueGrey500,
                                                           Accent.LightBlue200,
                                                           TextShade.WHITE);
        }

        private void InitializeWebControl()
        {
            this.webControl.LoadingFrame += (o, e) =>
            {
                if (this.loadingOverlay.Enabled)
                {
                    this.loadingOverlay.Visible = true;
                }
            };

            this.webControl.LoadingFrameComplete += (o, e) =>
            {
                if (this.loadingOverlay.Enabled)
                {
                    this.loadingOverlay.Visible = false;
                }
            };
        }
    }
}
