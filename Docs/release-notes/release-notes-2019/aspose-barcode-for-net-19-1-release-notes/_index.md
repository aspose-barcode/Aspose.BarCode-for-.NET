---
title: Aspose.BarCode for .NET 19.1 Release Notes
type: docs
weight: 150
url: /net/aspose-barcode-for-net-19-1-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes information for Aspose.BarCode for .NET 19.1.

{{% /alert %}} 
## **All Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|BARCODENET-37045|Pdf417 throws Out Of Memory Exception when the CodeText has a closing parenthesis ")"|Bug|
## **Usage Examples**
**BARCODENET-37045 - Pdf417 throws Out Of Memory Exception when CodeText has a closing parenthesis ")**

System.Drawing.Font f = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);

Aspose.BarCode.Generation.BarCodeGenerator b = new Aspose.BarCode.Generation.BarCodeGenerator(Aspose.BarCode.Generation.EncodeTypes.Pdf417);
b.Pdf417.CompactionMode = Aspose.BarCode.Pdf417CompactionMode.Text;
b.Pdf417.ErrorLevel = Aspose.BarCode.Pdf417ErrorLevel.Level2;
b.D2.Columns = 4;
b.D2.Rows = 12;
b.XDimension.Pixels = 3;
b.D2.AspectRatio = 1.33F;
b.CodeTextStyle.Font.FamilyName = f.FontFamily.Name;
b.CodeTextStyle.Alignment = System.Drawing.StringAlignment.Center;
b.CodeTextStyle.Space.Pixels = 5F;
b.CodeTextStyle.Font.Size.Pixels = 12F;
b.CodeTextStyle.Font.Style = System.Drawing.FontStyle.Regular;
b.CodeText = "Sample.Code.Text(Example).20181203_150435";

MemoryStream barcodeStream = new MemoryStream();
b.Save(barcodeStream, Aspose.BarCode.BarCodeImageFormat.Svg);

Result:
Correct SVG image.
## **Public API and Backward Incompatible Changes**
No Changes
