using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xamarin_playground
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void PressMe_ButtonClicked(object sender, EventArgs eventArgs){
            (sender as Button).Text = "I was just clicked!";
        }

    }
}
