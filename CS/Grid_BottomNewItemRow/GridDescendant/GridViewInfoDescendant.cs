using DevExpress.Data;
using DevExpress.XtraGrid.Drawing;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Grid_BottomNewItemRow
{
    public class GridViewInfoDescendant : GridViewInfo
    {
        public GridViewInfoDescendant(GridView gridView) : base(gridView) { }

        public override int CalcRowHeight(Graphics graphics, int rowHandle, int rowVisibleIndex, int min, int level, bool useCache, GridColumnsInfo columns)
        {
            if (View.OptionsView.NewItemRowPosition == NewItemRowPosition.None && rowHandle == CurrencyDataController.NewItemRow)
                return 0;
            else
                return base.CalcRowHeight(graphics, rowHandle, rowVisibleIndex, min, level, useCache, columns);
        }


        public ScrollBarPresence secondViewVScroll = ScrollBarPresence.Hidden;

        public override ScrollBarPresence VScrollBarPresence
        {
            get
            {
                if (View.OptionsView.NewItemRowPosition == NewItemRowPosition.Bottom)
                   return secondViewVScroll;
                else
                    return base.VScrollBarPresence;
            }
        }
           
    }
}
