using Android.App;
using Android.Content.PM;
using Avalonia;
using Avalonia.Android;

namespace Re.NET.Android;

[Activity(
    Label = "Re.NET.Android",
    Theme = "@style/MyTheme.NoActionBar",
    Icon = "@drawable/icon",
    MainLauncher = true,
    ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize | ConfigChanges.UiMode)]
public class MainActivity : AvaloniaMainActivity
{
}
