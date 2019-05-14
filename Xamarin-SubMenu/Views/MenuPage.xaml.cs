using Xamarin_SubMenu.Models;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin_SubMenu.Meta;

namespace Xamarin_SubMenu.Views
{

    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }

        public MenuPage() : this(null) { }

        public MenuPage(List<CategoryMenuItem> subItems)
        {
            Init(subItems);
        }

        void Init(List<CategoryMenuItem> subItems)
        {
            InitializeComponent();

            ListViewMenu.ItemsSource = subItems ?? Menus.menuItems;

            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                CategoryMenuItem categoryMenuItem = (CategoryMenuItem)e.SelectedItem;
                ListViewMenu.SelectedItem = null;

                await RootPage.NavigateFromMenu(categoryMenuItem);
            };
        }
    }
}