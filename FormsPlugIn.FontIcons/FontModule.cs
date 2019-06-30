using System;
using System.Collections.Generic;

namespace FormsPlugin.FontIcons
{
    internal sealed class FontModule
    {
        public FontModule(string fontFamily, Type iconNamesType)
        {
            FontFamily = fontFamily;
            IconNamesType = iconNamesType;
        }
        public readonly string FontFamily;
        public readonly Type IconNamesType;
    }
}