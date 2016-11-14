using System.IO;
using Aspose.BarCode;
using System;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class SetHeightBarcodeBars
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Instantiate barcode object and set differnt barcode properties
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder("1234567", EncodeTypes.Code128)
            {
                BarHeight = 3.0f,
                GraphicsUnit = System.Drawing.GraphicsUnit.Millimeter
            };

            // Save the image locally and set its image format to Jpeg
            barCodeBuilder.Save(dataDir + "barcode3_out.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            // Set the bar height to 3 millimeters and Save the image locally and set its image format to Jpeg
            barCodeBuilder.BarHeight = 7.0f;
            barCodeBuilder.Save(dataDir + "barcode7_out.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            // Set the bar height to 3 millimeters and  Save the image to disk
            barCodeBuilder.BarHeight = 11.0f;
            barCodeBuilder.Save(dataDir + "Code128-bar-height_out.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
