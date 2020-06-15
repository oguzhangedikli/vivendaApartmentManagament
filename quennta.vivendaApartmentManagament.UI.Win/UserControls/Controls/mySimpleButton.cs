using DevExpress.XtraEditors;
using quennta.vivendaApartmentManagament.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace quennta.vivendaApartmentManagament.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class mySimpleButton:SimpleButton, IstatusBarAciklama
    {
        public mySimpleButton()
        {
            Appearance.ForeColor = Color.White;

        }

        public string statusBarAciklama { get; set; }
    }
}
