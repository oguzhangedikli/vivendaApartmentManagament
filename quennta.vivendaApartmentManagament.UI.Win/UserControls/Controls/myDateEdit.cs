using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using DevExpress.XtraEditors.Mask;
using DevExpress.Utils;
using quennta.vivendaApartmentManagament.UI.Win.Interfaces;
using System.ComponentModel;

namespace quennta.vivendaApartmentManagament.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class myDateEdit:DateEdit,IStatusBarKisayol
    {
        public myDateEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.Gray;
            Properties.AllowNullInput = DefaultBoolean.False;
            //Tarih alanı null olmaması için yazılan kod

            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            //Tarihi ortalı bir şekilde yazan kod

            Properties.Mask.MaskType=MaskType.DateTimeAdvancingCaret;
            //sıralı bir şekilde günü yazınca aya ayı yazınca yıla otomatik geçiş yapsın.
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string statusBarKisayol { get; set; }= "F4 :";
        public string statusBarKisayolAciklama { get; set; } = "Tarih Seç";
        public string statusBarAciklama { get; set; }
    }
}
