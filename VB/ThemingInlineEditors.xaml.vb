Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Wpf.Grid

Namespace CustomTheme

	Partial Public Class ThemingInlineEditors
		Inherits UserControl
		Private list As List(Of TestData)
		Public Sub New()
			InitializeComponent()
			list = New List(Of TestData)()
			For i As Integer = 0 To 999
				list.Add(New TestData() With {.Text = "row " & i, .Number1 = i \ 100, .Number2 = i \ 5})
			Next i
			grid.DataSource = list
		End Sub

		Private Sub navigationCheckBox_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
			view.NavigationStyle = GridViewNavigationStyle.Cell
		End Sub

		Private Sub navigationCheckBox_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
			view.NavigationStyle = GridViewNavigationStyle.Row
		End Sub
	End Class
End Namespace
