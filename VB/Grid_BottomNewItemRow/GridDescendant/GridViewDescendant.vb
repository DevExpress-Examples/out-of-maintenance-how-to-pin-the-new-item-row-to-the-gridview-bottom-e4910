Imports Microsoft.VisualBasic
Imports DevExpress.Data
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Scrolling
Imports DevExpress.XtraGrid.Views.Grid
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace Grid_BottomNewItemRow
	Public Class GridViewDescendant
		Inherits GridView
		Public Sub New()
			Me.New(Nothing)
		End Sub

		Public Sub New(ByVal grid As DevExpress.XtraGrid.GridControl)
			MyBase.New(grid)
		End Sub

		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return "GridViewDescendant"
			End Get
		End Property


		Public Delegate Sub ScrollEventHandler(ByVal sender As Object, ByVal e As EventArgs)
		Public Event ScrollEvent As ScrollEventHandler

		Private Sub OnScrollEvent()
		   If ScrollEventEvent Is Nothing Then
			   Return
		   End If

			Dim args As New EventArgs()
			RaiseEvent ScrollEvent(Me, args)
		End Sub


		Private flag As Boolean = False

		Protected Overrides Sub DoChangeFocusedRow(ByVal currentRowHandle As Integer, ByVal newRowHandle As Integer, ByVal raiseUpdateCurrentRow As Boolean)
			If Me.OptionsView.NewItemRowPosition = NewItemRowPosition.None AndAlso newRowHandle = CurrencyDataController.NewItemRow Then
				flag = True
				Return
			Else
				MyBase.DoChangeFocusedRow(currentRowHandle, newRowHandle, raiseUpdateCurrentRow)
			End If
		End Sub

		Protected Overrides Sub OnDataController_VisibleRowCountChanged(ByVal sender As Object, ByVal e As EventArgs)
			MyBase.OnDataController_VisibleRowCountChanged(sender, e)

			If Me.OptionsView.NewItemRowPosition = NewItemRowPosition.None AndAlso flag Then
				flag = False
				DoChangeFocusedRow(0, Me.RowCount - 1, True)
			End If

		End Sub


		Protected Overrides Function CreateScrollInfo() As DevExpress.XtraGrid.Scrolling.ScrollInfo
			Dim si As DevExpress.XtraGrid.Scrolling.ScrollInfo = MyBase.CreateScrollInfo()
			AddHandler si.VScroll.VisibleChanged, AddressOf VScroll_VisibleChanged
			Return si
		End Function

		Private Sub VScroll_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim vScroll As VCrkScrollBar = TryCast(sender, VCrkScrollBar)
			If Me.OptionsView.NewItemRowPosition = NewItemRowPosition.None Then
				GridControl.BeginInvoke(New MethodInvoker(Function() AnonymousMethod1()))
			End If

		End Sub
		
		Private Function AnonymousMethod1() As Boolean
			OnScrollEvent()
			Return True
		End Function

	End Class


End Namespace
