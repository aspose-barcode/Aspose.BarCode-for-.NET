---
title: Managing Different Barcode Settings
type: docs
weight: 60
url: /net/managing-different-barcode-settings/
---

## **Manage Barcode Caption**
Sometimes, developers might be interested in displaying some extra information on the barcode image that is called Caption. Using Aspose.BarCode, developers can display captions on above, below or both positions of the barcode image.

|**All possible positions where captions can be placed**|
| :- |
|![todo:image_alt_text](managing-different-barcode-settings_1.jpg)|
It is also possible to customize the text, alignment, font, color and space of the caption. Aspose.BarCode provides a CaptionParameters class to serve this purpose. BarcodeGenerator class have two properties, [CaptionAbove](https://apireference.aspose.com/net/barcode/aspose.barcode.generation/barcodegenerator/properties/captionabove) , and [CaptionBelow](https://apireference.aspose.com/net/barcode/aspose.barcode.generation/barcodegenerator/properties/captionbelow) that take an instance of CaptionParameters class. 
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarCodes-ManageCaption-ManageCaption.cs" >}}



Continuing the sample above, the following sample shows the Font and Color settings.
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarcodeImages-SetFontandColorSetting-SetFontandColorSetting.cs" >}}

|**Customizing Caption**|
| :- |
|![todo:image_alt_text](managing-different-barcode-settings_2.jpg)|
For the functionality differences in Aspose.BarCode .Net and Aspose.BarCode Java, please check out [EditionType](/barcode/net/edition-types/)
## **Manage X and Y Dimensions of Barcode**
### **What is X-Dimension?**
All barcode symbologies have many unique things in themselves but there are also some things, which are common to all and X-Dimension is one of those common things. All barcodes are based on some X-Dimension. The X-Dimension is the narrowest bar or space in the barcode. Barcode symbologies usually specify a minimum value (of X-Dimension) to ensure compatibility between reading and printing equipment used in an open system (a barcode label that will be read by scanners from outside your company). The X-Dimension determines a barcode's density. Density refers to the amount of information that can be stored within a specific amount of space. When X-Dimension is small, the area required for each character is less than when X-Dimension is large; thus the barcode can hold more per linear inch and is said to be of higher density. Similarly, increasing the width of the narrowest element (X-Dimension) increases the space required for each character and reduces the number of characters per inch. Because the resulting code is often quite large, very low-density codes are often associated with applications such as warehousing that require reading bar codes from a significant distance (3 to 30 feet).

X-Dimension is specified in Mils (One thousand of an inch) but it can also be specified in Inches and Millimeters. For conversion purposes, developers may use the following ratios:|| 1 Mil || = || 0.001 Inches ||| 1 Inch | = | 25.4 Millimeters |Some sample X-Dimension values are listed below in Mils, Inches and Millimeters for the ease of developers.|| Mils || Inches || Millimeters || 4 | 0.004 | 0.1016 || 6 | 0.006 | 0.1524 || 8 | 0.008 | 0.2032 || 10 | 0.01 | 0.254 || 20 | 0.02 | 0.508 || 40 | 0.04 | 1.016 || 80 | 0.08 | 2.032 || 160 | 0.16 | 4.064 ||Other elements of a barcode are expressed as multiples of the X-Dimension. For instance, to ensure accurate scanning, most bar codes have a Quiet Zone (the blank margin on either side of a barcode that is used to tell the barcode reader about where a barcode's symbology starts and stops) whose width is 10X, or ten times the barcode's X-Dimension. In general, the greater the X-Dimension, the easier a barcode can be scanned.
### **Aspose.BarCode and X-Y Dimension**
Aspose.BarCode provides an [X-dimension](https://apireference.aspose.com/net/barcode/aspose.barcode.generation/barcodegenerator/properties/xdimension) property in BarcodeGenerator classes that allow developers to set the [X-dimension](https://apireference.aspose.com/net/barcode/aspose.barcode.generation/barcodegenerator/properties/xdimension) of the bars in the barcode. Normally, [X-dimension](https://apireference.aspose.com/net/barcode/aspose.barcode.generation/barcodegenerator/properties/xdimension) is configured in Mils but to ease the job of developers, Aspose.BarCode uses Millimeter as a measuring unit by default. But of course, developers can modify the measuring unit according to their choice using defined units under [Unit ](https://apireference.aspose.com/net/barcode/aspose.barcode.generation/unit)class. Just like [X-dimension](https://apireference.aspose.com/net/barcode/aspose.barcode/barcodebuilder/properties/xdimension) in linear barcodes, ImageHeight property of BarcodeGenerationParameters class fcan be used to set the height.
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarCodes-ManageXYDimension-ManageXYDimension.cs" >}}



Some of the 2D symbologies have a rectangular module, such as Datamatrix, then its yDimension will be ignored, module width and height will depend on xDimension: **rectangular 2d barcode**. For the functionality differences in Aspose.BarCode .Net and Aspose.BarCode Java, please check out [EditionType](/pages/createpage.action?spaceKey=barcodenet&title=Edition+Types&linkCreation=true&fromPageId=12943836)
## **Set Height of the Bars in the Barcode Image**
If developers want to control the height of the bars in the barcode, they can do it very easily by just setting the BarHeight property of all barcode generating classes offered by Aspose.BarCode. BarHeight property takes a float value to set the bar height and it's measuring unit is millimeter by default. To change the measuring unit of the bar height, developers can make use of any of the units defined in the Unit class ([BarCodeGenerator](https://apireference.aspose.com/net/barcode/aspose.barcode.generation/barcodegenerator), [BarCodeControl](https://apireference.aspose.com/net/barcode/aspose.barcode.windows.forms/barcodecontrol) or [BarCodeWebControl](https://apireference.aspose.com/net/barcode/aspose.barcode.web.ui/barcodewebcontrol)) provided by [Aspose.BarCode](https://apireference.aspose.com/net/barcode). The pre-defined measuring units in Unit class are as follows:

|**Measuring Units**|**Description**|
| :- | :- |
|Document|Specifies the document unit (1/300 inch) as the unit of measure|
|Inch|Specifies the inch as the unit of measure|
|Millimeter|Specifies the millimeter as the unit of measure|
|Pixel|Specifies a device pixel as the unit of measure|
|Point|Specifies a printer's point (1/72 inch) as the unit of measure|
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarCodes-SetHeightBarcodeBars-SetHeightBarcodeBars.cs" >}}
## **Setting Wide Narrow Ratio**
Some barcode symbologies like Code39, Interleaved2of5 and Standard2of5 allow to set the ratio of wide to narrow elements (bar or space) of the barcode. We know that in barcodes, a bar can be the printed black bar or the white space between the bars. So, it's a better way to say that a barcode is composed of two kinds of bars: black bar and white bar. In such barcodes, some bars are wider than the others. For example, in Code39 (sometimes called Code 3 from 9) symbology, each character is represented by 9 bars - 3 of which are wider than the others and the ratio of its bar widths can range from 2.2:1 to 3:1. To read the encoded information in a barcode reliably, the decoder must be able to differentiate between the wide and narrow bars. So, to manage the widths of the bars (both wide and narrow) in a barcode, wide to narrow ratio is configured that is supported by Aspose.BarCode as discussed below in more detail.

[Aspose.BarCode](https://apireference.aspose.com/net/barcode) facilitates its developers to make use of [WideNarrowRatio](https://apireference.aspose.com/net/barcode/aspose.barcode.generation/barcodegenerator/properties/widenarrowratio) property of a barcode class to control the ratio of wide/narrow element of the barcode. To specify the ratio, you just need to pass a float value to the [WideNarrowRatio](https://apireference.aspose.com/net/barcode/aspose.barcode.generation/barcodegenerator/properties/widenarrowratio) property. A barcode with different ratios (in increasing order) is shown in the figure below:

{{% alert color="primary" %}} 

Wide to narrow ratio for Interleaved2of5 and Standard2of5 symbologies is configured in the same way as that of Code39.

{{% /alert %}} 

A complete example is given below to demonstrate the use of [WideNarrowRatio](https://apireference.aspose.com/net/barcode/aspose.barcode.generation/barcodegenerator/properties/widenarrowratio) property.
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarCodes-WideNarrowRatio-WideNarrowRatio.cs" >}}
## **Setting Wide Narrow Ratio For Bars In BarCode**
Aspose.BarCode for .NET allows developers to set a wide narrow ratio of the bars in the barcode. Wide Narrow Ratio only works for symbologies :Code128, Code39, Interleaved2of5, and Standard2of5. The following code snippet shows you how set wide narrow ratio for bars In barcode.
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarCodes-SetWideNarrowRatio-SetWideNarrowRatio.cs" >}}
## **Set Start and Stop Symbols of Codabar Barcode**
The Codabar barcode has the following structure:

1. Start Symbol at the beginning (A, B, C or D)
1. Data to be encoded
1. End Symbol (A, B, C or D)

Using Aspose.BarCode for .NET, you can customize the start and stop symbols according to your requirements, using [BarCodeGenerator](https://apireference.aspose.com/net/barcode/aspose.barcode.generation/barcodegenerator).[Codabar](https://apireference.aspose.com/net/barcode/aspose.barcode.generation/barcodegenerator/properties/codabar).[StartSymbol](https://apireference.aspose.com/net/barcode/aspose.barcode.generation/codabarproperties/properties/startsymbol) and [BarCodeGenerator](https://apireference.aspose.com/net/barcode/aspose.barcode.generation/barcodegenerator).[Codabar](https://apireference.aspose.com/net/barcode/aspose.barcode.generation/barcodegenerator/properties/codabar).[StopSymbol](https://apireference.aspose.com/net/barcode/aspose.barcode.generation/codabarproperties/properties/stopsymbol) properties.
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarCodes-CodabarStartStopSymbols-CodabarStartStopSymbols.cs" >}}

|![todo:image_alt_text](managing-different-barcode-settings_3.png)|
| :- |
In the below code snippet, we will set A as the start symbol and D as the stop symbol for the Codabar barcode.
## **Set Height of the Bars in DataBarStackedOmniDirectional Barcodes**
This example sets the height of barcodes in while generating DataBarStackedOmniDirectional barcodes.
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarCodes-SetHeightOfBarsInDataBarStackedOmniDirectional-SetHeightOfBarsInDataBarStackedOmniDirectional.cs" >}}

Sets the height of DataBarStackedOmniDirectional barcodes.

The offset can be 1px to hold the equal height of rows, and 0.5 px is a rounding error. Max offset 1.5px = 0.03mm for 1200 DPI.
1mm – 48px
1px – 0.02 mm
1.5px – 0.03mm
## **Generate Australia Post Barcode**
The Australian post barcode can be generated using the code sample given below:
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarCodes-GenerateAustraliaPostBarcode-GenerateAustraliaPostBarcode.cs" >}}
## **Export Barcode Properties To XML**
The following code snippet demonstrates how to export all of the properties/variables that have been set to generate a barcode to XML.
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarCodes-ExportPropertiesToXML-ExportPropertiesToXML.cs" >}}
## **Generate BarCode With Segments Per Row**
Aspose.BarCode for .NET allows developers to set segments per row while generating the barcode. Following is the sample code demonstrates how to set segments per row before generating a barcode image.

{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarCodes-BarcodeWithSegments-BarcodeWithSegments.cs" >}}
