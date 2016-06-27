
using System.IO;
using Aspose.BarCode;
using System;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class CreateQRbarcode
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Initialize BarCodeBuilder
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder();

            // Set the Smbology Type
            barCodeBuilder.SymbologyType = Symbology.QR;

            // Set the Code text for the barcode
            barCodeBuilder.CodeText = "1234567890";

            // Save the file on disk and set its image format to Jpeg
            barCodeBuilder.Save(dataDir + "CreateQRbarcode_out.bmp", BarCodeImageFormat.Bmp);
        }
    }
}
