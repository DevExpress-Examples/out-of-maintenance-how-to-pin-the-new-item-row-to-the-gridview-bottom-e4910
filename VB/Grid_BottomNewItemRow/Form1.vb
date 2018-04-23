Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.Drawing
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace Grid_BottomNewItemRow
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()
		End Sub

		'Fields...
		Private _TestTable As DataTable

		Private Sub CreateTestTable()
			_TestTable = New DataTable("TestTable")
			CreateTableColumns()
			CreateCustomerRow(0, "Test0",0)
			CreateCustomerRow(1, "Test1",1)
			CreateCustomerRow(2, "Test2",2)
			CreateCustomerRow(3, "Test3",3)
			CreateCustomerRow(4, "Test4",4)
			CreateCustomerRow(5, "Test5",5)
			CreateCustomerRow(6, "Test6",6)
			CreateCustomerRow(7, "Test7",7)
			CreateCustomerRow(8, "Test8",8)
			CreateCustomerRow(9, "Test9",9)
			CreateCustomerRow(10, "Test10",10)
			CreateCustomerRow(11, "Test11",11)
			CreateCustomerRow(12, "Test12",12)
			CreateCustomerRow(13, "Test13",13)
			CreateCustomerRow(14, "Test14",14)
			CreateCustomerRow(15, "Test15",15)
			CreateCustomerRow(16, "Test16",16)
			CreateCustomerRow(17, "Test17",17)
			CreateCustomerRow(18, "Test18",18)

		End Sub

		Private Sub CreateTableColumns()
            Dim columns() As DataColumn = {
                New DataColumn("ID", GetType(Integer)),
                New DataColumn("Name", GetType(String)),
                New DataColumn("Number", GetType(Integer))
            }
            _TestTable.Columns.AddRange(columns)

		End Sub

		Private Sub CreateCustomerRow(ByVal id As Integer, ByVal name As String, ByVal number As Integer)
			Dim row As DataRow = _TestTable.NewRow()

			row("ID") = id
			row("Name") = name
			row("Number") = number

			_TestTable.Rows.Add(row)
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			CreateTestTable()

			gridSplitContainerDescendant1.Grid.DataSource = _TestTable

			Dim ex As New BottomNewItemRowEx(gridSplitContainerDescendant1)

		End Sub

	End Class
End Namespace
