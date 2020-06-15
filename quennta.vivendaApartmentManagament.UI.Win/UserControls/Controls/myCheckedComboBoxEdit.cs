using DevExpress.XtraEditors;
using quennta.vivendaApartmentManagament.UI.Win.Interfaces;
using System.Drawing;
using System.ComponentModel;

namespace quennta.vivendaApartmentManagament.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class myCheckedComboBoxEdit : CheckedComboBoxEdit, IStatusBarKisayol
    {
        public myCheckedComboBoxEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightSteelBlue;
            Properties.Appearance.ForeColor = Color.White;

        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string statusBarKisayol { get; set; } = "F4 :";
        public string statusBarKisayolAciklama { get; set; }
        public string statusBarAciklama { get; set; }
    }
}
