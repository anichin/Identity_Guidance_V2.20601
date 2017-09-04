//===============================================================================
// Microsoft patterns & practices
// Cliams Identity Guide V2
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// This code released under the terms of the 
// Microsoft patterns & practices license (http://claimsid.codeplex.com/license)
//===============================================================================


namespace AOrder.OrderTracking.Client.Converters
{
    using System;
    using System.Globalization;
    using System.Windows.Data;

    public class DateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var result = value as DateTime?;
            if (result == null)
            {
                result = DateTime.MinValue;
            }

            return string.Format(CultureInfo.CurrentUICulture, "{0:d}", result.Value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}