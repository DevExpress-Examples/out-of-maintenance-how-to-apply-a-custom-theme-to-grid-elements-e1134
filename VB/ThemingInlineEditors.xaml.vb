Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Grid
Imports System.ComponentModel

Namespace CustomTheme

	Partial Public Class ThemingInlineEditors
		Inherits UserControl
		Private list As BindingList(Of TestData)
		Public Sub New()
			InitializeComponent()
			list = New BindingList(Of TestData)()
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
			If view.MultiSelectMode = TableViewSelectMode.Cell Then
				selectMode.SelectedIndex = 1
			End If
		End Sub

		Private Sub newItemRowCheckBox_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
			view.NewItemRowPosition = NewItemRowPosition.Top
		End Sub

		Private Sub newItemRowCheckBox_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
			view.NewItemRowPosition = NewItemRowPosition.None
		End Sub

		Private Sub selectMode_SelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
			If view.MultiSelectMode = TableViewSelectMode.Cell Then
				navigationCheckBox.IsChecked = True
			End If
		End Sub
	End Class
End Namespace
