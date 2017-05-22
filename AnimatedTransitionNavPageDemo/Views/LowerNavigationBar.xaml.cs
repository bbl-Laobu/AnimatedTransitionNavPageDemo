using AnimatedTransitionNavPageDemo.Pages;
using Xamarin.Forms;

namespace AnimatedTransitionNavPageDemo.Views
{
    public partial class LowerNavigationBar : ContentView
    {
        public LowerNavigationBar()
        {
            InitializeComponent();
        }

		async void OnNavBarButtonLabelTappedAsync(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new RotateAnimationPage());
		}
    }
}
