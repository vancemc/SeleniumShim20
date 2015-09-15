using System;
using System.Diagnostics;
using System.Linq;

namespace SeleniumShim20
{
    public abstract class WebTest
    {
        public static WebBrowser TestBrowserWindow { get; set; }

        public static string MainPageUrl { get; set; }
    }
}
