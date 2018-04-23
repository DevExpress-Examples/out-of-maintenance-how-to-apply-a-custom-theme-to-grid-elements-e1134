using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using DevExpress.Wpf.Grid;

namespace CustomTheme {

    public partial class ThemingInlineEditors : UserControl {
        List<TestData> list;
        public ThemingInlineEditors() {
            InitializeComponent();
            list = new List<TestData>();
            for(int i = 0; i < 1000; i++) {
                list.Add(new TestData() 
                    { Text = "row " + i, Number1 = i / 100, Number2 = i / 5 });
            }
            grid.DataSource = list;
        }

        private void navigationCheckBox_Checked(object sender, RoutedEventArgs e) {
            view.NavigationStyle = GridViewNavigationStyle.Cell;
        }

        private void navigationCheckBox_Unchecked(object sender, RoutedEventArgs e) {
            view.NavigationStyle = GridViewNavigationStyle.Row;
        }
    }
}
