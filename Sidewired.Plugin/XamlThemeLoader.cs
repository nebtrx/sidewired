﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.SilverlightMediaFramework.Utilities.Extensions;

namespace Sidewired.Plugin
{
    public static class XamlThemeLoader
    {
        public static bool TryGetPlayerXamlThemeSource(IDictionary<string, string> initParams, out Uri xamlThemeSource)
        {
            if (initParams.ContainsKeyIgnoreCase("XamlThemeSource"))
            {
                if (Uri.TryCreate(initParams.GetEntryIgnoreCase("XamlThemeSource"), UriKind.RelativeOrAbsolute, out xamlThemeSource))
                {
                    return true;
                }
            }
            xamlThemeSource = null;
            return false;
        }
    }
}
