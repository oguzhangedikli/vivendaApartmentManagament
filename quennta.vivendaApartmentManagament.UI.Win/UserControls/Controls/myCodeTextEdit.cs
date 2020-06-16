using System.ComponentModel;
using System.Drawing;
using DevExpress.Utils;

namespace quennta.vivendaApartmentManagament.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class myCodeTextEdit:myTextEdit
    {
        public myCodeTextEdit()
        {
            Properties.Appearance.BackColor = Color.PaleGoldenrod;
            Properties.Appearance.ForeColor = Color.Black;
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.MaxLength = 20;
            statusBarAciklama = "Kod giriniz.";
        }
        
    }
}
