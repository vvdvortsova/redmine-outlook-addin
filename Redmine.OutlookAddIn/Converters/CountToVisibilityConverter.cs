﻿using System;
using System.Collections;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Redmine.OutlookAddIn.Converters
{
    public class CountToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is ICollection)
            {
                ICollection collection = value as ICollection;

                return collection.Count > 0 ?
                    Visibility.Visible :
                    Visibility.Collapsed;
            }

            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
