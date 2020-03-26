using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFRingButton
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Main_Clicked(object sender, EventArgs e)
        {
            await ToggleSubButtons();
        }

        private bool _isShown;
        private async Task ToggleSubButtons()
        {
            if (!_isShown)
            {
                Button_1.ScaleTo(1, 150, Easing.SpringOut);
                Button_1.FadeTo(1, 150, Easing.SpringOut);
                Button_1.TranslateTo(0, -70, 150, Easing.SpringOut);
                await Task.Delay(50);
                Button_2.ScaleTo(1, 150, Easing.SpringOut);
                Button_2.FadeTo(1, 150, Easing.SpringOut);
                Button_2.TranslateTo(-52.15, -52.15, 150, Easing.SpringOut);
                await Task.Delay(50);
                Button_3.ScaleTo(1, 150, Easing.SpringOut);
                Button_3.FadeTo(1, 150, Easing.SpringOut);
                Button_3.TranslateTo(-70, 0, 150, Easing.SpringOut);
            }
            else
            {
                Button_3.ScaleTo(0, 150, Easing.SpringOut);
                Button_3.FadeTo(0, 150, Easing.SpringOut);
                Button_3.TranslateTo(0, 0, 150, Easing.SpringOut);
                await Task.Delay(50);
                Button_2.ScaleTo(0, 150, Easing.SpringOut);
                Button_2.FadeTo(0, 150, Easing.SpringOut);
                Button_2.TranslateTo(0, 0, 150, Easing.SpringOut);
                await Task.Delay(50);
                Button_1.ScaleTo(0, 150, Easing.SpringOut);
                Button_1.FadeTo(0, 150, Easing.SpringOut);
                Button_1.TranslateTo(0, 0, 150, Easing.SpringOut);
            }

            _isShown = !_isShown;
        }

        private async void Button_Sub_Clicked(object sender, EventArgs e)
        {
            await ToggleSubButtons();
        }
    }
}
