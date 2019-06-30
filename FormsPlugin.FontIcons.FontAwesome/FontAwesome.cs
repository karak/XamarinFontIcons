namespace FormsPlugin.FontIcons
{
    public static class FontAwesome
    {
        public static void Init()
        {
            FontIcons.Install("fas", FontAwesome5FreeSolid.FontFamily, typeof (FontAwesome5FreeSolid.IconNames));
        }
    }
}
