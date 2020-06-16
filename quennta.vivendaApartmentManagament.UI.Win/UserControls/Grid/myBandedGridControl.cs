using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using quennta.vivendaApartmentManagament.UI.Win.Interfaces;
using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraGrid.Views.Base;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using System.ComponentModel;
using DevExpress.XtraGrid.Registrator;

namespace quennta.vivendaApartmentManagament.UI.Win.UserControls.Grid
{
    [ToolboxItem(true)]
    public class myBandedGridControl : GridControl
    {
        protected override BaseView CreateDefaultView()
        {
            var view = (myBandedGridView)CreateView("myBandedGridView");

            view.Appearance.BandPanel.ForeColor = Color.Blue;
            view.Appearance.BandPanel.Font = new Font(new FontFamily("Century SchoolBook"), 9f, FontStyle.Bold);
            view.Appearance.BandPanel.TextOptions.HAlignment = HorzAlignment.Center;
            view.BandPanelRowHeight = 40;

            view.Appearance.ViewCaption.ForeColor = Color.White;
            view.Appearance.HeaderPanel.ForeColor = Color.Blue;
            view.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center;

            view.Appearance.FooterPanel.ForeColor = Color.Blue;
            view.Appearance.FooterPanel.Font = new Font(new FontFamily("Century SchoolBook"), 9f,FontStyle.Bold);

            view.OptionsMenu.EnableColumnMenu = false;
            view.OptionsMenu.EnableFooterMenu = false;
            view.OptionsMenu.EnableGroupPanelMenu = false;

            view.OptionsNavigation.EnterMoveNextColumn = true;


            view.OptionsPrint.AutoWidth = false;
            view.OptionsPrint.PrintFooter = false;
            view.OptionsPrint.PrintGroupFooter = false;

            view.OptionsView.ShowAutoFilterRow = true;
            view.OptionsView.ShowViewCaption = true;
            view.OptionsView.ShowGroupPanel = false;
            view.OptionsView.ColumnAutoWidth = false;
            view.OptionsView.RowAutoHeight = true;
            view.OptionsView.HeaderFilterButtonShowMode = FilterButtonShowMode.Button;

            #region Columns
            var idColumn = new BandedGridColumn
            {
                Caption = "Id",
                FieldName = "Id",
            };
            idColumn.OptionsColumn.AllowEdit = false;

            idColumn.OptionsColumn.ShowInCustomizationForm = false;
            view.Columns.Add(idColumn);


            var kodColumn = new BandedGridColumn
            {
                Caption = "Kod",
                FieldName = "Kod",
            };
            kodColumn.OptionsColumn.AllowEdit = false;
            kodColumn.Visible = true;
            kodColumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            kodColumn.AppearanceCell.Options.UseTextOptions = true;
            view.Columns.Add(kodColumn);
            
            
            return view;
            #endregion
        }
        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new myBandedGridInfoRegistrator());
        }

        private class myBandedGridInfoRegistrator : BandedGridInfoRegistrator
        {
            public override string ViewName => "myBandedGridView";
            public override BaseView CreateView(GridControl grid) => new myBandedGridView(grid);

        }
    }
    public class myBandedGridView : BandedGridView, IStatusBarKisayol
    {
        #region Properties
        public string statusBarKisayol { get; set; }
        public string statusBarKisayolAciklama { get; set; }
        public string statusBarAciklama { get; set; }
        #endregion
        public myBandedGridView() { }

        public myBandedGridView(GridControl ownerGrid) : base(ownerGrid) { }


        protected override void OnColumnChangedCore(GridColumn column)
        {
            base.OnColumnChangedCore(column);
            if (column.ColumnEdit == null) return;
            if (column.ColumnEdit.GetType() == typeof(RepositoryItemDateEdit))
            {
                column.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                ((RepositoryItemDateEdit)column.ColumnEdit).Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            }
        }
        protected override GridColumnCollection CreateColumnCollection()
        {
            return new myGridColumnCollection(this);
        }

        private class myGridColumnCollection : BandedGridColumnCollection
        {
            public myGridColumnCollection(ColumnView view) : base(view) { }

            protected override GridColumn CreateColumn()
            {
                var column = new myBandedGridColumn();
                column.OptionsColumn.AllowEdit = false;
                return column;
            }
        }
    }
    public class myBandedGridColumn : BandedGridColumn, IStatusBarKisayol
    {
        #region Properties
        public string statusBarKisayol { get; set; }
        public string statusBarKisayolAciklama { get; set; }
        public string statusBarAciklama { get; set; }
        #endregion
    }


}
