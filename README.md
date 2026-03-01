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
- Pure managed .NET library.
- Supports modern .NET platforms including **.NET Framework**, **.NET**, and **.NET Core**.
- Works across a wide range of platforms supported by **.NET and .NET MAUI**, including **Windows, Linux, macOS, Android, and iOS**.
- Compatible with other Aspose products for extended document workflows.
- Optimized for high-throughput barcode generation and recognition.
- Supports multi-core processing where applicable.
- Designed for batch processing and server-side scenarios.
- Supports common raster image formats for input and output: **BMP**, **JPEG**, **GIF**, **TIFF**, and **PNG**.
- Supports vector image formats for output: **SVG**, **EMF**, and **PDF**.
- Supports a wide range of international barcode standards and symbologies.
- Supports **GS1** standards and industry-specific barcode formats.
- Simple licensing model suitable for development and production environments.
- License can be embedded and protected within the application.

## **Barcode Generation Features**
- The **[*BarcodeGenerator*](https://reference.aspose.com/barcode/net/aspose.barcode.generation/barcodegenerator)** class provides flexible and reliable barcode generation capabilities.
- Generate a wide range of **1D and 2D barcode symbologies**, including linear, matrix, stacked, postal, GS1, and industry-specific formats.
- Manage barcode size and layout, including X-dimension (module width), bar height, margins and quiet zones, auto-sizing, and scaling.
- Customize barcode appearance, including foreground and background colors, rotation to any angle, borders and frames, and captions with configurable font, alignment, and positioning.
- Generate barcodes with **high-resolution output** suitable for printing and screen display.
- Configure symbology-specific parameters, such as error correction levels (for 2D barcodes), columns, rows, and encoding modes where applicable, as well as checksums and supplemental data for supported 1D barcodes.
- Export generated barcodes to raster image formats (**BMP, JPEG, GIF, TIFF, PNG**) and vector formats (**SVG, EMF, PDF**).
- Generate barcode images fully in memory or save them directly to files or streams.
- Embed barcodes into Word and PDF documents via **[*Aspose.Words*](https://products.aspose.com/words/)** and **[*Aspose.PDF*](https://products.aspose.com/pdf/)**.
- Use visual components for barcode generation in **WinForms** and **WPF** applications.

## **Barcode Recognition Features**
- The **[*BarCodeReader*](https://reference.aspose.com/barcode/net/aspose.barcode.barcoderecognition/barcodereader/)** class enables detection and recognition of barcodes from images, image streams, and files.
- Recognize a wide range of **1D and 2D barcode symbologies**, including linear, matrix, stacked, postal, GS1, and industry-specific formats.
- Detect and read barcodes **at any orientation**, including rotated and skewed images.
- Read multiple barcodes from a single image.
- Restrict recognition to **specific image regions** to improve performance and accuracy.
- Validate checksums for supported 1D and postal barcode types.
- Retrieve detailed recognition results, including barcode type, decoded text, and barcode location.
- Process images in common raster formats (**BMP, JPEG, GIF, TIFF, PNG**).
- Support batch processing and high-throughput recognition scenarios.
- Scan barcodes from **multi-page TIFF** images via **System.Drawing** or **Aspose.Drawing.Common**.
- Scan barcodes from **PDF documents** via **[*Aspose.PDF*](https://products.aspose.com/pdf/)**.
- Select predefined recognition modes optimized for different scenarios, such as fast detection, high accuracy, or degraded image conditions.
- Adjust recognition parameters to handle low-quality or noisy images, complex backgrounds, small or dense barcodes, and inverted or low-contrast barcodes.
- Improve recognition performance by limiting expected barcode types and applying appropriate quality presets.

## **Complex Barcode Features**
- The **[*ComplexBarcodeGenerator*](https://reference.aspose.com/barcode/net/aspose.barcode.complexbarcode/complexbarcodegenerator/)** and **[*ComplexCodetextReader*](https://reference.aspose.com/barcode/net/aspose.barcode.complexbarcode/complexcodetextreader/)** classes enable generation and recognition of complex barcodes based on **structured domain models**, rather than manual composition of barcode text.
- Support complex standards that require strict payload structure, field validation, and formatting rules (for example, **Driving License ID Code** or **Swiss QR Code**).
- Parse and interpret complex barcode payloads into **strongly typed structured data representations**.
- Validate encoded data against format and checksum rules defined by the corresponding complex barcode specification.
- Eliminate manual handling of low-level encoding details such as field separators, control codes, and field ordering.
- Support **round-trip workflows**, converting **structured data into barcode images** and **recognized barcode data back into structured objects**.

## Supported Symbologies for Barcode Generation & Recognition

***Aspose.BarCode for .NET*** supports over 80 different [barcode types](https://en.wikipedia.org/wiki/Barcode#Types_of_barcodes) used in a variety of industries, namely, 1D (linear), 2D (including QR codes), and postal symbologies. The detailed information about generating barcodes using various barcode standards can be found in section [Generation Specifics for Symbologies](/barcode/net/generate-barcode-with-different-symbology/)
    
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

**Images:** EMF, SVG, PDF

## **Supported Operating Systems**
The barcode library supports any 32-bit or 64-bit operating system with the installed .NET framework 2.0 or later / .Net Core 3.1 or later with with [Aspose.Drawing.Common](https://www.nuget.org/packages/Aspose.Drawing.Common/) (.Net 10 included).
  
|Operating System|Compatible Versions|
|---|---|
|**Microsoft Windows**|Microsoft Windows 10 or later: x64 / x86|
|**Microsoft Windows Server**|Microsoft Windows Server 2016 and later: x64 / x86|
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
|.NET Standard|2.0 | [Aspose.Drawing.Common](https://www.nuget.org/packages/Aspose.Drawing.Common/) 25.11.0+ / [System.Text.Encoding.CodePages](https://www.nuget.org/packages/System.Text.Encoding.CodePages/) 9.0.2+|
|.NET Core| 3.1 / .Net 6.0 / .Net 8.0| [Aspose.Drawing.Common](https://www.nuget.org/packages/Aspose.Drawing.Common/) 25.11.0+ / [System.Text.Encoding.CodePages](https://www.nuget.org/packages/System.Text.Encoding.CodePages/) 9.0.2+|
|.NET Core| .Net 9.0. / .Net 10.0.| [Aspose.Drawing.Common](https://www.nuget.org/packages/Aspose.Drawing.Common/) 25.11.0+|

**Note on 32-bit (x86) Environments**

Aspose.BarCode fully supports 32-bit (x86) applications. However, it is recommended to use a 64-bit (x64) environment when possible.

Due to the inherent memory limitations of 32-bit processes, barcode recognition performance may be reduced in scenarios that require significant computational or memory resources, including:
* processing large or high-resolution images,
* PDF and document-based workflows,
* batch or bulk recognition operations,
* multi-threaded or server-side applications.

For improved performance, stability, and scalability, use of a 64-bit environment is advised.

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
