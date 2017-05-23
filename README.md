# CUSTOM PAGE TRANSITIONS
A simple but effective Xamarin Forms SlideMenu Demo

## INTRODUCTION
Using the [AnimationNavPage Component](https://components.xamarin.com/view/customnavpage) we can demonstrate how to create a custom transition between different pages.


## DESCRIPTION
To demonstrate and achieve different types of Transitions between navigation pages, we are using the excellent ‘AnimationNavPage Component’ written by AlexandrNikulin (price $26). 

Setting-up and using the component happens in 3 steps:	
1.	Install and reference the DLL files for PCL, IOS and Android
2.	Declare AnimationNavigationPage (instead of NavigationPage)
3.	Create and Animation page (use interface or use XAML tags)


## INSTALL
Download the ‘customnavpage’ package from https://components.xamarin.com/view/customnavpage . You can easily donwload a trial version from the site. Copy the included lib folder into your solution and link the following DLL’s to your different projects (PCL, Andoid and IOS) as shown below

![PCL](https://github.com/bbl-Laobu/AnimatedTransitionNavPageDemo/raw/master/PCLRef.png) ![Android](https://github.com/bbl-Laobu/AnimatedTransitionNavPageDemo/raw/master/AndroidRef.png) ![IOS](https://github.com/bbl-Laobu/AnimatedTransitionNavPageDemo/raw/master/IOSRef.png)

## DECLARE ANIMATIONNAVIGATIONPAGE
In your App, declare your new main page as follows:
```csharp  
public class App : Application
{
        public App()
        {
            InitializeComponent();
            MainPage = new AnimationNavigationPage(new StartPage());
        }
}
```
## CREATE AND ANIMATION PAGE
There are 2 ways to create an Animation Page:
1.	Implement the IAnimationPage interface
2.	Use XAML Tags 

## OPTION 1 - Implement the IAnimationPage interface
Firstly, add the interface declaration to your class definition as follows:
```csharp  
public partial class InterfaceImplementedPage : ContentPage, IAnimationPage 
```

Next, add the following code to the class:
```csharp  
public IPageAnimation PageAnimation { get; } = new FlipPageAnimation { Duration = AnimationDuration.Long, Subtype = AnimationSubtype.FromTop };

public void OnAnimationStarted(bool isPopAnimation)
{
	// Put your code here but leaving empty works just fine
}

public void OnAnimationFinished(bool isPopAnimation)
{
	// Put your code here but leaving empty works just fine
}
```

Note that depending on the type of transition you want, you can change FlipPageAnimation into SlidePageAnimation, FadePageAnimation… or whichever animation you require. Further configuration such as Duration and Subtype can be easily done.

## OPTION 2 - Use XAML 
Firstly, make sure that the code behind inherits from AnimationPage:
```csharp  
public partial class XamlNoBindingPage : AnimationPage
```

Next, use the <controls:AnimationPage> tag instead of the <ContentPage> tag as follows: 
```xaml  
<controls:AnimationPage xmlns="http://xamarin.com/schemas/2014/forms" 
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml" 
    xmlns:controls="clr-namespace:FormsControls.Base;assembly=FormsControls.Base"
    x:Class="AnimatedTransitionNavPageDemo.Pages.XamlNoBindingPage" 
    Title="XAML No Binding">
```




Enjoy and any question or improvements, please let me know.

Laobu!


## REFERENCES
- ‘AnimationNavPage’ By AlexandrNikulin @ [https://components.xamarin.com/view/customnavpage   ](https://components.xamarin.com/view/customnavpage ) 


Author
Laobu – Bernard Blanckaert
