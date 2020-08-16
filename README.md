# Barcode Library for .NET

[Aspose.BarCode for .NET](https://products.aspose.com/barcode/net) doesn't just create or recognize barcodes but it provides a complete framework to control almost everything about barcodes. Developers can customization the barcode's appearance including bar height, color, margins, borders and so on. While scanning for barcode, developers can specify area where a barcode can be found as well as direct the engine to look for rotated barcodes.

<p align="center">
  <a title="Download complete Aspose.BarCode for .NET source code" href="https://github.com/aspose-barcode/Aspose.BarCode-for-.NET/archive/master.zip">
	<img src="https://raw.github.com/AsposeExamples/java-examples-dashboard/master/images/downloadZip-Button-Large.png" />
  </a>
</p>

This repository contains [Demos](Demos), [Examples](Examples), [Plugins](Plugins) and Showcase projects for [Aspose.BarCode for .NET](https://products.aspose.com/barcode/net) to help you learn and write your own applications.

Directory | Description
--------- | -----------
[Demos](Demos)  | Source code for live demos hosted at https://products.aspose.app/barcode/family.
[Examples](Examples)  | A collection of .NET examples that help you learn the product features
[Plugins](Plugins)  | Visual Studio Plugins related to Aspose.BarCode for .NET.


## Barcode API

- [Generate](https://docs.aspose.com/barcode/net/generate-barcodes-with-aspose-barcode-apis/) & [recognize](https://docs.aspose.com/barcode/net/read-barcodes-with-aspose-barcode-apis/) 40+ barcode symbologies with just a few lines of code.
- Read 1D & 2D barcodes at any angle.
- Easily print barcode labels to physical or virtual printers.
- [Export barcode as XML](https://docs.aspose.com/barcode/net/barcode-in-xml/).
- Support for [barcode supplement data and checksum](https://docs.aspose.com/barcode/net/use-checksum-and-supplement-data/).
- Optimized code128 encoding.
- Specify image area to scan barcode.
- Create device resolution dependent images.

## Supported Barcode Symbologies

**Numeric Only:** EAN13,  EAN8, UPCA, UPCE, ISBN, ISMN, ISSN, Interleaved2of5,  Standard2of5, MSI, Code11, Codabar, Postnet, Planet, EAN14(SCC14), SSCC18, ITF14, IATA2of5, DatabarOmniDirectional, DatabarStackedOmniDirectional, DatabarExpandedStacked,   DatabarStacked, DatabarLimited, DatabarTruncated\
**Alpha-Numeric:** GS1Code128, Code128, Code39 Extended, Code39 Standard, Code93 Extended, Code93 Standard, Australia Post, Italian Post 25, Matrix2of5, DatabarExpanded. PatchCode\
**2D Symbologies:** PDF417, DataMatrix, Aztec, QR, MicroQR, GS1DataMatrix, Code16K, CompactPDF417, Swiss QR (QR Bill)

## Read or Write Barcode Labels As

**Images:** JPEG, TIFF, PNG, BMP, GIF, EXIF

## Save Barcodes As

**Images:** EMF, SVG

## Platform Independence

Aspose.BarCode for .NET can easily be used in any .NET 32-bit or 64-bit application, including, WinForms, WPF, ASP.NET, and .NET core. In short, you can develop apps using Aspose.BarCode for .NET where the .NET framework is available.

## Get Started with Aspose.BarCode for .NET

Are you ready to give Aspose.BarCode for .NET a try? Simply execute `Install-Package Aspose.BarCode` from Package Manager Console in Visual Studio to fetch the NuGet package. If you already have Aspose.BarCode for .NET and want to upgrade the version, please execute `Update-Package Aspose.BarCode` to get the latest version.

## Generate a Barcode Label with Code128

```csharp
// instantiate object and set different barcode properties
BarcodeGenerator  generator = new BarcodeGenerator (EncodeTypes.Code128, "1234567");
generator.Parameters.Barcode.XDimension.Millimeters = 1f;

// save the image to your system and set its image format to Jpeg
generator.Save(dir + "output.jpg", BarCodeImageFormat.Jpeg);
```

## Hide Barcode Text from the PNG Label

```csharp
string codeText = "This text is hidden.\n" + "This text is hidden.\n"; ;

// instantiate barcode object and set CodeText, Symbology , and  CodeLocation
BarcodeGenerator  generator = new BarcodeGenerator(EncodeTypes.DataMatrix, codeText);
generator.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
generator.Save(dir + "output.png", BarCodeImageFormat.Png);
```

[Home](https://www.aspose.com/) | [Product Page](https://products.aspose.com/barcode/net) | [Docs](https://docs.aspose.com/barcode/net/) | [Demos](https://products.aspose.app/barcode/family) | [API Reference](https://apireference.aspose.com/barcode/net) | [Examples](https://github.com/aspose-barcode/Aspose.BarCode-for-.NET) | [Blog](https://blog.aspose.com/category/barcode/) | [Free Support](https://forum.aspose.com/c/barcode) | [Temporary License](https://purchase.aspose.com/temporary-license)

