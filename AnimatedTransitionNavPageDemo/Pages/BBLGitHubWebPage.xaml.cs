using FormsControls.Base;
using Xamarin.Forms;

namespace AnimatedTransitionNavPageDemo.Pages
{
    public partial class BBLGitHubWebPage : ContentPage, IAnimationPage
    {
        public BBLGitHubWebPage()
        {
            InitializeComponent();
        }

		void webOnNavigating(object sender, WebNavigatingEventArgs e)
		{
			LoadingLabel.IsVisible = true;
            IndicatorActiviry.IsRunning = true;
            IndicatorActiviry.IsVisible = true;
            LoadingLayout.IsVisible = true;

		}

		void webOnEndNavigating(object sender, WebNavigatedEventArgs e)
		{
			LoadingLabel.IsVisible = false;
            IndicatorActiviry.IsRunning = false;
            IndicatorActiviry.IsVisible = false;
            LoadingLayout.IsVisible = false;
		}

		// ---------------------------------------------------------------------
		// Transition by Implementing IAnimation Interface 
		// ---------------------------------------------------------------------

		public IPageAnimation PageAnimation { get; } = new FlipPageAnimation { Duration = AnimationDuration.Medium, 
            Subtype = AnimationSubtype.FromRight };

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
