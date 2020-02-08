using Aspose.BarCode.Generation;
using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.BarCode.Examples.CSharp.TechnicalArticles
{
    class AddingBarcodeImageToExcelWorksheet
    {
        public static void Run()
        {
            // ExStart:AddingBarcodeImageToExcelWorksheet
            // For complete examples and data files, please go to https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_TechnicalArticles();

            // Instantiate linear barcode object, Set the Code text and symbology type for the barcode
            BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Code128, "1234567");

            // Creating memory stream and Saving barcode image to memory stream
            System.IO.Stream ms = new System.IO.MemoryStream();
            generator.Save(ms, BarCodeImageFormat.Bmp);

            // Instantiate Excel class that represents an excel file
            Workbook excel1 = new Workbook();

            // Add the barcode image into the pictures collection of the first worksheet of the excel file in the form of a MemoryStream, ms with upper left row=5 and
            // Upper left column=5 and Save the excel file
            excel1.Worksheets[0].Pictures.Add(5, 5, ms);
            excel1.Save(dataDir + "MyFile_out.xls");
            // ExEnd:AddingBarcodeImageToExcelWorksheet
            Console.WriteLine(Environment.NewLine + "Adding Barcode Image To Excel Worksheet Finished.");
        }
    }
}
