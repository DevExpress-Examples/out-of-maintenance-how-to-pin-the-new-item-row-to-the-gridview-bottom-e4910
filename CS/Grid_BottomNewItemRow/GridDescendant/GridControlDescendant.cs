using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grid_BottomNewItemRow
{
    public class GridControlDescendant : GridControl
    {      
        protected override BaseView CreateDefaultView()
        {
            return CreateView("GridViewDescendant");
        }
        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new GridViewInfoRegistratorDescendant());
        }


    }
}
