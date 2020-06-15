using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.Utils;
using quennta.vivendaApartmentManagament.UI.Win.Interfaces;
using System.ComponentModel;

namespace quennta.vivendaApartmentManagament.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class myCalcEdit:CalcEdit, IStatusBarKisayol
        //devexxpress'in calcedit compementinden ve bizim oluşturduğumuz IstatusBarKisayol interface'inden implemente etmekte. 
        //Buton olduğu için form altında hangi kısayolu kullanmamız gerektiğini gösteren ıstatusbarkisayol interface'i kullanılıyor. 
        //Buton olmasaydı Istatusbaraciklama interface'i kullanılacaktı.
    {
        public myCalcEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightSteelBlue;
            //Üstüne tıklandığında arkadaplanı deiştirmekte.
            Properties.AppearanceFocused.ForeColor = Color.Black;
            Properties.Appearance.ForeColor = Color.White;




            Properties.AllowNullInput = DefaultBoolean.False;
            //Boş değer olmamasını yani null olmamasını sağlamakta.


            Properties.EditMask = "n2";
            //editmask ile haneler arasında nokta koyabilir ve noktadan sonra kaç değer olabileceğini girebiliriz. 
            //n2 ise bize 3 haneden sonra nokta koymamızı ve noktadan sonra kuruş için iki adet  girmemizi sağlıyor. 
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string statusBarKisayol { get; set; }="F4 :";
        public string statusBarKisayolAciklama { get; set; } = "Hesap Makinesi";
        public string statusBarAciklama { get; set; }
    }
}
