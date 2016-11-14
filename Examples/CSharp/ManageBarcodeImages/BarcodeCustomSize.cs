using System.IO;
using Aspose.BarCode;
using System;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodeImages
{
    class BarcodeCustomSize
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodesImages();

            // Instantiate barcode object and set CodeText & Barcode Symbology
            BarCodeBuilder builder = new BarCodeBuilder("1234567890", EncodeTypes.Code39Standard)
            {
                // Set auto size false, height and width
                AutoSize = false,
                ImageHeight = 50,
                ImageWidth = 120
            };
            builder.Save(dataDir + "barcode-custom-size_out.jpg");
        }
    }
}
