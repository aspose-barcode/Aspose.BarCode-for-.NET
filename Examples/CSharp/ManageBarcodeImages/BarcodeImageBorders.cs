using System.IO;
using Aspose.BarCode;
using System;
using System.Drawing.Imaging;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodeImages
{
    class BarcodeImageBorders
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodesImages();

            // Instantiate barcode object
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder();

            // Set border style to solid
            barCodeBuilder.BorderDashStyle = BorderDashStyle.Solid;

            // Set border margins by assigning an instance of MarginsF
            barCodeBuilder.Margins = new MarginsF(2f, 2f, 2f, 2f);

            // Set border width
            barCodeBuilder.BorderWidth = 0.5f;

            // Enable border to be shown in the barcode
            barCodeBuilder.BorderVisible = true;

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir + "barcodeImageborders_out.jpeg", ImageFormat.Jpeg);
        }
    }
}
