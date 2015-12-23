using System;
using MaterialSkin;
using MaterialSkin.Controls;

namespace LibLog.Client
{
    public partial class MainForm : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;

        public MainForm()
        {
            this.InitializeComponent();
            this.InitializeMaterialSkin();
        }

        private void InitializeMaterialSkin()
        {
            this.materialSkinManager = MaterialSkinManager.Instance;
            this.materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,
                                                                   Primary.BlueGrey900,
                                                                   Primary.BlueGrey500,
                                                                   Accent.LightBlue200,
                                                                   TextShade.WHITE);
        }
    }
}
