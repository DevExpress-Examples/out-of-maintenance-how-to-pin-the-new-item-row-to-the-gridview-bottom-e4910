using DevExpress.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Scrolling;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grid_BottomNewItemRow
{
    public class GridViewDescendant : GridView
    {
        public GridViewDescendant() : this(null) {}

        public GridViewDescendant(DevExpress.XtraGrid.GridControl grid) : base(grid) { }

        protected override string ViewName { get { return "GridViewDescendant"; } }


        public delegate void ScrollEventHandler(object sender, EventArgs e);
        public event ScrollEventHandler ScrollEvent;

        private void OnScrollEvent()
        {
           if (ScrollEvent == null) return;

            EventArgs args = new EventArgs();
            ScrollEvent(this, args);
        }


        private bool flag = false;
       
        protected override void DoChangeFocusedRow(int currentRowHandle, int newRowHandle, bool raiseUpdateCurrentRow)
        {
            if (this.OptionsView.NewItemRowPosition == NewItemRowPosition.None && newRowHandle == CurrencyDataController.NewItemRow)
            {
                flag = true;
                return;
            }
            else
                base.DoChangeFocusedRow(currentRowHandle, newRowHandle, raiseUpdateCurrentRow);
        }

        protected override void OnDataController_VisibleRowCountChanged(object sender, EventArgs e)
        {
            base.OnDataController_VisibleRowCountChanged(sender, e);

            if (this.OptionsView.NewItemRowPosition == NewItemRowPosition.None && flag)
            {
                flag = false;
                DoChangeFocusedRow(0, this.RowCount - 1, true);
            }
            
        }

       
        protected override DevExpress.XtraGrid.Scrolling.ScrollInfo CreateScrollInfo()
        {
            DevExpress.XtraGrid.Scrolling.ScrollInfo si = base.CreateScrollInfo();
            si.VScroll.VisibleChanged += VScroll_VisibleChanged;
            return si;
        }

        void VScroll_VisibleChanged(object sender, EventArgs e)
        {
            VCrkScrollBar vScroll = sender as VCrkScrollBar;
            if (this.OptionsView.NewItemRowPosition == NewItemRowPosition.None)
            {
                GridControl.BeginInvoke(new MethodInvoker(() => { OnScrollEvent(); }));
            }
         
        }

    }

 
}
