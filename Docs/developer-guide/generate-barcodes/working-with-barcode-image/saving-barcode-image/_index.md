---
title: Saving Barcode Image
type: docs
weight: 20
url: /net/saving-barcode-image/
---

## **Save Barcode Images to Different Formats**
[Aspose.BarCode](http://www.aspose.com/api/net/barcode/aspose.barcode/) facilitates its developers to save the barcode images to most of the popular image formats. All barcode generating classes ([BarcodeGenerator](https://apireference.aspose.com/net/barcode/aspose.barcode.generation/barcodegenerator), [BarCodeControl](https://apireference.aspose.com/net/barcode/aspose.barcode.windows.forms/barcodecontrol) or [BarCodeWebControl](https://apireference.aspose.com/net/barcode/aspose.barcode.web.ui/barcodewebcontrol)) provided by Aspose.BarCode, have a public method, [Save](https://apireference.aspose.com/net/barcode/aspose.barcode.windows.forms.barcodecontrol/save/methods/1). The BarcodeGenerator.Save method takes an instance of [BarCodeImageFormat ](https://apireference.aspose.com/net/barcode/aspose.barcode/barcodeimageformat)class. Following image formats can be passed to Save method of the barcode class as an argument:

- BarCodeImageFormat.Bmp - Specifies the bitmap (BMP) image format.
- BarCodeImageFormat.Gif - Specifies the Graphics Interchange Format (GIF) image format.
- BarCodeImageFormat.Jpeg - Specifies the Joint Photographic Experts Group (JPEG) image format.
- BarCodeImageFormat.Png - Specifies the W3C Portable Network Graphics (PNG) image format.
- BarCodeImageFormat.Tiff - Specifies the Tagged Image File Format (TIFF) image format.
- BarCodeImageFormat.TiffInCmyk - Specifies the Tagged Image File Format (TIFF) image format in CMYK color model.
- BarCodeImageFormat.Emf - Specifies the Enhanced Metafile (EMF) image format.
- BarCodeImageFormat.Svg - Specifies the Scalable Vector Graphics (SVG) image format.

Developers can use any of the image formats from the above list to create a barcode image in the desired image format. An example is given below about its usage. Aspose.BarCode for Java only supports Jpg, Gif, Png, and Bmp.
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarcodeImages-SetSizeUnitForBarcodeImage-SetSizeUnitForBarcodeImage.cs" >}}
## **Save Barcode Image to Streams**
In our previous topics, we have studied that a barcode image can be saved to different image formats like Jpeg, Tiff, and Bitmap etc. But sometimes, developers may need to save the barcode image in the form of a Stream (as a binary format). To fulfill this need, [Aspose.BarCode](http://www.aspose.com/api/net/barcode/aspose.barcode/) offers its users to save a barcode image to a Stream by calling the [Save](https://apireference.aspose.com/net/barcode/aspose.barcode.windows.forms/barcodecontrol/methods/save) method which takes the Stream parameter along with BarCodeImageFormat as shown below:
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarcodeImages-SaveBarcodeImageToStreams-SaveBarcodeImageToStreams.cs" >}}
## **Specify Border Types for ITF14 Barcode**
[BarCodeGenerator](https://apireference.aspose.com/net/barcode/aspose.barcode.generation/barcodegenerator) class allows us to specify the Border type of the barcode ITF14 Symbology using [BarcodeGenerator.ITF](https://apireference.aspose.com/net/barcode/aspose.barcode.generation/barcodegenerator/properties/itf) property. Let's experience this feature and know how it works.
### **Specifying Border Type for ITF14 Barcode**
Developers can customize the border type of the ITF14 barcode image using [BorderType](https://apireference.aspose.com/net/barcode/aspose.barcode.generation/itfproperties/properties/bordertype) property of the [BarCodeGenerator.ITF](https://apireference.aspose.com/net/barcode/aspose.barcode.generation/barcodegenerator/properties/itf) class. Aspose.BarCode offers some built-in ITF14 barcode border types that are contained in an enumeration named as [ITF14BorderType](https://apireference.aspose.com/net/barcode/aspose.barcode/itf14bordertype). Developers can select the desired border type from this enumeration and assign it to the [ITF14BorderType](https://apireference.aspose.com/net/barcode/aspose.barcode/itf14bordertype) property of the [BarCodeGenerator.ITF](https://apireference.aspose.com/net/barcode/aspose.barcode.generation/barcodegenerator/properties/itf) class. The pre-defined border types in [ITF14BorderType](https://apireference.aspose.com/net/barcode/aspose.barcode/itf14bordertype) enumeration are as follows:

|**ITF14 Border Type**|**Value**|**Description**|
| :- | :- | :- |
|Bar|2|Two horizontal bars enclosing the barcode|
|BarOut|4|Two horizontal bars enclosing the barcode. It drew outside of the barcode and does not affect the height|
|Frame|1|Frame enclosing the barcode|
|FrameOut|3|Frame enclosing the barcode. It drew outside of the barcode and does not affect the height|
|None|0|No border enclosing the barcode|
### **Border Type: BarOut**
Two horizontal bars enclosing the barcode, It drew outside of the barcode and does not affect the height.
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarcodeImages-SetITF14SpecifyBorderType-SetITF14SpecifyBorderType.cs" >}}
### **Border Type : FrameOut**
Frame enclosing the barcode, It has drawn outside of the barcode and does not affect the height.


#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarcodeImages-SetFrameOut-SetFrameOut.cs" >}}
## **Specify Border Thickness for ITF14 Barcode**
[BarcodeGenerator](https://apireference.aspose.com/net/barcode/aspose.barcode.generation/barcodegenerator) class allows you to specify the Border Thickness of the barcode ITF14 Symbology. Let's experience this feature and know how it works. Developers can customize the border thickness of the ITF14 barcode image using [the BorderThickness](https://apireference.aspose.com/net/barcode/aspose.barcode.generation/itfproperties/properties/borderthickness) property of the [BarcodeGenerator.ITF](https://apireference.aspose.com/net/barcode/aspose.barcode.generation/barcodegenerator/properties/itf) class.
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarcodeImages-SpecifyITF14BorderThickness-SpecifyITF14BorderThickness.cs" >}}
