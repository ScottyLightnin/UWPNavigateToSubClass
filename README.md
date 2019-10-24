# UWPNavigateToSubClass

A Simple test app to replicate a Frame.Navigate issue with sub classed UWP Pages.

Running this app in DEBUG mode, you can succesfully navigate to either the BasePage.xaml instance, or the SubclassPage1 instance.

In RELEASE mode, you can only navigate to BasePage.xaml. Attempting to navigate to SubclassPage1 throws an unhandled exception at Runtime.
