using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btStart_Clicked(object sender, EventArgs e)
        {

        }
    } 
}
