using System.IO;
using Aspose.BarCode;
using System;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class CreateDatamatrixBarcode
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Instantiate barcode object and set CodeText & Barcode Symbology
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder("1234567890",EncodeTypes.DataMatrix);
            barCodeBuilder.Save(dataDir + "datamatrix-barcode_out.jpg", BarCodeImageFormat.Jpeg);
        }
    }
}
