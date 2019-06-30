using System;

namespace FormsPlugin.FontIcons
{
    public static class FontIcons
    {
        public static void Install(string key, string fontFamily, Type iconNamesType)
        {
            FontIconRepository.Add(key, fontFamily, iconNamesType);
        }
    }
}