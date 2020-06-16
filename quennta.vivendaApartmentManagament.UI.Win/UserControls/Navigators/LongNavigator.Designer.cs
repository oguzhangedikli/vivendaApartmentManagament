namespace quennta.vivendaApartmentManagament.UI.Win.UserControls.Navigators
{
    partial class LongNavigator
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LongNavigator));
            this.navigator = new DevExpress.XtraEditors.ControlNavigator();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // navigator
            // 
            this.navigator.Appearance.ForeColor = System.Drawing.Color.White;
            this.navigator.Appearance.Options.UseForeColor = true;
            this.navigator.Buttons.Append.Visible = false;
            this.navigator.Buttons.CancelEdit.Visible = false;
            this.navigator.Buttons.Edit.Visible = false;
            this.navigator.Buttons.EndEdit.Visible = false;
            this.navigator.Buttons.First.ImageIndex = 0;
            this.navigator.Buttons.ImageList = this.imageCollection;
            this.navigator.Buttons.Last.ImageIndex = 4;
            this.navigator.Buttons.Next.ImageIndex = 3;
            this.navigator.Buttons.NextPage.ImageIndex = 4;
            this.navigator.Buttons.Prev.ImageIndex = 2;
            this.navigator.Buttons.PrevPage.ImageIndex = 0;
            this.navigator.Buttons.Remove.Visible = false;
            this.navigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.navigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.navigator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.navigator.Location = new System.Drawing.Point(0, 0);
            this.navigator.Name = "navigator";
            this.navigator.Size = new System.Drawing.Size(581, 24);
            this.navigator.TabIndex = 0;
            this.navigator.Text = "controlNavigator1";
            this.navigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin;
            this.navigator.TextStringFormat = "Kartlar ({0} / {1})";
            this.navigator.Click += new System.EventHandler(this.controlNavigator1_Click);
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertImage(global::quennta.vivendaApartmentManagament.UI.Win.Properties.Resources.first_16x161, "first_16x161", typeof(global::quennta.vivendaApartmentManagament.UI.Win.Properties.Resources), 0);
            this.imageCollection.Images.SetKeyName(0, "first_16x161");
            this.imageCollection.InsertImage(global::quennta.vivendaApartmentManagament.UI.Win.Properties.Resources.doubleprev_16x161, "doubleprev_16x161", typeof(global::quennta.vivendaApartmentManagament.UI.Win.Properties.Resources), 1);
            this.imageCollection.Images.SetKeyName(1, "doubleprev_16x161");
            this.imageCollection.InsertImage(global::quennta.vivendaApartmentManagament.UI.Win.Properties.Resources.prev_16x161, "prev_16x161", typeof(global::quennta.vivendaApartmentManagament.UI.Win.Properties.Resources), 2);
            this.imageCollection.Images.SetKeyName(2, "prev_16x161");
            this.imageCollection.InsertImage(global::quennta.vivendaApartmentManagament.UI.Win.Properties.Resources.next_16x161, "next_16x161", typeof(global::quennta.vivendaApartmentManagament.UI.Win.Properties.Resources), 3);
            this.imageCollection.Images.SetKeyName(3, "next_16x161");
            this.imageCollection.InsertImage(global::quennta.vivendaApartmentManagament.UI.Win.Properties.Resources.last_16x161, "last_16x161", typeof(global::quennta.vivendaApartmentManagament.UI.Win.Properties.Resources), 4);
            this.imageCollection.Images.SetKeyName(4, "last_16x161");
            this.imageCollection.InsertImage(global::quennta.vivendaApartmentManagament.UI.Win.Properties.Resources.doublenext_16x161, "doublenext_16x161", typeof(global::quennta.vivendaApartmentManagament.UI.Win.Properties.Resources), 5);
            this.imageCollection.Images.SetKeyName(5, "doublenext_16x161");
            // 
            // LongNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navigator);
            this.Name = "LongNavigator";
            this.Size = new System.Drawing.Size(581, 24);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ControlNavigator navigator;
        private DevExpress.Utils.ImageCollection imageCollection;
    }
}
