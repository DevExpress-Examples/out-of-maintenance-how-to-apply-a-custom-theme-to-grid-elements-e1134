// Developer Express Code Central Example:
// How to apply a custom theme to grid elements
// 
// The following example demonstrates how to create a custom theme and apply it to
// the elements of the DXGrid control.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E1134

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows;

namespace CustomTheme {
    public class BottomIndicatorRowVisibilityConverter : IMultiValueConverter {
        #region IMultiValueConverter Members

        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            if(values.Count() < 2)
                return Visibility.Collapsed;
            if(!((values[0] is int) && (values[1] is int)))
                return Visibility.Collapsed;

            return ((int)values[0]) > ((int)values[1]) ? Visibility.Visible : Visibility.Collapsed;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }

        #endregion
    }
}