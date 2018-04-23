using DevExpress.Skins;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grid_BottomNewItemRow
{
    public class BottomNewItemRowEx
    {
        private const int buffer = 4;
        public BottomNewItemRowEx(GridSplitContainerDescendant splitContainer)
        {
            _Container = splitContainer;
            CustomizeSplitContainer();
        }

        
        //Fileds...
        GridSplitContainerDescendant _Container;
        GridViewDescendant firstView;
        GridViewDescendant secondView;
        GridViewInfoDescendant firstVI;
        GridViewInfoDescendant secondVI;

        private void CustomizeSplitContainer()
        {
            _Container.SizeChanged += _Container_SizeChanged;

            CustomizeFirstView();
            _Container.ShowSplitView();
            CustomizeSecondView();            

            SetSplitterPosition();

        }

        private void CustomizeFirstView()
        {
            firstView = _Container.Grid.MainView as GridViewDescendant;
            firstView.OptionsView.RowAutoHeight = true;
            firstVI = firstView.GetViewInfo() as GridViewInfoDescendant;

            firstView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            firstView.OptionsMenu.ShowSplitItem = false;
            firstView.ScrollEvent += firstView_ScrollEvent;
 
        }

        private void CustomizeSecondView()
        {
            secondView = _Container.SplitChildView as GridViewDescendant;
            secondVI = secondView.GetViewInfo() as GridViewInfoDescendant;

            secondView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            secondView.CustomRowFilter += secondView_CustomRowFilter;
            secondView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
 
        }

        private int i = 0;

        public void SetSplitterPosition()
        {
            Skin skin = CommonSkins.GetSkin(_Container.Grid.LookAndFeel);
            SkinElement element = skin[CommonSkins.SkinSplitterHorz];

            int newSplitterPosition = _Container.ClientSize.Height - secondVI.ViewRects.RowsTotalHeight - buffer - element.Size.MinSize.Height;
          
            if (newSplitterPosition <= 1)
                return;

            _Container.SplitterPosition = newSplitterPosition;
         
        }


        void _Container_SizeChanged(object sender, EventArgs e)
        {
            SetSplitterPosition();
        }

        private void firstView_ScrollEvent(object sender, EventArgs e)
        {
            secondVI.secondViewVScroll = (firstVI.VScrollBarPresence == ScrollBarPresence.Visible) ? ScrollBarPresence.Unknown : ScrollBarPresence.Hidden;

            secondView.LayoutChanged();
        }

        private void secondView_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
        {
            e.Visible = false;
            e.Handled = true;
        }

    }
}
