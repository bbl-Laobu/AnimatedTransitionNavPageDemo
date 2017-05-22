# SlideMenuDemo
A simple but effective Xamarin Forms SlideMenu Demo

## INTRODUCTION
A simple demo application demonstrating how to create a Slide Menu using only CORE Xamarin Forms.

![Demo](https://raw.githubusercontent.com/bbl-Laobu/SlideMenuDemo/master/SimpleSlideMenuDemo.gif)

## DESCRIPTION
The demo uses a combination of Grid Layout, Layers and Translate Animation to create a smooth Slide Menu when tapping the menu button at the bottom.

![Concept](https://raw.githubusercontent.com/bbl-Laobu/SlideMenuDemo/master/SlideMenuPictureA.png)

A SlideUpMenuView defines the layout of the menu. This view is then used twice in the StartPage; once for the animation of sliding the menu up/down and once for detecting interactions when open.

To avoid any flickering, we must make sure that when switching between Animated SlideMenuView and Interactive SlideMenuView both are aligned perfectly. Therefore, we use a Grid Layout to position the Interactive SlideMenuView at exactly 240 (40 + 200) from the bottom of the screen. We place it there, hidden in the background behind the content view waiting to be shown when ready. 

When starting the app, we begin by showing the Animated SlideMenuView on Grid Row 2, 40 from the bottom. Once we get an event to slide open the menu, we move (Translate animation) the Animated SlideMenuView to Grid Row 1 (-200 vertically up). Once in place, we finish by Raising the Interactive SlideMenuView to the front of the Layout. The menu is now fully displayed and can be interacted with.

![Steps](https://github.com/bbl-Laobu/SlideMenuDemo/raw/master/SlideMenuPictureB.png)

Using 2 SlideMenuViews is needed because when only using the Animated SlideViewMenu, Xamarin is unable to detect gestures on that SlideViewMenu as the interactive user controls on the layer underneath are still detected instead. This makes the menu visible but useless. 

Adding a second SlideMenuView, positioned exactly under the extended Animated menu and then moved in front when the animation is finished, solves the gesture detection problem, allowing for the interactive object of the menu to work.  

To demonstrate this, a Carouselview was added which allows you to navigate to a Scrollview with many interactive user controls. Notice that the user controls underneath the menu do no longer work once the menu is extended.

In conclusion; using this system should allow us to easily create any type of slide menu/form regardless of side, animation and size. We use grid to determine upfront where we want the menu to be displayed for interaction, and then use an animated version to move it to that exact location before switching between both. 

Enjoy and any question or improvements, please let me know.

Laobu!


## REFERENCES
- ‘Grid - Present views in grids.’ By Xamarin @ [https://developer.xamarin.com/guides/xamarin-forms/user-interface/layouts/grid/](https://developer.xamarin.com/guides/xamarin-forms/user-interface/layouts/grid/ )
- ‘Carousel View’ by alexrainman @ [https://github.com/alexrainman/CarouselView](https://github.com/alexrainman/CarouselView)
- ‘Creating Animations with Xamarin.Forms’ by David Britch @ [https://blog.xamarin.com/creating-animations-with-xamarin-forms/](https://blog.xamarin.com/creating-animations-with-xamarin-forms/)


Author
Laobu – Bernard Blanckaert
