using System;
using FormsControls.Base;
using PropertyChanged;
using Xamarin.Forms;

namespace AnimatedTransitionNavPageDemo.ViewModels
{
    [ImplementPropertyChanged]
    public class TransitionViewModel
    {
        public TransitionViewModel()
        {
            MyPageAnimation = new SlidePageAnimation()
            {
                Duration = AnimationDuration.Long,
                Subtype = AnimationSubtype.FromTop
            };
            TypeText = "Slide";
            SubTypeText = "FromTop";
            DurationText = "Long";
        }

        public IPageAnimation MyPageAnimation { get; set; }

        public String TypeText { get; set; }
        public String SubTypeText { get; set; }
        public String DurationText { get; set; }

    }
}
