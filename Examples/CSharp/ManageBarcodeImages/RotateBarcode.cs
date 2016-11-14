using System.IO;
using Aspose.BarCode;
using System;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodeImages
{
    class RotateBarcode
    {
        public static void Run()
        {            
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodesImages();

            // Instantiate barcode object and set CodeText, Barcode Symbology and  hide code text
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder("1234567890", EncodeTypes.QR)
            {
                CodeLocation = CodeLocation.None,
                RotationAngleF = 90
            };
            barCodeBuilder.Save(dataDir + "QR-rotate_out.jpeg", BarCodeImageFormat.Jpeg);
        }
    }
}
