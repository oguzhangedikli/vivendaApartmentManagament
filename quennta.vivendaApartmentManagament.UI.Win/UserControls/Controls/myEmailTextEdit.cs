using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors.Mask;
using DevExpress.Utils;
using System.ComponentModel;

namespace quennta.vivendaApartmentManagament.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class myEmailTextEdit : myTextEdit
    {
        public myEmailTextEdit()
        {
            Properties.Mask.MaskType = MaskType.RegEx;
            Properties.Mask.EditMask = @"((([0-9a-zA-Z_%-])+[.])+|([0-9a-zA-Z_%-])+)+@((([0-9a-zA-Z_-])+[.])+|([0-9a-zA-Z_-])+)+";
            Properties.Mask.AutoComplete = AutoCompleteType.Strong;
            statusBarAciklama = "E-Mail Adresi Giriniz";
        }
    }
}
