---
title: Generating Barcodes using New Barcode Generation API
type: docs
weight: 80
url: /net/generating-barcodes-using-new-barcode-generation-api/
---

## **Generating Barcode using BarcodeGenerator API**
Aspose.Barcode API lets you generate barcodes keeping in view real use cases like document printing and UI design. The Aspose.BarCode.Generation.BarCodeGenerator class is simple, yet powerful enough to work with Barcode generations. With this enhanced API as compared to the previous version of API i.e. BarcodeBuilder, you can generate and work with barcodes in more flexible ways. This article illustrates the usage of the API for working with Barcodes.
### **Generating Barcode with Restricted Barcode Size**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-CreateAndManageTwoDBarcodes-GenerateCustomBarcodes-GenerateBarcodeWithRestrictedBarcodeSize.cs" >}}
### **Generating Barcode without Restricted Barcode Size**


{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-CreateAndManageTwoDBarcodes-GenerateCustomBarcodes-GenerateBarcodeWithoutRestrictedBarcodeSize.cs" >}}
### **Get Generated Barcode Size**
if you just want to know the barcode size without saving the image you can call method RecalculateValues() and get barcode size.

{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-CreateAndManageTwoDBarcodes-GenerateCustomBarcodes-GetGeneratedBarcodeSize.cs" >}}
### **Units based Barcode Generation**
All measurement values can be get and set in pixels, millimeters, inches at the same time. You can easily change the resolution of the image and prepare the same barcode for printing, LCD screens or retina-displays.

{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-CreateAndManageTwoDBarcodes-GenerateCustomBarcodes-UnitBasedBarcodeGenerateion.cs" >}}
### **Grouping Properties by Barcode Type**
Properties for specific barcode types are grouped. Such specific properties like QR_EncodeType of DataMatrix_Ecc are grouped by type to simplify all the API for new users.

{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-CreateAndManageTwoDBarcodes-GenerateCustomBarcodes-GroupingPropertiesByBarcodeType.cs" >}}
### **Getting Default Text for Generated Barcode**
BarCodeGenearator class has predefined default CodeText, so you can just explore the default code text format for the specific type.

{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-CreateAndManageTwoDBarcodes-GenerateCustomBarcodes-GettingDefaultCodeTextForGeneratedBarcode.cs" >}}
### **Generate GS1DataMatrix Barcode with wrapping text**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-CreateAndManageTwoDBarcodes-GenerateCustomBarcodes-GS1DatamatrixBarcodeWithWrappingText.cs" >}}
### **Generate Code16K Barcode**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-CreateAndManageTwoDBarcodes-GenerateCustomBarcodes-GenerateCode16KBarCode.cs" >}}
### **Generate DotCode Barcode**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-CreateAndManageTwoDBarcodes-GenerateCustomBarcodes-ImplementDotCodeForBarcode.cs" >}}
### **Generate Barcode with Auto Size Interpolation**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-CreateAndManageTwoDBarcodes-GenerateCustomBarcodes-ImplementInterpolationAutoSizemode.cs" >}}
### **Generate MaxiCode Barcode**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-CreateAndManageTwoDBarcodes-GenerateCustomBarcodes-ImplementMaxiCodeForBarcode.cs" >}}
### **Generate UpcaGs1DatabarCoupon Barcode**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-CreateAndManageTwoDBarcodes-GenerateCustomBarcodes-ImplementUpcaGs1DatabarCouponForNewBarcode.cs" >}}
### **Generate UpcaGs1DatabarCoupon Barcode with AutoSizeMode Interpolation**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-CreateAndManageTwoDBarcodes-GenerateCustomBarcodes-ImplementUpcaGs1DatabarCouponWithAutoSizeModeInterpolation.cs" >}}
### **Generate Barcode at an angle**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-CreateAndManageTwoDBarcodes-GenerateCustomBarcodes-GenarateBarcodeWithRotationAndDpi.cs" >}}
