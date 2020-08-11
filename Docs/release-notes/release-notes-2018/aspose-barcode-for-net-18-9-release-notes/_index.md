---
title: Aspose.BarCode for .NET 18.9 Release Notes
type: docs
weight: 80
url: /net/aspose-barcode-for-net-18-9-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes information for Aspose.BarCode for .NET 18.9.

{{% /alert %}} 
## **New Features**
- [Enhancements in BarCode Recognition using Quality Settings](/barcode/net/barcode-recognition-advanced-features/#barcoderecognitionadvancedfeatures-improvebarcoderecognitionusingqualitysettings). 
- [Implement UpcaGs1Code128Coupon with AutoSizeMode Interpolation for new BarCode Generation API](/barcode/net/generating-barcodes-using-new-barcode-generation-api/#generatingbarcodesusingnewbarcodegenerationapi-generateupcags1databarcouponbarcodewithautosizemodeinterpolation) .
- Read all BarCodes from TIFF images.
- [Improve BarCode detection by allowing image inversion](/barcode/net/barcode-recognition-advanced-features/#barcoderecognitionadvancedfeatures-improvebarcodedetectionbyallowingimageinversioninqualitysettings).
- Deprecate BarCodeBuilder.
## **All Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|BARCODENET-36713|[Enhancements in BarCode Recognition using Quality Settings](/barcode/net/barcode-recognition-advanced-features/#barcoderecognitionadvancedfeatures-improvebarcoderecognitionusingqualitysettings). |New Feature|
|BARCODENET-36940|[Implement UpcaGs1Code128Coupon with AutoSizeMode Interpolation for new BarCode Generation API](/barcode/net/generating-barcodes-using-new-barcode-generation-api/#generatingbarcodesusingnewbarcodegenerationapi-generateupcags1databarcouponbarcodewithautosizemodeinterpolation).|New Feature|
|BARCODENET-36973|Read all BarCodes from TIFF images.|New Feature|
|BARCODENET-36962|[Improve BarCode detection by allowing image inversion](/barcode/net/barcode-recognition-advanced-features/#barcoderecognitionadvancedfeatures-improvebarcodedetectionbyallowingimageinversioninqualitysettings).|New Feature|
|BARCODENET-37013|Deprecate BarCodeBuilder.|New Feature|
|BARCODENET-36795|[DPI settings work incorrectly with rotation](/barcode/net/generating-barcodes-using-new-barcode-generation-api/#generatingbarcodesusingnewbarcodegenerationapi-generatebarcodeatanangle).|Bug|
|BARCODENET-36956|Incorrect Databars are generated fromGS1string.|Bug|
|BARCODENET-37008|ITF14 barcode fails GS1 Verification Process.|Bug|
|BARCODENET-34141|Can't recognize DataMatrix codes from the JPG image. |Bug|
|BARCODENET-36957|The text part isn't correct in ENA13 when the resolution is changed.|Bug|
|BARCODENET-36786|Aspose.BarCode is detecting only 1 out of 3 barcodes from PDF.|Bug|
## **Public API and Backward Incompatible Changes**
Following members have been added:

- Property Aspose.BarCode.BarCodeRecognition.BarCodeReader.QualitySettings
- Class Aspose.BarCode.BarCodeRecognition.QualitySettings
- Property Aspose.BarCode.BarCodeRecognition.QualitySettings.HighPerformance
- Property Aspose.BarCode.BarCodeRecognition.QualitySettings.NormalQuality
- Property Aspose.BarCode.BarCodeRecognition.QualitySettings.HighQuality
- Property Aspose.BarCode.BarCodeRecognition.QualitySettings.MaxBarCodes
- Property Aspose.BarCode.BarCodeRecognition.QualitySettings.AllowInvertImage
- Property Aspose.BarCode.BarCodeRecognition.QualitySettings.AllowIncorrectBarcodes
- Property Aspose.BarCode.BarCodeRecognition.QualitySettings.AllowComplexBackground
- Property Aspose.BarCode.BarCodeRecognition.QualitySettings.AllowMedianSmoothing
- Property Aspose.BarCode.BarCodeRecognition.QualitySettings.MedianSmoothingWindowSize
- Property Aspose.BarCode.BarCodeRecognition.QualitySettings.AllowRegularImage
- Property Aspose.BarCode.BarCodeRecognition.QualitySettings.AllowDecreasedImage
- Property Aspose.BarCode.BarCodeRecognition.QualitySettings.AllowWhiteSpotsRemoving
- Property Aspose.BarCode.BarCodeRecognition.QualitySettings.AllowOneDAdditionalScan
- Property Aspose.BarCode.BarCodeRecognition.QualitySettings.AllowOneDFastBarcodesDetector
- Property Aspose.BarCode.BarCodeRecognition.QualitySettings.AllowMicroWhiteSpotsRemoving
- Property Aspose.BarCode.BarCodeRecognition.QualitySettings.AllowSaltAndPaperFiltering
- Property Aspose.BarCode.BarCodeRecognition.QualitySettings.AllowDetectScanGap
- Property Aspose.BarCode.BarCodeRecognition.QualitySettings.AllowDatamatrixIndustrialBarcodes
- Property Aspose.BarCode.BarCodeRecognition.QualitySettings.AllowQRMicroQrRestoration
- Method Aspose.BarCode.BarCodeRecognition.BarCodeReader.SetBarCodeImage(System.Drawing.Bitmap,System.Drawing.Rectangle[])
- Method Aspose.BarCode.BarCodeRecognition.BarCodeReader.SetBarCodeImage(System.Drawing.Bitmap,System.Drawing.Rectangle)
- Method Aspose.BarCode.BarCodeRecognition.BarCodeReader.SetBarCodeImage(System.IO.Stream)

Following members have been marked as obsolete:

- Property Aspose.BarCode.BarCodeRecognition.BarCodeReader.MedianSmoothingWindowSize
- Property Aspose.BarCode.BarCodeRecognition.BarCodeReader.RecognitionMode
- Property Aspose.BarCode.BarCodeRecognition.BarCodeReader.ManualHints
- Enum Aspose.BarCode.BarCodeRecognition.RecognitionMode
- Enum Aspose.BarCode.BarCodeRecognition.ManualHint

Also class BarCodeBuilder has been deprecated. Please use BarCodeGenerator instead.


