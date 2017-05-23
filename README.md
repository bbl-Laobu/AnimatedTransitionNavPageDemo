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

Enjoy and any question or improvements, please let me know.

Laobu!


## REFERENCES
- ‘AnimationNavPage’ By AlexandrNikulin @ [https://components.xamarin.com/view/customnavpage   ](https://components.xamarin.com/view/customnavpage ) 


Author
Laobu – Bernard Blanckaert
