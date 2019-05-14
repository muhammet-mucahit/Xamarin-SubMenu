using Xamarin_SubMenu.Meta;
using Xamarin.Forms;

namespace Xamarin_SubMenu.Views
{
    public partial class ComingSoon : ContentPage
    {
        public ComingSoon()
        {
            InitializeComponent();
            this.Title = Strings.Anasayfa;
            lbl_alert.Text = "Çok Yakında Hizmetinizde!";
        }

        public ComingSoon(string Title)
        {
            InitializeComponent();
            this.Title = Title;
            lbl_alert.Text = "Çok Yakında Hizmetinizde!";
        }
    }
}
