﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using ZdfFlatUI.ExtensionFunc;

namespace ZdfFlatUI.Converters
{
    public class TreeViewItemIndentConverter : IValueConverter
    {
        public double Indent { get; set; }
        public double MarginLeft { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            TreeViewItem item = value as TreeViewItem;
            if (item == null)
            {
                return new Thickness(0);
            }
            return new Thickness(MarginLeft + Indent * item.GetDepth(), 0, 0, 0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
