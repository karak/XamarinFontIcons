# FormsPlugin.FontIcons

Yet another font icons utility <https://montemagno.com/using-font-icons-in-xamarin-forms-goodbye-images-hello-fonts/>,
which supports

* FontAwesome 5 Free

# How to use.

1. Add this assembly to your Xamarin.Forms project.
2. Download and extract FontAwesome 5 Free for Desktop from [here](https://fontawesome.com/download) (5.9.0 current).
3. Then, Add its OTF files to your application projects,
   and set Build Action _BundleResource_ for iOS, _AndroidAsset_ for Android.
4. Add their names to UIAppFonts entry in info.plist for iOS.

```xml
<dict>
    ...
	<key>UIAppFonts</key>
	<array>
		<string>Font Awesome 5 Free-Solid-900.otf</string>
		<string>Font Awesome 5 Free-Regular-400.otf</string>
		<string>Font Awesome 5 Brands-Regular-400.otf</string>
	</array>
	...
</dict>
```
