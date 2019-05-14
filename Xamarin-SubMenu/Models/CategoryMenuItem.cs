using System.Collections.Generic;

namespace Xamarin_SubMenu.Models
{
    public enum CategoryMenuItemType
    {
        Geri,
        Anasayfa,
        Hakkinda,
        Tasinir_Mal_Yonetimi,
        Zimmet,
        Muhasebe,
        Fatura_Onay,
        Onay_Bekleyen_Faturalar,
        Onaylanacak_Faturalar_Personel,
        Onaylanacak_Faturalar_YKB,
        Onaylanacak_Faturalar_GM,
        Onay_Surecindeki_Faturalar,
        Onaylanmis_Faturalar,
        Reddedilmis_Faturalar_Personel,
        Reddedilmis_Faturalar_Muhasebeci,
        Denetim_Geribildirim_Faturalari,
        Adat_Hesaplama,
        Altin_Fikirler,
        Fikirlerim,
        Fikirlere_Oy_Ver,
        Insan_Kaynaklari,
        Izin_Islemleri,
        Izinlerim,
        Personellerin_Talepleri,
        Yetkilendirme,
        Log_Kaydi
    }

    public class CategoryMenuItem
    {
        public CategoryMenuItemType Id { get; set; }
        public string LeadingIcon { get; set; }
        public string Title { get; set; }
        public string TrailingIcon { get; set; }
        public List<CategoryMenuItem> SubItems { get; set; }
        public bool IsVisible { get; set; } = false;
    }
}
