﻿using DevExpress.XtraEditors;
using quennta.vivendaApartmentManagament.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace quennta.vivendaApartmentManagament.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class myMemoEdit:MemoEdit,IstatusBarAciklama
    {
        public myMemoEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightSteelBlue;
            Properties.AppearanceFocused.ForeColor = Color.Black;
            Properties.Appearance.ForeColor = Color.White;

            Properties.MaxLength = 500;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string statusBarAciklama { get; set; } = "Açıklama giriniz";
    }
}
