Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Grid_BottomNewItemRow
	Public Class BottomNewItemRowEx
		Private Const buffer As Integer = 4
		Public Sub New(ByVal splitContainer As GridSplitContainerDescendant)
			_Container = splitContainer
			CustomizeSplitContainer()
		End Sub


		'Fileds...
		Private _Container As GridSplitContainerDescendant
		Private firstView As GridViewDescendant
		Private secondView As GridViewDescendant
		Private firstVI As GridViewInfoDescendant
		Private secondVI As GridViewInfoDescendant

		Private Sub CustomizeSplitContainer()
			AddHandler _Container.SizeChanged, AddressOf _Container_SizeChanged

			CustomizeFirstView()
			_Container.ShowSplitView()
			CustomizeSecondView()

			SetSplitterPosition()

		End Sub

		Private Sub CustomizeFirstView()
			firstView = TryCast(_Container.Grid.MainView, GridViewDescendant)
			firstView.OptionsView.RowAutoHeight = True
			firstVI = TryCast(firstView.GetViewInfo(), GridViewInfoDescendant)

			firstView.OptionsView.NewItemRowPosition = NewItemRowPosition.None
			firstView.OptionsMenu.ShowSplitItem = False
			AddHandler firstView.ScrollEvent, AddressOf firstView_ScrollEvent

		End Sub

		Private Sub CustomizeSecondView()
			secondView = TryCast(_Container.SplitChildView, GridViewDescendant)
			secondVI = TryCast(secondView.GetViewInfo(), GridViewInfoDescendant)

			secondView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom
			AddHandler secondView.CustomRowFilter, AddressOf secondView_CustomRowFilter
			secondView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never

		End Sub

		Private i As Integer = 0

		Public Sub SetSplitterPosition()
			Dim skin As Skin = CommonSkins.GetSkin(_Container.Grid.LookAndFeel)
			Dim element As SkinElement = skin(CommonSkins.SkinSplitterHorz)

			Dim newSplitterPosition As Integer = _Container.ClientSize.Height - secondVI.ViewRects.RowsTotalHeight - buffer - element.Size.MinSize.Height

			If newSplitterPosition <= 1 Then
				Return
			End If

			_Container.SplitterPosition = newSplitterPosition

		End Sub


		Private Sub _Container_SizeChanged(ByVal sender As Object, ByVal e As EventArgs)
			SetSplitterPosition()
		End Sub

		Private Sub firstView_ScrollEvent(ByVal sender As Object, ByVal e As EventArgs)
            secondVI.secondViewVScroll = If(firstVI.VScrollBarPresence = ScrollBarPresence.Visible, ScrollBarPresence.Unknown, ScrollBarPresence.Hidden)

            secondView.LayoutChanged()
		End Sub

		Private Sub secondView_CustomRowFilter(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowFilterEventArgs)
			e.Visible = False
			e.Handled = True
		End Sub

	End Class
End Namespace
