using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FormsPlugin.FontIcons
{
    /// <summary>
    /// Repository to search for all font icons
    /// </summary>
    internal static class FontIconRepository
    {
        
        private static readonly Dictionary<string, FontModule> FontModules = new Dictionary<string, FontModule>();

        public static void Add(string key, string fontFamily, Type iconNamesType)
        {
            FontModules.Add(key, new FontModule(fontFamily, iconNamesType));
        }

        private const string PrefixSeparator ="-";

        /// <summary>
        /// Split icon name to a pair of font family and char code.
        /// </summary>
        /// <param name="icon">an identifier like [icon-font-prefix]-[snake-case-icon-symbol]</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static (string fontFamily, string code) Find(string icon)
        {
            var pos = icon.IndexOf(PrefixSeparator, StringComparison.Ordinal);
            
            if (pos < 0) throw new ArgumentOutOfRangeException(nameof (icon));
            var prefix = icon.Substring(0, pos);
            var symbol = icon.Substring(pos + 1);

            if (!FontModules.TryGetValue(prefix, out var font))
                throw new ArgumentException(nameof(icon), $"{prefix} is unknown prefix for any icon");
            var fontFamily = font.FontFamily;
            var iconNamesType = font.IconNamesType;

            var code = GetStaticField(iconNamesType, ToCamelCase(symbol));
            if (code == null) throw new ArgumentException(nameof (icon), $"{symbol} is unknown symbol for any icon");

            return (fontFamily, code);
        }

        /// <summary>
        /// Get constant property
        /// </summary>
        /// <param name="type"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        private static string GetStaticField(Type type, string propertyName)
        {
            var typeInfo = type.GetTypeInfo();
            var property = typeInfo.GetField(propertyName, 
                BindingFlags.Static | BindingFlags.Public | BindingFlags.GetField | BindingFlags.GetProperty | BindingFlags.IgnoreCase);
            if (property == null) return null;
            return (string)property.GetValue(null);
        }

        /// <summary>
        /// Convert string from snake-case to upper-camel-case
        /// </summary>
        /// <param name="source">source string</param>
        /// <returns>result string</returns>
        private static string ToCamelCase(string source) =>
            string.Join("", source.Split('-').Select(Capitalize));

        private static string Capitalize(string word) =>
            word.Length > 0 ? char.ToUpperInvariant(word[0]) + word.Substring(1) : word;
    }
}