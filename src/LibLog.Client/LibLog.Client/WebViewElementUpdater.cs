using System;
using Awesomium.Core;

namespace LibLog.Client
{
    public sealed class WebViewElementUpdater
    {
        private IWebView webView;
        private string id;

        public WebViewElementUpdater(IWebView webView, string id)
        {
            this.webView = webView;
            this.id = id;
        }

        public void Update(string value)
        {
            if (this.webView.IsDocumentReady && JavaScript.GetElementById(this.webView, this.id).IsObject)
            {
                JavaScript.UpdateElementById(this.webView, this.id, value);
            }
        }
    }
}
