# VintaSoft WinForms Multipage TIFF Demo

This C# project uses <a href="https://www.vintasoft.com/vsimaging-dotnet-index.html">VintaSoft Imaging .NET SDK</a> and demonstrates how to work with multipage TIFF files:
* Create, display, pack and save single/multi-page TIFF file.
* Navigate TIFF images: first, previous, next, last.
* Change TIFF image preview settings.
* Manipulate TIFF file pages: add, insert, remove, save.
* Manipulate TIFF file tags: preview, add, modify, delete.


## Screenshot
<img src="vintasoft-multipage-tiff-demo.png" title="VintaSoft Multipage TIFF Demo">


## Usage
1. Get the 30 day free evaluation license for <a href="https://www.vintasoft.com/vsimaging-dotnet-index.html" target="_blank">VintaSoft Imaging .NET SDK</a> as described here: <a href="https://www.vintasoft.com/docs/vsimaging-dotnet/Licensing-Evaluation.html" target="_blank">https://www.vintasoft.com/docs/vsimaging-dotnet/Licensing-Evaluation.html</a>

2. Update the evaluation license in "CSharp\MainForm.cs" file:
   ```
   Vintasoft.Imaging.ImagingGlobalSettings.Register("REG_USER", "REG_EMAIL", "EXPIRATION_DATE", "REG_CODE");
   ```

3. Build the project ("MultiPageTiffDemo.Net10.csproj" file) in Visual Studio or using .NET CLI:
   ```
   dotnet build MultiPageTiffDemo.Net10.csproj
   ```

4. Run compiled application and try to work with multipage TIFF files.


## Documentation
VintaSoft Imaging .NET SDK on-line User Guide and API Reference for .NET developer is available here: https://www.vintasoft.com/docs/vsimaging-dotnet/


## Support
Please visit our <a href="https://myaccount.vintasoft.com/">online support center</a> if you have any question or problem.
