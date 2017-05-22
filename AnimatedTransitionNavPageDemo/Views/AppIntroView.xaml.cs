using Xamarin.Forms;
using AnimatedTransitionNavPageDemo.Pages;

namespace AnimatedTransitionNavPageDemo.Views
{
    public partial class AppIntroView : ContentView
	{
		public AppIntroView ()
		{
			InitializeComponent ();
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new BBLGitHubWebPage());
		}
	}
}