using System.IO;
using Aspose.BarCode;
using System;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodeImages
{
    class RotateBarcode
    {
        public static void Run()
        {
            //ExStart:RotateBarcode
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodesImages();

            // Instantiate BarCodeBuilder object
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder();

            // Set the symbology type 
            barCodeBuilder.SymbologyType = Symbology.QR;

            // Set the Code Text 
            barCodeBuilder.CodeText = "1234567890";
            
            // hide code text
            barCodeBuilder.CodeLocation = CodeLocation.None;
            barCodeBuilder.RotationAngleF = 90;
            barCodeBuilder.Save(dataDir + "QR-rotate_out.jpeg", BarCodeImageFormat.Jpeg);
            //ExEnd:RotateBarcode
        }
    }
}
