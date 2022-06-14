
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Layouts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContentViewExample : ContentView
    {
        public ContentViewExample()
        {
            InitializeComponent();
        }

        private void EmailEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            _emailAddress = e.NewTextValue;
        }

        private string _emailAddress;

        public string EmailAddress
        {
            get => _emailAddress;
        }
    }
}