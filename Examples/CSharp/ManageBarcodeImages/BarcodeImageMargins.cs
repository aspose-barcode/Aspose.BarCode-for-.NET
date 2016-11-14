using System.IO;
using Aspose.BarCode;
using System;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodeImages
{
    class BarcodeImageMargins
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodesImages();

            // Instantiate barcode object and different properties
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder("1234567890", EncodeTypes.Code128)
            {
                Margins = {Left = 0.5f, Right = 0f, Top = 0f, Bottom = 0f}
            };
            barCodeBuilder.Save(dataDir + "barcode-image-margins_out.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
