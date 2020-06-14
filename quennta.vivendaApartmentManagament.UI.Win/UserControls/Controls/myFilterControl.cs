using DevExpress.XtraEditors;
using quennta.vivendaApartmentManagament.UI.Win.Interfaces;
using System.ComponentModel;

namespace quennta.vivendaApartmentManagament.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class myFilterControl:FilterControl, IstatusBarAciklama
    {
        public myFilterControl()
        {
            ShowGroupCommandsIcon = true;
            //Filtrede gruplama yaparken image'ın çıkmasını sağlıyor.
        }

        public string statusBarAciklama { get; set; } = "Filtre metni giriniz.";
    }
}
