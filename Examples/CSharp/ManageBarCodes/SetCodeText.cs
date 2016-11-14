using System.IO;
using Aspose.BarCode;
using System;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class SetCodeText
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Instantiate barcode object and set differnt barcode properties
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder("1234567", EncodeTypes.Code128) { xDimension = 1f };

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir + "barcode-codetext_out.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dataDir + "barcode-codetext_out.jpg");
        }
    }
}