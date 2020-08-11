---
title: Aspose.BarCode for .NET 19.11 Release Notes
type: docs
weight: 20
url: /net/aspose-barcode-for-net-19-11-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes information for [Aspose.BarCode for .NET 19.11](https://downloads.aspose.com/barcode/net/new-releases/aspose.barcode-for-.net-19.11/).

{{% /alert %}} 
## **All Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|BARCODENET-37334|Create a new barcode detector|New Feature|
|BARCODENET-37303|Implement XML serialization for BarcodeGenerator|New Feature|
|BARCODENET-37302|Add changes to BarCodeReader interface|New Feature|
|BARCODENET-37316|Barcode with rotation is incorrect in SVG|Bug|
|BARCODENET-36973|Not able to read all barcodes from TIFF images|Bug|
|BARCODENET-37034|Region Points and Image Accuracy|Bug|

## **Public API and Backward Incompatible Changes**
Following members have been added:

- Property Aspose.BarCode.Generation.Unit.Resolution
- Method Aspose.BarCode.Generation.BarcodeGenerator.ExportToXml(System.String)
- Method Aspose.BarCode.Generation.BarcodeGenerator.ImportFromXml(System.String)
- Property Aspose.BarCode.BarCodeRecognition.QualitySettings.HighQualityDetection
- Property Aspose.BarCode.BarCodeRecognition.QualitySettings.MaxQualityDetection
- Property Aspose.BarCode.BarCodeRecognition.QualitySettings.UseOldBarcodeDetector
- Property Aspose.BarCode.BarCodeRecognition.QualitySettings.DetectorSettings
- Class Aspose.BarCode.BarCodeRecognition.BarcodeSvmDetectorSettings
- Property Aspose.BarCode.BarCodeRecognition.BarcodeSvmDetectorSettings.ScanWindowSizes
- Property Aspose.BarCode.BarCodeRecognition.BarcodeSvmDetectorSettings.SimilarityCoef
- Property Aspose.BarCode.BarCodeRecognition.BarcodeSvmDetectorSettings.RegionLikelihoodThresholdPercent
- Property Aspose.BarCode.BarCodeRecognition.BarcodeSvmDetectorSettings.SkipDiagonalSearch
- Property Aspose.BarCode.BarCodeRecognition.BarcodeSvmDetectorSettings.HighPerformance
- Property Aspose.BarCode.BarCodeRecognition.BarcodeSvmDetectorSettings.NormalQuality
- Property Aspose.BarCode.BarCodeRecognition.BarcodeSvmDetectorSettings.HighQuality
- Property Aspose.BarCode.BarCodeRecognition.BarcodeSvmDetectorSettings.MaxQuality  
- Property Aspose.BarCode.BarCodeRecognition.BarCodeReader.DetectEncoding 
- Property Aspose.BarCode.BarCodeRecognition.BarCodeReader.FoundCount 
- Property Aspose.BarCode.BarCodeRecognition.BarCodeReader.FoundBarCodes 
- Method Aspose.BarCode.BarCodeRecognition.BarCodeReader.ReadBarCodes 
- Method Aspose.BarCode.BarCodeRecognition.BarCodeReader.SetBarCodeReadType(Aspose.BarCode.BarCodeRecognition.SingleDecodeType[])    
- Class Aspose.BarCode.BarCodeRecognition.BarCodeConfidence 
- Field Aspose.BarCode.BarCodeRecognition.BarCodeConfidence.None 
- Field Aspose.BarCode.BarCodeRecognition.BarCodeConfidence.Moderate 
- Field Aspose.BarCode.BarCodeRecognition.BarCodeConfidence.Strong 
- Class Aspose.BarCode.BarCodeRecognition.BarCodeExtendedParameters 
- Property Aspose.BarCode.BarCodeRecognition.BarCodeExtendedParameters.OneD 
- Property Aspose.BarCode.BarCodeRecognition.BarCodeExtendedParameters.Code128 
- Property Aspose.BarCode.BarCodeRecognition.BarCodeExtendedParameters.QR 
- Property Aspose.BarCode.BarCodeRecognition.BarCodeExtendedParameters.Pdf417 
- Method Aspose.BarCode.BarCodeRecognition.BarCodeExtendedParameters.Equals(System.Object) 
- Method Aspose.BarCode.BarCodeRecognition.BarCodeExtendedParameters.op_Equality(Aspose.BarCode.BarCodeRecognition.BarCodeExtendedParameters,Aspose.BarCode.BarCodeRecognition.BarCodeExtendedParameters) 
- Method Aspose.BarCode.BarCodeRecognition.BarCodeExtendedParameters.op_Inequality(Aspose.BarCode.BarCodeRecognition.BarCodeExtendedParameters,Aspose.BarCode.BarCodeRecognition.BarCodeExtendedParameters) 
- Method Aspose.BarCode.BarCodeRecognition.BarCodeExtendedParameters.GetHashCode 
- Method Aspose.BarCode.BarCodeRecognition.BarCodeExtendedParameters.ToString 
- Class Aspose.BarCode.BarCodeRecognition.BarCodeRegionParameters 
- Property Aspose.BarCode.BarCodeRecognition.BarCodeRegionParameters.Quadrangle 
- Property Aspose.BarCode.BarCodeRecognition.BarCodeRegionParameters.Angle 
- Property Aspose.BarCode.BarCodeRecognition.BarCodeRegionParameters.Points 
- Property Aspose.BarCode.BarCodeRecognition.BarCodeRegionParameters.Rectangle 
- Method Aspose.BarCode.BarCodeRecognition.BarCodeRegionParameters.Equals(System.Object) 
- Method Aspose.BarCode.BarCodeRecognition.BarCodeRegionParameters.op_Equality(Aspose.BarCode.BarCodeRecognition.BarCodeRegionParameters,Aspose.BarCode.BarCodeRecognition.BarCodeRegionParameters) 
- Method Aspose.BarCode.BarCodeRecognition.BarCodeRegionParameters.op_Inequality(Aspose.BarCode.BarCodeRecognition.BarCodeRegionParameters,Aspose.BarCode.BarCodeRecognition.BarCodeRegionParameters) 
- Method Aspose.BarCode.BarCodeRecognition.BarCodeRegionParameters.GetHashCode 
- Method Aspose.BarCode.BarCodeRecognition.BarCodeRegionParameters.ToString 
- Class Aspose.BarCode.BarCodeRecognition.BarCodeResult 
- Method Aspose.BarCode.BarCodeRecognition.BarCodeResult.#ctor(Aspose.BarCode.BarCodeRecognition.BarCodeResult) 
- Property Aspose.BarCode.BarCodeRecognition.BarCodeResult.ReadingQuality 
- Property Aspose.BarCode.BarCodeRecognition.BarCodeResult.Confidence 
- Property Aspose.BarCode.BarCodeRecognition.BarCodeResult.CodeText 
- Property Aspose.BarCode.BarCodeRecognition.BarCodeResult.CodeBytes 
- Property Aspose.BarCode.BarCodeRecognition.BarCodeResult.CodeType 
- Property Aspose.BarCode.BarCodeRecognition.BarCodeResult.CodeTypeName 
- Property Aspose.BarCode.BarCodeRecognition.BarCodeResult.Region 
- Property Aspose.BarCode.BarCodeRecognition.BarCodeResult.Extended 
- Method Aspose.BarCode.BarCodeRecognition.BarCodeResult.GetCodeText(System.Text.Encoding) 
- Method Aspose.BarCode.BarCodeRecognition.BarCodeResult.Equals(Aspose.BarCode.BarCodeRecognition.BarCodeResult) 
- Method Aspose.BarCode.BarCodeRecognition.BarCodeResult.Equals(System.Object) 
- Method Aspose.BarCode.BarCodeRecognition.BarCodeResult.op_Equality(Aspose.BarCode.BarCodeRecognition.BarCodeResult,Aspose.BarCode.BarCodeRecognition.BarCodeResult) 
- Method Aspose.BarCode.BarCodeRecognition.BarCodeResult.op_Inequality(Aspose.BarCode.BarCodeRecognition.BarCodeResult,Aspose.BarCode.BarCodeRecognition.BarCodeResult) 
- Method Aspose.BarCode.BarCodeRecognition.BarCodeResult.GetHashCode 
- Method Aspose.BarCode.BarCodeRecognition.BarCodeResult.ToString 
- Method Aspose.BarCode.BarCodeRecognition.BarCodeResult.Clone 
- Class Aspose.BarCode.BarCodeRecognition.BaseExtendedParameters 
- Property Aspose.BarCode.BarCodeRecognition.BaseExtendedParameters.IsEmpty 
- Class Aspose.BarCode.BarCodeRecognition.Code128ExtendedParameters 
- Property Aspose.BarCode.BarCodeRecognition.Code128ExtendedParameters.Code128DataPortions 
- Method Aspose.BarCode.BarCodeRecognition.Code128ExtendedParameters.Equals(System.Object) 
- Method Aspose.BarCode.BarCodeRecognition.Code128ExtendedParameters.op_Equality(Aspose.BarCode.BarCodeRecognition.Code128ExtendedParameters,Aspose.BarCode.BarCodeRecognition.Code128ExtendedParameters) 
- Method Aspose.BarCode.BarCodeRecognition.Code128ExtendedParameters.op_Inequality(Aspose.BarCode.BarCodeRecognition.Code128ExtendedParameters,Aspose.BarCode.BarCodeRecognition.Code128ExtendedParameters) 
- Method Aspose.BarCode.BarCodeRecognition.Code128ExtendedParameters.GetHashCode 
- Method Aspose.BarCode.BarCodeRecognition.Code128ExtendedParameters.ToString 
- Class Aspose.BarCode.BarCodeRecognition.OneDExtendedParameters 
- Property Aspose.BarCode.BarCodeRecognition.OneDExtendedParameters.Value 
- Property Aspose.BarCode.BarCodeRecognition.OneDExtendedParameters.CheckSum 
- Method Aspose.BarCode.BarCodeRecognition.OneDExtendedParameters.Equals(System.Object) 
- Method Aspose.BarCode.BarCodeRecognition.OneDExtendedParameters.op_Equality(Aspose.BarCode.BarCodeRecognition.OneDExtendedParameters,Aspose.BarCode.BarCodeRecognition.OneDExtendedParameters) 
- Method Aspose.BarCode.BarCodeRecognition.OneDExtendedParameters.op_Inequality(Aspose.BarCode.BarCodeRecognition.OneDExtendedParameters,Aspose.BarCode.BarCodeRecognition.OneDExtendedParameters) 
- Method Aspose.BarCode.BarCodeRecognition.OneDExtendedParameters.GetHashCode 
- Method Aspose.BarCode.BarCodeRecognition.OneDExtendedParameters.ToString 
- Class Aspose.BarCode.BarCodeRecognition.Pdf417ExtendedParameters 
- Property Aspose.BarCode.BarCodeRecognition.Pdf417ExtendedParameters.MacroPdf417FileID 
- Property Aspose.BarCode.BarCodeRecognition.Pdf417ExtendedParameters.MacroPdf417SegmentID 
- Property Aspose.BarCode.BarCodeRecognition.Pdf417ExtendedParameters.MacroPdf417SegmentsCount 
- Method Aspose.BarCode.BarCodeRecognition.Pdf417ExtendedParameters.Equals(System.Object) 
- Method Aspose.BarCode.BarCodeRecognition.Pdf417ExtendedParameters.op_Equality(Aspose.BarCode.BarCodeRecognition.Pdf417ExtendedParameters,Aspose.BarCode.BarCodeRecognition.Pdf417ExtendedParameters) 
- Method Aspose.BarCode.BarCodeRecognition.Pdf417ExtendedParameters.op_Inequality(Aspose.BarCode.BarCodeRecognition.Pdf417ExtendedParameters,Aspose.BarCode.BarCodeRecognition.Pdf417ExtendedParameters) 
- Method Aspose.BarCode.BarCodeRecognition.Pdf417ExtendedParameters.GetHashCode 
- Method Aspose.BarCode.BarCodeRecognition.Pdf417ExtendedParameters.ToString 
- Class Aspose.BarCode.BarCodeRecognition.QRExtendedParameters 
- Property Aspose.BarCode.BarCodeRecognition.QRExtendedParameters.QRStructuredAppendModeBarCodesQuantity 
- Property Aspose.BarCode.BarCodeRecognition.QRExtendedParameters.QRStructuredAppendModeBarCodeIndex 
- Property Aspose.BarCode.BarCodeRecognition.QRExtendedParameters.QRStructuredAppendModeParityData 
- Method Aspose.BarCode.BarCodeRecognition.QRExtendedParameters.Equals(System.Object) 
- Method Aspose.BarCode.BarCodeRecognition.QRExtendedParameters.op_Equality(Aspose.BarCode.BarCodeRecognition.QRExtendedParameters,Aspose.BarCode.BarCodeRecognition.QRExtendedParameters) 
- Method Aspose.BarCode.BarCodeRecognition.QRExtendedParameters.op_Inequality(Aspose.BarCode.BarCodeRecognition.QRExtendedParameters,Aspose.BarCode.BarCodeRecognition.QRExtendedParameters) 
- Method Aspose.BarCode.BarCodeRecognition.QRExtendedParameters.GetHashCode 
- Method Aspose.BarCode.BarCodeRecognition.QRExtendedParameters.ToString 
- Class Aspose.BarCode.BarCodeRecognition.Quadrangle 
- Method Aspose.BarCode.BarCodeRecognition.Quadrangle.#ctor(System.Drawing.Point,System.Drawing.Point,System.Drawing.Point,System.Drawing.Point) 
- Property Aspose.BarCode.BarCodeRecognition.Quadrangle.LeftTop 
- Property Aspose.BarCode.BarCodeRecognition.Quadrangle.RightTop 
- Property Aspose.BarCode.BarCodeRecognition.Quadrangle.RightBottom 
- Property Aspose.BarCode.BarCodeRecognition.Quadrangle.LeftBottom 
- Property Aspose.BarCode.BarCodeRecognition.Quadrangle.IsEmpty 
- Property Aspose.BarCode.BarCodeRecognition.Quadrangle.BoundingRectangle 
- Method Aspose.BarCode.BarCodeRecognition.Quadrangle.Contains(System.Drawing.Point) 
- Method Aspose.BarCode.BarCodeRecognition.Quadrangle.Contains(System.Int32,System.Int32) 
- Method Aspose.BarCode.BarCodeRecognition.Quadrangle.Contains(Aspose.BarCode.BarCodeRecognition.Quadrangle) 
- Method Aspose.BarCode.BarCodeRecognition.Quadrangle.Contains(System.Drawing.Rectangle) 
- Method Aspose.BarCode.BarCodeRecognition.Quadrangle.Equals(Aspose.BarCode.BarCodeRecognition.Quadrangle) 
- Method Aspose.BarCode.BarCodeRecognition.Quadrangle.Equals(System.Object) 
- Method Aspose.BarCode.BarCodeRecognition.Quadrangle.op_Equality(Aspose.BarCode.BarCodeRecognition.Quadrangle,Aspose.BarCode.BarCodeRecognition.Quadrangle) 
- Method Aspose.BarCode.BarCodeRecognition.Quadrangle.op_Inequality(Aspose.BarCode.BarCodeRecognition.Quadrangle,Aspose.BarCode.BarCodeRecognition.Quadrangle) 
- Method Aspose.BarCode.BarCodeRecognition.Quadrangle.GetHashCode 
- Method Aspose.BarCode.BarCodeRecognition.Quadrangle.ToString 
- Field Aspose.BarCode.BarCodeRecognition.Quadrangle.Empty 
- Method Aspose.BarCode.BarCodeRecognition.Code128DataPortion.Equals(System.Object)      
- Method Aspose.BarCode.BarCodeRecognition.Code128DataPortion.op_Equality(Aspose.BarCode.BarCodeRecognition.Code128DataPortion,Aspose.BarCode.BarCodeRecognition.Code128DataPortion)      
- Method Aspose.BarCode.BarCodeRecognition.Code128DataPortion.op_Inequality(Aspose.BarCode.BarCodeRecognition.Code128DataPortion,Aspose.BarCode.BarCodeRecognition.Code128DataPortion)      
- Method Aspose.BarCode.BarCodeRecognition.Code128DataPortion.GetHashCode      
- Method Aspose.BarCode.BarCodeRecognition.Code128DataPortion.ToString
