' Developer Express Code Central Example:
' How to apply a custom theme to grid elements
' 
' The following example demonstrates how to create a custom theme and apply it to
' the elements of the DXGrid control.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E1134

' Developer Express Code Central Example:
' How to apply a custom theme to grid elements
' 
' The following example demonstrates how to create a custom theme and apply it to
' the elements of the DXGrid control.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E1134


Imports Microsoft.VisualBasic
Imports System.Windows
Imports DevExpress.Xpf.Core

Namespace CustomTheme

	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			Theme.RegisterTheme(New Theme("Simple"))
			InitializeComponent()
		End Sub
	End Class
End Namespace
