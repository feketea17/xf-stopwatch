using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace XF_Stopwatch
{
    public partial class MainPage : ContentPage
    {
        Stopwatch stopwatch;

        public MainPage()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
        }

        private bool needResume = true;         // Start gomb "Resume"-ra állításához

        private void btStart_Clicked(object sender, EventArgs e)
        {
            needResume = true;
            stopwatch.Start();
            Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
             {
                 lbTimer.Text = stopwatch.Elapsed.ToString();       // eltelt idő megjelenítése
                 return true;
             });
        }

        private void btStop_Clicked(object sender, EventArgs e)
        {
            stopwatch.Stop();
            if (needResume == true)         // ha true, akkor a "Start" felirat "Resume"-ra vált
            {
                btStart.Text = "Resume";
            }
        }

        private void btReset_Clicked(object sender, EventArgs e)
        {
            stopwatch.Reset();
            needResume = false;             // Reset után erre már nincs szükség
            btStart.Text = "Start";         // "Start" felirat visszaállítása
        }
    } 
}
