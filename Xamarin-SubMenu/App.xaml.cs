using Xamarin.Forms;
using Xamarin_SubMenu.Meta;
using Xamarin_SubMenu.Views;

namespace Xamarin_SubMenu
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            // Constructs menus from Meta.Menus
            Menus.ConstuctMenus();

            // Responsive fonts for different device sizes
            Size size = Device.Info.PixelScreenSize;

            int fontSize;

            if (size.Width > 1200)
                fontSize = 16;
            else if (size.Width > 800)
                fontSize = 15;
            else if (size.Width > 600)
                fontSize = 14;
            else
                fontSize = 13;

            var MenuItemTextStyle = new Style(typeof(Label))
            {
                Setters = {
                    new Setter { Property = Label.TextColorProperty, Value = Current.Resources["OnPrimary"] },
                    new Setter { Property = Label.FontSizeProperty, Value = fontSize},
                    new Setter { Property = Label.FontAttributesProperty, Value = FontAttributes.Bold },
                    new Setter { Property = View.MarginProperty, Value = new Thickness(10, 0, 0, 0)},
                    new Setter { Property = Label.FontFamilyProperty, Value = Current.Resources["Font"] },
                    new Setter { Property = Label.VerticalTextAlignmentProperty, Value = TextAlignment.Center }
                }
            };

            Resources.Add
            (
                new ResourceDictionary
                {
                    { "MenuItemTextStyle", MenuItemTextStyle }
                }
            );

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
