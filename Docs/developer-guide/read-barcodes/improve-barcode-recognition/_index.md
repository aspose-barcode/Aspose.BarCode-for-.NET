---
title: Improve Barcode Recognition
type: docs
weight: 20
url: /net/improve-barcode-recognition/
---

## **Optimized Scan for Barcode Recognition**
There are two approaches addressing recognition optimization, the first is towards accuracy, the second is towards speed:
### **Pinpointing barcode**
- SymbologyType setting. If the barcode type is unknown, try not to pass the symbology type (BarCodeReadType) in the constructor. Instead, try to recognize separately.
- BarCodeReader's internal optimization schema will sacrifice accuracy for speed if symbology type is not specified in the BarCodeReader’s constructor.
### **Speed up**
- Reduce image size. Larger images will lead to longer processing time.
## **Optimize Barcode Recognition Process Through Multi-Threading**
[ProcessorSettings](https://apireference.aspose.com/net/barcode/aspose.barcode.barcoderecognition/barcodereader/properties/processorsettings) class of namespace Aspose.BarCodeRecognition allows us to speed up the recognition process by defining the settings to involve multi-threading calculations and setting the number of processor cores to use. Let's experience this feature and see how it works.

Aspose.BarCodeRecognition namespace introduced a class [ProcessorSettings](https://apireference.aspose.com/net/barcode/aspose.barcode.barcoderecognition/barcodereader/properties/processorsettings) to define the settings for involving multi-threading & number of processor cores to be used. [ProcessorSettings](https://apireference.aspose.com/net/barcode/aspose.barcode.barcoderecognition/barcodereader/properties/processorsettings) can be found as a static member of class [BarCodeReader](https://apireference.aspose.com/net/barcode/aspose.barcode.barcoderecognition/barcodereader). Developers can set UseAllCores property to TRUE or FALSE to specify whether to use all cores of the processor or not. In case it is set to FALSE then set how many cores to be used by setting UseOnlyThisCoresCount propery that takes in an integer value. The following code snippet shows you how to optimize Barcode Recognition Process
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageAndOptimizeBarcodeRecognition-OptimizingBarCodeRecognitionProcess-OptimizingBarCodeRecognitionProcess.cs" >}}
## **Better and Faster Image Processing for Barcode Recognition**
Aspose.BarCode for .NET provides better and faster barcode recognition with the following quality settings:

|[AllowComplexBackground](https://apireference.aspose.com/net/barcode/aspose.barcode.barcoderecognition/qualitysettings/properties/allowcomplexbackground)|Allows the engine to recognize color barcodes on the color background as an additional scan. Extremely slow mode.|
| :- | :- |
|[AllowDatamatrixIndustrialBarcodes](https://apireference.aspose.com/net/barcode/aspose.barcode.barcoderecognition/qualitysettings/properties/allowdatamatrixindustrialbarcodes)|Allows engine for Datamatrix to recognize dashed industrial Datamatrix barcodes. The slow mode which helps only for dashed barcodes which consist of spots.|
|[AllowDecreasedImage](https://apireference.aspose.com/net/barcode/aspose.barcode.barcoderecognition/qualitysettings/properties/allowdecreasedimage)|Allows the engine to recognize the decreased image as an additional scan. Size for decreasing is selected by internal engine algorithms. Mode helps to recognize barcodes which are noised and blurred but captured with high resolution.|
|[AllowDetectScanGap](https://apireference.aspose.com/net/barcode/aspose.barcode.barcoderecognition/qualitysettings/properties/allowdetectscangap)|Allows the engine to use the gap between scans to increase recognition speed. The mode can make recognition problems with low height barcodes.|
|[AllowIncorrectBarcodes](https://apireference.aspose.com/net/barcode/aspose.barcode.barcoderecognition/qualitysettings/properties/allowincorrectbarcodes)|Allows the engine to recognize barcodes which have an incorrect checksum or incorrect values. The mode can be used to recognize damaged barcodes with incorrect text.|
|[AllowInvertImage](https://apireference.aspose.com/net/barcode/aspose.barcode.barcoderecognition/qualitysettings/properties/allowinvertimage)|Allows the engine to recognize the inverse color image as an additional scan. The mode can be used when the barcode is white on black background.|
|[AllowMedianSmoothing](https://apireference.aspose.com/net/barcode/aspose.barcode.barcoderecognition/qualitysettings/properties/allowmediansmoothing)|Allows engine to enable median smoothing as an additional scan. Mode helps to recognize noised barcodes.|
|[AllowMicroWhiteSpotsRemoving](https://apireference.aspose.com/net/barcode/aspose.barcode.barcoderecognition/qualitysettings/properties/allowmicrowhitespotsremoving)|Allows engine for Postal barcodes to recognize slightly noised images. Mode helps to recognize slightly damaged Postal barcodes.|
|[AllowOneDAdditionalScan](https://apireference.aspose.com/net/barcode/aspose.barcode.barcoderecognition/qualitysettings/properties/allowonedadditionalscan)|Allows engine for 1D barcodes to recognize regular image with different params as an additional scan. Mode helps to recognize low height 1D barcodes.|
|[AllowOneDFastBarcodesDetector](https://apireference.aspose.com/net/barcode/aspose.barcode.barcoderecognition/qualitysettings/properties/allowonedfastbarcodesdetector)|Allows engine for 1D barcodes to quickly recognize high-quality barcodes which fill almost whole image. Mode helps to quickly recognize generated barcodes from the Internet.|
|[AllowQRMicroQrRestoration](https://apireference.aspose.com/net/barcode/aspose.barcode.barcoderecognition/qualitysettings/properties/allowqrmicroqrrestoration)|Allows engine for QR/MicroQR to recognize damaged MicroQR barcodes.|
|[AllowRegularImage](https://apireference.aspose.com/net/barcode/aspose.barcode.barcoderecognition/qualitysettings/properties/allowregularimage)|Allows the engine to recognize the regular image without any restorations as the main scan. Mode to recognize the image as is.|
|[AllowSaltAndPaperFiltering](https://apireference.aspose.com/net/barcode/aspose.barcode.barcoderecognition/qualitysettings/properties/allowsaltandpaperfiltering)|Allows engine to recognize barcodes with salt and paper noise type. The mode can remove small noise with white and black dots.|
|[AllowWhiteSpotsRemoving](https://apireference.aspose.com/net/barcode/aspose.barcode.barcoderecognition/qualitysettings/properties/allowwhitespotsremoving)|Allows the engine to recognize the image without small white spots an additional scan. Mode helps to recognize the noised image as well as median smoothing filtering.|
|[MedianSmoothingWindowSize](https://apireference.aspose.com/net/barcode/aspose.barcode.barcoderecognition/qualitysettings/properties/mediansmoothingwindowsize)|Window size for median smoothing. Typical values are 3 or 4. The default value is 3. AllowMedianSmoothing must be set.|
### **Code Samples**
The following code snippet shows how to use the above mentioned quality settings.
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageAndOptimizeBarcodeRecognition-SwitchBarcodeRecognitionModes-SwitchBarcodeRecognitionModes.cs" >}}
## **Barcode Recognition Modes**
Aspose.BarCode for .NET provides some recognition modes, those help developers to quickly set up and tune the processing speed and quality in a way which is the most appropriate for their need.

- **Hight Performance** 
  [QualitySettings.HighPerformance](https://apireference.aspose.com/net/barcode/aspose.barcode.barcoderecognition/qualitysettings/properties/highperformance)
  HighPerformance recognition quality preset. High-quality barcodes are recognized well in this mode.
- **Hight Quality** 
  [QualitySettings.HighQuality](https://apireference.aspose.com/net/barcode/aspose.barcode.barcoderecognition/qualitysettings/properties/highquality)
  HighQuality recognition quality preset. This preset is developed for low-quality barcodes.
- **Max Barcodes** 
  [QualitySettings.MaxBarCodes](https://apireference.aspose.com/net/barcode/aspose.barcode.barcoderecognition/qualitysettings/properties/maxbarcodes)
  MaxBarCodes recognition quality preset. This preset is developed to recognize all possible barcodes, even incorrect barcodes.
- **Normal Quality** 
  [QualitySettings.NormalQuality](https://apireference.aspose.com/net/barcode/aspose.barcode.barcoderecognition/qualitysettings/properties/normalquality)
  Normal quality recognition quality preset. Suitable for most of the barcodes.

The following code snippet shows how to switch the barcode recognition modes:
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageAndOptimizeBarcodeRecognition-ImageProcessingBarcodeRecognition-ImageProcessingBarcodeRecognition.cs" >}}


## **Improve Barcode Recognition using Quality Settings**
### **Quality Settings Presets**
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageAndOptimizeBarcodeRecognition-BarCodeRecognitionFilters-QualitySettingWithManualOptionsHighPerformance.cs" >}}
### **Quality Settings with Manual Options**
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageAndOptimizeBarcodeRecognition-BarCodeRecognitionFilters-QualitySetting.cs" >}}
### **Quality Settings with Manual Options for Normal Quality**
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageAndOptimizeBarcodeRecognition-BarCodeRecognitionFilters-QualitySettingWithManualOptionsNormalQuality.cs" >}}
### **Improve Barcode detection by allowing image inversion in Quality Settings**
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageAndOptimizeBarcodeRecognition-BarCodeRecognitionFilters-ImproveDetectionByInverting.cs" >}}
### **Recognizing Single Wiped Bars in Pattern**
Aspose.BarCode provides public property AllowOneDWipedBarsRestoration to the QualitySettings which allows to recognize barcodes with single wiped/glued bars in pattern. This property is enabled by default in HighQuality, MaxBarCodes modes. Currently this property can be used for Code128, GS1Code128, SCC14, EAN14, SSCC18, AustralianPosteParcel and SwissPostParcel barcode types.

{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageAndOptimizeBarcodeRecognition-SingleWipedBarsInPattern-SingleWipedBarsInPattern.cs" >}}
## **Reading Barcode from Specific Region of Image**
In this section, we will scan only a part of the image that contains a barcode. Suppose that we have an image of large size e.g. 800 x 600 pixels and our barcode is placed on the top left corner of the image e.g. 100 x 50 pixels, we can optimize the barcode scanning by specifying the area, instead of scanning the whole image. But, in this case, we need to know in advance about the location of the barcode. The barcode reader will not scan other parts of the image if we specify the area. The following image is of 333 x 127 pixels and the size of the barcode is only 94 x 18 pixels and it is located on the top right corner of the image. The rest of the image contains some text in this example. But in your case, it might contain any other text and image.

|**Reading Barcode from Specific Region of Image**|
| :- |
|![todo:image_alt_text](improve-barcode-recognition_1.png)|
If we specify an area of (0, 0, 100, 50), the barcode reader will scan only this area and will be able to recognize the barcode. It will greatly increase the speed of recognition because the barcode reader will not look in other parts of the image.
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageAndOptimizeBarcodeRecognition-ReadBarcodeSpecificRegionOfImage-ReadBarcodeSpecificRegionOfImage.cs" >}}
### **Define Specific Region**
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageAndOptimizeBarcodeRecognition-BarcodeReaderSetBarcodeImage-ReadBarCodeFromSpecificRegion.cs" >}}
## **Read Barcodes from Multiple Regions**
In this section, we will scan multiple parts of the image to read barcodes from those specific regions. Suppose that we have an image of large size e.g. 800 x 600 pixels and our barcodes are placed on the top left and bottom right corners of the image, we can optimize the barcode scanning by specifying the areas, instead of scanning the whole image. But, in this case, we need to know in advance about the locations of the barcodes. The barcode reader will not scan other parts of the image if we specify the areas.
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageAndOptimizeBarcodeRecognition-ReadMultipleBarcodeRegions-ReadMultipleBarcodeRegions.cs" >}}
### **Define Multiple Regions**
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageAndOptimizeBarcodeRecognition-BarcodeReaderSetBarcodeImage-ReadBarCodeFromMultipleRegions.cs" >}}
