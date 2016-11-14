using System.IO;
using Aspose.BarCode;
using System;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodeImages
{
    class RotateBarcodeImage
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodesImages();

            // Instantiate barcode object and set CodeText, Barcode Symbology and RotationAngleF
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder("1234567", EncodeTypes.Code128) {RotationAngleF = 180};
            barCodeBuilder.Save(dataDir + "barcode-image-rotate_out.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
