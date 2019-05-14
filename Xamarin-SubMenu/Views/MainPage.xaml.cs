using Xamarin_SubMenu.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_SubMenu.Meta;

namespace Xamarin_SubMenu.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, Page> MenuItems = new Dictionary<int, Page>();
        Stack<Page> pages = new Stack<Page>();

        public MainPage()
        {
            InitializeComponent();
        }
        public async Task NavigateFromMenu(CategoryMenuItem item)
        {
            int id = (int)item.Id;
            bool hasSubItems = (item.SubItems != null);

            if (item.Id == CategoryMenuItemType.Geri)
            {
                Master = pages.Pop();
                return;
            }

            if (!MenuItems.ContainsKey(id))
            {
                if (hasSubItems)
                {
                    MenuItems.Add(id, new MenuPage(item.SubItems));
                }
                else
                {
                    switch (id)
                    {
                        case (int)CategoryMenuItemType.Anasayfa:
                            MenuItems.Add(id, new NavigationPage(new ComingSoon(Strings.Anasayfa)));
                            break;
                        case (int)CategoryMenuItemType.Yetkilendirme:
                            MenuItems.Add(id, new NavigationPage(new ComingSoon(Strings.Yetkilendirme)));
                            break;
                        case (int)CategoryMenuItemType.Log_Kaydi:
                            MenuItems.Add(id, new NavigationPage(new ComingSoon(Strings.Log_Kaydi)));
                            break;
                        case (int)CategoryMenuItemType.Hakkinda:
                            MenuItems.Add(id, new NavigationPage(new ComingSoon(Strings.Hakkinda)));
                            break;
                        case (int)CategoryMenuItemType.Personellerin_Talepleri:
                            MenuItems.Add(id, new NavigationPage(new ComingSoon(Strings.Personellerin_Talepleri)));
                            break;
                        case (int)CategoryMenuItemType.Izinlerim:
                            MenuItems.Add(id, new NavigationPage(new ComingSoon(Strings.Izinlerim)));
                            break;
                        case (int)CategoryMenuItemType.Zimmet:
                            MenuItems.Add(id, new NavigationPage(new ComingSoon(Strings.Zimmet)));
                            break;
                        case (int)CategoryMenuItemType.Onay_Bekleyen_Faturalar:
                            MenuItems.Add(id, new NavigationPage(new ComingSoon(Strings.Onay_Bekleyen_Faturalar)));
                            break;
                        case (int)CategoryMenuItemType.Onaylanacak_Faturalar_Personel:
                            MenuItems.Add(id, new NavigationPage(new ComingSoon(Strings.Onaylanacak_Faturalar)));
                            break;
                        case (int)CategoryMenuItemType.Onaylanacak_Faturalar_YKB:
                            MenuItems.Add(id, new NavigationPage(new ComingSoon(Strings.Onaylanacak_Faturalar)));
                            break;
                        case (int)CategoryMenuItemType.Onaylanacak_Faturalar_GM:
                            MenuItems.Add(id, new NavigationPage(new ComingSoon(Strings.Onaylanacak_Faturalar)));
                            break;
                        case (int)CategoryMenuItemType.Onay_Surecindeki_Faturalar:
                            MenuItems.Add(id, new NavigationPage(new ComingSoon(Strings.Onay_Surecindeki_Faturalar)));
                            break;
                        case (int)CategoryMenuItemType.Onaylanmis_Faturalar:
                            MenuItems.Add(id, new NavigationPage(new ComingSoon(Strings.Onaylanmis_Faturalar)));
                            break;
                        case (int)CategoryMenuItemType.Reddedilmis_Faturalar_Personel:
                            MenuItems.Add(id, new NavigationPage(new ComingSoon(Strings.Reddedilmis_Faturalar)));
                            break;
                        case (int)CategoryMenuItemType.Reddedilmis_Faturalar_Muhasebeci:
                            MenuItems.Add(id, new NavigationPage(new ComingSoon(Strings.Reddedilmis_Faturalar)));
                            break;
                        case (int)CategoryMenuItemType.Denetim_Geribildirim_Faturalari:
                            MenuItems.Add(id, new NavigationPage(new ComingSoon(Strings.Denetim_Geribildirim_Faturalari)));
                            break;
                        case (int)CategoryMenuItemType.Adat_Hesaplama:
                            MenuItems.Add(id, new NavigationPage(new ComingSoon(Strings.Adat_Hesaplama)));
                            break;
                    }
                }
            }

            var newPage = MenuItems[id];

            if (newPage != null)
            {
                if (hasSubItems)
                {
                    pages.Push(Master);
                    Master = newPage;
                }
                else
                {
                    Detail = newPage;

                    if (Device.RuntimePlatform == Device.Android)
                        await Task.Delay(100);

                    IsPresented = false;
                }
            }
        }
    }
}