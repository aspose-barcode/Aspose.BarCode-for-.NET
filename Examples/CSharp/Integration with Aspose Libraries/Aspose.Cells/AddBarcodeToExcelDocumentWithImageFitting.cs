//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.IO;
using System.Drawing;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.Integration
{
    internal class AddBarcodeToExcelDocumentWithImageFitting : CellsIntegrationBase
    {
        public static void Run()
        {
            string path = GetWriteFolder();
            Console.WriteLine("AddBarcodeToExcelDocumentWithImageFitting:");

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
            generator.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;//make the codetext invisible
            generator.Parameters.ImageWidth.Pixels = (Resolution * excelSheet.Cells.GetColumnWidthPixel(CellColumn)) / 96;//96 is standard resolution
            generator.Parameters.ImageHeight.Pixels = (Resolution * excelSheet.Cells.GetRowHeightPixel(CellRow)) / 96;//96 is standard resolution
            generator.Parameters.AutoSizeMode = Aspose.BarCode.Generation.AutoSizeMode.Nearest;
            MemoryStream imageStream = new MemoryStream();
            //emf is a vector image format, but it can be not fully supported on non-Windows systems
            generator.Save(imageStream, BarCodeImageFormat.Emf);
            imageStream.Position = 0;

            //insert barcode image to our cell
            Aspose.Cells.Drawing.Picture excelPicture = excelSheet.Pictures[excelSheet.Pictures.Add(CellRow, CellColumn, CellRow + 1, CellColumn + 1, imageStream)];
            //set the image as resizible with cell size changing
            excelPicture.Placement = Aspose.Cells.Drawing.PlacementType.MoveAndSize;

            //save the Excel book
            excelBook.Save($"{path}AddBarcodeToExcelDocumentWithImageFitting.xlsx", Aspose.Cells.SaveFormat.Xlsx);
        }
    }
}