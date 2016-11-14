using System.IO;
using Aspose.BarCode;
using System;
using System.Drawing.Printing;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodeImages
{
    class SetSizeUnitForBarcodeImage
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodesImages();

            // Instantiate barcode object
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder("1234567", EncodeTypes.Code128)
            {
                // Set the bar height to 3 points and measuring unit of barcode to point
                BarHeight = 3.0f,
                GraphicsUnit = System.Drawing.GraphicsUnit.Point
            };
            barCodeBuilder.Save(dataDir + "barcode-size-unit_out.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
