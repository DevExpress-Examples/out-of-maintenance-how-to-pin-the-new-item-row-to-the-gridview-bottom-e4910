Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Drawing
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text


Namespace Grid_BottomNewItemRow
	Public Class SplitContainerViewInfoDescendant
		Inherits SplitContainerViewInfo
		Public Sub New(ByVal container As SplitContainerControl)
			MyBase.New(container)
		End Sub

		Protected Overrides Sub UpdatePanelBounds()
			MyBase.UpdatePanelBounds()

			Dim rect As Rectangle = Panel1Info.Bounds
			rect.Height += Splitter.Bounds.Height
			Panel1Info.Bounds = rect
			rect = Splitter.Bounds
			rect.Height = 0
			Splitter.Bounds = rect

		End Sub


	End Class
End Namespace
