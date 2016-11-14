using System.IO;
using Aspose.BarCode;
using System;
using System.Drawing.Printing;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodeImages
{
    class SaveBarcodeImagesToDifferentFormats
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodesImages();

            // Instantiate barcode object and set CodeText & Barcode Symbology
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder("1234567", EncodeTypes.Code128);
            barCodeBuilder.Save(dataDir + "barcode-image-format_out.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
