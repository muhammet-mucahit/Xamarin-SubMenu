using System.Collections.Generic;
using Xamarin_SubMenu.Models;
using Xamarin.Forms;

namespace Xamarin_SubMenu.Meta
{
    public class Menus
    {
        #region Geri
        private static readonly CategoryMenuItem Geri = new CategoryMenuItem
        {
            Id = CategoryMenuItemType.Geri,
            Title = Strings.Geri,
            LeadingIcon = Icons.BackArrow,
        };
        #endregion

        #region Anasayfa
        private static readonly CategoryMenuItem Anasayfa = new CategoryMenuItem
    {
            Id = CategoryMenuItemType.Anasayfa,
            LeadingIcon = Icons.Anasayfa,
            Title = Strings.Anasayfa.ToString(),
        };
        #endregion

        #region Insan_Kaynaklari
        private static readonly CategoryMenuItem Personellerin_Talepleri = new CategoryMenuItem
        {
            Id = CategoryMenuItemType.Personellerin_Talepleri,
            Title = Strings.Personellerin_Talepleri,
        };

        private static readonly CategoryMenuItem Izinlerim = new CategoryMenuItem
        {
            Id = CategoryMenuItemType.Izinlerim,
            Title = Strings.Izinlerim,
        };

        private static readonly CategoryMenuItem Izin_Islemleri = new CategoryMenuItem
        {
            Id = CategoryMenuItemType.Izin_Islemleri,
            Title = Strings.Izin_Islemleri,
            TrailingIcon = Icons.ForwardArrow,
        };

        private static List<CategoryMenuItem> insanKaynaklari;

        private static readonly CategoryMenuItem Insan_Kaynaklari = new CategoryMenuItem
        {
            Id = CategoryMenuItemType.Insan_Kaynaklari,
            LeadingIcon = Icons.Insan_Kaynaklari,
            Title = Strings.Insan_Kaynaklari,
            TrailingIcon = Icons.ForwardArrow,
        };
        #endregion

        #region Tasinir_Mal_Yonetimi
        private static readonly CategoryMenuItem Zimmet = new CategoryMenuItem
        {
            Id = CategoryMenuItemType.Zimmet,
            Title = Strings.Zimmet,
        };

        private static readonly CategoryMenuItem Tasinir_Mal_Yonetimi = new CategoryMenuItem
        {
            LeadingIcon = Icons.Tasinir_Mal_Yonetimi,
            Id = CategoryMenuItemType.Tasinir_Mal_Yonetimi,
            TrailingIcon = Icons.ForwardArrow,
            Title = Strings.Tasinir_Mal_Yonetimi,
        };
        #endregion

        #region Muhasebe
        private static readonly CategoryMenuItem Muhasebe = new CategoryMenuItem
        {
            Id = CategoryMenuItemType.Muhasebe,
            LeadingIcon = Icons.Muhasebe,
            TrailingIcon = Icons.ForwardArrow,
            Title = Strings.Muhasebe,
        };

        private static readonly CategoryMenuItem Fatura_Onay = new CategoryMenuItem
        {
            Id = CategoryMenuItemType.Fatura_Onay,
            Title = Strings.Fatura_Onay,
            TrailingIcon = Icons.ForwardArrow,
        };

        private static readonly CategoryMenuItem Onay_Bekleyen_Faturalar = new CategoryMenuItem
        {
            Id = CategoryMenuItemType.Onay_Bekleyen_Faturalar,
            Title = Strings.Onay_Bekleyen_Faturalar,
        };

        private static readonly CategoryMenuItem Onaylanacak_Faturalar_Personel = new CategoryMenuItem
        {
            Id = CategoryMenuItemType.Onaylanacak_Faturalar_Personel,
            Title = Strings.Onaylanacak_Faturalar,
        };

        private static readonly CategoryMenuItem Onaylanacak_Faturalar_YKB = new CategoryMenuItem
        {
            Id = CategoryMenuItemType.Onaylanacak_Faturalar_YKB,
            Title = Strings.Onaylanacak_Faturalar,
        };

        private static readonly CategoryMenuItem Onaylanacak_Faturalar_GM = new CategoryMenuItem
        {
            Id = CategoryMenuItemType.Onaylanacak_Faturalar_GM,
            Title = Strings.Onaylanacak_Faturalar,
        };

