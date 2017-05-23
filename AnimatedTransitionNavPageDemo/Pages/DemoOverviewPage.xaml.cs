using FormsControls.Base;

namespace AnimatedTransitionNavPageDemo.Pages
{
    public partial class DemoOverviewPage : AnimationPage
    {
        XamlWithBindingPage _myAnimationPage;

        public DemoOverviewPage()
        {
            InitializeComponent();
            _myAnimationPage = new XamlWithBindingPage();
        }

        async void Button1_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new InterfaceImplementedPage());
        }

        async void Button2_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new XamlNoBindingPage());
        }

        async void Button3_Clicked(object sender, System.EventArgs e)
        {
            _myAnimationPage._vm.MyPageAnimation = new SlidePageAnimation()
            {
                Subtype = AnimationSubtype.FromTop,
                Duration = AnimationDuration.Long
            };
            _myAnimationPage._vm.TypeText = "Slide";
            _myAnimationPage._vm.SubTypeText = "FromTop";
            _myAnimationPage._vm.DurationText = "Long";
            await Navigation.PushAsync(_myAnimationPage);
        }

        async void Button4_Clicked(object sender, System.EventArgs e)
        {
			_myAnimationPage._vm.MyPageAnimation = new FadePageAnimation()
			{
				Subtype = AnimationSubtype.FromRight,
				Duration = AnimationDuration.Medium
			};
			_myAnimationPage._vm.TypeText = "Fade";
			_myAnimationPage._vm.SubTypeText = "FromRight";
			_myAnimationPage._vm.DurationText = "Medium";
			await Navigation.PushAsync(_myAnimationPage);
        }

		async void Button5_Clicked(object sender, System.EventArgs e)
		{
			_myAnimationPage._vm.MyPageAnimation = new PushPageAnimation()
			{
				Subtype = AnimationSubtype.FromBottom,
				Duration = AnimationDuration.Long
			};
			_myAnimationPage._vm.TypeText = "Push";
			_myAnimationPage._vm.SubTypeText = "FromBottom";
			_myAnimationPage._vm.DurationText = "Long";
			await Navigation.PushAsync(_myAnimationPage);
		}

		async void Button6_Clicked(object sender, System.EventArgs e)
		{
			_myAnimationPage._vm.MyPageAnimation = new RollPageAnimation()
            {
                Subtype = AnimationSubtype.FromLeft,
				Duration = AnimationDuration.Medium,
			};
			_myAnimationPage._vm.TypeText = "Roll";
			_myAnimationPage._vm.SubTypeText = "FromLeft";
			_myAnimationPage._vm.DurationText = "Medium";
			await Navigation.PushAsync(_myAnimationPage);
		}

		async void Button7_Clicked(object sender, System.EventArgs e)
		{
			_myAnimationPage._vm.MyPageAnimation = new LandingPageAnimation()
			{
				Subtype = AnimationSubtype.FromTop,
				Duration = AnimationDuration.Long,
			};
			_myAnimationPage._vm.TypeText = "Landng";
			_myAnimationPage._vm.SubTypeText = "FromTop";
			_myAnimationPage._vm.DurationText = "Long";
			await Navigation.PushAsync(_myAnimationPage);
		}
    }
}
