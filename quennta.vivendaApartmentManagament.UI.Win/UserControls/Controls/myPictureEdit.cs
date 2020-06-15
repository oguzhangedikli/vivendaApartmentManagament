using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using quennta.vivendaApartmentManagament.UI.Win.Interfaces;
using System.ComponentModel;

namespace quennta.vivendaApartmentManagament.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class myPictureEdit:PictureEdit,IStatusBarKisayol
    {
        public myPictureEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightSteelBlue;
            Properties.Appearance.ForeColor = Color.White;
            Properties.AppearanceFocused.ForeColor = Color.Black;

            Properties.NullText = "Resim Yok";
            Properties.SizeMode = PictureSizeMode.Stretch;
            Properties.ShowMenu = false;


        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string statusBarKisayol { get; set; }
        public string statusBarKisayolAciklama { get; set; }
        public string statusBarAciklama { get; set; }
    }
}
