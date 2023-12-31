﻿using System;
using System.Windows.Data;
using System.Globalization;

namespace Invise.Services.UI.Converters;

public class BoolRadioConverter : IValueConverter
{
    public bool Inverse { get; set; }

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        bool boolValue = (bool)value;

        return this.Inverse ? !boolValue : boolValue;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        bool boolValue = (bool)value;

        if (!boolValue)
        {
            // We only care when the user clicks a radio button to select it.
            return null;
        }

        return !this.Inverse;
    }
}
