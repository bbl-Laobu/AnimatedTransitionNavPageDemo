using System;
using FormsControls.Base; // Using Added
using Xamarin.Forms;

namespace AnimatedTransitionNavPageDemo.Pages
{
    
	public partial class InterfaceImplementedPage : ContentPage, IAnimationPage // Interface added
	{
		public InterfaceImplementedPage ()
		{
			InitializeComponent ();
		}

		// ---------------------------------------------------------------------
		// Transition by Implementing IAnimation Interface 
		// ---------------------------------------------------------------------

		public IPageAnimation PageAnimation { get; } = new FlipPageAnimation { Duration = AnimationDuration.Long, Subtype = AnimationSubtype.FromTop };

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

