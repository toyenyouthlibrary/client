using System;
using Awesomium.Core;

namespace LibLog.Client
{
    public static class JavaScript
    {
        private const string GET_ELEMENT_BY_ID = "document.getElementById(\"{0}\")";
        private const string UPDATE_ELEMENT_BY_ID = "document.getElementById(\"{0}\").value = \"{1}\"";

        public static JSValue GetElementById(IWebView webView, string id)
        {
            string formatted = string.Format(JavaScript.GET_ELEMENT_BY_ID, id);

            return webView.ExecuteJavascriptWithResult(string.Format(JavaScript.GET_ELEMENT_BY_ID, id));
        }

        public static void UpdateElementById(IWebView webView, string id, string value)
        {
            webView.ExecuteJavascript(string.Format(JavaScript.UPDATE_ELEMENT_BY_ID, id, value));
        }
    }
}
