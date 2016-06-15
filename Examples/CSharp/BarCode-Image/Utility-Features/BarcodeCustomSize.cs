using System.IO;
using Aspose.BarCode;
using System;

namespace Aspose.BarCode.Examples.CSharp.BarCode.Image.Basic.Features
{
    class BarcodeCustomSize
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_BarCodeImage();
            string dst = dataDir + "barcode-custom-size.jpg";

            //Instantiate barcode object
            BarCodeBuilder builder = new BarCodeBuilder("1234567890", Symbology.Code39Standard);

            // Set auto size false
            builder.AutoSize = false;

            // Set height
            builder.ImageHeight = 50;

            // Set width
            builder.ImageWidth = 120;

            // Save image to disk
            builder.Save(dst);

            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dst);
        }
    }
}
