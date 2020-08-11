---
title: Aspose.BarCode for .NET 19.2 Release Notes
type: docs
weight: 130
url: /net/aspose-barcode-for-net-19-2-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes information for Aspose.BarCode for .NET 19.2.

{{% /alert %}} 
## **All Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|BARCODENET-37039|Add termination by Timeout support for internal imaging and recognition filters|Enhancement|
|BARCODENET-37002|BarCodeReader exceded defined Timeout|Bug|
|BARCODENET-36680|BarCodeReader Timeout property is not working as expected|Bug|
## **Usage Examples**
**BARCODENET-37039 - Add termination by Timeout support for internal imaging and recognition filters**

BarCodeReader reader = new BarCodeReader(filename);
while(reader.Read());
//other thread call code
reader.Abort();
## **Public API and Backward Incompatible Changes**
Following members have been added:

- Method Aspose.BarCode.BarCodeRecognition.BarCodeReader.Abort()
