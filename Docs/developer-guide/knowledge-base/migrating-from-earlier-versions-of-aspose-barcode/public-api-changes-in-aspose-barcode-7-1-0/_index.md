---
title: Public API Changes in Aspose.BarCode 7.1.0
type: docs
weight: 60
url: /net/public-api-changes-in-aspose-barcode-7-1-0/
---

{{% alert color="primary" %}} 

This document describes changes to the Aspose.BarCode API from version 7.0.0 to 7.1.0, that may be of interest to module/application developers. It includes not only new and updated public methods, but also a description of any changes in the behavior behind the scenes in Aspose.BarCode. 

{{% /alert %}} 
### **Property BarCodeBuilder.DatamatrixECC is added**
Added a DatamatrixECC property in [BarCodeBuilder](/pages/createpage.action?spaceKey=barcodenet&title=Aspose.BarCode.BarCodeBuilder+Class&linkCreation=true&fromPageId=12943443) Class. This new property is added to specify the type of the ECC to encode.
### **Method BarCodeReader.GetIsDeniable is added**
Added a GetIsDeniable method in [BarCodeReader](/pages/createpage.action?spaceKey=barcodenet&title=Aspose.BarCodeRecognition.BarCodeReader+Class&linkCreation=true&fromPageId=12943443) Class. It indicate whether the image contains an unreadable barcode.
### **The Enum DataMatrixEccType is added**
Description of the new Enum to specify the type of the ECC to encode:

1. **EccAuto** - Specifies that encoded Ecc type is defined by default Reed-Solomon error correction or ECC 200.
1. **Ecc000** - Specifies that encoded Ecc type is defined ECC 000.
1. **Ecc050** - Specifies that encoded Ecc type is defined ECC 050.
1. **Ecc080** - Specifies that encoded Ecc type is defined ECC 080.
1. **Ecc100** - Specifies that encoded Ecc type is defined ECC 100.
1. **Ecc140** - Specifies that encoded Ecc type is defined ECC 140.
1. **Ecc200** - Specifies that encoded Ecc type is defined ECC 200.
   (This is recommended to use)
