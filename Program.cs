using System;

namespace ReadWriteINI
{
    class Program
    {
        static void Main(string[] args)
        {
            IniFile settingsIni = new IniFile (@".\\TestData.ini");
            string executionMode = settingsIni.Read ("BrowserName", "BrowserInfo").ToLower ();
            Console.WriteLine (executionMode);
            string WebdriverToUse = settingsIni.Read ("WebDriverLocation", "BrowserInfo").ToLower ();
            Console.WriteLine (WebdriverToUse);

            // settingsIni.Write("TimeOut","4000","BrowserInfo");
            // string TimeOut = settingsIni.Read ("TimeOut", "BrowserInfo");
             settingsIni.Write("TimeOut","4000","BrowserInfo");
            string TimeOut = settingsIni.Read ("TimeOut", "BrowserInfo");
            Console.WriteLine (TimeOut);
            string Implicit = settingsIni.Read ("Implicit", "BrowserInfo");
            Console.WriteLine (Implicit);
            settingsIni.Write("Implicit","4000","BrowserInfo");

            settingsIni.Write("BrowserName","IE","BrowserInfo");
            settingsIni.Write("url","https://www.google.com/","ApplicationTest");



        }

    }
}
