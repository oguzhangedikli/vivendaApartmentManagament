namespace quennta.vivendaApartmentManagament.UI.Win.Forms.sitesForms
{
    partial class siteCardsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid = new quennta.vivendaApartmentManagament.UI.Win.UserControls.Grid.myGridControl();
            this.tablo = new quennta.vivendaApartmentManagament.UI.Win.UserControls.Grid.myGridView();
            this.colId = new quennta.vivendaApartmentManagament.UI.Win.UserControls.Grid.myGridColumn();
            this.colKod = new quennta.vivendaApartmentManagament.UI.Win.UserControls.Grid.myGridColumn();
            this.colSiteAdi = new quennta.vivendaApartmentManagament.UI.Win.UserControls.Grid.myGridColumn();
            this.colIlAdi = new quennta.vivendaApartmentManagament.UI.Win.UserControls.Grid.myGridColumn();
            this.colIlceAdi = new quennta.vivendaApartmentManagament.UI.Win.UserControls.Grid.myGridColumn();
            this.colMahalleAdi = new quennta.vivendaApartmentManagament.UI.Win.UserControls.Grid.myGridColumn();
            this.colAdres = new quennta.vivendaApartmentManagament.UI.Win.UserControls.Grid.myGridColumn();
            this.colAciklama = new quennta.vivendaApartmentManagament.UI.Win.UserControls.Grid.myGridColumn();
            this.longNavigator1 = new quennta.vivendaApartmentManagament.UI.Win.UserControls.Navigators.LongNavigator();
            this.kolonlarBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.kolonlarBarButtonItem});
            this.ribbonControl.MaxItemId = 17;
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.Size = new System.Drawing.Size(1052, 95);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 95);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1052, 385);
            this.grid.TabIndex = 3;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            this.grid.Click += new System.EventHandler(this.grid_Click);
            // 
            // tablo
            // 
            this.tablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Blue;
            this.tablo.Appearance.FooterPanel.Options.UseFont = true;
            this.tablo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.tablo.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Blue;
            this.tablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.White;
            this.tablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKod,
            this.colSiteAdi,
            this.colIlAdi,
            this.colIlceAdi,
            this.colMahalleAdi,
            this.colAdres,
            this.colAciklama});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintFooter = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.ColumnAutoWidth = false;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowAutoFilterRow = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.statusBarAciklama = null;
            this.tablo.statusBarKisayol = null;
            this.tablo.statusBarKisayolAciklama = null;
            this.tablo.ViewCaption = "Site / Apartman Kartları";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.statusBarAciklama = null;
            this.colId.statusBarKisayol = null;
            this.colId.statusBarKisayolAciklama = null;
            // 
            // colKod
            // 
            this.colKod.AppearanceCell.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.colKod.AppearanceCell.Options.UseForeColor = true;
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.AppearanceHeader.ForeColor = System.Drawing.Color.Gold;
            this.colKod.AppearanceHeader.Options.UseForeColor = true;
            this.colKod.Caption = "Kod";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.statusBarAciklama = null;
            this.colKod.statusBarKisayol = null;
            this.colKod.statusBarKisayolAciklama = null;
            this.colKod.Visible = true;
            this.colKod.VisibleIndex = 0;
            this.colKod.Width = 110;
            // 
            // colSiteAdi
            // 
            this.colSiteAdi.AppearanceCell.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.colSiteAdi.AppearanceCell.Options.UseForeColor = true;
            this.colSiteAdi.AppearanceHeader.ForeColor = System.Drawing.Color.Gold;
            this.colSiteAdi.AppearanceHeader.Options.UseForeColor = true;
            this.colSiteAdi.Caption = "Site Adı";
            this.colSiteAdi.FieldName = "SiteAdi";
            this.colSiteAdi.Name = "colSiteAdi";
            this.colSiteAdi.OptionsColumn.AllowEdit = false;
            this.colSiteAdi.statusBarAciklama = null;
            this.colSiteAdi.statusBarKisayol = null;
            this.colSiteAdi.statusBarKisayolAciklama = null;
            this.colSiteAdi.Visible = true;
            this.colSiteAdi.VisibleIndex = 1;
            this.colSiteAdi.Width = 170;
            // 
            // colIlAdi
            // 
            this.colIlAdi.AppearanceCell.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.colIlAdi.AppearanceCell.Options.UseForeColor = true;
            this.colIlAdi.AppearanceHeader.ForeColor = System.Drawing.Color.Gold;
            this.colIlAdi.AppearanceHeader.Options.UseForeColor = true;
            this.colIlAdi.Caption = "İl";
            this.colIlAdi.FieldName = "Il";
            this.colIlAdi.Name = "colIlAdi";
            this.colIlAdi.OptionsColumn.AllowEdit = false;
            this.colIlAdi.statusBarAciklama = null;
            this.colIlAdi.statusBarKisayol = null;
            this.colIlAdi.statusBarKisayolAciklama = null;
            this.colIlAdi.Visible = true;
            this.colIlAdi.VisibleIndex = 2;
            this.colIlAdi.Width = 110;
            // 
            // colIlceAdi
            // 
            this.colIlceAdi.AppearanceCell.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.colIlceAdi.AppearanceCell.Options.UseForeColor = true;
            this.colIlceAdi.AppearanceHeader.ForeColor = System.Drawing.Color.Gold;
            this.colIlceAdi.AppearanceHeader.Options.UseForeColor = true;
            this.colIlceAdi.Caption = "İlçe";
            this.colIlceAdi.FieldName = "Ilce";
            this.colIlceAdi.Name = "colIlceAdi";
            this.colIlceAdi.OptionsColumn.AllowEdit = false;
            this.colIlceAdi.statusBarAciklama = null;
            this.colIlceAdi.statusBarKisayol = null;
            this.colIlceAdi.statusBarKisayolAciklama = null;
            this.colIlceAdi.Visible = true;
            this.colIlceAdi.VisibleIndex = 3;
            this.colIlceAdi.Width = 110;
            // 
            // colMahalleAdi
            // 
            this.colMahalleAdi.AppearanceCell.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.colMahalleAdi.AppearanceCell.Options.UseForeColor = true;
            this.colMahalleAdi.AppearanceHeader.ForeColor = System.Drawing.Color.Gold;
            this.colMahalleAdi.AppearanceHeader.Options.UseForeColor = true;
            this.colMahalleAdi.Caption = "Mahalle";
            this.colMahalleAdi.FieldName = "Mahalle";
            this.colMahalleAdi.Name = "colMahalleAdi";
            this.colMahalleAdi.OptionsColumn.AllowEdit = false;
            this.colMahalleAdi.statusBarAciklama = null;
            this.colMahalleAdi.statusBarKisayol = null;
            this.colMahalleAdi.statusBarKisayolAciklama = null;
            this.colMahalleAdi.Visible = true;
            this.colMahalleAdi.VisibleIndex = 4;
            this.colMahalleAdi.Width = 140;
            // 
            // colAdres
            // 
            this.colAdres.AppearanceCell.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.colAdres.AppearanceCell.Options.UseForeColor = true;
            this.colAdres.AppearanceHeader.ForeColor = System.Drawing.Color.Gold;
            this.colAdres.AppearanceHeader.Options.UseForeColor = true;
            this.colAdres.Caption = "Adres";
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.OptionsColumn.AllowEdit = false;
            this.colAdres.statusBarAciklama = null;
            this.colAdres.statusBarKisayol = null;
            this.colAdres.statusBarKisayolAciklama = null;
            this.colAdres.Visible = true;
            this.colAdres.VisibleIndex = 5;
            this.colAdres.Width = 190;
            // 
            // colAciklama
            // 
            this.colAciklama.AppearanceCell.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.colAciklama.AppearanceCell.Options.UseForeColor = true;
            this.colAciklama.AppearanceHeader.ForeColor = System.Drawing.Color.Gold;
            this.colAciklama.AppearanceHeader.Options.UseForeColor = true;
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.statusBarAciklama = null;
            this.colAciklama.statusBarKisayol = null;
            this.colAciklama.statusBarKisayolAciklama = null;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 6;
            this.colAciklama.Width = 190;
            // 
            // longNavigator1
            // 
            this.longNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator1.Location = new System.Drawing.Point(0, 480);
            this.longNavigator1.Name = "longNavigator1";
            this.longNavigator1.Size = new System.Drawing.Size(1052, 21);
            this.longNavigator1.TabIndex = 4;
            // 
            // kolonlarBarButtonItem
            // 
            this.kolonlarBarButtonItem.Caption = "Kolonlar";
            this.kolonlarBarButtonItem.Id = 16;
            this.kolonlarBarButtonItem.ImageOptions.SvgImage = global::quennta.vivendaApartmentManagament.UI.Win.Properties.Resources.compressweekend;
            this.kolonlarBarButtonItem.Name = "kolonlarBarButtonItem";
            // 
            // siteCardsForm
            // 
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 525);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator1);
            this.IconOptions.ShowIcon = false;
            this.Name = "siteCardsForm";
            this.Text = "Site / Apartman Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator1, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UserControls.Grid.myGridControl grid;
        private UserControls.Grid.myGridView tablo;
        private UserControls.Grid.myGridColumn colId;
        private UserControls.Grid.myGridColumn colKod;
        private UserControls.Navigators.LongNavigator longNavigator1;
        private UserControls.Grid.myGridColumn colSiteAdi;
        private UserControls.Grid.myGridColumn colIlAdi;
        private UserControls.Grid.myGridColumn colIlceAdi;
        private UserControls.Grid.myGridColumn colMahalleAdi;
        private UserControls.Grid.myGridColumn colAdres;
        private UserControls.Grid.myGridColumn colAciklama;
        private DevExpress.XtraBars.BarButtonItem kolonlarBarButtonItem;
    }
}