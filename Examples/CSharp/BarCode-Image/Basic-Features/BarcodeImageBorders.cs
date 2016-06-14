
using System.IO;

using Aspose.BarCode;
using System;

namespace Aspose.BarCode.Examples.CSharp.BarCode.Image.Basic.Features
{
    class BarcodeImageBorders
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_BarCodeImage();
            string dst = dataDir + "barcode-image-borders.jpg";

            //Instantiate barcode object
            BarCodeBuilder bb = new BarCodeBuilder();

            //Set border style to solid
            bb.BorderDashStyle = Aspose.BarCode.BorderDashStyle.Solid;

            //Set border margins by assigning an instance of MarginsF
            bb.Margins = new Aspose.BarCode.MarginsF(2f, 2f, 2f, 2f);

            //Set border width
            bb.BorderWidth = 0.5f;

            //Enable border to be shown in the barcode
            bb.BorderVisible = true;

            //Save the image to your system
            //and set its image format to Jpeg
            bb.Save(dst, System.Drawing.Imaging.ImageFormat.Jpeg);

            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dst);
        }
    }
}
