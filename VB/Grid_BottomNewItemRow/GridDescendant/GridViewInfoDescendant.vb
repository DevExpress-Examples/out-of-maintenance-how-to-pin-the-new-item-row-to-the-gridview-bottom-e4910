Imports DevExpress.Data
Imports DevExpress.XtraGrid.Drawing
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text

Namespace Grid_BottomNewItemRow
	Public Class GridViewInfoDescendant
		Inherits GridViewInfo

		Public Sub New(ByVal gridView As GridView)
			MyBase.New(gridView)
		End Sub

		Public Overrides Function CalcRowHeight(ByVal graphics As Graphics, ByVal rowHandle As Integer, ByVal rowVisibleIndex As Integer, ByVal min As Integer, ByVal level As Integer, ByVal useCache As Boolean, ByVal columns As GridColumnsInfo) As Integer
			If View.OptionsView.NewItemRowPosition = NewItemRowPosition.None AndAlso rowHandle = CurrencyDataController.NewItemRow Then
				Return 0
			Else
				Return MyBase.CalcRowHeight(graphics, rowHandle, rowVisibleIndex, min, level, useCache, columns)
			End If
		End Function


		Public secondViewVScroll As ScrollBarPresence = ScrollBarPresence.Hidden

		Public Overrides ReadOnly Property VScrollBarPresence() As ScrollBarPresence
			Get
				If View.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom Then
				   Return secondViewVScroll
				Else
					Return MyBase.VScrollBarPresence
				End If
			End Get
		End Property

	End Class
End Namespace
