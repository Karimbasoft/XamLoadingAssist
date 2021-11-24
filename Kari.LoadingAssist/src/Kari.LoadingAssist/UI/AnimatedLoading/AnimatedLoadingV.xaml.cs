using Lottie.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Kari.LoadingAssist.UI.AnimatedLoading
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnimatedLoadingV : ContentView
    {
        public static readonly BindableProperty LoadingTextProperty =
            BindableProperty.Create(nameof(LoadingText)
                , typeof(string)
                , typeof(AnimatedLoadingV)
                , default(string)
                , BindingMode.TwoWay);

        public static readonly BindableProperty SourceFileProperty =
            BindableProperty.Create(nameof(SourceFile)
                , typeof(string)
                , typeof(AnimatedLoadingV)
                , default(string)
                , BindingMode.TwoWay);


        public static readonly BindableProperty AnimationSourceProperty =
          BindableProperty.Create(nameof(AnimationSource)
              , typeof(AnimationSource)
              , typeof(AnimatedLoadingV)
              , default(AnimationSource)
              , BindingMode.OneWay);

        public string LoadingText
        {
            get
            {
                return (string)GetValue(LoadingTextProperty);
            }

            set
            {
                SetValue(LoadingTextProperty, value);
            }
        }

        public string SourceFile
        {
            get
            {
                return (string)GetValue(SourceFileProperty);
            }

            set
            {
                SetValue(SourceFileProperty, value);
            }
        }

        public AnimationSource AnimationSource
        {
            get
            {
                return (AnimationSource)GetValue(SourceFileProperty);
            }

            set
            {
                SetValue(SourceFileProperty, value);
            }
        }

        public AnimatedLoadingV()
        {
            InitializeComponent();
            BindingContext = new AnimatedLoadingVM();
        }
    }
}