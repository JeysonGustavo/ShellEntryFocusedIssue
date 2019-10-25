using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xaminals.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryTest : ContentPage
    {
        public EntryTest()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            entryOne.Text = "";
            entryOne.Unfocus();
        }

        private void entryOne_Focused(object sender, FocusEventArgs e)
        {

        }

        private void entryTwo_Focused(object sender, FocusEventArgs e)
        {

        }
    }
}