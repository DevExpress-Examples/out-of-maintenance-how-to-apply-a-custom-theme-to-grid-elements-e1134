// Developer Express Code Central Example:
// How to apply a custom theme to grid elements
// 
// The following example demonstrates how to create a custom theme and apply it to
// the elements of the DXGrid control.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E1134

// Developer Express Code Central Example:
// How to apply a custom theme to grid elements
// 
// The following example demonstrates how to create a custom theme and apply it to
// the elements of the DXGrid control.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E1134

using System.Windows;
using DevExpress.Xpf.Core;

namespace CustomTheme {

    public partial class MainWindow : Window {
        public MainWindow() {
            Theme.RegisterTheme(new Theme("Simple"));
            InitializeComponent();
        }
    }
}