        private static readonly CategoryMenuItem Onaylanmis_Faturalar = new CategoryMenuItem
        {
            Id = CategoryMenuItemType.Onaylanmis_Faturalar,
            Title = Strings.Onaylanmis_Faturalar,
        };

        private static readonly CategoryMenuItem Onay_Surecindeki_Faturalar = new CategoryMenuItem
        {
            Id = CategoryMenuItemType.Onay_Surecindeki_Faturalar,
            Title = Strings.Onay_Surecindeki_Faturalar,
        };

        private static readonly CategoryMenuItem Reddedilmis_Faturalar_Personel = new CategoryMenuItem
        {
            Id = CategoryMenuItemType.Reddedilmis_Faturalar_Personel,
            Title = Strings.Reddedilmis_Faturalar,
        };

        private static readonly CategoryMenuItem Reddedilmis_Faturalar_Muhasebeci = new CategoryMenuItem
        {
            Id = CategoryMenuItemType.Reddedilmis_Faturalar_Muhasebeci,
            Title = Strings.Reddedilmis_Faturalar,
        };

        private static readonly CategoryMenuItem Denetim_Geribildirim_Faturalari = new CategoryMenuItem
        {
            Id = CategoryMenuItemType.Denetim_Geribildirim_Faturalari,
            Title = Strings.Denetim_Geribildirim_Faturalari,
        };

        private static List<CategoryMenuItem> faturaOnay;

        private static readonly CategoryMenuItem Adat_Hesaplama = new CategoryMenuItem
        {
            Id = CategoryMenuItemType.Adat_Hesaplama,
            Title = Strings.Adat_Hesaplama,
        };
        #endregion

        #region Yetkilendirme
        private static readonly CategoryMenuItem Yetkilendirme = new CategoryMenuItem
        {
            Id = CategoryMenuItemType.Yetkilendirme,
            LeadingIcon = Icons.Yetkilendirme,
            Title = Strings.Yetkilendirme,
        };
        #endregion

        #region Log_Kaydi
        private static readonly CategoryMenuItem Log_Kaydi = new CategoryMenuItem
        {
            Id = CategoryMenuItemType.Log_Kaydi,
            LeadingIcon = Icons.Log_Kaydi,
            Title = Strings.Log_Kaydi,
        };
        #endregion

        #region Hakkinda
        private static readonly CategoryMenuItem Hakkinda = new CategoryMenuItem
        {
            Id = CategoryMenuItemType.Hakkinda,
            LeadingIcon = Icons.Hakkinda,
            Title = Strings.Hakkinda,
        };
        #endregion

        public static List<CategoryMenuItem> menuItems;

        public static void ConstuctMenus()
        {
            Izin_Islemleri.SubItems = new List<CategoryMenuItem>
            {
                Geri,
                Personellerin_Talepleri,
                Izinlerim,
            };

            insanKaynaklari = new List<CategoryMenuItem>
            {
                Geri,
                Izin_Islemleri,
            };

            Insan_Kaynaklari.SubItems = insanKaynaklari;

            faturaOnay = new List<CategoryMenuItem>
            {
                Geri,
                Onay_Bekleyen_Faturalar,
                Onaylanacak_Faturalar_Personel,
                Onaylanacak_Faturalar_YKB,
                Onaylanacak_Faturalar_GM,
                Onay_Surecindeki_Faturalar,
                Onaylanmis_Faturalar,
                Reddedilmis_Faturalar_Personel,
                Reddedilmis_Faturalar_Muhasebeci,
                Denetim_Geribildirim_Faturalari
            };

            Fatura_Onay.SubItems = faturaOnay;

            Tasinir_Mal_Yonetimi.SubItems = new List<CategoryMenuItem>
            {
                Geri,
                Zimmet,
            };

            Muhasebe.SubItems = new List<CategoryMenuItem>
            {
                Geri,
                Fatura_Onay,
                Adat_Hesaplama,
            };

            menuItems = new List<CategoryMenuItem>
            {
                Anasayfa,
                Insan_Kaynaklari,
                Tasinir_Mal_Yonetimi,
                Muhasebe,
                Yetkilendirme,
                Log_Kaydi,
                Hakkinda,
            };
        }
    }
}