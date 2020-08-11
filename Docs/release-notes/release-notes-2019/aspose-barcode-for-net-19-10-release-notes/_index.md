---
title: Aspose.BarCode for .NET 19.10 Release Notes
type: docs
weight: 30
url: /net/aspose-barcode-for-net-19-10-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes information for Aspose.BarCode for .NET 19.10.

{{% /alert %}} 
## **All Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|BARCODENET-37307|Fix vulnerabilities found by a security check|New Feature|
|BARCODENET-37310|Implement [SwissQR ](/barcode/net/swiss-qr-code/)support|New Feature|
|BARCODENET-36825|Ability to recognize ID card and driving license from Colombia|Bug|
|BARCODENET-37235|Whole Barcode Length is not read|Bug|

## **Public API and Backward Incompatible Changes**
Following members have been added:

- Class Aspose.BarCode.ComplexBarcode.ComplexBarcodeGenerator
- Method Aspose.BarCode.ComplexBarcode.ComplexBarcodeGenerator.#ctor(Aspose.BarCode.ComplexBarcode.IComplexCodetext)
- Property Aspose.BarCode.ComplexBarcode.ComplexBarcodeGenerator.Parameters
- Method Aspose.BarCode.ComplexBarcode.ComplexBarcodeGenerator.GenerateBarCodeImage
- Method Aspose.BarCode.ComplexBarcode.ComplexBarcodeGenerator.Save(System.IO.Stream,Aspose.BarCode.BarCodeImageFormat)
- Method Aspose.BarCode.ComplexBarcode.ComplexBarcodeGenerator.Save(System.String,Aspose.BarCode.BarCodeImageFormat)
- Method Aspose.BarCode.ComplexBarcode.ComplexBarcodeGenerator.Save(System.String)
- Method Aspose.BarCode.ComplexBarcode.ComplexBarcodeGenerator.Dispose
- Class Aspose.BarCode.ComplexBarcode.ComplexCodetextReader
- Method Aspose.BarCode.ComplexBarcode.ComplexCodetextReader.TryDecodeSwissQR(System.String)
- Class Aspose.BarCode.ComplexBarcode.IComplexCodetext
- Method Aspose.BarCode.ComplexBarcode.IComplexCodetext.GetConstructedCodetext
- Method Aspose.BarCode.ComplexBarcode.IComplexCodetext.InitFromString(System.String)
- Method Aspose.BarCode.ComplexBarcode.IComplexCodetext.GetBarcodeType
- Class Aspose.BarCode.ComplexBarcode.SwissQRCodetext
- Method Aspose.BarCode.ComplexBarcode.SwissQRCodetext.#ctor(Aspose.BarCode.ComplexBarcode.SwissQRBill)
- Method Aspose.BarCode.ComplexBarcode.SwissQRCodetext.#ctor
- Property Aspose.BarCode.ComplexBarcode.SwissQRCodetext.Bill
- Method Aspose.BarCode.ComplexBarcode.SwissQRCodetext.GetConstructedCodetext
- Method Aspose.BarCode.ComplexBarcode.SwissQRCodetext.InitFromString(System.String)
- Method Aspose.BarCode.ComplexBarcode.SwissQRCodetext.GetBarcodeType
- Class Aspose.BarCode.ComplexBarcode.SwissQRBill
- Property Aspose.BarCode.ComplexBarcode.SwissQRBill.Version
- Property Aspose.BarCode.ComplexBarcode.SwissQRBill.Amount
- Property Aspose.BarCode.ComplexBarcode.SwissQRBill.Currency
- Property Aspose.BarCode.ComplexBarcode.SwissQRBill.Account
- Property Aspose.BarCode.ComplexBarcode.SwissQRBill.Creditor
- Property Aspose.BarCode.ComplexBarcode.SwissQRBill.Reference
- Property Aspose.BarCode.ComplexBarcode.SwissQRBill.Debtor
- Property Aspose.BarCode.ComplexBarcode.SwissQRBill.UnstructuredMessage
- Property Aspose.BarCode.ComplexBarcode.SwissQRBill.BillInformation
- Property Aspose.BarCode.ComplexBarcode.SwissQRBill.AlternativeSchemes
- Method Aspose.BarCode.ComplexBarcode.SwissQRBill.CreateAndSetCreditorReference(System.String)
- Method Aspose.BarCode.ComplexBarcode.SwissQRBill.Equals(System.Object)
- Method Aspose.BarCode.ComplexBarcode.SwissQRBill.Equals(Aspose.BarCode.ComplexBarcode.SwissQRBill)
- Method Aspose.BarCode.ComplexBarcode.SwissQRBill.GetHashCode
- Class Aspose.BarCode.ComplexBarcode.AlternativeScheme
- Method Aspose.BarCode.ComplexBarcode.AlternativeScheme.#ctor
- Property Aspose.BarCode.ComplexBarcode.AlternativeScheme.Instruction
- Method Aspose.BarCode.ComplexBarcode.AlternativeScheme.Equals(System.Object)
- Method Aspose.BarCode.ComplexBarcode.AlternativeScheme.Equals(Aspose.BarCode.ComplexBarcode.AlternativeScheme)
- Method Aspose.BarCode.ComplexBarcode.AlternativeScheme.GetHashCode
- Class Aspose.BarCode.ComplexBarcode.AddressType
- Field Aspose.BarCode.ComplexBarcode.AddressType.Undetermined
- Field Aspose.BarCode.ComplexBarcode.AddressType.Structured
- Field Aspose.BarCode.ComplexBarcode.AddressType.CombinedElements
- Field Aspose.BarCode.ComplexBarcode.AddressType.Conflicting
- Class Aspose.BarCode.ComplexBarcode.Address
- Method Aspose.BarCode.ComplexBarcode.Address.#ctor
- Property Aspose.BarCode.ComplexBarcode.Address.Type
- Property Aspose.BarCode.ComplexBarcode.Address.Name
- Property Aspose.BarCode.ComplexBarcode.Address.AddressLine1
- Property Aspose.BarCode.ComplexBarcode.Address.AddressLine2
- Property Aspose.BarCode.ComplexBarcode.Address.Street
- Property Aspose.BarCode.ComplexBarcode.Address.HouseNo
- Property Aspose.BarCode.ComplexBarcode.Address.PostalCode
- Property Aspose.BarCode.ComplexBarcode.Address.Town
- Property Aspose.BarCode.ComplexBarcode.Address.CountryCode
- Method Aspose.BarCode.ComplexBarcode.Address.Clear
- Method Aspose.BarCode.ComplexBarcode.Address.Equals(System.Object)
- Method Aspose.BarCode.ComplexBarcode.Address.Equals(Aspose.BarCode.ComplexBarcode.Address)
- Method Aspose.BarCode.ComplexBarcode.Address.GetHashCode
- Class Aspose.BarCode.ComplexBarcode.SwissQRBill.QrBillStandardVersion
- Field Aspose.BarCode.ComplexBarcode.SwissQRBill.QrBillStandardVersion.V2_0


