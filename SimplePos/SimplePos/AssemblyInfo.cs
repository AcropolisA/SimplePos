using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

#if DEBUG
[assembly: XmlnsDefinition("debug-mode", "Namespace")]
#endif