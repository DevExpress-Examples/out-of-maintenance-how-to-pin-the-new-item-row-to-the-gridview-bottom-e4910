using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grid_BottomNewItemRow
{
    public class GridSplitContainerDescendant : GridSplitContainer
    {
        public GridSplitContainerDescendant()
            : base()
        { }

        protected override SplitContainerViewInfo CreateContainerInfo()
        {
            return new SplitContainerViewInfoDescendant(this);
        }

        protected override GridControl CreateGridControl()
        {
            return new GridControlDescendant();
           
        }

    }
}
