---
title: Aspose.BarCode for .NET 17.10 Release Notes
type: docs
weight: 30
url: /net/aspose-barcode-for-net-17-10-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for Aspose.BarCode for .NET 17.10

{{% /alert %}} 
### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|BARCODENET-36699|Merge Aspose.BarCode for WPF with main .NET 3.0 - 4.5 versions|Enhancement|
|BARCODENET-36667|Remove Obsolete public API|Enhancement|
|BARCODENET-36694|Incorrect text in picture for DatabarStacked|Bug|
|BARCODENET-36681|Recognition result isn't correct for DatabarExpandedStacked|Bug|
|BARCODENET-36679|Unable to recognize DatabarStacked barcode|Bug|
|BARCODENET-36652|Rotation doesn't affected to EMF export|Bug|
|BARCODENET-36688|Index was out of range exception when try to recognize barcode from PDF|Bug|
|BARCODENET-36701|Incorrect DatabarLimited generation/recognition|Bug|
### **Public API and Backward Incompatible Changes**
This section lists public API changes that were introduced in Aspose.BarCode for .NET 17.10. It includes not only new, obsoleted public methods, but also a description of any changes in the behavior behind the scenes in Aspose.BarCode for .NET which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.

- Aspose.BarCode for WPF has been merged with main Aspose.BarCode for .NET 3.0 - 4.5.
- Class Aspose.BarCode.WPF.BarCodeElement has been added to Aspose.BarCode for .NET 3.0 and higher.
#### **Removed Members**

|Method|ICOMBarCodeReader.SetBarCodeReadType|Please use ICOMBarCodeReader.SetBarCodeReadType|
| :- | :- | :- |
|Property|BarCodeReader.ImageBinarizationHints|Please use ManualHints and RecognitionMode|
|Method|BarCodeReader.GetReadType()|Please use BarCodeReader.GetCodeType()|
|Method|BarCodeReader.SetBarCodeReadType()|Please use BarCodeReader.SetBarCodeReadType(BaseDecodeType type)|
|Constructor|BarCodeReader(Bitmap, BarCodeReadType)|Please use BarCodeReader(Bitmap, BaseDecodeType)|
|Constructor|BarCodeReader(Bitmap, Rectangle, BarCodeReadType)|Please use BarCodeReader(Bitmap, Rectangle, BaseDecodeType)|
|Constructor|BarCodeReader(Bitmap, Rectangle[], BarCodeReadType)|Please use BarCodeReader(Bitmap, Rectangle[], BaseDecodeType)|
|Constructor|BarCodeReader(string, BarCodeReadType)|Please use BarCodeReader(string, BaseDecodeType)|
|Constructor|BarCodeReader(Stream, BarCodeReadType)|Please use BarCodeReader(Stream, BaseDecodeType)|
|Enum|BarCodeReadType|Please use class DecodeType|
|Constructor|BarCodeWebControl(string, Symbology)|Please use BarCodeWebControl(string, BaseEncodeType)|
|Property|BarCodeWebControl.SymbologyType|Please use BarCodeWebControl.EncodeType|
|Method|BarCodeBuilder.SaveAsTiffInCMYK|Please use BarCodeBuilder.Save(string, BarCodeImageFormat.TiffInCmyk)|
|Method|BarCodeBuilder.SaveAsEmf(string)|Please use BarCodeBuilder.Save(string, BarCodeImageFormat.Emf)|
|Method|BarCodeBuilder.SaveAsEmf(Stream)|Please use BarCodeBuilder.Save(Stream, BarCodeImageFormat.Emf)|
|Constructor|BarCodeBuilder(string,Symbology)|Please use BarCodeBuilder(string codeText, BaseEncodeType type)|
|Property|BarCodeBuilder.SymbologyType|Please use BarCodeBuilder.EncodeType|
|Enum|Symbology|Please use class EncodeTypes|
|IBarCodeControl.SymbologyType| |Please use IBarCodeControl.EncodeType|
|Property|BarCodeControl.SymbologyType|Please use BarCodeControl.EncodeType|
|Constructor|BarCodeControl(string, Symbology)|Please use BarCodeControl(string, BaseEncodeType)|
|method| |BaseDecodeType.Convert(BarCodeReadType)|
|method| |BaseDecodeType.Convert(BaseDecodeType)|
|method| |BaseDecodeType.ConvertSingle(SingleDecodeType)|
|method| |BaseDecodeType.ConvertMulty(MultyDecodeType)|
|Constructor|BaseEncodeType(short, string, BarcodeClassifications)|Please use predefined supported encode types from class EncodeType|
|Constructor|BaseEncodeType(short, BarcodeClassifications)|Please use predefined supported encode types from class EncodeType|
|Property|BarCodeBuilder.AustraliaPostFormatControlCode and enum AustraliaPostFormatControlCode|<p>Please include format control code into the BarCodeBuilder.CodeText (e.g. builder.CodeText = \"1112345678\")<br>Following format codes are available in AustraliaPostFormat:</p><p>- Standard Customer BarCode - "0101"</p><p>- Reply Paid BarCode - "1112"</p><p>- Customer BarCode 2 - "1230"</p><p>- Customer BarCode 3 - "2002"</p><p>- Routing BarCode - "2221"</p><p>- Redirection - "3002"</p>|
|Dependency property|Aspose.BarCode.WPF.BarCodeElement.SymbologyTypeProperty|Please use Aspose.BarCode.WPF.BarCodeElement.EncodeTypeProperty|
|Class|Aspose.BarCode.BarCodeRecognition.Common.Algorithms.HistogramStatistic|has been removed as useless|
|Enum|Aspose.BarCode.BarCodeRecognition.RecognitionHints.ImageBinarization|has been removed as useless|
#### **New Members**

|constructor|BarCodeWebControl(string, BaseEncodeType)| |
| :- | :- | :- |
###
