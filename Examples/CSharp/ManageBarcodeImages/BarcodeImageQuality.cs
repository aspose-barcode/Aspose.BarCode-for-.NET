using System.IO;
using Aspose.BarCode;
using System;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodeImages
{
    class BarcodeImageQuality
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodesImages();

            // Instantiate barcode object and set CodeText, Barcode Symbology and image quality mode to anti alias
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder("1234567", EncodeTypes.Code128)
            {
                ImageQuality = ImageQualityMode.AntiAlias
            };
            barCodeBuilder.Save(dataDir + "barcode-image-quality_out.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
