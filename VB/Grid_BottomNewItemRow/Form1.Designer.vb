Namespace Grid_BottomNewItemRow
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridSplitContainerDescendant1 = New Grid_BottomNewItemRow.GridSplitContainerDescendant()
			Me.gridSplitContainerDescendant1Grid = New Grid_BottomNewItemRow.GridControlDescendant()
			Me.gridSplitContainerDescendant1View = New Grid_BottomNewItemRow.GridViewDescendant()
			DirectCast(Me.gridSplitContainerDescendant1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gridSplitContainerDescendant1.SuspendLayout()
			DirectCast(Me.gridSplitContainerDescendant1Grid, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gridSplitContainerDescendant1View, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridSplitContainerDescendant1
			' 
			Me.gridSplitContainerDescendant1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridSplitContainerDescendant1.Grid = Me.gridSplitContainerDescendant1Grid
			Me.gridSplitContainerDescendant1.Location = New System.Drawing.Point(0, 0)
			Me.gridSplitContainerDescendant1.Name = "gridSplitContainerDescendant1"
			Me.gridSplitContainerDescendant1.Panel1.Controls.Add(Me.gridSplitContainerDescendant1Grid)
			Me.gridSplitContainerDescendant1.Panel1.Text = "Panel1"
			Me.gridSplitContainerDescendant1.Panel2.Text = "Panel2"
			Me.gridSplitContainerDescendant1.Size = New System.Drawing.Size(408, 432)
			Me.gridSplitContainerDescendant1.TabIndex = 0
			Me.gridSplitContainerDescendant1.Text = "gridSplitContainerDescendant1"
			' 
			' gridSplitContainerDescendant1Grid
			' 
			Me.gridSplitContainerDescendant1Grid.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridSplitContainerDescendant1Grid.Location = New System.Drawing.Point(0, 0)
			Me.gridSplitContainerDescendant1Grid.MainView = Me.gridSplitContainerDescendant1View
			Me.gridSplitContainerDescendant1Grid.Name = "gridSplitContainerDescendant1Grid"
			Me.gridSplitContainerDescendant1Grid.Size = New System.Drawing.Size(408, 432)
			Me.gridSplitContainerDescendant1Grid.TabIndex = 0
			Me.gridSplitContainerDescendant1Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridSplitContainerDescendant1View})
			' 
			' gridSplitContainerDescendant1View
			' 
			Me.gridSplitContainerDescendant1View.GridControl = Me.gridSplitContainerDescendant1Grid
			Me.gridSplitContainerDescendant1View.Name = "gridSplitContainerDescendant1View"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(408, 432)
			Me.Controls.Add(Me.gridSplitContainerDescendant1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			DirectCast(Me.gridSplitContainerDescendant1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gridSplitContainerDescendant1.ResumeLayout(False)
			DirectCast(Me.gridSplitContainerDescendant1Grid, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gridSplitContainerDescendant1View, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridSplitContainerDescendant1 As GridSplitContainerDescendant
		Private gridSplitContainerDescendant1Grid As GridControlDescendant
		Private gridSplitContainerDescendant1View As GridViewDescendant






	End Class
End Namespace

