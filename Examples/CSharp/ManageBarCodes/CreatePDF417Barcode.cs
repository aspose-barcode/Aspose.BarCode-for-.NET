using System.IO;
using Aspose.BarCode;
using System;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class CreatePDF417Barcode
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();
 
            // Instantiate BarCodeBuilder object Set the Code text & SymbologyType for the barcode
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder("1234567890", EncodeTypes.Pdf417);
            barCodeBuilder.Save(dataDir + "pdf417-barcode_out.jpg", BarCodeImageFormat.Jpeg);
        }
    }
}
