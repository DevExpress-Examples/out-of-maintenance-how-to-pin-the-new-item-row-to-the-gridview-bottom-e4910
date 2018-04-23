using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;


namespace Grid_BottomNewItemRow
{
    public class SplitContainerViewInfoDescendant : SplitContainerViewInfo
    {
        public SplitContainerViewInfoDescendant(SplitContainerControl container) : base(container) { }

        protected override void UpdatePanelBounds()
        {
            base.UpdatePanelBounds();

            Rectangle rect = Panel1Info.Bounds;
            rect.Height += Splitter.Bounds.Height;
            Panel1Info.Bounds = rect;
            rect = Splitter.Bounds;
            rect.Height = 0;
            Splitter.Bounds = rect;
                       
        }


    }
}
