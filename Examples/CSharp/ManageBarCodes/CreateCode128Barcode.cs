
using System.IO;
using Aspose.BarCode;
using System;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class CreateCode128Barcode
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Initialize BarCodeBuilder
            // Instantiate barcode object and set CodeText & Barcode Symbology
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder("1234", EncodeTypes.Code128);
            barCodeBuilder.Save(dataDir + "Code128-customized_out.png");
        }
    }
}