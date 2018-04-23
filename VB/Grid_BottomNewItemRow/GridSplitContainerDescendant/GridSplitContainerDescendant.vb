Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraGrid
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Grid_BottomNewItemRow
	Public Class GridSplitContainerDescendant
		Inherits GridSplitContainer

		Public Sub New()
			MyBase.New()
		End Sub

		Protected Overrides Function CreateContainerInfo() As SplitContainerViewInfo
			Return New SplitContainerViewInfoDescendant(Me)
		End Function

		Protected Overrides Function CreateGridControl() As GridControl
			Return New GridControlDescendant()

		End Function

	End Class
End Namespace
