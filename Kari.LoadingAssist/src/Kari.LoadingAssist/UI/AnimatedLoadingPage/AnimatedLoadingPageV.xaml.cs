using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Kari.LoadingAssist.UI.AnimatedLoadingPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnimatedLoadingPageV : ContentPage
    {
        public AnimatedLoadingPageV()
        {
            InitializeComponent();
            BindingContext = new AnimatedLoadingPageVM();
        }
    }
}