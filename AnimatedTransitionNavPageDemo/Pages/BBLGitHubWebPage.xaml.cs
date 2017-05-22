using Xamarin.Forms;

namespace AnimatedTransitionNavPageDemo.Pages
{
    public partial class BBLGitHubWebPage : ContentPage
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
    }
}
