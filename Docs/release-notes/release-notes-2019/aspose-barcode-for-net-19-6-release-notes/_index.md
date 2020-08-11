---
title: Aspose.BarCode for .NET 19.6 Release Notes
type: docs
weight: 80
url: /net/aspose-barcode-for-net-19-6-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes information for [Aspose.BarCode for .NET 19.6](https://downloads.aspose.com/barcode/net/new-releases/aspose.barcode-for-.net-19.6/).

{{% /alert %}} 
## **All Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|BARCODENET-37226|Add reverse target scanning for Code39 processor|New Feature|
|BARCODENET-37206|Release new BarcodeGenerator, new WinForms and WPF components, remove old BarCodeGenerator and BarCodeBuilder|New Feature|
|BARCODENET-37214|Alternate sample code for an older version 15.x|New Feature|
|BARCODENET-36958|Right margin calculated incorrectly for UPCA|Bug|
|BARCODENET-37217|Problem with recognition Code128 barcodes in a newer version of Aspose.BarCode for .NET|Bug|
|BARCODENET-37222|Unable to read code39standard barcode from a PNG image|Bug|
|BARCODENET-37225|Unable to read barcode when PDF/image has a seal in it|Bug|
|BARCODENET-37223|Aspose.BarCode could not recognize the barcode correctly in the attached scan|Bug|
|BARCODENET-37221|Barcode recognition hangs on Reads|Bug|
|BARCODENET-37213|BarCodeReader never exits when scanning the following Aztec code|Bug|
|BARCODENET-37218|Barcode error with code text containing "è"|Bug|
## **Public API and Backward Incompatible Changes**
Please note that .NET Standard 1.3 will be discontinued in Aspose.BarCode for .NET 19.7.



Following members have been added in recognition quality setting:

- added Property Aspose.BarCode.BarCodeRecognition.QualitySettings.AllowOneDWipedBarsRestoration
 

New BarcodeGenerator has been moved to Aspose.BarCode.Generation namespace:

- namespace **Aspose.BarCode.Generation.V3** has been removed, **new BarcodeGenerator** is placed in **Aspose.BarCode.Generation** namespce now
- removed Class Aspose.BarCode.Generation.BarcodePadding
- removed Property Aspose.BarCode.Generation.BarcodePadding.Top
- removed Property Aspose.BarCode.Generation.BarcodePadding.Bottom
- removed Property Aspose.BarCode.Generation.BarcodePadding.Right
- removed Property Aspose.BarCode.Generation.BarcodePadding.Left
- removed Class Aspose.BarCode.Generation.CaptionPadding
- removed Property Aspose.BarCode.Generation.CaptionPadding.Top
- removed Property Aspose.BarCode.Generation.CaptionPadding.Bottom
- removed Property Aspose.BarCode.Generation.CaptionPadding.Right
- removed Property Aspose.BarCode.Generation.CaptionPadding.Left
- added Class Aspose.BarCode.Generation.Padding
- added Property Aspose.BarCode.Generation.Padding.Top
- added Property Aspose.BarCode.Generation.Padding.Bottom
- added Property Aspose.BarCode.Generation.Padding.Right
- added Property Aspose.BarCode.Generation.Padding.Left
- removed Class Aspose.BarCode.Generation.StringAlignment
- removed Field Aspose.BarCode.Generation.StringAlignment.Left
- removed Field Aspose.BarCode.Generation.StringAlignment.Center
- removed Field Aspose.BarCode.Generation.StringAlignment.Right

Following changes have been made in BarCodeGeneratorControl API:

- removed Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.ForeBarsColor
- removed Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.BackgroundColor
- removed Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.FilledBars
- removed Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.BarHeight
- removed Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.Margins
- removed Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.D2
- removed Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.ITF
- removed Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.QR
- removed Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.DataMatrix
- removed Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.Aztec
- removed Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.Pdf417
- removed Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.Codabar
- removed Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.Supplement
- removed Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.Checksum
- removed Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.AutoSizeMode
- removed Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.CodeTextStyle
- removed Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.ThrowExceptionWhenCodeTextIncorrect
- removed Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.AustralianPostEncodingTable
- removed Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.EnableEscape
- removed Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.PostalShortBarHeight
- removed Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.DotCodeMask
- removed Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.MaxiCodeEncodeMode
- removed Class Aspose.BarCode.Windows.Forms.BorderPropertiesUI
- removed Property Aspose.BarCode.Windows.Forms.BorderPropertiesUI.Visible
- removed Property Aspose.BarCode.Windows.Forms.BorderPropertiesUI.Width
- removed Property Aspose.BarCode.Windows.Forms.BorderPropertiesUI.DashStyle
- removed Property Aspose.BarCode.Windows.Forms.BorderPropertiesUI.Color
- removed Method Aspose.BarCode.Windows.Forms.BorderPropertiesUI.ToString
- removed Property Aspose.BarCode.Windows.Forms.CaptionUI.Space
- removed Class Aspose.BarCode.Windows.Forms.CodeTextStyleUI
- removed Property Aspose.BarCode.Windows.Forms.CodeTextStyleUI.Location
- removed Property Aspose.BarCode.Windows.Forms.CodeTextStyleUI.Alignment
- removed Property Aspose.BarCode.Windows.Forms.CodeTextStyleUI.Color
- removed Property Aspose.BarCode.Windows.Forms.CodeTextStyleUI.Space
- removed Property Aspose.BarCode.Windows.Forms.CodeTextStyleUI.Font
- removed Class Aspose.BarCode.Windows.Forms.ITFPropertiesUI
- removed Property Aspose.BarCode.Windows.Forms.ITFPropertiesUI.BorderThickness
- removed Property Aspose.BarCode.Windows.Forms.ITFPropertiesUI.BorderType
- removed Method Aspose.BarCode.Windows.Forms.ITFPropertiesUI.ToString
- removed Class Aspose.BarCode.Windows.Forms.MarginsUI
- removed Property Aspose.BarCode.Windows.Forms.MarginsUI.Bottom
- removed Property Aspose.BarCode.Windows.Forms.MarginsUI.Top
- removed Property Aspose.BarCode.Windows.Forms.MarginsUI.Right
- removed Property Aspose.BarCode.Windows.Forms.MarginsUI.Left
- removed Method Aspose.BarCode.Windows.Forms.MarginsUI.ToString
- removed Class Aspose.BarCode.Windows.Forms.SupplementPropertiesUI
- removed Property Aspose.BarCode.Windows.Forms.SupplementPropertiesUI.Data
- removed Property Aspose.BarCode.Windows.Forms.SupplementPropertiesUI.Space
- removed Method Aspose.BarCode.Windows.Forms.SupplementPropertiesUI.ToString
- added Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.AutoSizeMode
- added Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.BarHeight
- added Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.BarCodeHeight
- added Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.BarCodeWidth
- added Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.ForeColor
- added Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.BarcodePaddings
- added Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.ChecksumAlwaysShow
- added Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.IsChecksumEnabled
- added Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.EnableEscape
- added Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.ThrowExceptionWhenCodeTextIncorrect
- added Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.CodeTextParameters
- added Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.FilledBars
- added Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.Specific
- added Property Aspose.BarCode.Windows.Forms.BarCodeGeneratorControl.BackColor
- added Property Aspose.BarCode.Windows.Forms.CaptionUI.Padding
- added Class Aspose.BarCode.Windows.Forms.AztecParametersUI
- added Property Aspose.BarCode.Windows.Forms.AztecParametersUI.AztecErrorLevel
- added Property Aspose.BarCode.Windows.Forms.AztecParametersUI.AztecSymbolMode
- added Property Aspose.BarCode.Windows.Forms.AztecParametersUI.AspectRatio
- added Property Aspose.BarCode.Windows.Forms.AztecParametersUI.CodeTextEncoding
- added Method Aspose.BarCode.Windows.Forms.AztecParametersUI.ToString
- added Class Aspose.BarCode.Windows.Forms.DataMatrixParametersUI
- added Property Aspose.BarCode.Windows.Forms.DataMatrixParametersUI.DataMatrixEcc
- added Property Aspose.BarCode.Windows.Forms.DataMatrixParametersUI.DataMatrixEncodeMode
- added Property Aspose.BarCode.Windows.Forms.DataMatrixParametersUI.Columns
- added Property Aspose.BarCode.Windows.Forms.DataMatrixParametersUI.Rows
- added Property Aspose.BarCode.Windows.Forms.DataMatrixParametersUI.AspectRatio
- added Property Aspose.BarCode.Windows.Forms.DataMatrixParametersUI.CodeTextEncoding
- added Method Aspose.BarCode.Windows.Forms.DataMatrixParametersUI.ToString
- added Class Aspose.BarCode.Windows.Forms.Pdf417ParametersUI
- added Property Aspose.BarCode.Windows.Forms.Pdf417ParametersUI.Pdf417CompactionMode
- added Property Aspose.BarCode.Windows.Forms.Pdf417ParametersUI.Pdf417ErrorLevel
- added Property Aspose.BarCode.Windows.Forms.Pdf417ParametersUI.Pdf417Truncate
- added Property Aspose.BarCode.Windows.Forms.Pdf417ParametersUI.Pdf417MacroFileID
- added Property Aspose.BarCode.Windows.Forms.Pdf417ParametersUI.Pdf417MacroSegmentID
- added Property Aspose.BarCode.Windows.Forms.Pdf417ParametersUI.Pdf417MacroSegmentsCount
- added Property Aspose.BarCode.Windows.Forms.Pdf417ParametersUI.Columns
- added Property Aspose.BarCode.Windows.Forms.Pdf417ParametersUI.Rows
- added Property Aspose.BarCode.Windows.Forms.Pdf417ParametersUI.AspectRatio
- added Property Aspose.BarCode.Windows.Forms.Pdf417ParametersUI.CodeTextEncoding
- added Method Aspose.BarCode.Windows.Forms.Pdf417ParametersUI.ToString
- added Class Aspose.BarCode.Windows.Forms.QrParametersUI
- added Property Aspose.BarCode.Windows.Forms.QrParametersUI.QrEncodeMode
- added Property Aspose.BarCode.Windows.Forms.QrParametersUI.QrEncodeType
- added Property Aspose.BarCode.Windows.Forms.QrParametersUI.QrErrorLevel
- added Property Aspose.BarCode.Windows.Forms.QrParametersUI.QrVersion
- added Property Aspose.BarCode.Windows.Forms.QrParametersUI.AspectRatio
- added Property Aspose.BarCode.Windows.Forms.QrParametersUI.CodeTextEncoding
- added Method Aspose.BarCode.Windows.Forms.QrParametersUI.ToString
- added Class Aspose.BarCode.Windows.Forms.SpecificParametersUI
- added Property Aspose.BarCode.Windows.Forms.SpecificParametersUI.Postal
- added Property Aspose.BarCode.Windows.Forms.SpecificParametersUI.AustralianPost
- added Property Aspose.BarCode.Windows.Forms.SpecificParametersUI.DataBar
- added Property Aspose.BarCode.Windows.Forms.SpecificParametersUI.Codablock
- added Property Aspose.BarCode.Windows.Forms.SpecificParametersUI.DataMatrix
- added Property Aspose.BarCode.Windows.Forms.SpecificParametersUI.Code16K
- added Property Aspose.BarCode.Windows.Forms.SpecificParametersUI.DotCode
- added Property Aspose.BarCode.Windows.Forms.SpecificParametersUI.ITF
- added Property Aspose.BarCode.Windows.Forms.SpecificParametersUI.Pdf417
- added Property Aspose.BarCode.Windows.Forms.SpecificParametersUI.QR
- added Property Aspose.BarCode.Windows.Forms.SpecificParametersUI.MaxiCode
- added Property Aspose.BarCode.Windows.Forms.SpecificParametersUI.Aztec
- added Property Aspose.BarCode.Windows.Forms.SpecificParametersUI.Codabar
- added Property Aspose.BarCode.Windows.Forms.SpecificParametersUI.Coupon
- added Property Aspose.BarCode.Windows.Forms.SpecificParametersUI.Supplement
- added Method Aspose.BarCode.Windows.Forms.SpecificParametersUI.ToString
 

Following WPF Component members have been added:

- added Class Aspose.BarCode.WPF.AutoSizeModeWpf
- added Field Aspose.BarCode.WPF.AutoSizeModeWpf.Nearest
- added Field Aspose.BarCode.WPF.AutoSizeModeWpf.Interpolation
- added Class Aspose.BarCode.WPF.BarcodeGeneratorElement
- added Method Aspose.BarCode.WPF.BarcodeGeneratorElement.#ctor
- added Method Aspose.BarCode.WPF.BarcodeGeneratorElement.MeasureOverride(System.Windows.Size)
- added Method Aspose.BarCode.WPF.BarcodeGeneratorElement.OnRenderSizeChanged(System.Windows.SizeChangedInfo)
- added Method Aspose.BarCode.WPF.BarcodeGeneratorElement.OnRender(System.Windows.Media.DrawingContext)
- added Method Aspose.BarCode.WPF.BarcodeGeneratorElement.Dispose
- added Method Aspose.BarCode.WPF.BarcodeGeneratorElement.Save(System.String)
- added Method Aspose.BarCode.WPF.BarcodeGeneratorElement.Save(System.IO.Stream,Aspose.BarCode.BarCodeImageFormat)
- added Method Aspose.BarCode.WPF.BarcodeGeneratorElement.Save(System.String,Aspose.BarCode.BarCodeImageFormat)
- added Method Aspose.BarCode.WPF.BarcodeGeneratorElement.ToString
- added Method Aspose.BarCode.WPF.BarcodeGeneratorElement.GenerateBarCodeImage
- added Field Aspose.BarCode.WPF.BarcodeGeneratorElement.CodeTextProperty
- added Property Aspose.BarCode.WPF.BarcodeGeneratorElement.CodeText
- added Field Aspose.BarCode.WPF.BarcodeGeneratorElement.EncodeTypeProperty
- added Property Aspose.BarCode.WPF.BarcodeGeneratorElement.EncodeType
- added Field Aspose.BarCode.WPF.BarcodeGeneratorElement.AutoSizeModeProperty
- added Property Aspose.BarCode.WPF.BarcodeGeneratorElement.AutoSizeMode
- added Field Aspose.BarCode.WPF.BarcodeGeneratorElement.CodeTextLocationProperty
- added Property Aspose.BarCode.WPF.BarcodeGeneratorElement.CodeTextLocation
- added Field Aspose.BarCode.WPF.BarcodeGeneratorElement.SupplementDataProperty
- added Property Aspose.BarCode.WPF.BarcodeGeneratorElement.SupplementData
- added Field Aspose.BarCode.WPF.BarcodeGeneratorElement.RowsProperty
- added Property Aspose.BarCode.WPF.BarcodeGeneratorElement.Rows
- added Field Aspose.BarCode.WPF.BarcodeGeneratorElement.ColumnsProperty
- added Property Aspose.BarCode.WPF.BarcodeGeneratorElement.Columns

Following Old BarCodeGenerator and all it's members and related properties classes have been removed:

- removed Class Aspose.BarCode.Generation.BarCodeGenerator
- removed Method Aspose.BarCode.Generation.BarCodeGenerator.#ctor(Aspose.BarCode.Generation.BaseEncodeType)
- removed Method Aspose.BarCode.Generation.BarCodeGenerator.#ctor(Aspose.BarCode.Generation.BaseEncodeType,System.String)
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.IsLicensed
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.CodeText
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.EncodeType
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.CaptionAbove
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.CaptionBelow
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.ForeColor
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.BackColor
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.FilledBars
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.BarHeight
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.XDimension
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.WideNarrowRatio
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.Resolution
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.Margins
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.D2
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.ITF
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.QR
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.DataMatrix
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.Aztec
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.Pdf417
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.Codabar
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.Supplement
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.Border
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.Checksum
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.RotationAngle
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.AutoSizeMode
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.BarCodeWidth
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.BarCodeHeight
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.CodeTextStyle
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.ThrowExceptionWhenCodeTextIncorrect
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.AustralianPostEncodingTable
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.EnableEscape
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.PostalShortBarHeight
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.DotCodeMask
- removed Property Aspose.BarCode.Generation.BarCodeGenerator.MaxiCodeEncodeMode
- removed Method Aspose.BarCode.Generation.BarCodeGenerator.RecalculateValues
- removed Method Aspose.BarCode.Generation.BarCodeGenerator.GenerateBarCodeImage
- removed Method Aspose.BarCode.Generation.BarCodeGenerator.Save(System.IO.Stream,Aspose.BarCode.BarCodeImageFormat)
- removed Method Aspose.BarCode.Generation.BarCodeGenerator.Save(System.String,Aspose.BarCode.BarCodeImageFormat)
- removed Method Aspose.BarCode.Generation.BarCodeGenerator.Save(System.String)
- removed Class Aspose.BarCode.Generation.AutoSizeMode
- removed Field Aspose.BarCode.Generation.AutoSizeMode.None
- removed Field Aspose.BarCode.Generation.AutoSizeMode.Nearest
- removed Field Aspose.BarCode.Generation.AutoSizeMode.Interpolation
- removed Class Aspose.BarCode.Generation.AztecProperties
- removed Property Aspose.BarCode.Generation.AztecProperties.SymbolMode
- removed Property Aspose.BarCode.Generation.AztecProperties.ErrorLevel
- removed Method Aspose.BarCode.Generation.AztecProperties.ToString
- removed Class Aspose.BarCode.Generation.BorderProperties
- removed Property Aspose.BarCode.Generation.BorderProperties.Visible
- removed Property Aspose.BarCode.Generation.BorderProperties.Width
- removed Property Aspose.BarCode.Generation.BorderProperties.DashStyle
- removed Property Aspose.BarCode.Generation.BorderProperties.Color
- removed Class Aspose.BarCode.Generation.Caption
- removed Property Aspose.BarCode.Generation.Caption.Visible
- removed Property Aspose.BarCode.Generation.Caption.Color
- removed Property Aspose.BarCode.Generation.Caption.Font
- removed Property Aspose.BarCode.Generation.Caption.Space
- removed Property Aspose.BarCode.Generation.Caption.Alignment
- removed Property Aspose.BarCode.Generation.Caption.Text
- removed Class Aspose.BarCode.Generation.ChecksumProperties
- removed Property Aspose.BarCode.Generation.ChecksumProperties.Enable
- removed Property Aspose.BarCode.Generation.ChecksumProperties.AlwaysShow
- removed Method Aspose.BarCode.Generation.ChecksumProperties.ToString
- removed Class Aspose.BarCode.Generation.CodabarProperties
- removed Property Aspose.BarCode.Generation.CodabarProperties.ChecksumMode
- removed Property Aspose.BarCode.Generation.CodabarProperties.StartSymbol
- removed Property Aspose.BarCode.Generation.CodabarProperties.StopSymbol
- removed Method Aspose.BarCode.Generation.CodabarProperties.ToString
- removed Class Aspose.BarCode.Generation.CodeTextStyle
- removed Property Aspose.BarCode.Generation.CodeTextStyle.Location
- removed Property Aspose.BarCode.Generation.CodeTextStyle.Alignment
- removed Property Aspose.BarCode.Generation.CodeTextStyle.Color
- removed Property Aspose.BarCode.Generation.CodeTextStyle.Space
- removed Property Aspose.BarCode.Generation.CodeTextStyle.Font
- removed Class Aspose.BarCode.Generation.D2Properties
- removed Property Aspose.BarCode.Generation.D2Properties.AspectRatio
- removed Property Aspose.BarCode.Generation.D2Properties.Columns
- removed Property Aspose.BarCode.Generation.D2Properties.Rows
- removed Property Aspose.BarCode.Generation.D2Properties.DisplayText
- removed Property Aspose.BarCode.Generation.D2Properties.CodeTextEncoding
- removed Method Aspose.BarCode.Generation.D2Properties.ToString
- removed Class Aspose.BarCode.Generation.DataMatrixProperties
- removed Property Aspose.BarCode.Generation.DataMatrixProperties.Ecc
- removed Property Aspose.BarCode.Generation.DataMatrixProperties.EncodeMode
- removed Method Aspose.BarCode.Generation.DataMatrixProperties.ToString
- removed Class Aspose.BarCode.Generation.ITFProperties
- removed Property Aspose.BarCode.Generation.ITFProperties.BorderThickness
- removed Property Aspose.BarCode.Generation.ITFProperties.BorderType
- removed Class Aspose.BarCode.Generation.Margins
- removed Property Aspose.BarCode.Generation.Margins.Bottom
- removed Property Aspose.BarCode.Generation.Margins.Left
- removed Property Aspose.BarCode.Generation.Margins.Right
- removed Property Aspose.BarCode.Generation.Margins.Top
- removed Method Aspose.BarCode.Generation.Margins.ToString
- removed Class Aspose.BarCode.Generation.Pdf417Properties
- removed Property Aspose.BarCode.Generation.Pdf417Properties.CompactionMode
- removed Property Aspose.BarCode.Generation.Pdf417Properties.ErrorLevel
- removed Property Aspose.BarCode.Generation.Pdf417Properties.Truncate
- removed Property Aspose.BarCode.Generation.Pdf417Properties.MacroFileID
- removed Property Aspose.BarCode.Generation.Pdf417Properties.MacroSegmentID
- removed Property Aspose.BarCode.Generation.Pdf417Properties.MacroSegmentsCount
- removed Method Aspose.BarCode.Generation.Pdf417Properties.ToString
- removed Class Aspose.BarCode.Generation.QRProperties
- removed Property Aspose.BarCode.Generation.QRProperties.EncodeMode
- removed Property Aspose.BarCode.Generation.QRProperties.EncodeType
- removed Property Aspose.BarCode.Generation.QRProperties.ErrorLevel
- removed Property Aspose.BarCode.Generation.QRProperties.Version
- removed Property Aspose.BarCode.Generation.QRProperties.ECIEncoding
- removed Method Aspose.BarCode.Generation.QRProperties.ToString
- removed Class Aspose.BarCode.Generation.SupplementProperties
- removed Property Aspose.BarCode.Generation.SupplementProperties.Data
- removed Property Aspose.BarCode.Generation.SupplementProperties.Space

Following Old BarCodeBuilder and all it's members have been removed:

- removed Class Aspose.BarCode.BarCodeBuilder
- removed Method Aspose.BarCode.BarCodeBuilder.#ctor
- removed Method Aspose.BarCode.BarCodeBuilder.#ctor(System.String)
- removed Method Aspose.BarCode.BarCodeBuilder.#ctor(System.ComponentModel.IContainer)
- removed Method Aspose.BarCode.BarCodeBuilder.#ctor(System.String,Aspose.BarCode.Generation.BaseEncodeType)
- removed Property Aspose.BarCode.BarCodeBuilder.EncodeType
- removed Property Aspose.BarCode.BarCodeBuilder.BarWidthReduction
- removed Property Aspose.BarCode.BarCodeBuilder.AztecSymbolMode
- removed Property Aspose.BarCode.BarCodeBuilder.MaxiCodeEncodeMode
- removed Method Aspose.BarCode.BarCodeBuilder.IsOverridedDimensionX
- removed Property Aspose.BarCode.BarCodeBuilder.IsLicensed
- removed Property Aspose.BarCode.BarCodeBuilder.ITF14BorderThickness
- removed Property Aspose.BarCode.BarCodeBuilder.CodeText
- removed Property Aspose.BarCode.BarCodeBuilder.Display2DText
- removed Property Aspose.BarCode.BarCodeBuilder.CodeTextEncoding
- removed Property Aspose.BarCode.BarCodeBuilder.EnableEscape
- removed Property Aspose.BarCode.BarCodeBuilder.CodeTextFont
- removed Property Aspose.BarCode.BarCodeBuilder.CodeTextColor
- removed Property Aspose.BarCode.BarCodeBuilder.CodeLocation
- removed Property Aspose.BarCode.BarCodeBuilder.CodeTextAlignment
- removed Property Aspose.BarCode.BarCodeBuilder.RotationAngleF
- removed Property Aspose.BarCode.BarCodeBuilder.CaptionAbove
- removed Property Aspose.BarCode.BarCodeBuilder.CaptionBelow
- removed Property Aspose.BarCode.BarCodeBuilder.GraphicsUnit
- removed Property Aspose.BarCode.BarCodeBuilder.Resolution
- removed Property Aspose.BarCode.BarCodeBuilder.ImageQuality
- removed Property Aspose.BarCode.BarCodeBuilder.TextRenderingHint
- removed Property Aspose.BarCode.BarCodeBuilder.AutoSize
- removed Property Aspose.BarCode.BarCodeBuilder.ImageWidth
- removed Property Aspose.BarCode.BarCodeBuilder.ImageHeight
- removed Property Aspose.BarCode.BarCodeBuilder.BorderWidth
- removed Property Aspose.BarCode.BarCodeBuilder.xDimension
- removed Property Aspose.BarCode.BarCodeBuilder.yDimension
- removed Property Aspose.BarCode.BarCodeBuilder.BarHeight
- removed Property Aspose.BarCode.BarCodeBuilder.AspectRatio
- removed Property Aspose.BarCode.BarCodeBuilder.Margins
- removed Property Aspose.BarCode.BarCodeBuilder.SupplementSpace
- removed Property Aspose.BarCode.BarCodeBuilder.PostnetShortBarHeight
- removed Property Aspose.BarCode.BarCodeBuilder.PlanetShortBarHeight
- removed Property Aspose.BarCode.BarCodeBuilder.CodeTextSpace
- removed Property Aspose.BarCode.BarCodeBuilder.BarCodeImage
- removed Property Aspose.BarCode.BarCodeBuilder.BorderVisible
- removed Property Aspose.BarCode.BarCodeBuilder.BorderColor
- removed Property Aspose.BarCode.BarCodeBuilder.BorderDashStyle
- removed Property Aspose.BarCode.BarCodeBuilder.CodabarStartSymbol
- removed Property Aspose.BarCode.BarCodeBuilder.CodabarStopSymbol
- removed Property Aspose.BarCode.BarCodeBuilder.CodabarChecksumMode
- removed Property Aspose.BarCode.BarCodeBuilder.CustomerInformationInterpretingType
- removed Property Aspose.BarCode.BarCodeBuilder.ITF14BorderType
- removed Property Aspose.BarCode.BarCodeBuilder.ForeColor
- removed Property Aspose.BarCode.BarCodeBuilder.BackColor
- removed Property Aspose.BarCode.BarCodeBuilder.EnableChecksum
- removed Property Aspose.BarCode.BarCodeBuilder.Columns
- removed Property Aspose.BarCode.BarCodeBuilder.Rows
- removed Property Aspose.BarCode.BarCodeBuilder.DataMatrixEncodeMode
- removed Property Aspose.BarCode.BarCodeBuilder.Pdf417CompactionMode
- removed Property Aspose.BarCode.BarCodeBuilder.Pdf417Truncate
- removed Property Aspose.BarCode.BarCodeBuilder.Pdf417ErrorLevel
- removed Property Aspose.BarCode.BarCodeBuilder.MacroPdf417SegmentsCount
- removed Property Aspose.BarCode.BarCodeBuilder.MacroPdf417SegmentID
- removed Property Aspose.BarCode.BarCodeBuilder.MacroPdf417FileID
- removed Property Aspose.BarCode.BarCodeBuilder.WideNarrowRatio
- removed Property Aspose.BarCode.BarCodeBuilder.SupplementData
- removed Property Aspose.BarCode.BarCodeBuilder.QRErrorLevel
- removed Property Aspose.BarCode.BarCodeBuilder.QRVersion
- removed Property Aspose.BarCode.BarCodeBuilder.QREncodeMode
- removed Property Aspose.BarCode.BarCodeBuilder.AztectErrorLevel
- removed Property Aspose.BarCode.BarCodeBuilder.AlwaysShowChecksum
- removed Property Aspose.BarCode.BarCodeBuilder.ThrowExceptionWhenCodeTextIncorrect
- removed Method Aspose.BarCode.BarCodeBuilder.Dispose(System.Boolean)
- removed Method Aspose.BarCode.BarCodeBuilder.Dispose
- removed Method Aspose.BarCode.BarCodeBuilder.GenerateBarCodeImage
- removed Method Aspose.BarCode.BarCodeBuilder.Rotate
- removed Method Aspose.BarCode.BarCodeBuilder.Rotate(System.Single)
- removed Method Aspose.BarCode.BarCodeBuilder.Rotate(Aspose.BarCode.RotationDirection,System.Single)
- removed Property Aspose.BarCode.BarCodeBuilder.PrinterName
- removed Method Aspose.BarCode.BarCodeBuilder.Print
- removed Method Aspose.BarCode.BarCodeBuilder.GetMinimumBarCodeSize
- removed Method Aspose.BarCode.BarCodeBuilder.GetOnlyBarCodeImage
- removed Method Aspose.BarCode.BarCodeBuilder.GetOnlyBarCodeImage(System.Int32)
- removed Method Aspose.BarCode.BarCodeBuilder.GetCustomSizeBarCodeImage(System.Drawing.Size,System.Boolean)
- removed Method Aspose.BarCode.BarCodeBuilder.GetCustomSizeBarCodeImage(System.Single,System.Single,System.Boolean)
- removed Method Aspose.BarCode.BarCodeBuilder.Save(System.IO.Stream,System.Drawing.Imaging.ImageFormat)
- removed Method Aspose.BarCode.BarCodeBuilder.Save(System.IO.Stream,Aspose.BarCode.BarCodeImageFormat)
- removed Method Aspose.BarCode.BarCodeBuilder.Save(System.String)
- removed Method Aspose.BarCode.BarCodeBuilder.Save(System.String,System.Drawing.Imaging.ImageFormat)
- removed Method Aspose.BarCode.BarCodeBuilder.Save(System.String,Aspose.BarCode.BarCodeImageFormat)
- removed Method Aspose.BarCode.BarCodeBuilder.DrawWpf(System.Windows.Media.DrawingContext)
- removed Method Aspose.BarCode.BarCodeBuilder.ExportToXml(System.String)
- removed Method Aspose.BarCode.BarCodeBuilder.ImportFromXml(System.String)
- removed Method Aspose.BarCode.BarCodeBuilder.ToString
- removed Method Aspose.BarCode.BarCodeBuilder.SetBinaryCodeText(System.Byte[])
- removed Property Aspose.BarCode.BarCodeBuilder.FilledBars
- removed Property Aspose.BarCode.BarCodeBuilder.DotCodeMask
- removed Property Aspose.BarCode.BarCodeBuilder.QREncodeType
- removed Property Aspose.BarCode.BarCodeBuilder.ECIEncoding
- removed Property Aspose.BarCode.BarCodeBuilder.DatamatrixEcc

Following Old BarCodeWebControl and all it's members have been removed:

- removed Class Aspose.BarCode.Web.UI.BarCodeWebControl
- removed Method Aspose.BarCode.Web.UI.BarCodeWebControl.#ctor
- removed Method Aspose.BarCode.Web.UI.BarCodeWebControl.#ctor(System.String)
- removed Method Aspose.BarCode.Web.UI.BarCodeWebControl.#ctor(System.Web.UI.HtmlTextWriterTag)
- removed Method Aspose.BarCode.Web.UI.BarCodeWebControl.#ctor(System.String,Aspose.BarCode.Generation.BaseEncodeType)
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.RenderFormat
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.RenderMethod
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.CodeText
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.Display2DText
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.EnableEscape
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.CodeTextFont
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.CodeTextColor
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.ITF14BorderType
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.CodeLocation
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.CodeTextSpace
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.CodeTextAlignment
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.RotationAngleF
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.AutoSize
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.ImageWidth
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.ImageHeight
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.CaptionAbove
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.CaptionBelow
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.BarCodeImage
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.GraphicsUnit
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.Resolution
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.BorderWidth
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.BorderVisible
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.BorderColor
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.BorderDashStyle
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.CodabarStartSymbol
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.CodabarStopSymbol
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.xDimension
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.yDimension
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.BarHeight
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.ForeColor
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.BackColor
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.EnableChecksum
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.AspectRatio
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.Columns
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.Rows
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.DataMatrixEncodeMode
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.Pdf417CompactionMode
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.Pdf417Truncate
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.Pdf417ErrorLevel
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.MacroPdf417
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.MacroPdf417SegmentsCount
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.MacroPdf417SegmentID
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.MacroPdf417FileID
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.QRErrorLevel
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.QREncodeMode
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.AztectErrorLevel
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.WideNarrowRatio
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.Margins
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.SupplementData
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.SupplementSpace
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.PostnetShortBarHeight
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.PlanetShortBarHeight
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.ImageQuality
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.TextRenderingHint
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.ImageCreator
- removed Method Aspose.BarCode.Web.UI.BarCodeWebControl.Render(System.Web.UI.HtmlTextWriter)
- removed Method Aspose.BarCode.Web.UI.BarCodeWebControl.RenderContents(System.Web.UI.HtmlTextWriter)
- removed Method Aspose.BarCode.Web.UI.BarCodeWebControl.OnInit(System.EventArgs)
- removed Method Aspose.BarCode.Web.UI.BarCodeWebControl.GenerateBarCodeImage
- removed Method Aspose.BarCode.Web.UI.BarCodeWebControl.Rotate
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.CustomerInformationInterpretingType
- removed Method Aspose.BarCode.Web.UI.BarCodeWebControl.Rotate(System.Single)
- removed Method Aspose.BarCode.Web.UI.BarCodeWebControl.Rotate(Aspose.BarCode.RotationDirection,System.Single)
- removed Method Aspose.BarCode.Web.UI.BarCodeWebControl.Save(System.String)
- removed Method Aspose.BarCode.Web.UI.BarCodeWebControl.Save(System.IO.Stream,System.Drawing.Imaging.ImageFormat)
- removed Method Aspose.BarCode.Web.UI.BarCodeWebControl.Save(System.String,System.Drawing.Imaging.ImageFormat)
- removed Method Aspose.BarCode.Web.UI.BarCodeWebControl.ToString
- removed Property Aspose.BarCode.Web.UI.BarCodeWebControl.EncodeType
- removed Class Aspose.BarCode.Web.BarCodeImageHandler
- removed Method Aspose.BarCode.Web.BarCodeImageHandler.#ctor
- removed Property Aspose.BarCode.Web.BarCodeImageHandler.IsReusable
- removed Method Aspose.BarCode.Web.BarCodeImageHandler.ProcessRequest(System.Web.HttpContext)
- removed Class Aspose.BarCode.Web.UI.Design.BarCodeWebCtrlDesigner
- removed Method Aspose.BarCode.Web.UI.Design.BarCodeWebCtrlDesigner.#ctor
- removed Method Aspose.BarCode.Web.UI.Design.BarCodeWebCtrlDesigner.GetDesignTimeHtml
- removed Method Aspose.BarCode.Web.UI.Design.BarCodeWebCtrlDesigner.Initialize(System.ComponentModel.IComponent)
- removed Method Aspose.BarCode.Web.UI.Design.BarCodeWebCtrlDesigner.PostFilterAttributes(System.Collections.IDictionary)
- removed Class Aspose.BarCode.RenderFormat
- removed Field Aspose.BarCode.RenderFormat.Jpeg
- removed Field Aspose.BarCode.RenderFormat.Gif
- removed Field Aspose.BarCode.RenderFormat.Bmp
- removed Field Aspose.BarCode.RenderFormat.Png
- removed Class Aspose.BarCode.Web.UI.RenderMethod
- removed Field Aspose.BarCode.Web.UI.RenderMethod.FromCache
- removed Field Aspose.BarCode.Web.UI.RenderMethod.FromSession
- removed Field Aspose.BarCode.Web.UI.RenderMethod.FromHttpHandler

IsLicensed property has been removed:

- removed Property Aspose.BarCode.Generation.BarcodeGenerator.IsLicensed
- removed Property Aspose.BarCode.BarCodeRecognition.BarCodeReader.IsLicensed
- removed Property Aspose.BarCode.License.IsLicensed
- removed Property Aspose.BarCode.Windows.Forms.BarCodeControl.IsLicensed
