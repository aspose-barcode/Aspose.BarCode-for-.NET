using System.IO;
using Aspose.BarCode;
using System;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class CreatePDF417Barcode
    {
        public static void Run()
        {
            // ExStart:CreatePDF417Barcode 
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Instantiate BarCodeBuilder object
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder();

            // Set the SymbologyType for the barcode
            barCodeBuilder.SymbologyType = Symbology.Pdf417;

            // Set the Code text for the barcode
            barCodeBuilder.CodeText = "1234567890";

            // Save file to disk
            barCodeBuilder.Save(dataDir + "pdf417-barcode_out.jpg", BarCodeImageFormat.Jpeg);
            // ExEnd:CreatePDF417Barcode 
        }
    }
}
