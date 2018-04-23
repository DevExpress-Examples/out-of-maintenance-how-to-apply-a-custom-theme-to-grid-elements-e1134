using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Grid;
using System.ComponentModel;

namespace CustomTheme {

    public partial class ReplaceThemeResources : UserControl {
        BindingList<TestData> list;
        public ReplaceThemeResources() {
            InitializeComponent();
            list = new BindingList<TestData>();
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
            if(view.MultiSelectMode == TableViewSelectMode.Cell)
                selectMode.SelectedIndex = 1;
        }

        private void newItemRowCheckBox_Checked(object sender, RoutedEventArgs e) {
            view.NewItemRowPosition = NewItemRowPosition.Top;
        }

        private void newItemRowCheckBox_Unchecked(object sender, RoutedEventArgs e) {
            view.NewItemRowPosition = NewItemRowPosition.None;
        }

        private void selectMode_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if(view.MultiSelectMode == TableViewSelectMode.Cell) navigationCheckBox.IsChecked = true;
        }
    }
}
