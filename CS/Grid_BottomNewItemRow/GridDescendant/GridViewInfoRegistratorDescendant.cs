using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base.Handler;
using DevExpress.XtraGrid.Views.Base.ViewInfo;

namespace Grid_BottomNewItemRow
{
    public class GridViewInfoRegistratorDescendant : GridInfoRegistrator
    {
        public override string ViewName { get { return "GridViewDescendant"; } }
        public override BaseView CreateView(GridControl grid) { return new GridViewDescendant(grid as GridControlDescendant); }
        public override BaseViewInfo CreateViewInfo(BaseView view) { return new GridViewInfoDescendant(view as GridViewDescendant); }
       
    }
}
