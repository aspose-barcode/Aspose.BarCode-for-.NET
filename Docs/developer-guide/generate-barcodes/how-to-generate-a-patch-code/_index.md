---
title: How to Generate a Patch Code
type: docs
weight: 90
url: /net/how-to-generate-a-patch-code/
---

{{% alert color="primary" %}} 

Patch code is a one-dimensional barcode symbology developed by Kodak.

{{% /alert %}} 
### **How to produce a Patch Code**
Instantiate a [BarcodeGenerator](https://apireference.aspose.com/barcode/net/aspose.barcode.generation/barcodegenerator) and set its EncodeType to be [EncodeTypes.](https://apireference.aspose.com/barcode/net/aspose.barcode.generation/encodetypes/fields/patchcode)[PatchCode](https://apireference.aspose.com/barcode/net/aspose.barcode.generation/encodetypes/fields/patchcode), and set its code text for the data you want to encode. Below is an example to generate a Patch code.
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarCodes-GenerateAPatchCode-GeneratePatchCode.cs" >}}



PatchCode is a specific barcode and often is used in the whole page. Following example shows, how developers can generate whole pages.
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarCodes-GenerateAPatchCode-GenerateWholePage.cs" >}}
