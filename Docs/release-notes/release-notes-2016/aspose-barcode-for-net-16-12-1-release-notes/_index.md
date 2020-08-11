---
title: Aspose.BarCode for .NET 16.12.1 Release Notes
type: docs
weight: 10
url: /net/aspose-barcode-for-net-16-12-1-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for Aspose.BarCode for .NET 16.12.1

{{% /alert %}} 
### **Features and Improvements**

|**Key** |**Summary** |**Category** |
| :- | :- | :- |
|BARCODENET-36423 |[Reading problem of DataMatrix barcode](http://www.aspose.com/community/forums/thread/655630.aspx)|Enhancement |
|BARCODENET-36403 |[Barcode generated with WinForms application and WPF is different](https://www.aspose.com/community/forums/thread/808431/barcode-resolution-size.aspx)|Enhancement |
|BARCODENET-36404 |[Barcode generated with WPF application is not showing code text at the center of the image](https://www.aspose.com/community/forums/thread/808431/barcode-resolution-size.aspx)|Enhancement |
# **Usage examples:**
**BARCODENET-36423 Reading problem of DataMatrix barcode**

Code sample

string code = "614;N;N;Max;Mustermann;Eidg. Personalamt;Garde-frontière;7M202721M;1;01.01.1970;21.07.2016;00.00.0000;Dienstleistungszentrum Personal EFD;Team Support SB 1;;;Eigerstrasse 71;3003;Bern;;;;;;;";

BarCodeBuilder builder = new BarCodeBuilder(code, Symbology.DataMatrix);

builder.DataMatrixEncodeMode = DataMatrixEncodeMode.ASCII;

builder.AutoSize = true;

builder.Margins.Set(0);

builder.CodeLocation = CodeLocation.None;

string strImagePath = "datamatrix65.jpg";

builder.Save(strImagePath);

BarCodeReader reader = new BarCodeReader(strImagePath);

reader.Read();

Assert.AreEqual(code, reader.GetCodeText());

Console.WriteLine(reader.GetCodeText());

Result:

614;N;N;Max;Mustermann;Eidg. Personalamt;Garde-frontière;7M202721M;1;01.01.1970;21.07.2016;00.00.0000;Dienstleistungszentrum Personal EFD;Team Support SB 1;;;Eigerstrasse 71;3003;Bern;;;;;;;

**BARCODENET-36403 Barcode generated with WinForms application and WPF is different** 
Code sample:

{{< highlight xml >}}

 using (BarCodeBuilder builder = new BarCodeBuilder())

{

      builder.GraphicsUnit = System.Drawing.GraphicsUnit.Millimeter;

      //Set the Code text for the barcode

      builder.CodeText = "6040223579";

      //default resolution

      builder.Resolution = new Aspose.BarCode.Resolution(96, 96, ResolutionMode.Graphics);

      //Set the symbology type to Code128

      builder.EncodeType = Aspose.BarCode.Generation.EncodeTypes.Code128;

      //Set the rotation angle of the barcode

      builder.RotationAngleF = 0;

      builder.BarHeight = 4;

      builder.yDimension = 4;

      builder.CodeTextAlignment = System.Drawing.StringAlignment.Center;

      builder.CodeLocation = CodeLocation.Below;

      builder.CaptionAbove = null;

      builder.SupplementSpace = 0;

      builder.CodeTextSpace = 0;

      //Save image to view result

      builder.BarCodeImage.Save(@"test_barcode_winfroms.tif", System.Drawing.Imaging.ImageFormat.tif);

}

{{< /highlight >}}

Result:

{{< highlight xml >}}

 test_barcode_winfroms.Tifff

Note: to reduce space below codetext, please add to the code

builder.Margins.Bottom = 0;

because default value is 1

{{< /highlight >}}
