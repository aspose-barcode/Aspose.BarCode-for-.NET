using System.IO;
using Aspose.BarCode;
using System;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodeImages
{
    class ColorizeAnyPartoftheBarcodeImage
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodesImages();
            string dst = dataDir + "colorize-barcode_out.jpg";

            // Instantiate barcode object and differnt properties
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder("1234567", EncodeTypes.Code128)
            {
                BackColor = System.Drawing.Color.Yellow,
                ForeColor = System.Drawing.Color.Blue,
                BorderColor = System.Drawing.Color.Red,
                CodeTextColor = System.Drawing.Color.Red
            };
            barCodeBuilder.Save(dst, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
