using AnimatedTransitionNavPageDemo.ViewModels;
using FormsControls.Base; // Using Added

namespace AnimatedTransitionNavPageDemo.Pages
{

    public partial class XamlWithBindingPage : AnimationPage //The page inherits from AnimationPage
	{

        public TransitionViewModel _vm;

		public XamlWithBindingPage ()
		{
			InitializeComponent ();

            BindingContext = _vm = new TransitionViewModel();

		}
	}
}

