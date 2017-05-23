using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FormsControls.Base;
using Xamarin.Forms;

namespace AnimatedTransitionNavPageDemo.Pages
{
    public partial class StartPage : ContentPage, IAnimationPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

		public IPageAnimation PageAnimation { get; } = new FlipPageAnimation { Duration = AnimationDuration.Long, Subtype = AnimationSubtype.FromLeft };

		public void OnAnimationStarted(bool isPopAnimation)
		{
			// Put your code here
		}

		public void OnAnimationFinished(bool isPopAnimation)
		{
			// Put your code here
		}
    }
}