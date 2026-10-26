using Android.App;
using Android.Content.PM;

using Avalonia.Android;

namespace Exmaple2._0.Android;

[Activity(
    Label = "MsBox Example",
    Theme = "@style/MyTheme.NoActionBar",
    Icon = "@drawable/icon",
    MainLauncher = true,
    ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize | ConfigChanges.UiMode)]
public class MainActivity : AvaloniaMainActivity<App>
{
}
