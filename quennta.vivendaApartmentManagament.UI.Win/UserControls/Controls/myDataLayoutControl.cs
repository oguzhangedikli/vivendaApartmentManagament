using DevExpress.XtraDataLayout;
using DevExpress.XtraLayout;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraLayout.Utils;

namespace quennta.vivendaApartmentManagament.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class myDataLayoutControl : DataLayoutControl
    {
        public myDataLayoutControl()
        {
            OptionsFocus.EnableAutoTabOrder = false;
            //Tab tuşuna basıldığında kendi belirleyeceğimiz indeks düzenine göre hareket etmemizi sağlamakta.

        }
        protected override LayoutControlImplementor CreateILayoutControlImplementorCore()
        {
            return new myLayoutControlImplementor(this);
            //kendi layout implementorumuzu oluşturup tab tuşu sayesinde nasıl hareket edeceğimizi belirliyoruz.
        }
    }

    internal class myLayoutControlImplementor : LayoutControlImplementor //İmplemente olmuş bir implementor bizim.
    {
        public myLayoutControlImplementor(ILayoutControlOwner controlOwner) : base(controlOwner)
        {
        }
        public override BaseLayoutItem CreateLayoutItem(LayoutGroup parent)
        {
            var item = base.CreateLayoutItem(parent);
            item.AppearanceItemCaption.ForeColor = Color.Black;
            return item;
        }

        public override LayoutGroup CreateLayoutGroup(LayoutGroup parent)
        {
            var grp = base.CreateLayoutGroup(parent);
            grp.LayoutMode = LayoutMode.Table;
            grp.OptionsTableLayoutGroup.ColumnDefinitions[0].SizeType = SizeType.Absolute;
            grp.OptionsTableLayoutGroup.ColumnDefinitions[0].Width = 200;
            grp.OptionsTableLayoutGroup.ColumnDefinitions[1].SizeType = SizeType.Percent;
            //Kalan büyüklüğü buraya ver. Yüzdelik hesap.
            grp.OptionsTableLayoutGroup.ColumnDefinitions[1].Width = 100;
            //sürunların tipini ve genişliğini ayarlama

            grp.OptionsTableLayoutGroup.ColumnDefinitions.Add(new ColumnDefinition { SizeType = SizeType.Absolute, Width = 99 });
            //Yeni sütun ekleme

            grp.OptionsTableLayoutGroup.RowDefinitions.Clear();
            for (int i = 0; i < 9; i++)
            {
                grp.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition
                {
                    SizeType=SizeType.Absolute,
                    Height=24
                });
                if (i + 1 != 9) continue;
                grp.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition
                {
                    SizeType = SizeType.Percent,
                    Height=100
                    //Sütunlar aşağıya doğru gittikçe 9 tanesi sabit gelecek. Sonuncusu ise büyüyüp küçülebilecek.
                });
            }
            return grp;
        }
    }
}
