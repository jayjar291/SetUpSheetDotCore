using Avalonia;
using Avalonia.Markup.Xaml;

namespace SetUpSheet
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
   }
}