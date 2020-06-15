using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.Utils;
using quennta.vivendaApartmentManagament.UI.Win.Interfaces;
using System.ComponentModel;

namespace quennta.vivendaApartmentManagament.UI.Win.UserControls.Controls
{
    public class myToogleSwitchEdit : ToggleSwitch,IstatusBarAciklama
    {
        [ToolboxItem(true)]
        public myToogleSwitchEdit()
        {
            Name = "tglDurum";
            Properties.OffText = "Pasif";
            Properties.OnText = "Aktif";
            Properties.AutoHeight = false;
            Properties.AutoWidth = true;
            Properties.GlyphAlignment = HorzAlignment.Far;
            Properties.Appearance.ForeColor = Color.Yellow;

        }
        public override bool EnterMoveNextControl { get; set; } = true;

        public string statusBarAciklama { get; set; } = "Kartın Kullanım Durumunu Seçiniz.";
    }
}
