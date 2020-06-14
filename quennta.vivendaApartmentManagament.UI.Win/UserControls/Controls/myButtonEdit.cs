using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using quennta.vivendaApartmentManagament.UI.Win.Interfaces;
using System.Drawing;
using System;
using System.Security.Cryptography.X509Certificates;
using DevExpress.Xpo.DB.Helpers;
using System.ComponentModel;

namespace quennta.vivendaApartmentManagament.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class myButtonEdit : ButtonEdit, IStatusBarKisayol //Statusbarkisayol interface'inden implemente ediliyor.
    {
        //Buttonlar değiştiğinde arkaplanda değişen id'lerin bu değişkende saklıyoruz.

        public myButtonEdit()
        {
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            //Kendi oluşturduğumuz myButtonEdit compenentinin içine devexpressin buttonEdit compenentindeki textedit 
            //özelliğini disable olarak aktarıyoruz. Button üzerindeki yazılar program içerisinde düzenlenemiyor bu sayede
            Properties.Appearance.BackColor = Color.LightSkyBlue;
            //Button üstüne gelindiğinde arkaplan rengini değiştime.
            
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        //properties olduğu için override. Enter tuşuna basıldığında bir sonraki alana gelmesi için bu proprt. false
        //yerine true olarak değiştirildi.
        public string statusBarAciklama { get; set; }
        public string statusBarKisayol { get; set; } = "f4 :";
        public string statusBarKisayolAciklama { get; set; }
        //formun alt kısmında bulunan bilgilendirme buttonlarının aktif hale getirilmesi.

        #region Events
        private long? _Id;

        [Browsable(false)]
        public long? Id
        {
            get => _Id;
            set
            {
                var oldValue = _Id;
                var newValue = value;
                if (newValue == oldValue) return;
                _Id = value;
                IdChanged?.Invoke(this, new IdChangedEventArgs(oldValue, newValue));
                //IdChanged "Null" değilse eventi çalıştır.
            }
        }

        public event EventHandler<IdChangedEventArgs> IdChanged;
        //Event handler ile Id'si bulunan buttonların değişen id lerini yakalama. 

        #endregion
    }
    public class IdChangedEventArgs : EventArgs
    {
        public IdChangedEventArgs(long? oldValue,long? newValue)
        {
            oldValue = oldValue;
            NewValue = newValue;
        }
        public long? OldValue { get;}
        //bir önceki id.
        public long? NewValue { get;}
        //yeni id.
    }
    
}
