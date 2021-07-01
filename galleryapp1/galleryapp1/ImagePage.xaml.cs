using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace galleryapp1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();

            
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new Page2();
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new Page1();
        }
    }
}