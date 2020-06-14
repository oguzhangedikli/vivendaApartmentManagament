using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using quennta.vivendaApartmentManagament.UI.Win.Interfaces;
using System.ComponentModel;

namespace quennta.vivendaApartmentManagament.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class myComboBoxEdit : ComboBoxEdit, IStatusBarKisayol
    {
        public myComboBoxEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightBlue;
            //Arka plan odaklanıldığında değişiyor. 

            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            //Text kısmına yazı yazılaması için disabled edildi.
            //eşittireden sonra ctrl+space tuşuna bastığımızda gelmesi gereken değer seçili olarak geliyor. 
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string statusBarKisayol { get; set; } = "F4 :";
        public string statusBarKisayolAciklama { get; set; }
        public string statusBarAciklama { get; set; }
    }
}
