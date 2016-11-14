using System.IO;
using Aspose.BarCode;
using System;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class SpecifySymbology
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Instantiate barcode object and set differnt barcode properties
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder("1234567", EncodeTypes.Code128);

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir + "barcode-symbiology_out.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);            
        }
    }
}