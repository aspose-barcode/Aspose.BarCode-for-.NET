using System.IO;
using Aspose.BarCode;
using System;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodeImages
{
    class BarcodeCustomSize
    {
        public static void Run()
        {
            //ExStart:BarcodeCustomSize
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodesImages();

            // Instantiate barcode object
            BarCodeBuilder builder = new BarCodeBuilder("1234567890", Symbology.Code39Standard);

            // Set auto size false
            builder.AutoSize = false;

            // Set height
            builder.ImageHeight = 50;

            // Set width
            builder.ImageWidth = 120;

            // Save image to disk
            builder.Save(dataDir + "barcode-custom-size_out.jpg");
            //ExEnd:BarcodeCustomSize
        }
    }
}
