---
title: Read Barcode Properties
type: docs
weight: 30
url: /net/read-barcode-properties/
---

## **Getting Barcode Region Information from Image**
In this section, we will read the image and get all the barcode regions, for all the recognized barcodes in the image. The barcode region is the part of the image that only contains the barcode itself. In a large image, it is possible that there are other texts or images along with the barcode. Getting the barcode region will separate the barcodes from other text/objects in the image by detecting their edges. First, we will read the BarCodes in the image using the [BarCodeReader.ReadBarCodes()](https://apireference.aspose.com/net/barcode/aspose.barcode.barcoderecognition/barcodereader/methods/readbarcodes) method. Then, we will get the region of the barcode using [BarCodeRegionParameters](https://apireference.aspose.com/net/barcode/aspose.barcode.barcoderecognition/barcoderegionparameters) class instance, which will return the recognized barcode's region and barcode angle. We can then get the X and Y coordinates of the barcode using [BarCodeRegionParameters](https://apireference.aspose.com/net/barcode/aspose.barcode.barcoderecognition/barcoderegionparameters).Points property.
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageAndOptimizeBarcodeRecognition-GetBarCodeRegionInformationfromImage-GetBarCodeRegionInformationfromImage.cs" >}}
## **Getting Barcode Recognition Quality in Percentage**
The [BarCodeReader.GetRecognitionQuality](https://apireference.aspose.com/net/barcode/aspose.barcode.barcoderecognition/barcodereader/methods/getrecognitionquality) method gets the recognition quality in percentage. It works for only 1D and postal barcodes. The following code snippet shows you how to get barcode recognition quality in percentage.
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageAndOptimizeBarcodeRecognition-GetBarCodeRecognitionQualityInPercent-GetBarCodeRecognitionQualityInPercent.cs" >}}
## **Detect an Unreadable Barcode on the Image**
[Aspose.BarCode for .NET APIs](https://www.aspose.com/products/barcode/net) allows developers to detect an unreadable barcode on the image.  It is currently supported by QR and Code128 recognition engines and enabled by the modes: [RecognitionMode.MaxBarCodes](https://apireference.aspose.com/net/barcode/aspose.barcode.barcoderecognition/recognitionmode). All recognition modes are defined in this help topic: [Switch Barcode Recognition Modes According to the Requirement](/barcode/net/read-barcode-properties-html/). The new [GetIsDeniable method](https://apireference.aspose.com/net/barcode/aspose.barcode.barcoderecognition/barcodereader/methods/getisdeniable) has been added to the [Aspose.BarCode](https://apireference.aspose.com/net/barcode) class in order to indicate whether the image contains any unreadable barcodes. The following code snippet shows you how to get barcode recognition quality in percentage.
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageAndOptimizeBarcodeRecognition-DetectUnreadableBarcode-DetectUnreadableBarcode.cs" >}}

**Scan result:** Code128: A;000000014941, IsDeniable: True
## **Detect Orientation of a Barcode**
[Aspose.BarCode](https://apireference.aspose.com/net/barcode) allows developers to detect the orientation of a detected bar code by calling GetAngle method of BarCodeReader class. The following code snippet shows you how to detect the orientation of a barcode.
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageAndOptimizeBarcodeRecognition-DetectOrientationOfBarCode-DetectOrientationOfBarCode.cs" >}}
