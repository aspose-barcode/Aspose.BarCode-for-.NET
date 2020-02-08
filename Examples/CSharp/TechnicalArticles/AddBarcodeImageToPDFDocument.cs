using Aspose.BarCode.Generation;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.BarCode.Examples.CSharp.TechnicalArticles
{
    class AddBarcodeImageToPDFDocument
    {
        public static void Run()
        {
            // ExStart:AddBarcodeImageToPDFDocument
            // For complete examples and data files, please go to https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_TechnicalArticles();

            // Instantiate linear barcode object, Set the Code text and symbology type for the barcode
            BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Code39Standard, "1234567");

            // Creating memory stream and Saving barcode image to memory stream
            System.IO.Stream ms = new System.IO.MemoryStream();
            generator.Save(ms, BarCodeImageFormat.Bmp);

            // ExStart:CreatePdfDocument
            // Create Pdf document and Add a section to the Pdf document
            Document doc = new Document();
            doc.Pages.Add();
            // ExEnd:CreatePdfDocument

            // Open document
            PdfFileMend mender = new PdfFileMend();

            // Create PdfFileMend object to add barcode image
            mender.BindPdf(doc);

            // Add image in the PDF file
            mender.AddImage(ms, 1, 100, 600, 200, 700);

            // Save changes
            mender.Save(dataDir + "AddImage_out.pdf");

            // Close PdfFileMend object
            mender.Close();
            // ExEnd:AddBarcodeImageToPDFDocument
            Console.WriteLine(Environment.NewLine + "Add BarCode Image To PDF Document Finished.");
        }
    }
}
