using System.IO;
using Aspose.BarCode;
using System;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class ManageXYDimension
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();
            string dstCode128 = dataDir + "code128-YDimensionChanged_out.jpg";

            // Instantiate barcode object and set CodeText & Barcode Symbology
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder("1234567", EncodeTypes.Code128);

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dstCode128, System.Drawing.Imaging.ImageFormat.Jpeg);

            // Set the X-Dimension for the bars of the barcode
            barCodeBuilder.xDimension = 0.5f;

            // Set the measuring unit of barcode to millimeter
            barCodeBuilder.GraphicsUnit = System.Drawing.GraphicsUnit.Millimeter;

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dstCode128, System.Drawing.Imaging.ImageFormat.Jpeg);

            // Instantiate barcode object and set differnt barcode properties
            BarCodeBuilder barCodeBuilder1 = new BarCodeBuilder("1234567", EncodeTypes.Pdf417)
            {
                yDimension = 4
            };

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder1.Save(dataDir + "pdf417-YDimensionChanged_out.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
