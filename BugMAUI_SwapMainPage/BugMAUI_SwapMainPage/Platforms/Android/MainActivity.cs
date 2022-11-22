using Android.App;
using Android.Content.PM;
using Android.OS;

namespace BugMAUI_SwapMainPage;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, 
    ScreenOrientation = ScreenOrientation.SensorLandscape,
    WindowSoftInputMode =Android.Views.SoftInput.AdjustPan | Android.Views.SoftInput.StateHidden )]
public class MainActivity : MauiAppCompatActivity
{
}
