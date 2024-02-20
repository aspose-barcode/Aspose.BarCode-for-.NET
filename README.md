![Nuget](https://img.shields.io/nuget/v/Aspose.Barcode) ![Nuget](https://img.shields.io/nuget/dt/Aspose.Barcode) ![GitHub](https://img.shields.io/github/license/aspose-barcode/Aspose.Barcode-for-.NET)

[Home](https://www.aspose.com/) | [Product Page](https://products.aspose.com/barcode/net) | [Docs](https://docs.aspose.com/barcode/net/) | [Demos](https://products.aspose.app/barcode/family) | [API Reference](https://apireference.aspose.com/barcode/net) | [Examples](https://github.com/aspose-barcode/Aspose.BarCode-for-.NET) | [Blog](https://blog.aspose.com/category/barcode/) | [Free Support](https://forum.aspose.com/c/barcode) | [Temporary License](https://purchase.aspose.com/temporary-license)

# Barcode Library for .NET
[Aspose.BarCode for .NET](https://products.aspose.com/barcode/net) doesn't just create or recognize barcodes but it provides a complete framework to control almost everything about barcodes. Developers can customize the barcode's appearance like bar height, colors, margins, borders, row/columns count and interpolation modes, as well as barcode generation properties like symbol mode encodings, error correction modes, ECI modes or special barcode metadata. While scanning for barcodes, developers can specify the area/areas where a barcode can be found. Moreover, scanning engine can be optimized for better barcode reading quality or speed with variety of options, which allows to recognize strongly corrupted barcodes.

Directory | Description
-|-
[Demos](Demos) | Source code for live demos hosted at https://products.aspose.app/barcode/family.
[Examples](Examples) | A collection of .NET examples that help you learn the product features
[Plugins](Plugins) | Visual Studio Plugins related to Aspose.BarCode for .NET.
[ReportingServices](ReportingServices) | Source code of examples and utilities for Aspose.BarCode for Reporting Services

## Demo applications

[Generate Barcode](https://products.aspose.app/barcode/generate) | [Recognize Barcode](https://products.aspose.app/barcode/recognize) | [Embed Barcode](https://products.aspose.app/barcode/embed)
:---: | :---: | :---:
[![Generate](https://products.aspose.app/barcode/generate/img/aspose_generate-app-48.png)](https://products.aspose.app/barcode/generate) | [![Recognize](https://products.aspose.app/barcode/recognize/img/aspose_recognize-app-48.png)](https://products.aspose.app/barcode/recognize) | [![Embed](https://products.aspose.app/barcode/embed/img/aspose_embed-app-48.png)](https://products.aspose.app/barcode/embed)

## **General Features**
- Barcode generation
- Barcode recognition
- Symbology specification (80+ symbologies: 1D, 2D, DataBar, Postal, HIBC, GS1 types)
- Managing barcode appearance-related parameters
- Image rotation
- Encoding and decoding non-English characters in 2D types
- Customizing recognition engine variables
- Saving to or loading from a stream or a file
- Label printing
- Working with complex barcodes (e.g. Swiss QR Code) 

## **Barcode Recognition Features**
- Class [*BarCodeReader*](https://reference.aspose.com/barcode/net/aspose.barcode.barcoderecognition/barcodereader): reading 1D and 2D barcodes at any angle from an image
- Supporting popular image formats: JPEG, TIFF, PNG, BMP, and GIF
- Reading images with resolution from 75 to 600 dpi
- Reading highly blurred or noised images
- Specifying image areas to scan barcodes
- Predefining target barcode types
- Managing recognition engine variables to reach the best trade-off between reading speed and quality (both manually and through embedded presets). For example, the following cases can be allowed for recognition: color barcodes on color background, dashed industrial Datamatrix barcodes, decreased images, damaged barcodes with incorrect text, damaged QR Codes, and others
- Detecting and then reading all barcodes presented in the scanned region
- Reading barcodes of different 1D types from a single scanned region
- Defining the angle and region information for all barcodes recognized in an image (using points, quadrangle, or rectangle to specify a bounding barcode region)
- Performing checksum validation for 1D and postal barcodes
- Increasing the barcode detection speed through multi-threading
- Scanning from multi-page TIFF through System.Drawing
- Scanning from PDF format via [*Aspose.PDF*](https://products.aspose.com/pdf/)

## **Barcode Generation Features**
- Class [*BarcodeGenerator*](https://reference.aspose.com/barcode/net/aspose.barcode.generation/barcodegenerator): generating barcode labels according to required settings
- Providing a wide range of options to customize barcode image appearance (size, resolution, height, background color, bar color, rotation angle, X-dimension, image quality, captions, wide-to-narrow-ratio, and others)
- Saving barcode labels in various image formats: JPEG, TIFF, PNG, BMP, GIF, EMF, and SVG 
- Customizing the barcode encoding type and parameters
- Supporting checksum addition (for 1D barcodes) and supplement data
- Supporting X- and Y-dimensions for 2D barcodes
- Customizing a wide-to-narrow ratio for the supported symbologies to improve recognition precision
- Setting an encoding type for 2D barcodes: Error Checking and Correcting (ECC) or Extended Channel Interpretation (ECI)
- Providing visual components for barcode generation in WinForms and WPF (e.g. supporting WYSIWYG editing through GUI-based controls)
- Encoding DataMatrix barcodes through X12, EDIFACT, and Base 256
- Embedding barcodes to Word and PDF formats via [*Aspose.Words*](https://products.aspose.com/words/) and [*Aspose.PDF*](https://products.aspose.com/pdf/)

## **Barcode Imaging Features**
- Customizing barcode image borders, border color, style, margins, and width
- Customizing barcode image color, background color, and bar color
- Customizing bar height
- Customizing barcode caption and its font, background/foreground colors, alignment, and location
- Rotating barcode images to any degree
- Setting the required quality and resolution setting for barcode images to be generated
- Anti-aliasing for barcode images
- Selecting size units (inches or millimeters)
- Auto-sizing of barcode images
- Rendering barcode images on any device

## Supported Symbologies for Barcode Generation & Recognition

**Linear barcode types**, or *1D barcodes*, correspond to the first generation of one-dimensional barcodes (1D) that are used to represent information by varying the widths and spacings of parallel lines. Some 1D symbologies allow encoding only numbers, while others permit encoding also letters.  

**DataBar barcodes** (former RSS-14) are 1D and 1D staked barcodes, which were developed to efficiently encode [*GS1 Application Identifier*](https://ref.gs1.org/ai/?lang=en) data.

**Matrix barcodes**, also known as *2D barcodes*, have been introduced as a two-dimensional way to encode information. Two-dimensional (2D) barcodes are generated using various symbols and shapes. This barcode type is considered to be more efficient, as such barcodes contain more data per unit area, and most of them are self-correctable.  
  
**Postal barcodes** are specific symbologies used by postal services in different countries.

**HIBC barcodes** encode data in [special format](https://www.hibcc.org/udi-labeling-standards/barcode-standards/) which is used in Health Industry. As transport, the barcodes use other 1D and 2D barcodes and encode data as Alpha-Numeric.

**GS1 barcodes** use other 1D and 2D barcodes to encode [*GS1 Application Identifier*](https://ref.gs1.org/ai/?lang=en) data.

|Barcode Family|Barcode Types|
|---|---|
| 1D Numeric (Linear) |Codabar, Code11, Code128, DataLogic2of5, EAN13, EAN14, EAN8, IATA2of5, ISBN, ISMN, ISSN, ITF14, ITF6, Interleaved2of5, ItalianPost25, MSI, Matrix2of5, OPC, PZN, PatchCode, Pharmacode, SCC14, SSCC18, Standard2of5, UPCA, UPCE|
| 1D Alpha-Numeric (Linear) |CodablockF, Code128, Code16K, Code32, Code39Extended, Code39Standard, Code93Extended, Code93Standard, VIN|
| DataBar (RSS-14) |DatabarExpanded, DatabarExpandedStacked, DatabarLimited, DatabarOmniDirectional, DatabarStacked, DatabarStackedOmniDirectional, DatabarTruncated|
| 2D |Aztec, CompactPdf417, DataMatrix, DotCode, HanXin, MacroPdf417, MaxiCode, MicroPdf417, MicroQR, Pdf417, QR, RectMicroQR(rMQR), Swiss QR Code|
| Postal |AustraliaPost, AustralianPosteParcel, DeutschePostIdentcode, DeutschePostLeitcode, DutchKIX, Mailmark, Mailmark 2D, OneCode, Planet, Postnet, RM4SCC, SingaporePost, SwissPostParcel|
| HIBC |HIBCAztecLIC, HIBCAztecPAS, HIBCCode128LIC, HIBCCode128PAS, HIBCCode39LIC, HIBCCode39PAS, HIBCDataMatrixLIC, HIBCDataMatrixPAS, HIBCQRLIC, HIBCQRPAS|
| GS1 |GS1Aztec, GS1CodablockF, GS1Code128, GS1CompositeBar (GS1 Composite barcode), GS1DataMatrix, GS1DotCode, GS1HanXin, GS1MicroPdf417, GS1QR, UpcaGs1Code128Coupon, UpcaGs1DatabarCoupon|
| Other | MicrE13B(recognition only) |

## Barcode Generation & Recognition Formats

**Images:** JPEG, TIFF, PNG, BMP, GIF, EXIF

## Save BarCode Labels As

**Images:** EMF, SVG

## **Supported Operating Systems**
The barcode library supports any 32-bit or 64-bit operating system with the installed .NET framework 2.0 or later / .Net Core 2.1 or later with with [Aspose.Drawing.Common](https://www.nuget.org/packages/Aspose.Drawing.Common/) (.Net 7 included).
  
|Operating System|Compatible Versions|
|---|---|
|**Microsoft Windows**|Microsoft Windows 7 or later: x64 / x86|
|**Microsoft Windows Server**|Microsoft Windows Server 2008 and later: x64 / x86|
|**Linux**|Any Linux x64 or x86 with installed .Net (Mono, .Net Core) |
|**MacOS**|Any MacOS x64 or x86 with installed .Net (Mono, .Net Core) |
|**Android**|Any supported with [.Net MAUI](https://learn.microsoft.com/dotnet/maui/what-is-maui)|
|**iOS**|Any supported with [.Net MAUI](https://learn.microsoft.com/dotnet/maui/what-is-maui)|
|**Tizen**|Any supported with [.Net MAUI](https://learn.microsoft.com/dotnet/maui/what-is-maui)|

## **Supported Frameworks**
***Aspose.BarCode for .NET*** can be used to create any type of x86 or x64 (32-bit or 64-bit) .NET application. Supported .NET frameworks are outlined below.
  
|Framework|Supported Versions|Additional Requirements|
|---|---|---|
|.NET Framework|2.0 / 3.5 / 4.0 / 4.6 / 4.7 / 4.8| |
|.NET Standard|2.0 / 2.1| [Aspose.Drawing.Common](https://www.nuget.org/packages/Aspose.Drawing.Common/) 23.5.0+ / [System.Text.Encoding.CodePages](https://www.nuget.org/packages/System.Text.Encoding.CodePages/) 7.0.0+|
|.NET Core| 3.1 / .Net 5.0 / .Net 6.0 / .Net 7.0.| [Aspose.Drawing.Common](https://www.nuget.org/packages/Aspose.Drawing.Common/) 23.5.0+ / [System.Text.Encoding.CodePages](https://www.nuget.org/packages/System.Text.Encoding.CodePages/) 7.0.0+|

## Generate a Barcode Label with Code128

Try the following snippet to see how Aspose.BarCode API performs in your environment or check the [GitHub Repository](https://github.com/aspose-barcode/Aspose.BarCode-for-.NET) for other common usage scenarios.

```csharp
// instantiate object and set different barcode properties
BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Code128, "1234567");
generator.Parameters.Barcode.XDimension.Millimeters = 1f;

// save the image to your system and set its image format to Jpeg
generator.Save(dir + "output.jpg", BarCodeImageFormat.Jpeg);
```

## Hide Barcode Text from the PNG Label via C# Code

Aspose.BarCode for .NET allows you to customize various properties of barcodes, such as borders, color, type, bar height as well as barcode text. The following example shows, how simple it is to hide the barcode text using C#.

```csharp
string codeText = "This text is hidden.\n";

// instantiate barcode object and set CodeText, Symbology , and  CodeLocation
BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.DataMatrix, codeText);
generator.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
generator.Save(dir + "output.png", BarCodeImageFormat.Png);
```

## Recognize Barcode from File via C# Code

The following example demonstrates how to scan a picture of a barcode image using Aspose.BarCode
```csharp
// Read file from directory with DecodeType.EAN13
using (BarCodeReader reader = new BarCodeReader(dataDir + "Scan.jpg", DecodeType.EAN13))
{
    foreach (BarCodeResult result in reader.ReadBarCodes())
    {
        // Read symbology type and code text
        Console.WriteLine("Symbology Type: " + result.CodeType);
        Console.WriteLine("CodeText: " + result.CodeText);
    }
}
```

[Home](https://www.aspose.com/) | [Product Page](https://products.aspose.com/barcode/net) | [Docs](https://docs.aspose.com/barcode/net/) | [Demos](https://products.aspose.app/barcode/family) | [API Reference](https://apireference.aspose.com/barcode/net) | [Examples](https://github.com/aspose-barcode/Aspose.BarCode-for-.NET) | [Blog](https://blog.aspose.com/category/barcode/) | [Search](https://search.aspose.com/) | [Free Support](https://forum.aspose.com/c/barcode) | [Temporary License](https://purchase.aspose.com/temporary-license)
