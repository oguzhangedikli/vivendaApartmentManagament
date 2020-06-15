using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using quennta.vivendaApartmentManagament.UI.Win.Interfaces;
using DevExpress.XtraGrid.Views.Base;
using System.Drawing;
using DevExpress.XtraGrid.Registrator;
using System.ComponentModel;

namespace quennta.vivendaApartmentManagament.UI.Win.UserControls.Grid
{
    [ToolboxItem(true)]
    public class myGridControl : GridControl
    {
        protected override BaseView CreateDefaultView()
        {
            var view = (GridView)CreateView("myGridView");
            view.Appearance.ViewCaption.ForeColor = Color.White;
            view.Appearance.HeaderPanel.ForeColor = Color.White;
            view.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center;
            view.Appearance.FooterPanel.TextOptions.HAlignment = HorzAlignment.Center;
            view.Appearance.FooterPanel.ForeColor = Color.White;
            view.Appearance.FooterPanel.Font = new Font(new FontFamily("Tahoma"), 8.25f, FontStyle.Bold);

            view.OptionsMenu.EnableColumnMenu = false;
            view.OptionsMenu.EnableFooterMenu = false;
            view.OptionsMenu.EnableGroupPanelMenu = false;

            view.OptionsNavigation.EnterMoveNextColumn = true;
            view.OptionsPrint.AutoWidth = false;
            view.OptionsPrint.PrintFooter = false;
            view.OptionsPrint.PrintGroupFooter = false;

            view.OptionsView.ShowViewCaption = true;
            view.OptionsView.ShowAutoFilterRow = true;
            view.OptionsView.ShowGroupPanel = false;
            view.OptionsView.ColumnAutoWidth = false;
            view.OptionsView.RowAutoHeight = true;
            view.OptionsView.HeaderFilterButtonShowMode = FilterButtonShowMode.Button;

            #region Columns
            var idcolumn = new myGridColumn
            {
                Caption = "Id",
                FieldName = "Id"
            };
            idcolumn.OptionsColumn.AllowEdit = false;
            idcolumn.Visible = true;

            idcolumn.OptionsColumn.ShowInCustomizationForm = false;
            view.Columns.Add(idcolumn);

            var kodColumn = new myGridColumn
            {
                Caption = "Kod",
                FieldName = "Kod"
            };
            kodColumn.OptionsColumn.AllowEdit = false;
            kodColumn.Visible = true;
            kodColumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            kodColumn.AppearanceCell.Options.UseTextOptions = true;


            view.Columns.Add(kodColumn); 
            #endregion

            return view;

        }
        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new myGridInfoRegistrator());

        }

        private class myGridInfoRegistrator : GridInfoRegistrator
        {
            public override string ViewName => "myGridView";
            public override BaseView CreateView(GridControl grid)=> new myGridView(grid);

        }
    }


    public class myGridView : GridView, IStatusBarKisayol
    {

        #region Properties
        public string statusBarKisayol { get; set; }
        public string statusBarKisayolAciklama { get; set; }
        public string statusBarAciklama { get; set; }
        #endregion

        public myGridView() { }

        public myGridView(GridControl ownerGrid) : base(ownerGrid) { }
        protected override void OnColumnChangedCore(GridColumn column)
        {
            base.OnColumnChangedCore(column);
            if (column.ColumnEdit == null) return;
            if (column.ColumnEdit.GetType() == typeof(RepositoryItemDateEdit))
            {
                column.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                //MygridControlü forma eklediğimizde ve içine kolon ekleyip kolonun itemini repostoryItemDate edit seçtiğimizde
                //Value değeri otomatik olarak ortalanmış olacak
                ((RepositoryItemDateEdit)column.ColumnEdit).Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            }
        }
        protected override GridColumnCollection CreateColumnCollection()
        {
            return new myGridColumnCollection(this);
        }

        private class myGridColumnCollection : GridColumnCollection
        {
            public myGridColumnCollection(ColumnView view) : base(view) { }
            protected override GridColumn CreateColumn()
            {
                var column = new myGridColumn();
                column.OptionsColumn.AllowEdit = false;
                return column;
            }
        }
    }


    public class myGridColumn : GridColumn, IStatusBarKisayol
    {
        #region Properties
        public string statusBarKisayol { get; set; }
        public string statusBarKisayolAciklama { get; set; }
        public string statusBarAciklama { get; set; } 
        #endregion
    }
}
