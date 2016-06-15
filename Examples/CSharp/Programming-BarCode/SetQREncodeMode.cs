using System.IO;
using Aspose.BarCode;
using System;

namespace Aspose.BarCode.Examples.CSharp.Programming.BarCode
{
    class SetQREncodeMode
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ProgrammingBarCode();
            string dst = dataDir + "QR-Encode-mode.jpg";

            // Create instance of BarCodeBuilder, specify codetext and symbology in the constructor
            BarCodeBuilder builder = new BarCodeBuilder("test123", Symbology.QR);

            // Set QR encode mode
            builder.QREncodeMode = Aspose.BarCode.QREncodeMode.Auto;

            // Save the image to disk in PNG format
            builder.Save(dst);

            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dst);
        }
    }
}
