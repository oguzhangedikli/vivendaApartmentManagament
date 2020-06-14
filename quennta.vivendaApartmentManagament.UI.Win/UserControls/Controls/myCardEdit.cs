using DevExpress.Data.Utils;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using quennta.vivendaApartmentManagament.UI.Win.Interfaces;
using quennta.vivendaApartmentManagament.UI.Win.UserControls.Controls;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace quennta.vivendaApartmentManagament.UI.Win.UserControls
{
    public class myCardEdit : myTextEdit
    {
        [ToolboxItem(true)]
        public myCardEdit()
        {
            Properties.AppearanceReadOnly.BackColor = Color.LightBlue;
            Properties.MaxLength = 19;
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            //Text'e değer girerken girilen değerler ortada yazmakta.

            Properties.Mask.MaskType = MaskType.Regular;
            //Maskenin tipini belirledik. Regular= istediğimiz gibi yapabileceğimiz anlamına gelmekte.

            Properties.Mask.EditMask = @"\d?\d?\d?\d?-\d?\d?\d?\d?-\d?\d?\d?\d?-\d?\d?\d?\d?";
            //4 karakter girdikten sonra araya tire koyarak ayıran kod toplam 16 karakter girilebilir.
            //d?' buraya değer girilebilir aynı zamanda null de olabilir. d= karakterleri ?=boş olabileceğini gösteriyor.
            //Sola yatık slashları tanıması için satırın basşına @ işareti koyulur. 

            Properties.Mask.AutoComplete = AutoCompleteType.None;
            //Biz rakam yazmadan rakam yazma. kullanıcıdan önce text alanına herhangi bir sayı atamaması için.
            
            statusBarAciklama = "Kart No Giriniz";
            //mycardedit compenentini mytextedit üzerinden implemente ettiğimiz için statusbaracıklama static itemini burada kullanabiliyoruz
        }
    }
}
