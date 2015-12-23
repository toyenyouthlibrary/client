using System;
using System.Windows.Forms;
using Awesomium.Core;

namespace LibLog.Client
{
    public partial class MainWindow : Form
    {
        private WebViewElementUpdater webViewElementUpdater;
        private Random random;

        public MainWindow()
        {
            this.InitializeComponent();
            this.InitializeWindow();
        }

        private void InitializeWindow()
        {
            this.webViewElementUpdater = new WebViewElementUpdater(this.webControl, "rfid");
            this.random = new Random();

            this.Menu = new MainMenu(new MenuItem[]
            {
                new MenuItem("Generate RFID", (o, e) =>
                {
                    this.webViewElementUpdater.Update(random.Next().ToString());
                })
            });
        }
    }
}
