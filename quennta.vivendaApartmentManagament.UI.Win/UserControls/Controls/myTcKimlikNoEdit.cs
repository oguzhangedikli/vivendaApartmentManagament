using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;

namespace quennta.vivendaApartmentManagament.UI.Win.UserControls.Controls
{
    public class myTcKimlikNoEdit : myTextEdit
    {
        [ToolboxItem(true)]
        public myTcKimlikNoEdit()
        {
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.EditMask = @"\d?\d?\d? \d?\d?\d? \d?\d?\d? \d?\d?";
            Properties.Mask.AutoComplete = AutoCompleteType.None;
            statusBarAciklama = "TC Kimlik No Giriniz.";
        }
    }
}
