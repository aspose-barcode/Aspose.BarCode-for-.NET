---
title: Working with BarCode Text Appearance
type: docs
weight: 50
url: /net/working-with-barcode-text-appearance/
---

## **Control the appearance of Code text**
[Aspose.BarCode](https://apireference.aspose.com/net/barcode) provides complete control over the appearance of the Code text in the barcode image. There are many settings that can be applied to the Code text to customize its appearance using CodeTextParameters class properties. 
### **Location of Code text**
[Aspose.BarCode](https://apireference.aspose.com/net/barcode) gives full power to developers to decide whether they want to display Code text or not. Moreover, it is also possible to customize that where to display the Code text (that is display above or below the barcode) as shown below in the figure.

|**All possible locations of Code text on the barcode image**|
| :- |
|![todo:image_alt_text](working-with-barcode-text-appearance_1.jpg)|
All barcode generating classes have a CodeTextParameters.Location property that can accept any pre-defined value stored in CodeLocation enumeration.The pre-defined values in [CodeLocation ](https://apireference.aspose.com/net/barcode/aspose.barcode/codelocation)enumeration are listed below.

|**Code Locations**|**Description** |
| :- | :- |
|Above|Specifies that the Code text is shown on the top of the bar code|
|Below |Specifies that the Code text is shown on the bottom of the bar code|
|None |Specifies that the Code text is hidden|
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarcodeImages-SetCodetextLocation-SetCodetextLocation.cs" >}}


### **Alignment of Code text**
Horizontal alignment of the Code text can be configured by making use of CodeTextParameters.Alignment property of the BarcodeGenerator class. The CodeTextParameters.Alignment property accepts any enumerated value in Aspose.BarCode.Generation.TextAlignment enumeration (which is a part of the Microsoft .NET Framework). The pre-defined values in StringAlignment enumeration are listed below

|**Alignment Types**|**Description** |
| :- | :- |
|Center |Specifies that text is aligned in the center of the layout rectangle|
|Left|Specifies that text is aligned Left from the origin position of the layout rectangle.|
|Right|Specifies the text to be aligned on right of the layout.|
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarcodeImages-SetCodeAlignment-SetCodeAlignment.cs" >}}


### **Color of CodeText**
Developers who want to add colors to their barcodes may also change the color of CodeText. Setting the CodeTextParameters.Color property can change the color of the Code text as demonstrated below in a code snippet.
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarcodeImages-SetForeColorText-SetForeColorText.cs" >}}


### **Set CodeText Font Family Name and Size**
Setting the CodeTextParameters.Font property to any font family name and its size of the Code text as demonstrated below in a code snippet.
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarcodeImages-SetCodeTextFontFamilyNameAndSize-SetCodeTextFontFamilyNameAndSize.cs" >}}


### **Space between Code text & Barcode**
You saw above in the barcode image that the default gap between the barcode and Code text is very small. Developers can increase/decrease the space (gap) between the barcode and Code text by setting the CodeTextParameters.Space property. The following code snippet shows you how to space between code text and Barcode.
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarcodeImages-AddSpaceInBarCodeAndText-AddSpaceInBarCodeAndText.cs" >}}



A complete example is given below that combines all possible format settings that can be applied to the CodeText to control its appearance.
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarCodes-CodetextAppearance-CodetextAppearance.cs" >}}
