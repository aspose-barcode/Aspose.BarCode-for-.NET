---
title: Public API Changes in Aspose.BarCode 6.1.0
type: docs
weight: 10
url: /net/public-api-changes-in-aspose-barcode-6-1-0/
---

{{% alert color="primary" %}} 

This document describes changes to the Aspose.BarCode API from version 6.0.0 to 6.1.0, that may be of interest to module/application developers. It includes not only new and updated public methods, but also a description of any changes in the behavior behind the scenes in Aspose.BarCode. 

{{% /alert %}} 
### **Merging the recognition and generation modules**
We have merged the recognition and generation modules so that now there is a single library for both APIs. This means that developers don’t have to apply a license for each module. As a result, we have removed the **Aspose.BarCodeRecognition.License class** because there’s no need for it. Simply apply a license once using the **Aspose.BarCode.License class**. Same is case with **BuildVersionInfo class**.
### **The barcode recognition in WPF projects**
The barcode recognition has been added for WPF application projects. Developers can now read barcodes in WPF projects. You can see an example topic about this feature: [Recognizing Barcode in WPF Project](/pages/createpage.action?spaceKey=barcodenet&title=Recognizing+Barcode+in+WPF+Project&linkCreation=true&fromPageId=12943431)
### **Separate binary for .NET Compact Framework 3.5**
We have also shipped a separate Aspose.BarCode library for .NET Compact Framework 3.5.
