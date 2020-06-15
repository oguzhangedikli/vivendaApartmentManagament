using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.Utils;
using quennta.vivendaApartmentManagament.UI.Win.Interfaces;
using System.ComponentModel;

namespace quennta.vivendaApartmentManagament.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class mySpinEdit: SpinEdit,IstatusBarAciklama
    {
        public mySpinEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightSteelBlue;
            Properties.AppearanceFocused.ForeColor = Color.Black;
            Properties.Appearance.ForeColor = Color.White;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.EditMask = "d";
        }
        public override bool EnterMoveNextControl { get; set; }=true;
        public string statusBarAciklama { get; set; }
    }
}
