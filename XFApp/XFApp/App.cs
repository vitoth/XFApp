using System;
using Xamarin.Forms;

namespace XFApp
{
    public class App : Application // superclass new in 1.3
    {
        public App()
        {
            MainPage = new Board();
        }
    }
}
