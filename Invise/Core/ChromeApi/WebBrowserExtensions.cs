﻿using CefSharp;
using CefSharp.Web;

namespace Invise.Core.ChromeApi;

public static class WebBrowserExtensions
{
    /// <summary>
    /// Encode text/html url to utf8
    /// </summary>
    public static void LoadUnicodeHtml(this IFrame Frame, string html)
    {
        var htmlString = new HtmlString(html, true);
        var replace = htmlString.ToDataUriString().Replace(":text/html;", ":text/html;charset=utf8;");
        Frame.LoadUrl(replace);
    }
}
