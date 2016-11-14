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

            // Instantiate barcode object and set different properties
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder
            {
                BorderDashStyle = BorderDashStyle.Solid,
                Margins = new MarginsF(2f, 2f, 2f, 2f),
                BorderWidth = 0.5f,
                BorderVisible = true
            };
            barCodeBuilder.Save(dataDir + "barcodeImageborders_out.jpeg", ImageFormat.Jpeg);
        }
    }
}
