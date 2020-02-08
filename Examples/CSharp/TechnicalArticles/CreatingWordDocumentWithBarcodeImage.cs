using Aspose.BarCode.Examples.CSharp;
using Aspose.BarCode.Generation;
using Aspose.Words;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.BarCode.Examples.CSharp.TechnicalArticles
{
    class CreatingWordDocumentWithBarcodeImage
    {
        public static void Run()
        {
            // ExStart:CreatingWordDocumentWithBarcodeImage
            // For complete examples and data files, please go to https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_TechnicalArticles();

            // Create a word document object with Aspose.Words
            Document doc = new Document();

            // Instantiate linear barcode object, Set the Code text and symbology type for the barcode
            BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Code39Standard, "1234567");

            // Create builder for document object, Insert the barCode image into document and Save the word document.
            DocumentBuilder builder = new DocumentBuilder(doc);
            builder.InsertImage(generator.GenerateBarCodeImage());
            doc.Save(dataDir + "Myfile_out.doc");
            // ExEnd:CreatingWordDocumentWithBarcodeImage
            Console.WriteLine(Environment.NewLine + "Creating Word Document With BarCode Image Finished.");
        }
    }
}
