﻿' Developer Express Code Central Example:
' How to apply a custom theme to grid elements
' 
' The following example demonstrates how to create a custom theme and apply it to
' the elements of the DXGrid control.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E1134


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Data
Imports System.Windows

Namespace CustomTheme
	Public Class BottomIndicatorRowVisibilityConverter
		Implements IMultiValueConverter
		#Region "IMultiValueConverter Members"

		Public Function Convert(ByVal values() As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IMultiValueConverter.Convert
			If values.Count() < 2 Then
				Return Visibility.Collapsed
			End If
			If Not((TypeOf values(0) Is Integer) AndAlso (TypeOf values(1) Is Integer)) Then
				Return Visibility.Collapsed
			End If

			Return If((CInt(Fix(values(0)))) > (CInt(Fix(values(1)))), Visibility.Visible, Visibility.Collapsed)
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetTypes() As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object() Implements IMultiValueConverter.ConvertBack
			Throw New NotImplementedException()
		End Function

		#End Region
	End Class
End Namespace