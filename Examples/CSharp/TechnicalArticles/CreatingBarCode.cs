using Aspose.BarCode.Generation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.BarCode.Examples.CSharp.TechnicalArticles
{
    class CreatingBarCode
    {
        public static void Run()
        {
            // ExStart:CreatingBarCode
            // For complete examples and data files, please go to https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_TechnicalArticles();

            // Instantiate linear barcode object, Set the Code text and symbology type for the barcode
            BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Code128);
            generator.CodeText = "1234567";

            // Save the Barcode image in JPEG format
            generator.Save(dataDir + "barcode_out.jpg", BarCodeImageFormat.Jpeg);
            // ExEnd:CreatingBarCode
            Console.WriteLine(Environment.NewLine + "Creating BarCode Finished.");
        }
    }
}
