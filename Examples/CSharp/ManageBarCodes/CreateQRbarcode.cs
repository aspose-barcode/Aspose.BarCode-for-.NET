using System.IO;
using Aspose.BarCode;
using System;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class CreateQRbarcode
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Instantiate barcode object and set CodeText & Barcode Symbology
            BarCodeBuilder barCodeBarCodeBuilder  = new BarCodeBuilder("1234567890", EncodeTypes.QR);
            barCodeBarCodeBuilder.Save(dataDir + "CreateQRbarcode_out.bmp", BarCodeImageFormat.Bmp);
        }
    }
}
