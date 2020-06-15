namespace quennta.vivendaApartmentManagament.UI.Win.UserControls.Navigators
{
    partial class SmallNavigator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmallNavigator));
            this.nivagator = new DevExpress.XtraEditors.ControlNavigator();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // nivagator
            // 
            this.nivagator.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.nivagator.Appearance.Options.UseForeColor = true;
            this.nivagator.Buttons.Append.Visible = false;
            this.nivagator.Buttons.CancelEdit.Visible = false;
            this.nivagator.Buttons.Edit.Visible = false;
            this.nivagator.Buttons.EndEdit.Visible = false;
            this.nivagator.Buttons.First.ImageIndex = 0;
            this.nivagator.Buttons.ImageList = this.imageCollection1;
            this.nivagator.Buttons.Last.ImageIndex = 3;
            this.nivagator.Buttons.Next.ImageIndex = 2;
            this.nivagator.Buttons.NextPage.Visible = false;
            this.nivagator.Buttons.Prev.ImageIndex = 1;
            this.nivagator.Buttons.PrevPage.Visible = false;
            this.nivagator.Buttons.Remove.Visible = false;
            this.nivagator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nivagator.Location = new System.Drawing.Point(0, 0);
            this.nivagator.Name = "nivagator";
            this.nivagator.Size = new System.Drawing.Size(581, 24);
            this.nivagator.TabIndex = 0;
            this.nivagator.Text = "controlNavigator1";
            this.nivagator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin;
            this.nivagator.TextStringFormat = "Kartlar ({0} / {1})";
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertImage(global::quennta.vivendaApartmentManagament.UI.Win.Properties.Resources.first_16x162, "first_16x162", typeof(global::quennta.vivendaApartmentManagament.UI.Win.Properties.Resources), 0);
            this.imageCollection1.Images.SetKeyName(0, "first_16x162");
            this.imageCollection1.InsertImage(global::quennta.vivendaApartmentManagament.UI.Win.Properties.Resources.prev_16x162, "prev_16x162", typeof(global::quennta.vivendaApartmentManagament.UI.Win.Properties.Resources), 1);
            this.imageCollection1.Images.SetKeyName(1, "prev_16x162");
            this.imageCollection1.InsertImage(global::quennta.vivendaApartmentManagament.UI.Win.Properties.Resources.next_16x162, "next_16x162", typeof(global::quennta.vivendaApartmentManagament.UI.Win.Properties.Resources), 2);
            this.imageCollection1.Images.SetKeyName(2, "next_16x162");
            this.imageCollection1.InsertImage(global::quennta.vivendaApartmentManagament.UI.Win.Properties.Resources.last_16x162, "last_16x162", typeof(global::quennta.vivendaApartmentManagament.UI.Win.Properties.Resources), 3);
            this.imageCollection1.Images.SetKeyName(3, "last_16x162");
            // 
            // SmallNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nivagator);
            this.Name = "SmallNavigator";
            this.Size = new System.Drawing.Size(581, 24);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ControlNavigator nivagator;
        private DevExpress.Utils.ImageCollection imageCollection1;
    }
}
