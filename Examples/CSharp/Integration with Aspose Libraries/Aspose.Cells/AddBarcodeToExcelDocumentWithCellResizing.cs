//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.IO;
using System.Drawing;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.Integration
{
    internal class AddBarcodeToExcelDocumentWithCellResizing : CellsIntegrationBase
    {
		public static void Run()
        {
            string path = GetWriteFolder();
            Console.WriteLine("AddBarcodeToExcelDocumentWithCellResizing:");

            int Resolution = 300;//300 dpi high resolution of the barcode image
            int CellRow = 5;
            int CellColumn = 3;

            //create Excel book
            Aspose.Cells.Workbook excelBook = new Aspose.Cells.Workbook();
            Aspose.Cells.Worksheet excelSheet = excelBook.Worksheets[0];

            //create barcode image
            BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Pdf417, "Aspose.Barcode Pdf417 Example");
            generator.Parameters.Resolution = Resolution;//set the barcode image resolution
            generator.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;//make the codetext invisible
            Bitmap image = generator.GenerateBarCodeImage();
            MemoryStream imageStream = new MemoryStream();
            //emf is a vector image format, but it can be not fully supported on non-Windows systems
            generator.Save(imageStream, BarCodeImageFormat.Emf);
            imageStream.Position = 0;

            //resize cell to proportional image size, 96 dpi is a standard screen resolution
            int cellWidth = (96 * image.Width) / 300;
            int cellHeight = (96 * image.Height) / 300;
            excelSheet.Cells.SetColumnWidthPixel(CellColumn, cellWidth);
            excelSheet.Cells.SetRowHeightPixel(CellRow, cellHeight);

            //insert barcode image to our resized cell
            Aspose.Cells.Drawing.Picture excelPicture = excelSheet.Pictures[excelSheet.Pictures.Add(CellRow, CellColumn, CellRow + 1, CellColumn + 1, imageStream)];
            //set the image as resizible with cell size changing
            excelPicture.Placement = Aspose.Cells.Drawing.PlacementType.MoveAndSize;

            //save the Excel book
            excelBook.Save($"{path}AddBarcodeToExcelDocumentWithCellResizing.xlsx", Aspose.Cells.SaveFormat.Xlsx);
        }
	}
}