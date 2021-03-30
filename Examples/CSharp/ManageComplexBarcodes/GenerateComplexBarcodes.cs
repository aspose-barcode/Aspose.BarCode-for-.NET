using System;
using System.Drawing.Imaging;
using Aspose.BarCode.Generation;
using Aspose.BarCode.ComplexBarcode;

namespace Aspose.BarCode.Examples.CSharp.ManageComplexBarcodes
{
    class GenerateComplexBarcodes
    {
        public static void Run()
        {
            //ExStart:GenerateComplexBarcodes
            // For complete examples and data files, please go to https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageComplexBarcodes();

            // Instantiate barcode object and set CodeText
            var swissQRCodetext = new SwissQRCodetext();
            swissQRCodetext.Bill.Account = "Account";
            swissQRCodetext.Bill.BillInformation = "BillInformation";
            swissQRCodetext.Bill.Currency = "EUR";

            var generator = new ComplexBarcodeGenerator(swissQRCodetext);
            var img = generator.GenerateBarCodeImage();

            generator.Parameters.Barcode.CodeTextParameters.TwoDDisplayText = "test";

            // Save the Barcode image in BMP format
            img.Save(dataDir + "swissQRCode_out.bmp", ImageFormat.Bmp);

            // Save the Barcode image in JPEG format
            generator.Save(dataDir + "swissQRCodetext_out.png", BarCodeImageFormat.Png);
            // ExEnd:GenerateComplexBarcodes
            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dataDir);
        }
    }
}
