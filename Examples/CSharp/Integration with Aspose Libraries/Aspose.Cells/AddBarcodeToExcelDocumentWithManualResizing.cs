//Copyright(c) 2001-2023 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.IO;
using Aspose.BarCode.Generation;
#if NETSTANDARD2_0_OR_GREATER || NETCOREAPP2_1_OR_GREATER
using Aspose.Drawing;
#else
using System.Drawing;
#endif

namespace Aspose.BarCode.Examples.CSharp.Integration
{
    internal class AddBarcodeToExcelDocumentWithManualResizing : CellsIntegrationBase
    {
        public static void Run()
        {
            string path = GetWriteFolder();
            Console.WriteLine("AddBarcodeToExcelDocumentWithManualResizing:");

            int Resolution = 300;//300 dpi high resolution of the barcode image
            int CellRow = 5;
            int CellColumn = 3;

            //create Excel book
            Aspose.Cells.Workbook excelBook = new Aspose.Cells.Workbook();
            Aspose.Cells.Worksheet excelSheet = excelBook.Worksheets[0];

            //resize the cell where we will insert the barcode to random size (can be any)
            excelSheet.Cells.SetRowHeightPixel(CellRow, 200);
            excelSheet.Cells.SetColumnWidthPixel(CellColumn, 500);

            //create barcode image
            BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Pdf417, "Aspose.Barcode Pdf417 Example");
            generator.Parameters.Resolution = Resolution;//set the barcode image resolution
            generator.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;//make the codetext invisible
            Bitmap image = generator.GenerateBarCodeImage();
            MemoryStream imageStream = new MemoryStream();
            //can be in Png as raster image format
            //generator.Save(imageStream, BarCodeImageFormat.Png);
            //emf is a vector image format, but it can be not fully supported on non-Windows systems
            generator.Save(imageStream, BarCodeImageFormat.Emf);
            imageStream.Position = 0;

            //insert barcode image to our cell
            Aspose.Cells.Drawing.Picture excelPicture = excelSheet.Pictures[excelSheet.Pictures.Add(CellRow, CellColumn, CellRow + 1, CellColumn + 1, imageStream)];
            //set the image as resizible with cell size changing
            excelPicture.Placement = Aspose.Cells.Drawing.PlacementType.MoveAndSize;

            //resize and place it proportionally in a cell center
            double columnWidth = excelSheet.Cells.GetColumnWidthPixel(CellColumn);
            double rowHeight = excelSheet.Cells.GetRowHeightPixel(CellRow);
            double sizeMultiplier = Math.Min(columnWidth / image.Width, rowHeight / image.Height);
            excelPicture.Width = (int)Math.Round(image.Width * sizeMultiplier);
            excelPicture.Height = (int)Math.Round(image.Height * sizeMultiplier);
            excelPicture.Left = (int)Math.Round((columnWidth - excelPicture.Width) / 2);
            excelPicture.Top = (int)Math.Round((rowHeight - excelPicture.Height) / 2);

            //save the Excel book
            excelBook.Save($"{path}AddBarcodeToExcelDocumentWithManualResizing.xlsx", Aspose.Cells.SaveFormat.Xlsx);
        }
    }
}