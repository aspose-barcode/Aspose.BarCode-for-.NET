---
title: Aspose.BarCode for .NET 19.8 Release Notes
type: docs
weight: 50
url: /net/aspose-barcode-for-net-19-8-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes information for [Aspose.BarCode for .NET 19.8](https://downloads.aspose.com/barcode/net/new-releases/aspose.barcode-for-.net-19.8/).

{{% /alert %}} 
## **All Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|BARCODENET-37261|Replace SkiaSharp with System.Drawing.Common|New Feature|
## **Public API and Backward Incompatible Changes**
- Removed class Aspose.BarCode.GraphicsUnit
- Removed field Aspose.BarCode.GraphicsUnit.World
- Removed field Aspose.BarCode.GraphicsUnit.Display
- Removed field Aspose.BarCode.GraphicsUnit.Pixel
- Removed field Aspose.BarCode.GraphicsUnit.Point
- Removed field Aspose.BarCode.GraphicsUnit.Inch
- Removed field Aspose.BarCode.GraphicsUnit.Document
- Removed field Aspose.BarCode.GraphicsUnit.Millimeter
- Removed class Aspose.BarCode.TextRenderingHint
- Removed field Aspose.BarCode.TextRenderingHint.SystemDefault
- Removed field Aspose.BarCode.TextRenderingHint.AntiAlias
- Removed field Aspose.BarCode.TextRenderingHint.SingleBitPerPixelGridFit
- Removed class Aspose.BarCode.ImageFormat
- Removed property Aspose.BarCode.ImageFormat.Bmp
- Removed property Aspose.BarCode.ImageFormat.Gif
- Removed property Aspose.BarCode.ImageFormat.Jpeg
- Removed property Aspose.BarCode.ImageFormat.Png
- Removed property Aspose.BarCode.ImageFormat.Tiff
- Removed property Aspose.BarCode.ImageFormat.Guid
- Removed class Aspose.BarCode.PixelFormat
- Removed field Aspose.BarCode.PixelFormat.Unknown
- Removed field Aspose.BarCode.PixelFormat.Format16bppRgb565
- Removed field Aspose.BarCode.PixelFormat.Format8bppIndexed
- Removed field Aspose.BarCode.PixelFormat.Format32bppPArgb
- Removed field Aspose.BarCode.PixelFormat.Format32bppArgb
- Removed class Aspose.BarCode.Bitmap
- Removed method Aspose.BarCode.Bitmap.#ctor(System.Int32,System.Int32)
- Removed method Aspose.BarCode.Bitmap.#ctor(System.Int32,System.Int32,Aspose.BarCode.PixelFormat)
- Removed method Aspose.BarCode.Bitmap.#ctor(Aspose.BarCode.Bitmap)
- Removed method Aspose.BarCode.Bitmap.#ctor(System.IO.Stream)
- Removed method Aspose.BarCode.Bitmap.#ctor(System.String)
- Removed property Aspose.BarCode.Bitmap.Width
- Removed property Aspose.BarCode.Bitmap.Height
- Removed property Aspose.BarCode.Bitmap.Size
- Removed property Aspose.BarCode.Bitmap.HorizontalResolution
- Removed property Aspose.BarCode.Bitmap.VerticalResolution
- Removed property Aspose.BarCode.Bitmap.PixelFormat
- Removed property Aspose.BarCode.Bitmap.RawFormat
- Removed method Aspose.BarCode.Bitmap.FromFile(System.String)
- Removed method Aspose.BarCode.Bitmap.FromStream(System.IO.Stream)
- Removed method Aspose.BarCode.Bitmap.Save(System.IO.Stream,Aspose.BarCode.ImageFormat)
- Removed method Aspose.BarCode.Bitmap.Save(System.String)
- Removed method Aspose.BarCode.Bitmap.Save(System.String,Aspose.BarCode.ImageFormat)
- Removed method Aspose.BarCode.Bitmap.GetPixel(System.Int32,System.Int32)
- Removed method Aspose.BarCode.Bitmap.SetPixel(System.Int32,System.Int32,System.Drawing.Color)
- Removed method Aspose.BarCode.Bitmap.SetResolution(System.Single,System.Single)
- Removed method Aspose.BarCode.Bitmap.Dispose
- Removed class Aspose.BarCode.Font
- Removed method Aspose.BarCode.Font.#ctor(System.String,System.Single)
- Removed method Aspose.BarCode.Font.#ctor(System.String,System.Single,Aspose.BarCode.FontStyle)
- Removed method Aspose.BarCode.Font.#ctor(System.String,System.Single,Aspose.BarCode.FontStyle,Aspose.BarCode.GraphicsUnit)
- Removed property Aspose.BarCode.Font.Name
- Removed property Aspose.BarCode.Font.Family
- Removed property Aspose.BarCode.Font.Size
- Removed property Aspose.BarCode.Font.Style
- Removed method Aspose.BarCode.Font.Dispose
- Removed method Aspose.BarCode.Font.Equals(System.Object)
- Removed method Aspose.BarCode.Font.GetHashCode
- Removed method Aspose.BarCode.Font.ToString
- Removed class Aspose.BarCode.FontStyle
- Removed field Aspose.BarCode.FontStyle.Regular
- Removed field Aspose.BarCode.FontStyle.Bold
- Removed field Aspose.BarCode.FontStyle.Italic
- Removed field Aspose.BarCode.FontStyle.Underline
- Removed field Aspose.BarCode.FontStyle.Strikeout
- Removed class Aspose.BarCode.StringAlignment
- Removed field Aspose.BarCode.StringAlignment.Near
- Removed field Aspose.BarCode.StringAlignment.Center
- Removed field Aspose.BarCode.StringAlignment.Far
