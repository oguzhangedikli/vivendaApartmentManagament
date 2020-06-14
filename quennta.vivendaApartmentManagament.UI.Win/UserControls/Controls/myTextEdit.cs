using DevExpress.XtraEditors;
using quennta.vivendaApartmentManagament.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace quennta.vivendaApartmentManagament.UI.Win.UserControls.Controls
{
    public class myTextEdit:TextEdit,IstatusBarAciklama
    {
        [ToolboxItem(true)]
        public myTextEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightBlue;
            Properties.MaxLength = 50;

        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string statusBarAciklama { get; set; }
    }
}
