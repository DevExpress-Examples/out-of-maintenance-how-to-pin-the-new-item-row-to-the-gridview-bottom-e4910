Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Grid_BottomNewItemRow
	Public Class GridControlDescendant
		Inherits GridControl

		Protected Overrides Function CreateDefaultView() As BaseView
			Return CreateView("GridViewDescendant")
		End Function
		Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
			MyBase.RegisterAvailableViewsCore(collection)
			collection.Add(New GridViewInfoRegistratorDescendant())
		End Sub


	End Class
End Namespace
