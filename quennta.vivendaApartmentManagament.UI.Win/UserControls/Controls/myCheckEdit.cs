using DevExpress.XtraEditors;
using quennta.vivendaApartmentManagament.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace quennta.vivendaApartmentManagament.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class myCheckEdit : CheckEdit, IstatusBarAciklama
    {
        public myCheckEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.Transparent;

        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string statusBarAciklama { get; set; }
    }
}
